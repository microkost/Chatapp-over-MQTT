/*
 * Inspired by 
 * https://dutchtechy.wordpress.com/2014/03/13/c-mqtt-client/
 * http://www.hivemq.com/blog/mqtt-client-library-encyclopedia-m2mqtt
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MS_mqtt_client
{
    public partial class FormChat1 : Form
    {
        public List<string> topics { get; set; } //discuss topics
        private bool IsSubscribed { get; set; } //cannot send without subscribing
        private List<string> WhatWasSubscribed { get; set; } //because it should change

        MqttClient client;

        delegate void SetTextCallback(string text);

        public FormChat1()
        {
            InitializeComponent();
            IsSubscribed = false;

            topics = new List<string>(); //update ComboBox by actual subs
            WhatWasSubscribed = new List<string>(); //for unsuscribing everything

            lockGUIsettings(true);
            lockGUIsettings(false);
        }

        public FormChat1(string nickname, string partnerID) //for switching names of users for another form
        {
            InitializeComponent();
            IsSubscribed = false;

            this.textBoxNick.Text = nickname;
            this.textBoxPartner.Text = partnerID;

            topics = new List<string>(); //update ComboBox by actual subs
            WhatWasSubscribed = new List<string>(); //for unsuscribing everything

            lockGUIsettings(true);
            lockGUIsettings(false);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new MqttClient(textBoxURL.Text);                

                if (client == null)
                {
                    textBoxInfo.Text += System.Environment.NewLine + ("*** Setting of broker failed!");
                    return;
                }

                client.MqttMsgPublishReceived += new MqttClient.MqttMsgPublishEventHandler(EventPublished); //register
                client.ProtocolVersion = MqttProtocolVersion.Version_3_1;

                byte code;
                if (checkBoxAnon.Checked == true)
                {                   
                    code = client.Connect(Guid.NewGuid().ToString()); //při anonymním režimu by neměl odesílat identitu
                    //WARNING nemusí fungovat korektně vždy do všech kategoriích
                }
                else
                {
                    //SAMPLE
                    //public byte Connect(string clientId, string username, string password, bool willRetain, byte willQosLevel, bool willFlag, string willTopic, string willMessage, bool cleanSession, ushort keepAlivePeriod);                

                    //WITHOUT WILL message
                    //code = client.Connect(textBoxNick.Text, textBoxUsername.Text, textBoxPass.Text, false, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, false, null, null, true, 60);
                    //WARNING! Superbad sending password in clear text!

                    //WITH WILL MESSAGE doesnt work
                    code = client.Connect(textBoxNick.Text, textBoxUsername.Text, textBoxPass.Text, true, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true, String.Format("/mschat/status/{0}", textBoxNick.Text), "offline", true, 60);
                    //WARNING! Superbad sending password in clear text!
                }

                if (Convert.ToInt32(code) == 0)
                {
                    //code: it’s value is 0 if the connection was accepted OR a number greater than 0 identifying the reason of connection failure. 
                    textBoxStatus.Text = "connected";
                    textBoxInfo.Text += System.Environment.NewLine + ("* Client connected");
                    lockGUIsettings(true);
                }
                else
                {
                    textBoxInfo.Text += System.Environment.NewLine + "* Connection failed, failure number: " + Convert.ToInt32(code);
                    lockGUIsettings(false);
                }
            }
            catch
            {
                textBoxInfo.Text += System.Environment.NewLine + ("* not connected (network or host error)");
                lockGUIsettings(false);
            }
        }

        private void EventPublished(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            try
            {
                //SetText("*** Speak: " + ((uPLibrary.Networking.M2Mqtt.MqttClient)sender).ClientId); //uPLibrary.Networking.M2Mqtt.MqttClient.ClientId //TODO!
                SetText("*** Topic: " + e.Topic);
                SetText("*** Message: " + System.Text.UTF8Encoding.UTF8.GetString(e.Message));
                SetText("");
            }
            catch (InvalidCastException ex)
            {
                textBoxInfo.Text += System.Environment.NewLine + ("* Invalid Cast Exception");
            }
        }
        private void SetText(string text)
        {
            if (this.textBoxInfo.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxInfo.Text += System.Environment.NewLine + text;
            }            
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

            if (client != null && textBoxStatus.Text == "connected") //&& IsSubscribed == true NOT neesessary to be subscribed
            {
                //public ushort Publish(string topic, byte[] message, byte qosLevel, bool retain);
                client.Publish(comboBoxTopic.Text, Encoding.UTF8.GetBytes(textBoxWrite.Text), MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, checkBoxRetain.Checked);
                textBoxWrite.Clear();
            }
            else
            {
                textBoxInfo.Text += System.Environment.NewLine + ("** You are not logged on or subscribed!");
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (client != null && textBoxStatus.Text == "connected")
            {
                try
                {
                    client.Disconnect();
                    textBoxInfo.Text += System.Environment.NewLine + ("* Client disconnected");
                }
                catch //uPLibrary.Networking.M2Mqtt.Exceptions.MqttCommunicationException
                {
                    textBoxInfo.Text += System.Environment.NewLine + ("* MQTT exception during disconnecting");
                }
            }

            textBoxStatus.Text = "disconnected";
            lockGUIsettings(false);
            textBoxInfo.Clear();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (client != null && textBoxStatus.Text == "connected")
            {
                if (comboBoxTopic.Text == null) //else failure of dll
                {
                    comboBoxTopic.Text = "";
                }

                
                try
                {
                    WhatWasSubscribed.Add(comboBoxTopic.Text);
                    ushort msgId = client.Subscribe(new string[] { WhatWasSubscribed[(WhatWasSubscribed.Count)-1] }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });

                    textBoxInfo.Text += System.Environment.NewLine + ("** Subscribing to: " + WhatWasSubscribed[(WhatWasSubscribed.Count) - 1]);
                    IsSubscribed = true;
                }
                catch
                {
                    textBoxInfo.Text += System.Environment.NewLine + ("** not subscribed!");
                    IsSubscribed = false;
                }
            }
            else
            {
                textBoxInfo.Text += System.Environment.NewLine + ("* You are not connected!");
            }
        }

        private void buttonUnsub_Click(object sender, EventArgs e)
        {
            if (client != null && textBoxStatus.Text == "connected")
            {
                try
                {
                    foreach(string s in WhatWasSubscribed) //.Distinct()
                    { 
                        ushort msgId = client.Unsubscribe(new string[] { s });
                        textBoxInfo.Text += System.Environment.NewLine + ("** Unsubscribing from: " + s);
                    }
                    IsSubscribed = false;
                    WhatWasSubscribed.Clear(); //flush old topics
                }
                catch
                {
                    textBoxInfo.Text += System.Environment.NewLine + ("** Unsuscribe failed!");
                }

            }
        }

        private void lockGUIsettings(bool DoYouWantToLock)
        {
            //header
            tabPageChat1.Text = "Chat: " + textBoxNick.Text + " and " + textBoxPartner.Text;

            //buttons magic
            if (DoYouWantToLock == false)
            {
                textBoxURL.ReadOnly = false;
                textBoxNick.ReadOnly = false;
                textBoxUsername.ReadOnly = false;
                textBoxPass.ReadOnly = false;
                textBoxPartner.ReadOnly = false;
                checkBoxAnon.Enabled = true;

                checkBoxAnon_CheckedChanged(null, null);
            }
            else
            {
                textBoxURL.ReadOnly = true;
                textBoxNick.ReadOnly = true;
                textBoxUsername.ReadOnly = true;
                textBoxPass.ReadOnly = true;
                textBoxPartner.ReadOnly = true;
                checkBoxAnon.Enabled = false;

                checkBoxAnon_CheckedChanged(null, null);

                try //update topics for selection by actual usernames
                {
                    topics.Clear();
                    topics.Add(@"/mschat");
                    topics.Add(@"/mschat/all");
                    topics.Add(@"/mschat/all/" + textBoxNick.Text);
                    topics.Add(@"/mschat/all/anon");
                    topics.Add(@"/mschat/status");
                    topics.Add(@"/mschat/status/" + textBoxNick.Text);
                    topics.Add(@"/mschat/user/");
                    topics.Add(@"/mschat/user/" + textBoxPartner.Text);
                    topics.Add(@"/mschat/user/" + textBoxPartner.Text + "/" + textBoxNick.Text);

                    comboBoxTopic.Items.Clear(); //combobox flush

                    foreach (String s in topics) //put them back
                    {
                        comboBoxTopic.Items.Add(s);
                    }

                    if (comboBoxTopic.SelectedIndex == -1) //set new master if is nothing selected
                    {
                        comboBoxTopic.SelectedIndex = 1; //TODO: not working
                    }
                }
                catch
                {
                    textBoxInfo.Text += System.Environment.NewLine + ("** Topic update failed");
                }

            }
        }

        private void buttonTabMinus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTabPlus_Click(object sender, EventArgs e)
        {
            Form FormChat2 = new FormChat1(textBoxPartner.Text, textBoxNick.Text); //changes usernames
            FormChat2.Show();
        }

        private void textBoxInfo_TextChanged(object sender, EventArgs e) //autoscroll chat window
        {
            textBoxInfo.SelectionStart = textBoxInfo.Text.Length;
            textBoxInfo.ScrollToCaret();
        }

        private void checkBoxAnon_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAnon.Checked == true)
            {
                textBoxNick.ReadOnly = true;
                textBoxUsername.ReadOnly = true;
                textBoxPass.ReadOnly = true;
                comboBoxTopic.Text = "/mschat/all/anon";
            }
            else
            {
                textBoxNick.ReadOnly = false;
                textBoxUsername.ReadOnly = false;
                textBoxPass.ReadOnly = false;
            }
        }
    }
}

