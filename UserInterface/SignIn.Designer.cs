namespace UserInterface
{
    partial class SignIn
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.ConfirmIP = new System.Windows.Forms.Button();
            this.NicknameConfirmationButton = new System.Windows.Forms.Button();
            this.IPmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.process1 = new System.Diagnostics.Process();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ConnectButton = new System.Windows.Forms.Button();
            this.IPconfirmationLabel = new System.Windows.Forms.Label();
            this.NickNameConfirmationLabel = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PortConfirmationButtom = new System.Windows.Forms.Button();
            this.portConfirmationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter IP Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Your UserName";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(197, 92);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(108, 20);
            this.UserNameBox.TabIndex = 3;
            // 
            // ConfirmIP
            // 
            this.ConfirmIP.Location = new System.Drawing.Point(358, 41);
            this.ConfirmIP.Name = "ConfirmIP";
            this.ConfirmIP.Size = new System.Drawing.Size(75, 23);
            this.ConfirmIP.TabIndex = 4;
            this.ConfirmIP.Text = "ConfirmIP";
            this.ConfirmIP.UseVisualStyleBackColor = true;
            this.ConfirmIP.Click += new System.EventHandler(this.ConfirmIP_Click);
            // 
            // NicknameConfirmationButton
            // 
            this.NicknameConfirmationButton.Location = new System.Drawing.Point(358, 92);
            this.NicknameConfirmationButton.Name = "NicknameConfirmationButton";
            this.NicknameConfirmationButton.Size = new System.Drawing.Size(75, 24);
            this.NicknameConfirmationButton.TabIndex = 5;
            this.NicknameConfirmationButton.Text = "Confirm UserName";
            this.NicknameConfirmationButton.UseVisualStyleBackColor = true;
            this.NicknameConfirmationButton.Click += new System.EventHandler(this.NicknameConfirmationButton_Click);
            // 
            // IPmaskedTextBox
            // 
            this.IPmaskedTextBox.Location = new System.Drawing.Point(197, 41);
            this.IPmaskedTextBox.Mask = " ###.###.###.###";
            this.IPmaskedTextBox.Name = "IPmaskedTextBox";
            this.IPmaskedTextBox.Size = new System.Drawing.Size(108, 20);
            this.IPmaskedTextBox.TabIndex = 6;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(187, 178);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(153, 32);
            this.ConnectButton.TabIndex = 9;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // IPconfirmationLabel
            // 
            this.IPconfirmationLabel.AutoSize = true;
            this.IPconfirmationLabel.Location = new System.Drawing.Point(471, 48);
            this.IPconfirmationLabel.Name = "IPconfirmationLabel";
            this.IPconfirmationLabel.Size = new System.Drawing.Size(49, 13);
            this.IPconfirmationLabel.TabIndex = 10;
            this.IPconfirmationLabel.Text = "sometext";
            // 
            // NickNameConfirmationLabel
            // 
            this.NickNameConfirmationLabel.AutoSize = true;
            this.NickNameConfirmationLabel.Location = new System.Drawing.Point(471, 103);
            this.NickNameConfirmationLabel.Name = "NickNameConfirmationLabel";
            this.NickNameConfirmationLabel.Size = new System.Drawing.Size(49, 13);
            this.NickNameConfirmationLabel.TabIndex = 11;
            this.NickNameConfirmationLabel.Text = "sometext";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(197, 134);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(127, 20);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Enter you port";
            // 
            // PortConfirmationButtom
            // 
            this.PortConfirmationButtom.Location = new System.Drawing.Point(358, 135);
            this.PortConfirmationButtom.Name = "PortConfirmationButtom";
            this.PortConfirmationButtom.Size = new System.Drawing.Size(75, 23);
            this.PortConfirmationButtom.TabIndex = 14;
            this.PortConfirmationButtom.Text = "Confirm port";
            this.PortConfirmationButtom.UseVisualStyleBackColor = true;
            // 
            // portConfirmationLabel
            // 
            this.portConfirmationLabel.AutoSize = true;
            this.portConfirmationLabel.Location = new System.Drawing.Point(474, 144);
            this.portConfirmationLabel.Name = "portConfirmationLabel";
            this.portConfirmationLabel.Size = new System.Drawing.Size(49, 13);
            this.portConfirmationLabel.TabIndex = 15;
            this.portConfirmationLabel.Text = "sometext";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 248);
            this.Controls.Add(this.portConfirmationLabel);
            this.Controls.Add(this.PortConfirmationButtom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.NickNameConfirmationLabel);
            this.Controls.Add(this.IPconfirmationLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.IPmaskedTextBox);
            this.Controls.Add(this.NicknameConfirmationButton);
            this.Controls.Add(this.ConfirmIP);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignIn_FormClosing);
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
       public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox UserNameBox;
        public System.Windows.Forms.Button ConfirmIP;
       public System.Windows.Forms.Button NicknameConfirmationButton;
        public System.Windows.Forms.MaskedTextBox IPmaskedTextBox;
        public System.Diagnostics.Process process1;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label NickNameConfirmationLabel;
        private System.Windows.Forms.Label IPconfirmationLabel;
        private System.Windows.Forms.Label portConfirmationLabel;
        private System.Windows.Forms.Button PortConfirmationButtom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}