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
           Sdata.IPofServer = IPmaskedTextBox.Text;
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
