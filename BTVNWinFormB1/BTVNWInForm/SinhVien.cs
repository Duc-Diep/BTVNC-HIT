using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVNWInForm
{
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "admin" && txtPassWord.Text == "12345")
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = "Đăng nhập thành công";
                groupBox.Visible = true;
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Đăng nhập thất bại";
                groupBox.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMasv.Text == ""||txtName.Text == "")
            {
                MessageBox.Show("Mã sinh viên hoặc họ tên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgvListStudent.Rows.Add(txtMasv.Text, txtName.Text);
            }
        }
    }
}
