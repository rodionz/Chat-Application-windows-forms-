using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserData;
using ServerData;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public event EventHandler<MessageArgs> SendMessage;

        MessageArgs MA = new MessageArgs();
       
        Server servak = new Server();
        User localuser;
        //ClientInterface.Text = new_user;
        SignIn signinForm = new SignIn();

      public static List<User> ListOfUsers = new List<User>();


        public Form1()
        {



            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            signinForm.ShowDialog();
            MyuserControl control = new MyuserControl();
            localuser = ListOfUsers.LastOrDefault();
            TabPage tbp = new TabPage(localuser.Nickname);
            tbp.Controls.Add(control);
            this.tabControl1.TabPages.Add(tbp);
        }




        //private void ColorChoosing_Click(object sender, EventArgs e)
        //{

        //    colorDialog1.AllowFullOpen = true;
        //    colorDialog1.AnyColor = true;
        //    DialogResult result = colorDialog1.ShowDialog();

        //    if (result == DialogResult.OK)
        //    {

        //        this.TextMessages.ForeColor = colorDialog1.Color;
        //    }
        //}



     

        //private void changeFontButton_Click(object sender, EventArgs e)
        //{


        //    fontDialog1.AllowScriptChange = true;
        //    fontDialog1.AllowSimulations = true;
        //    fontDialog1.ShowEffects = true;
           
        //    DialogResult result = fontDialog1.ShowDialog();

        //    if(result == DialogResult.OK)
        //    {
        //        this.TextMessages.Font = fontDialog1.Font;

        //    }
        //}


        private void button1_Click(object sender, EventArgs e)
        {
            MyuserControl control = new MyuserControl();
            TabPage tbp = new TabPage();
            tbp.Controls.Add(control);
            this.tabControl1.TabPages.Add(tbp);
        }

        //private void sendmessageButton_Click(object sender, EventArgs e)
        //{
        //    MA.MessageText = TextMessages.Text;
        //    SendMessage(this, MA);
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            signinForm.ShowDialog();
            MyuserControl control = new MyuserControl();
            localuser = ListOfUsers.LastOrDefault();
            TabPage  tbp = new TabPage(localuser.Nickname);
            
            tbp.Controls.Add(control);
            
            this.tabControl1.TabPages.Add(tbp);
           
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            signinForm.ShowDialog();
            MyuserControl control = new MyuserControl();
            localuser = ListOfUsers.LastOrDefault();
            TabPage tbp = new TabPage(localuser.Nickname);
            tbp.Controls.Add(control);
            this.tabControl1.TabPages.Add(tbp);
        }
    }
}
