﻿using System;
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
    public partial class SignIn : Form
    {
        public SignIn()
        {

            InitializeComponent();
        }

     

        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ValidationBooleans.SignInisValid == false)
            {

                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
