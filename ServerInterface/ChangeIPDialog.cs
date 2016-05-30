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
    public partial class ChangeIPDialog : Form
    {
        public ChangeIPDialog(ServerOnlineArgs so)
        {
            Soargs = so;
            InitializeComponent();
        }


        ServerOnlineArgs Soargs;

        private void ConfirmIP_Click(object sender, EventArgs e)
        {
            Soargs.IPofServer = IPmaskedTextBox.Text;
            Close();
        }

        private void clearIP_Click(object sender, EventArgs e)
        {
            IPmaskedTextBox.Clear();
        }
    }
}
