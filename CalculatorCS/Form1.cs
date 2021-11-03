using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "9";
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0.";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + ".";
            }

            btnPoint.Enabled = false;
        }
        double num1, num2, equals;
        char optr;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtDisplay.Text);
            optr = '+';
            btnPoint.Enabled = true;
            txtDisplay.Text = "0";

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtDisplay.Text);
            optr = '-';
            btnPoint.Enabled = true;
            txtDisplay.Text = "0";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtDisplay.Text);
            optr = '*';
            btnPoint.Enabled = true;
            txtDisplay.Text = "0";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtDisplay.Text);
            optr = '/';
            btnPoint.Enabled = true;
            txtDisplay.Text = "0";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtDisplay.Text);

            if (optr == '+')
            {
                equals = num1 + num2;
            }
            else if (optr == '-')
            {
                equals = num1 - num2;
            }
            else if (optr == '*')
            {
                equals = num1 * num2;
            }
            else if (optr == '/')
            {
                equals = num1 / num2;
            }

            txtDisplay.Text = Convert.ToString(equals);
            btnPoint.Enabled = true;

            MessageBox.Show("The answer is " + equals, "Answer");
            txtDisplay.Text = "0";
        }
    }
}
