namespace ServerInterface
{
    partial class ServerInterfaceClass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.StartServerButton = new System.Windows.Forms.Button();
            this.ChangeIpButton = new System.Windows.Forms.Button();
            this.ChangePortButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Location = new System.Drawing.Point(248, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 326);
            this.panel1.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(23, 21);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(400, 274);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(392, 248);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Current Users";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Transparent;
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(392, 248);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "History";
            // 
            // StartServerButton
            // 
            this.StartServerButton.Location = new System.Drawing.Point(248, 442);
            this.StartServerButton.Name = "StartServerButton";
            this.StartServerButton.Size = new System.Drawing.Size(103, 43);
            this.StartServerButton.TabIndex = 2;
            this.StartServerButton.Text = "Start Server";
            this.StartServerButton.UseVisualStyleBackColor = true;
            this.StartServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
            // 
            // ChangeIpButton
            // 
            this.ChangeIpButton.Location = new System.Drawing.Point(451, 442);
            this.ChangeIpButton.Name = "ChangeIpButton";
            this.ChangeIpButton.Size = new System.Drawing.Size(85, 43);
            this.ChangeIpButton.TabIndex = 3;
            this.ChangeIpButton.Text = "Change IP";
            this.ChangeIpButton.UseVisualStyleBackColor = true;
            this.ChangeIpButton.Click += new System.EventHandler(this.ChangeIpButton_Click);
            // 
            // ChangePortButton
            // 
            this.ChangePortButton.Location = new System.Drawing.Point(610, 442);
            this.ChangePortButton.Name = "ChangePortButton";
            this.ChangePortButton.Size = new System.Drawing.Size(86, 43);
            this.ChangePortButton.TabIndex = 4;
            this.ChangePortButton.Text = "Change Port";
            this.ChangePortButton.UseVisualStyleBackColor = true;
            this.ChangePortButton.Click += new System.EventHandler(this.ChangePortButton_Click);
            // 
            // ServerInterfaceClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(999, 568);
            this.Controls.Add(this.ChangePortButton);
            this.Controls.Add(this.ChangeIpButton);
            this.Controls.Add(this.StartServerButton);
            this.Controls.Add(this.panel1);
            this.Name = "ServerInterfaceClass";
            this.Text = "ServerUi";
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TabControl tabControl2;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button StartServerButton;
        private System.Windows.Forms.Button ChangeIpButton;
        private System.Windows.Forms.Button ChangePortButton;
    }
}

