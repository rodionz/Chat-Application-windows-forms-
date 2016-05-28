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

        List<User> listofUsers;

        IPAddress clientIpAddr;









        public SignIn()
        {
            server1 = new Server();
            InitializeComponent();
        }

      

        


        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Validators_GlobalBooleans.SignInisValid == false)
            {

                e.Cancel = true;
            }
        }

      

       

        private void NicknameConfirmationButton_Click(object sender, EventArgs e)
        {
            var uniq = listofUsers.Where(usr => usr.Nickname == this.UserNameBox.Text).Count();

            if (uniq == 0)
            {
                NickNameConfirmationLabel.ForeColor = Color.DarkGreen;
                NickNameConfirmationLabel.Text = "UserName confirmed";
                Validators_GlobalBooleans.NicnameConfirmed = true;
            }

            else
            {
                NickNameConfirmationLabel.ForeColor = Color.DarkRed;
                NickNameConfirmationLabel.Text = "UserName already take, please choose another one";


            }
        }


        private void ConnectButton_Click(object sender, EventArgs e)
        {


            if (Validators_GlobalBooleans.IPconfirmed == true && Validators_GlobalBooleans.NicnameConfirmed == true)
            {
                User user1 = new User() {Nickname = this.UserNameBox.Text, IP = clientIpAddr.ToString() };
                TcpClient client1 = new TcpClient();
            }

        }

        private void SignIn_Load(object sender, EventArgs e)


        {

            List<User> listofUsers= new List<User>();
            

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
                    IPconfirmationLabel.ForeColor = Color.DarkGreen;
                    IPconfirmationLabel.Text = "IP Confimed";
                    Validators_GlobalBooleans.IPconfirmed = true;
                }

                else
                {
                    IPconfirmationLabel.ForeColor = Color.DarkRed;
                    IPconfirmationLabel.Text = "IP Denied, please try another one";

                }

            }

        }





    }
    }

