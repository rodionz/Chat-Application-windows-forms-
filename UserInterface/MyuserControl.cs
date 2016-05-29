using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class MyuserControl : UserControl
    {

        SignIn signinForm = new SignIn();

        public MyuserControl()
        {
            InitializeComponent();
        }

        private void ColorChoosing_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.AnyColor = true;
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {

                this.TextMessages.ForeColor = colorDialog1.Color;
            }
        }

        private void changeFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.AllowScriptChange = true;
            fontDialog1.AllowSimulations = true;
            fontDialog1.ShowEffects = true;

            DialogResult result = fontDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.TextMessages.Font = fontDialog1.Font;

            }
        }

        private void MyuserControl_Load(object sender, EventArgs e)
        {
            signinForm.ShowDialog();
        }
    }
}
