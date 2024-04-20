using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DangNhap : Form
    {
        string loaiTaiKhoan;
        TaiKhoanDAO tKDAO = new TaiKhoanDAO();
        bool loggedOut = false;
        public DangNhap()
        {
            InitializeComponent();
        }
        public DangNhap(bool logOut)
        {
            InitializeComponent();
            this.loggedOut = logOut;
        }
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!loggedOut)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tKDAO.DangNhap(this,txtTenDangNhap.Text,loaiTaiKhoan);
        }
        private void chkAccAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccAdmin.Checked)
            {
                loaiTaiKhoan = "admin";
            }
        }
        private void chkAccUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccUser.Checked)
            {
                loaiTaiKhoan = "user";
            }
        }
        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '\u25CF';
        }
    }
}
