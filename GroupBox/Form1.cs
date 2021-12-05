using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FreeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PlanChenge();
        }


        private void PaidRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PlanChenge();
        }
        private void PlanChenge()
        {
            if (PaidRadioButton.Checked)
            {
                PaidLabel.Text = "有料会員です。";
            }
            else if (FreeRadioButton.Checked)
            {
                PaidLabel.Text = "無料会員です。";
            }
            
        }
    }
}
