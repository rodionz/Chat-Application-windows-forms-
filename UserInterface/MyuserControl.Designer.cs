namespace UserInterface
{
    partial class MyuserControl
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

        #region Component Designer generated code

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
            this.ColorChoosing = new System.Windows.Forms.Button();
            this.changeFontButton = new System.Windows.Forms.Button();
            this.sendmessageButton = new System.Windows.Forms.Button();
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
            this.panel5.Location = new System.Drawing.Point(266, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 235);
            this.panel5.TabIndex = 2;
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
            this.panel6.Location = new System.Drawing.Point(266, 301);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(341, 67);
            this.panel6.TabIndex = 3;
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
            // ColorChoosing
            // 
            this.ColorChoosing.Location = new System.Drawing.Point(266, 401);
            this.ColorChoosing.Name = "ColorChoosing";
            this.ColorChoosing.Size = new System.Drawing.Size(109, 33);
            this.ColorChoosing.TabIndex = 5;
            this.ColorChoosing.Text = "ChooseYourColor";
            this.ColorChoosing.UseVisualStyleBackColor = true;
            this.ColorChoosing.Click += new System.EventHandler(this.ColorChoosing_Click);
            // 
            // changeFontButton
            // 
            this.changeFontButton.Location = new System.Drawing.Point(266, 470);
            this.changeFontButton.Name = "changeFontButton";
            this.changeFontButton.Size = new System.Drawing.Size(109, 36);
            this.changeFontButton.TabIndex = 6;
            this.changeFontButton.Text = "Change Font";
            this.changeFontButton.UseVisualStyleBackColor = true;
            this.changeFontButton.Click += new System.EventHandler(this.changeFontButton_Click);
            // 
            // sendmessageButton
            // 
            this.sendmessageButton.Location = new System.Drawing.Point(663, 314);
            this.sendmessageButton.Name = "sendmessageButton";
            this.sendmessageButton.Size = new System.Drawing.Size(100, 39);
            this.sendmessageButton.TabIndex = 7;
            this.sendmessageButton.Text = "SEND";
            this.sendmessageButton.UseVisualStyleBackColor = true;
            this.sendmessageButton.Click += new System.EventHandler(this.sendmessageButton_Click);
            // 
            // MyuserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.sendmessageButton);
            this.Controls.Add(this.changeFontButton);
            this.Controls.Add(this.ColorChoosing);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Name = "MyuserControl";
            this.Size = new System.Drawing.Size(1270, 664);
            this.Load += new System.EventHandler(this.MyuserControl_Load);
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
        public System.Windows.Forms.Button ColorChoosing;
        private System.Windows.Forms.Button changeFontButton;
        public System.Windows.Forms.Button sendmessageButton;
        public System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.FontDialog fontDialog1;
    }
}
