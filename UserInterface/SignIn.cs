using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using UserData;
using ServerData;





namespace UserInterface
{
    public partial class SignIn : Form
    {
        public Server server1;

        //List<User> listofUsers = new List<User>();

        IPAddress clientIpAddr;

        internal User new_user;

        












        public SignIn()
        {
            server1 = new Server();
            InitializeComponent();
        }

      

        


        //private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (GlobalBoolean.UserIsValid == false)
        //    {

        //        e.Cancel = true;
        //    }

        //    GlobalBoolean.ResetBooleans();

        //}

      

       

        private void NicknameConfirmationButton_Click(object sender, EventArgs e)
        {
            

            var listofnames = from n in Form1.ListOfUsers
                              select (n.Nickname);


            bool a = listofnames.Contains(UserNameBox.Text);

            if (!a)
            {
                NickNameConfirmationLabel.ForeColor = Color.Lime;
                NickNameConfirmationLabel.Text = "UserName confirmed";
                GlobalBoolean.NicnameConfirmed = true;
            }

            else
            {
                NickNameConfirmationLabel.ForeColor = Color.Red;
                NickNameConfirmationLabel.Text = "UserName already take, please choose another one";


            }
        }


        private void ConnectButton_Click(object sender, EventArgs e)
        {


            if (GlobalBoolean.IPconfirmed  && GlobalBoolean.NicnameConfirmed  && GlobalBoolean.PORTconfirmed )
            {
                Form1.ListOfUsers.Add (new User(Form1.ListOfUsers.Count) { Nickname = this.UserNameBox.Text, IP = clientIpAddr.ToString() });
                new_user = Form1.ListOfUsers.LastOrDefault();
                TcpClient client1 = new TcpClient();
                GlobalBoolean.UserIsValid = true;
                GlobalBoolean.ResetBooleans();
                ClearAll();
                Close();
            }

        }

    

        private void ConfirmIP_Click(object sender, EventArgs e)
        {

            this.IPmaskedTextBox.ValidatingType = typeof(IPAddress);
            

            char[] delimit = { ' ' };
            string[] str = IPmaskedTextBox.Text.Split();
            string separator = "";




            string adress = string.Join(separator, str);


            bool b = IPAddress.TryParse(adress, out clientIpAddr);


            if (b == true)
            {
                if (clientIpAddr.ToString() == server1.IP)
                {
                    IPconfirmationLabel.ForeColor = Color.Lime;
                    IPconfirmationLabel.Text = "IP Confimed";
                    GlobalBoolean.IPconfirmed = true;
                }

                else
                {
                    IPconfirmationLabel.ForeColor = Color.Red;
                    IPconfirmationLabel.Text = "IP Denied, please try another one";

                }

            }

        }

        private void PortConfirmationButtom_Click(object sender, EventArgs e)
        {
            if (server1.Port == int.Parse(portTextBox.Text))
            {
                portConfirmationLabel.ForeColor = Color.Lime;
                portConfirmationLabel.Text = "Port Confirmed";
                GlobalBoolean.PORTconfirmed = true;

            }


            else

            {
                portConfirmationLabel.ForeColor = Color.Red;
                portConfirmationLabel.Text = "Port Denied, pleasetry again.";


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPmaskedTextBox.Clear();
        }

        private void UsernameClearButton_Click(object sender, EventArgs e)
        {
            UserNameBox.Clear();
        }

        private void Clearportbutton_Click(object sender, EventArgs e)
        {
            portTextBox.Clear();
        }

        private void ClearAll()
        {
            IPmaskedTextBox.Clear();
            UserNameBox.Clear();
            portTextBox.Clear();
        }
    }
    }

