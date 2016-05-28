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
using UserData;
using ServerData;





namespace UserInterface
{
    public partial class SignIn : Form
    {
        public Server server1;

    

        
      

        

       



        public SignIn()
        {
            server1 = new Server();
            InitializeComponent();
        }

      

        


        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Validators_GlobalBooleans.SignInisValid == false)
            {

                e.Cancel = true;
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
                if (clientIpAddr.ToString() == server1.IP)
                {

                }

                else
                {


                }

            }

        }

       

        private void NicknameConfirmationButton_Click(object sender, EventArgs e)
        {
          

        }


        private void ConnectButton_Click(object sender, EventArgs e)
        {
            User user1 = new User();
            TcpClient client1 = new TcpClient();


        }

        private void SignIn_Load(object sender, EventArgs e)


        {

            List<User> listofUsers= new List<User>();
            

        }
    }
}
