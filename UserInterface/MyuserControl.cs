using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserData;
using ServerData;

namespace UserInterface
{
    public partial class MyuserControl : UserControl
    {

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text { get; set; }



        public event EventHandler<MessageArgs> SendMessage;

        MessageArgs MA = new MessageArgs();

        SignIn signinForm = new SignIn();

        Server servak = new Server();

        User localUser;
       

        public MyuserControl()
        {
            InitializeComponent();
            
        }

        private void ColorChoosing_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.AnyColor = true;
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {

                this.TextMessages.ForeColor = colorDialog1.Color;
            }
        }

        private void changeFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.AllowScriptChange = true;
            fontDialog1.AllowSimulations = true;
            fontDialog1.ShowEffects = true;

            DialogResult result = fontDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.TextMessages.Font = fontDialog1.Font;

            }
        }

        private void MyuserControl_Load(object sender, EventArgs e)
        {
            signinForm.ShowDialog();
             localUser = Form1.ListOfUsers.LastOrDefault();
            this.label1.Text = localUser.Nickname;
            this.Text = localUser.Nickname;
            

        }

        private void sendmessageButton_Click(object sender, EventArgs e)
        {
            MA.MessageText = TextMessages.Text;
            SendMessage(this, MA);

        }

        private void MyuserControl_Enter(object sender, EventArgs e)
        {
            //User localuser = new User(Form1.ListOfUsers.Count);
            //this.label1.Text = localuser.Nickname;
            this.Text = localUser.Nickname;
        }
    }
}
