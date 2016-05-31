using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonTypes;

namespace ServerInterface
{
    public partial class ServerConnection : Form
    {
        public ServerConnection(ServerData sdat)
        {
            Sdata = sdat;
            InitializeComponent();
        }

        ServerData Sdata;
       

        private void ConfirmIP_Click(object sender, EventArgs e)
        {
            if (IPmaskedTextBox.Text.Length != 0)
            {
                ipConfirmLabel.ForeColor = Color.Green;
                ipConfirmLabel.Text = "Ok";
                Sdata.IPofServer = IPmaskedTextBox.Text;
            }

            else
            {
                ipConfirmLabel.ForeColor = Color.Red;
                ipConfirmLabel.Text = "Illigal Ip, Please Try Again";
            }
        }

        private void PortConfirmationButtom_Click(object sender, EventArgs e)
        {
           Sdata.PortofServer = int.Parse(portTextBox.Text);
        }

        private void CreateServerButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearIP_Click(object sender, EventArgs e)
        {
            IPmaskedTextBox.Clear();
        }

        private void Clearportbutton_Click(object sender, EventArgs e)
        {
            portTextBox.Clear();
        }

        
    }
}
