using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SignIn sign = new SignIn();
    

        private void Form1_Load(object sender, EventArgs e)
        {
            sign.ShowDialog();
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
