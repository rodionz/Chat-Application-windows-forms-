namespace ClientInterface
{
    partial class UserInterfaceClass
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TextMessages = new System.Windows.Forms.TextBox();
            this.sendmessageButton = new System.Windows.Forms.Button();
            this.changeFontButton = new System.Windows.Forms.Button();
            this.ColorChoosing = new System.Windows.Forms.Button();
            this.ConnectToserverButton = new System.Windows.Forms.Button();
            this.DisconnectFromServerButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Location = new System.Drawing.Point(205, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 235);
            this.panel5.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 202);
            this.textBox1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Controls.Add(this.TextMessages);
            this.panel6.Location = new System.Drawing.Point(205, 282);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(341, 67);
            this.panel6.TabIndex = 4;
            // 
            // TextMessages
            // 
            this.TextMessages.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextMessages.Location = new System.Drawing.Point(23, 13);
            this.TextMessages.Multiline = true;
            this.TextMessages.Name = "TextMessages";
            this.TextMessages.Size = new System.Drawing.Size(283, 39);
            this.TextMessages.TabIndex = 0;
            // 
            // sendmessageButton
            // 
            this.sendmessageButton.Location = new System.Drawing.Point(607, 295);
            this.sendmessageButton.Name = "sendmessageButton";
            this.sendmessageButton.Size = new System.Drawing.Size(100, 39);
            this.sendmessageButton.TabIndex = 8;
            this.sendmessageButton.Text = "SEND";
            this.sendmessageButton.UseVisualStyleBackColor = true;
            // 
            // changeFontButton
            // 
            this.changeFontButton.Location = new System.Drawing.Point(205, 451);
            this.changeFontButton.Name = "changeFontButton";
            this.changeFontButton.Size = new System.Drawing.Size(109, 36);
            this.changeFontButton.TabIndex = 10;
            this.changeFontButton.Text = "Change Font";
            this.changeFontButton.UseVisualStyleBackColor = true;
            this.changeFontButton.Click += new System.EventHandler(this.changeFontButton_Click);
            // 
            // ColorChoosing
            // 
            this.ColorChoosing.Location = new System.Drawing.Point(205, 382);
            this.ColorChoosing.Name = "ColorChoosing";
            this.ColorChoosing.Size = new System.Drawing.Size(109, 33);
            this.ColorChoosing.TabIndex = 9;
            this.ColorChoosing.Text = "ChooseYourColor";
            this.ColorChoosing.UseVisualStyleBackColor = true;
            this.ColorChoosing.Click += new System.EventHandler(this.ColorChoosing_Click);
            // 
            // ConnectToserverButton
            // 
            this.ConnectToserverButton.Location = new System.Drawing.Point(583, 382);
            this.ConnectToserverButton.Name = "ConnectToserverButton";
            this.ConnectToserverButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectToserverButton.TabIndex = 11;
            this.ConnectToserverButton.Text = "Connect";
            this.ConnectToserverButton.UseVisualStyleBackColor = true;
            this.ConnectToserverButton.Click += new System.EventHandler(this.ConnectToserverButton_Click);
            // 
            // DisconnectFromServerButton
            // 
            this.DisconnectFromServerButton.Location = new System.Drawing.Point(583, 442);
            this.DisconnectFromServerButton.Name = "DisconnectFromServerButton";
            this.DisconnectFromServerButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectFromServerButton.TabIndex = 12;
            this.DisconnectFromServerButton.Text = "Disconnect";
            this.DisconnectFromServerButton.UseVisualStyleBackColor = true;
            // 
            // UserInterfaceClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(932, 562);
            this.Controls.Add(this.DisconnectFromServerButton);
            this.Controls.Add(this.ConnectToserverButton);
            this.Controls.Add(this.changeFontButton);
            this.Controls.Add(this.ColorChoosing);
            this.Controls.Add(this.sendmessageButton);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Name = "UserInterfaceClass";
            this.Text = "ClientInterface";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TextBox TextMessages;
        public System.Windows.Forms.Button sendmessageButton;
        private System.Windows.Forms.Button changeFontButton;
        public System.Windows.Forms.Button ColorChoosing;
        private System.Windows.Forms.Button ConnectToserverButton;
        private System.Windows.Forms.Button DisconnectFromServerButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

