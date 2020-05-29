using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casio
{
    public partial class Casio : Form
    {
        static int a, b;
        static String pheptoan;
        public Casio()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtResult.Text);
            pheptoan = "tru";
            txtResult.Text = "";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtResult.Text);
            pheptoan = "nhan";
            txtResult.Text = "";
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtResult.Text);
            pheptoan = "chia";
            txtResult.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            b =int.Parse(txtResult.Text);
            float result;
            if(pheptoan == "cong")
            {
                result = a + b;
                txtResult.Text = result.ToString();
            }
            if (pheptoan == "tru")
            {
                result = a - b;
                txtResult.Text = result.ToString();
            }
            if (pheptoan == "nhan")
            {
                result = a * b;
                txtResult.Text = result.ToString();
            }
            if (pheptoan == "chia")
            {
                if (b == 0)
                {
                    MessageBox.Show("Số bị chia phải khác 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    result = (float)a / b;
                    txtResult.Text = result.ToString();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            String s = txtResult.Text.ToString();
            if(s=="")
            {
                MessageBox.Show("Không còn gì để xóa -_-", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtResult.Text = s.Remove(s.Length - 1);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtResult.Text);
            pheptoan = "cong";
            txtResult.Text = "";
        }

    }
}
