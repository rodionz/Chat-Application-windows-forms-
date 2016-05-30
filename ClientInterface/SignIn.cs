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

namespace ClientInterface
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }


        IPAddress clientIpAddr;


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
    }
}
