using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonTypes;

namespace ClientInterface
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        ServerData Sdata;
        IPAddress clientIpAddr;
        public event EventHandler newUsercreated;
        UserData new_user;

        NewUserEventArgs NUEA = new NewUserEventArgs();


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
                if (clientIpAddr.ToString() == Sdata.IPofServer)
                {
                    IPconfirmationLabel.ForeColor = Color.Lime;
                    IPconfirmationLabel.Text = "IP Confimed";
                    ClientUiBooleans.IPconfirmed = true;
                }

                else
                {
                    IPconfirmationLabel.ForeColor = Color.Red;
                    IPconfirmationLabel.Text = "IP Denied, please try another one";

                }

            }
        }

        private void clearIP_Click(object sender, EventArgs e)
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

        private void PortConfirmationButtom_Click(object sender, EventArgs e)
        {
            if (Sdata.PortofServer == int.Parse(portTextBox.Text))
            {
                portConfirmationLabel.ForeColor = Color.Lime;
                portConfirmationLabel.Text = "Port Confirmed";
                ClientUiBooleans.PORTconfirmed = true;

            }


            else

            {
                portConfirmationLabel.ForeColor = Color.Red;
                portConfirmationLabel.Text = "Port Denied, pleasetry again.";


            }
        }

        private void NicknameConfirmationButton_Click(object sender, EventArgs e)
        {


            var listofnames = from n in UserInterfaceClass.ListofUsers
                              select (n.Username);


            bool a = listofnames.Contains(UserNameBox.Text);

            if (!a)
            {
                NickNameConfirmationLabel.ForeColor = Color.Lime;
                NickNameConfirmationLabel.Text = "UserName confirmed";
                ClientUiBooleans.NicnameConfirmed = true;
            }

            else
            {
                NickNameConfirmationLabel.ForeColor = Color.Red;
                NickNameConfirmationLabel.Text = "UserName already take, please choose another one";


            }



        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (ClientUiBooleans.IPconfirmed && ClientUiBooleans.NicnameConfirmed && ClientUiBooleans.PORTconfirmed)
            {
                UserInterfaceClass.ListofUsers.Add(new UserData(UserInterfaceClass.ListofUsers.Count) { Username = this.UserNameBox.Text, UserIP = clientIpAddr.ToString() });
                newUsercreated(this, NUEA);
                new_user = UserInterfaceClass.ListofUsers.LastOrDefault();
               
                ClientUiBooleans.UserIsValid = true;
                ClientUiBooleans.ResetBooleans();
                ClearAll();
                Close();
            }
        }
    }
}
