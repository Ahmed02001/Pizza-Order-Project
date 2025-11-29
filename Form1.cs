using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProjectWinForm
{
    public partial class Form1 : Form
    {
        int Total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSmall.Checked )
            {
                labSiz.Text = rbSmall.Text;
                Total = 30;
                labTotal.Text = Total.ToString();
            }
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedium.Checked)
            {
                labSiz.Text = rbMedium.Text;
                Total = 40;
                labTotal.Text = Total.ToString();
            }
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarge.Checked)
            {
                labSiz.Text = rbLarge.Text;
                Total = 50;
                labTotal.Text = Total.ToString();
            }
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThin.Checked)
            {
                labCrust.Text = rbThin.Text;
            }
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThick.Checked)
            {
                labCrust.Text = rbThick.Text;
                Total = Int32.Parse(labTotal.Text);
                Total += 5;
                labTotal.Text = Total.ToString();
            }
            else
            {
                Total = Int32.Parse(labTotal.Text);
                Total -= 5;
                labTotal.Text = Total.ToString();
            }
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEatIn.Checked)
            {
                labWhere.Text = rbEatIn.Text;
            }
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTakeOut.Checked)
            {
                labWhere.Text = rbTakeOut.Text;
            }
        }

        private void chkbExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbExtra.Checked)
            {
                txtTop.Text += chkbExtra.Text + ", ";
                Total = Int32.Parse(labTotal.Text);
                Total += 5;
                labTotal.Text = Total.ToString();
            }
            else
            {
                Total = Int32.Parse(labTotal.Text);
                Total -= 5;
                labTotal.Text = Total.ToString();
            }
        }

        private void chkbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbMushrooms.Checked)
            {
                txtTop.Text += chkbMushrooms.Text + ", ";
                Total = Int32.Parse(labTotal.Text);
                Total += 5;
                labTotal.Text = Total.ToString();
            }
            else
            {
                Total = Int32.Parse(labTotal.Text);
                Total -= 5;
                labTotal.Text = Total.ToString();
            }
        }

        private void chkbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbTomatoes.Checked)
            {
                txtTop.Text += chkbTomatoes.Text + ", ";
                Total = Int32.Parse(labTotal.Text);
                Total += 5;
                labTotal.Text = Total.ToString(); ;
            }
            else
            {
                Total = Int32.Parse(labTotal.Text);
                Total -= 5;
                labTotal.Text = Total.ToString();
            }
        }

        private void chkbOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbOnion.Checked)
            {
                txtTop.Text += chkbOnion.Text + ", ";
                Total = Int32.Parse(labTotal.Text);
                Total += 5;
                labTotal.Text = Total.ToString();
            }
            else
            {
                Total = Int32.Parse(labTotal.Text);
                Total -= 5;
                labTotal.Text = Total.ToString();
            }
        }

        private void chkbOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbOlives.Checked)
            {
                txtTop.Text += chkbOlives.Text + ", ";
                Total = Int32.Parse(labTotal.Text);
                Total += 5;
                labTotal.Text = Total.ToString();
            }
            else
            {
                Total = Int32.Parse(labTotal.Text);
                Total -= 5;
                labTotal.Text = Total.ToString();
            }
        }

        private void chkbGPapper_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbGPapper.Checked)
            {
                txtTop.Text += chkbGPapper.Text + ", ";
                Total = Int32.Parse(labTotal.Text);
                Total += 5;
                labTotal.Text = Total.ToString();
            }
            else
            {
                Total = Int32.Parse(labTotal.Text);
                Total -= 5;
                labTotal.Text = Total.ToString();
            }
        }

        private void txtTop_TextChanged(object sender, EventArgs e)
        {

        }

        private void labTotal_Click(object sender, EventArgs e)
        {
        
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            

            if(MessageBox.Show("Are You Sure From This Order?", "Conform", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("your order will after a meinute.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
                gbSize.Enabled = false;
                gbCrust.Enabled = false;
                label4.Enabled = false;
                chkbExtra.Enabled = false;
                chkbMushrooms.Enabled = false;
                chkbTomatoes.Enabled = false;
                chkbOnion.Enabled = false;  
                chkbOlives.Enabled = false;
                chkbGPapper.Enabled = false;    
                label5.Enabled = false;
                rbEatIn.Enabled = false;
                rbTakeOut.Enabled = false;


            }



           
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            label4.Enabled = true;
            chkbExtra.Enabled = true;
            chkbMushrooms.Enabled = true;
            chkbTomatoes.Enabled = true;
            chkbOnion.Enabled = true;
            chkbOlives.Enabled = true;
            chkbGPapper.Enabled = true;
            label5.Enabled = true;
            rbEatIn.Enabled = true;
            rbTakeOut.Enabled = true;
            rbMedium.Checked = true;
            rbThin.Checked = true;
            rbEatIn.Checked = true;
            chkbExtra.Checked = false;
            chkbMushrooms.Checked = false;
            chkbTomatoes.Checked = false;
            chkbOnion.Checked = false;
            chkbOlives.Checked = false;
            chkbGPapper.Checked = false;
            txtTop.Text = string.Empty;


        }
    }
}
