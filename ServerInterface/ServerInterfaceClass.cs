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

      

      

       

       

      

        ServerData sData = new ServerData();

        public event EventHandler ServerisOnline;

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            ServerConnection Sr = new ServerConnection(sData);
            Sr.ShowDialog();
            
            //ServerisOnline(this, sData );

        }

        private void ChangeIpButton_Click(object sender, EventArgs e)
        {
            ChangeIPDialog ChipDialog = new ChangeIPDialog(sData);
            //ChangeIPDialog ChIp = new ChangeIPDialog(SOargs);
            ChipDialog.ShowDialog();
        }

        private void ChangePortButton_Click(object sender, EventArgs e)
        {
            ChangePortDialog Cpd = new ChangePortDialog(sData);

            Cpd.ShowDialog();
        }
    }
}
