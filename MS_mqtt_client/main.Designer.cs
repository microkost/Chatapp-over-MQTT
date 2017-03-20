namespace MS_mqtt_client
{
    partial class FormChat1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPageChat1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxAnon = new System.Windows.Forms.CheckBox();
            this.checkBoxRetain = new System.Windows.Forms.CheckBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonTabMinus = new System.Windows.Forms.Button();
            this.buttonTabPlus = new System.Windows.Forms.Button();
            this.comboBoxTopic = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPartner = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonUnsub = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWrite = new System.Windows.Forms.TextBox();
            this.tabControlChat = new System.Windows.Forms.TabControl();
            this.tabPageChat1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControlChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageChat1
            // 
            this.tabPageChat1.Controls.Add(this.groupBox3);
            this.tabPageChat1.Controls.Add(this.textBoxInfo);
            this.tabPageChat1.Controls.Add(this.label10);
            this.tabPageChat1.Controls.Add(this.label9);
            this.tabPageChat1.Controls.Add(this.buttonTabMinus);
            this.tabPageChat1.Controls.Add(this.buttonTabPlus);
            this.tabPageChat1.Controls.Add(this.comboBoxTopic);
            this.tabPageChat1.Controls.Add(this.groupBox1);
            this.tabPageChat1.Controls.Add(this.groupBox2);
            this.tabPageChat1.Controls.Add(this.buttonSub);
            this.tabPageChat1.Controls.Add(this.buttonUnsub);
            this.tabPageChat1.Controls.Add(this.buttonSend);
            this.tabPageChat1.Controls.Add(this.label4);
            this.tabPageChat1.Controls.Add(this.textBoxWrite);
            this.tabPageChat1.Location = new System.Drawing.Point(4, 22);
            this.tabPageChat1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageChat1.Name = "tabPageChat1";
            this.tabPageChat1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageChat1.Size = new System.Drawing.Size(746, 310);
            this.tabPageChat1.TabIndex = 1;
            this.tabPageChat1.Text = "ChatClient";
            this.tabPageChat1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxAnon);
            this.groupBox3.Controls.Add(this.checkBoxRetain);
            this.groupBox3.Location = new System.Drawing.Point(458, 126);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(286, 34);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message settings";
            // 
            // checkBoxAnon
            // 
            this.checkBoxAnon.AutoSize = true;
            this.checkBoxAnon.Location = new System.Drawing.Point(145, 11);
            this.checkBoxAnon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxAnon.Name = "checkBoxAnon";
            this.checkBoxAnon.Size = new System.Drawing.Size(81, 17);
            this.checkBoxAnon.TabIndex = 1;
            this.checkBoxAnon.Text = "Anonymous";
            this.checkBoxAnon.UseVisualStyleBackColor = true;
            this.checkBoxAnon.CheckedChanged += new System.EventHandler(this.checkBoxAnon_CheckedChanged);
            // 
            // checkBoxRetain
            // 
            this.checkBoxRetain.AutoSize = true;
            this.checkBoxRetain.Location = new System.Drawing.Point(227, 11);
            this.checkBoxRetain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxRetain.Name = "checkBoxRetain";
            this.checkBoxRetain.Size = new System.Drawing.Size(57, 17);
            this.checkBoxRetain.TabIndex = 0;
            this.checkBoxRetain.Text = "Retain";
            this.checkBoxRetain.UseVisualStyleBackColor = true;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(7, 165);
            this.textBoxInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo.Size = new System.Drawing.Size(447, 145);
            this.textBoxInfo.TabIndex = 11;
            this.textBoxInfo.TextChanged += new System.EventHandler(this.textBoxInfo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Flow:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Client:";
            // 
            // buttonTabMinus
            // 
            this.buttonTabMinus.Location = new System.Drawing.Point(76, 130);
            this.buttonTabMinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTabMinus.Name = "buttonTabMinus";
            this.buttonTabMinus.Size = new System.Drawing.Size(28, 30);
            this.buttonTabMinus.TabIndex = 14;
            this.buttonTabMinus.Text = "-";
            this.buttonTabMinus.UseVisualStyleBackColor = true;
            this.buttonTabMinus.Click += new System.EventHandler(this.buttonTabMinus_Click);
            // 
            // buttonTabPlus
            // 
            this.buttonTabPlus.Location = new System.Drawing.Point(44, 130);
            this.buttonTabPlus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTabPlus.Name = "buttonTabPlus";
            this.buttonTabPlus.Size = new System.Drawing.Size(28, 30);
            this.buttonTabPlus.TabIndex = 13;
            this.buttonTabPlus.Text = "+";
            this.buttonTabPlus.UseVisualStyleBackColor = true;
            this.buttonTabPlus.Click += new System.EventHandler(this.buttonTabPlus_Click);
            // 
            // comboBoxTopic
            // 
            this.comboBoxTopic.Items.AddRange(new object[] {
            "/mschat/#",
            "/mschat/all/#",
            "/mschat/all/id_odesilatele",
            "/mschat/all/anon",
            "/mschat/status/#",
            "/mschat/status/id_uživatele",
            "/mschat/user/#",
            "/mschat/user/id_příjemce/#",
            "/mschat/user/id_příjemce/id_odesilatele"});
            this.comboBoxTopic.Location = new System.Drawing.Point(44, 6);
            this.comboBoxTopic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTopic.Name = "comboBoxTopic";
            this.comboBoxTopic.Size = new System.Drawing.Size(410, 21);
            this.comboBoxTopic.TabIndex = 1;
            this.comboBoxTopic.Text = "Conversation rooms";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.numericUpDownPort);
            this.groupBox1.Controls.Add(this.textBoxStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxURL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Location = new System.Drawing.Point(458, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(285, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(146, 99);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(135, 40);
            this.buttonDisconnect.TabIndex = 10;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownPort.Location = new System.Drawing.Point(116, 37);
            this.numericUpDownPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownPort.Minimum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.ReadOnly = true;
            this.numericUpDownPort.Size = new System.Drawing.Size(164, 20);
            this.numericUpDownPort.TabIndex = 4;
            this.numericUpDownPort.Value = new decimal(new int[] {
            1883,
            0,
            0,
            0});
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(116, 76);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(165, 20);
            this.textBoxStatus.TabIndex = 10;
            this.textBoxStatus.Text = "disconnected";
            this.textBoxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Connection port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(116, 14);
            this.textBoxURL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(165, 20);
            this.textBoxURL.TabIndex = 9;
            this.textBoxURL.Text = "pcfeib425t.vsb.cz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection URL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(4, 99);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(136, 40);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPartner);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxPass);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxUsername);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxNick);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(458, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(285, 115);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Identity";
            // 
            // textBoxPartner
            // 
            this.textBoxPartner.Location = new System.Drawing.Point(116, 92);
            this.textBoxPartner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPartner.Name = "textBoxPartner";
            this.textBoxPartner.Size = new System.Drawing.Size(165, 20);
            this.textBoxPartner.TabIndex = 8;
            this.textBoxPartner.Text = "von05";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Partner\'s ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(116, 69);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(165, 20);
            this.textBoxPass.TabIndex = 7;
            this.textBoxPass.Text = "Systemy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(116, 46);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(165, 20);
            this.textBoxUsername.TabIndex = 6;
            this.textBoxUsername.Text = "mobilni";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Server username";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxNick
            // 
            this.textBoxNick.Location = new System.Drawing.Point(116, 24);
            this.textBoxNick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(165, 20);
            this.textBoxNick.TabIndex = 5;
            this.textBoxNick.Text = "kos0148";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nickname";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(253, 130);
            this.buttonSub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(101, 30);
            this.buttonSub.TabIndex = 2;
            this.buttonSub.Text = "Listen";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonUnsub
            // 
            this.buttonUnsub.Location = new System.Drawing.Point(154, 130);
            this.buttonUnsub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUnsub.Name = "buttonUnsub";
            this.buttonUnsub.Size = new System.Drawing.Size(94, 30);
            this.buttonUnsub.TabIndex = 12;
            this.buttonUnsub.Text = "Stop listening";
            this.buttonUnsub.UseVisualStyleBackColor = true;
            this.buttonUnsub.Click += new System.EventHandler(this.buttonUnsub_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(358, 130);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(94, 30);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Speak";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Topic";
            // 
            // textBoxWrite
            // 
            this.textBoxWrite.Location = new System.Drawing.Point(7, 30);
            this.textBoxWrite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxWrite.Multiline = true;
            this.textBoxWrite.Name = "textBoxWrite";
            this.textBoxWrite.Size = new System.Drawing.Size(447, 92);
            this.textBoxWrite.TabIndex = 3;
            // 
            // tabControlChat
            // 
            this.tabControlChat.Controls.Add(this.tabPageChat1);
            this.tabControlChat.Location = new System.Drawing.Point(3, 2);
            this.tabControlChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlChat.Name = "tabControlChat";
            this.tabControlChat.SelectedIndex = 0;
            this.tabControlChat.Size = new System.Drawing.Size(754, 336);
            this.tabControlChat.TabIndex = 13;
            // 
            // FormChat1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 343);
            this.Controls.Add(this.tabControlChat);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormChat1";
            this.Text = "MQTT chat application";
            this.tabPageChat1.ResumeLayout(false);
            this.tabPageChat1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControlChat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageChat1;
        private System.Windows.Forms.Button buttonTabMinus;
        private System.Windows.Forms.Button buttonTabPlus;
        private System.Windows.Forms.ComboBox comboBoxTopic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPartner;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonUnsub;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWrite;
        private System.Windows.Forms.TabControl tabControlChat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxRetain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAnon;
    }
}

