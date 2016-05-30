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
    public partial class ServerRegistration : Form
    {
        public ServerRegistration(ServerOnlineArgs so)
        {
            Soarg = so;
            InitializeComponent();
        }


        ServerOnlineArgs Soarg;

        private void ConfirmIP_Click(object sender, EventArgs e)
        {
            Soarg.IPofServer = IPmaskedTextBox.Text;
        }

        private void PortConfirmationButtom_Click(object sender, EventArgs e)
        {
            Soarg.PortofServer = int.Parse(portTextBox.Text);
        }

        private void CreateServerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
