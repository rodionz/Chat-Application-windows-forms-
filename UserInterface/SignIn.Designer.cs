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
            this.button1 = new System.Windows.Forms.Button();
            this.NicknameConfirmationButton = new System.Windows.Forms.Button();
            this.IPmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.process1 = new System.Diagnostics.Process();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.IPConfirmed = new System.Windows.Forms.Label();
            this.UserNameConfirmed = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter IP Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Your UserName";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(187, 120);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(108, 20);
            this.UserNameBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NicknameConfirmationButton
            // 
            this.NicknameConfirmationButton.Location = new System.Drawing.Point(358, 116);
            this.NicknameConfirmationButton.Name = "NicknameConfirmationButton";
            this.NicknameConfirmationButton.Size = new System.Drawing.Size(75, 23);
            this.NicknameConfirmationButton.TabIndex = 5;
            this.NicknameConfirmationButton.Text = "Confirm";
            this.NicknameConfirmationButton.UseVisualStyleBackColor = true;
            this.NicknameConfirmationButton.Click += new System.EventHandler(this.NicknameConfirmationButton_Click);
            // 
            // IPmaskedTextBox
            // 
            this.IPmaskedTextBox.Location = new System.Drawing.Point(187, 74);
            this.IPmaskedTextBox.Mask = " ###.###.###.###";
            this.IPmaskedTextBox.Name = "IPmaskedTextBox";
            this.IPmaskedTextBox.Size = new System.Drawing.Size(108, 20);
            this.IPmaskedTextBox.TabIndex = 6;
            this.IPmaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.IPmaskedTextBox_Validating);
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
            // IPConfirmed
            // 
            this.IPConfirmed.AutoSize = true;
            this.IPConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IPConfirmed.ForeColor = System.Drawing.Color.Lime;
            this.IPConfirmed.Location = new System.Drawing.Point(460, 74);
            this.IPConfirmed.Name = "IPConfirmed";
            this.IPConfirmed.Size = new System.Drawing.Size(35, 16);
            this.IPConfirmed.TabIndex = 7;
            this.IPConfirmed.Text = "   V   ";
            // 
            // UserNameConfirmed
            // 
            this.UserNameConfirmed.AutoSize = true;
            this.UserNameConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UserNameConfirmed.ForeColor = System.Drawing.Color.Lime;
            this.UserNameConfirmed.Location = new System.Drawing.Point(460, 119);
            this.UserNameConfirmed.Name = "UserNameConfirmed";
            this.UserNameConfirmed.Size = new System.Drawing.Size(35, 16);
            this.UserNameConfirmed.TabIndex = 8;
            this.UserNameConfirmed.Text = "   V   ";
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
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 248);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.UserNameConfirmed);
            this.Controls.Add(this.IPConfirmed);
            this.Controls.Add(this.IPmaskedTextBox);
            this.Controls.Add(this.NicknameConfirmationButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignIn_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
       public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox UserNameBox;
        public System.Windows.Forms.Button button1;
       public System.Windows.Forms.Button NicknameConfirmationButton;
        public System.Windows.Forms.MaskedTextBox IPmaskedTextBox;
        public System.Diagnostics.Process process1;
        public System.Windows.Forms.ToolTip toolTip1;
       public System.Windows.Forms.Label UserNameConfirmed;
        public System.Windows.Forms.Label IPConfirmed;
        public System.Windows.Forms.Button ConnectButton;
    }
}