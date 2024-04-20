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
    public partial class TrangChuUser : Form
    {
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();
        bool logOut;
        public TrangChuUser()
        {
            InitializeComponent();
        }
        public TrangChuUser(string TenDangNhap, int IDNguoiDung)
        {
            InitializeComponent();
            lblTenTaiKhoan.Text = TenDangNhap;
        }

        private void TrangChuUser_Load(object sender, EventArgs e)
        {
            var kSan = from p in db.ThongTinKhachSans select p;
            foreach (var p in kSan)
            {
                UCThongTinKhachSanUser uc = new UCThongTinKhachSanUser(p);
                this.flpTrangChuUser.Controls.Add(uc);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            flpTrangChuUser.Controls.Clear();
            string DiaDiem = cboDiaDiemTimKiem.Text;
            UCThongTinKhachSanUser f = new UCThongTinKhachSanUser();
            f.LoadDataTimKiem(flpTrangChuUser, DiaDiem);
        }

        private void pic_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                logOut = true; // Đánh dấu đã đăng xuất
                this.Hide();
                DangNhap f = new DangNhap(logOut);
                f.ShowDialog();
                f = null;
                this.Close(); // Đóng form đăng nhập khi đã đăng xuất
            }
        }
    }
}
