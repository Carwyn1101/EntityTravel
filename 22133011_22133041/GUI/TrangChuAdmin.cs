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
    public partial class TrangChuAdmin : Form
    {    
        ThongTinKhachSanDAO kSDAO = new ThongTinKhachSanDAO();
        int iDNguoiDung; bool logOut;
        DatPhongDAO dpDAO = new DatPhongDAO();
        public TrangChuAdmin()
        {
            InitializeComponent();           
        }
        public TrangChuAdmin(string TenDangNhap, int IDNguoiDung)
        {
            InitializeComponent();
            lblTenTaiKhoan.Text = TenDangNhap;
            iDNguoiDung = IDNguoiDung;
            flpTrangChu.Controls.Clear();          
            Program.TrangChuAdminInstance = this;
        }
        private void btnChoThue_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangThongTinKhachSan f = new DangThongTinKhachSan(iDNguoiDung, lblTenTaiKhoan.Text);
            f.ShowDialog();
            f = null;
            this.Close();
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
        private void TrangChuAdmin_Load(object sender, EventArgs e)
        {
            dpDAO.TrangThaiLoad(sender,e);
            kSDAO.LoadData(flpTrangChu, iDNguoiDung);
        }
    }
}
