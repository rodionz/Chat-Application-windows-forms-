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
    public partial class ServerInterfaceClass : Form
    {
        public ServerInterfaceClass()
        {
            InitializeComponent();
        }
        ServerRegistration Sr = new ServerRegistration();

        ServerOnlineArgs SOargs = new ServerOnlineArgs();

        public event EventHandler<ServerOnlineArgs> ServerisOnline;

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            Sr.ShowDialog();
            ServerData sData = new ServerData();
            ServerisOnline(this, SOargs);
        }

        private void ChangeIpButton_Click(object sender, EventArgs e)
        {

        }

        private void ChangePortButton_Click(object sender, EventArgs e)
        {

        }
    }
}
