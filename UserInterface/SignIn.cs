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





namespace UserInterface
{
    public partial class SignIn : Form
    {
        public SignIn()
        {

            InitializeComponent();
        }

       
       

        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Validators_GlobalBooleans.SignInisValid == false)
            {
                
                //e.Cancel = true;
            }
        }

        private void IPmaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            this.IPmaskedTextBox.ValidatingType = typeof(IPAddress);
            IPAddress clientIpAddr;

            char[] delimit = {' '};
            string[] str = IPmaskedTextBox.Text.Split();
            string separator = "";




            string adress = string.Join(separator, str);


            bool b = IPAddress.TryParse(adress, out clientIpAddr);


            if (b == true)
            {
                //if (clientIpAddr == serv )



            }

        }




    }
}
