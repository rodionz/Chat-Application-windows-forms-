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
    public partial class ChangePortDialog : Form
    {
        public ChangePortDialog(ServerInterfaceClass sClass)
        {
            SIC = sClass;
            InitializeComponent();
        }

        ServerInterfaceClass SIC;

        private void PortConfirmationButtom_Click(object sender, EventArgs e)
        {
            SIC.
        }
    }
}
