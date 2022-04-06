using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_C1201041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bnt0_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "0";
                i = 1;
            }
            else
            {
                textBox1.Text += "0";
            }

        }

        private void bnt1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "1";
                i = 1;
            }
            else
            {
                textBox1.Text += "1";
            }

        }

        private void bnt2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "2";
                i = 1;
            }
            else
            {
                textBox1.Text += "2";
            }

        }

        private void bnt3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "3";
                i = 1;
            }
            else
            {
                textBox1.Text += "3";
            }

        }

        private void bnt4_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "4";
                i = 1;
            }
            else
            {
                textBox1.Text += "4";
            }

        }

        private void bnt5_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "5";
                i = 1;
            }
            else
            {
                textBox1.Text += "5";
            }

        }

        private void bnt6_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "6";
                i = 1;
            }
            else
            {
                textBox1.Text += "6";
            }

        }

        private void bnt7_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "7";
                i = 1;
            }
            else
            {
                textBox1.Text += "7";
            }

        }

        private void bnt8_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "8";
                i = 1;
            }
            else
            {
                textBox1.Text += "8";
            }

        }

        private void bnt9_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "9";
                i = 1;
            }
            else
            {
                textBox1.Text += "9";
            }

        }

        private void bntback_Click(object sender, EventArgs e)
        {

        }
    }
}
