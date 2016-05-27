using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserData;
using ServerData;

namespace UserInterface
{
    public partial class Form1 : Form
    {

        Server servak = new Server();



        public Form1()
        {
            InitializeComponent();
        }


        SignIn signinForm = new SignIn();

        private void Form1_Load(object sender, EventArgs e)
        {
            signinForm.ShowDialog();
        }




        private void ColorChoosing_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.AnyColor = true;
            DialogResult result = colorDialog1.ShowDialog();
           
            if (result == DialogResult.OK)
            {
                
                this.BackColor = colorDialog1.Color;
            }
        }

     
    }
}
