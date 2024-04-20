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
        int iDNguoiDung;
        public TrangChuAdmin()
        {
            InitializeComponent();
        }
        public TrangChuAdmin(string TenDangNhap, int IDNguoiDung)
        {
            InitializeComponent();
            lblTenTaiKhoan.Text = TenDangNhap;
            iDNguoiDung = IDNguoiDung;
            kSDAO.LoadData(flpTrangChu, iDNguoiDung);
        }       
        private void btnChoThue_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangThongTinKhachSan f = new DangThongTinKhachSan(iDNguoiDung, lblTenTaiKhoan.Text);
            f.ShowDialog();
            f = null;
            this.Close();
        }    
    }
}
