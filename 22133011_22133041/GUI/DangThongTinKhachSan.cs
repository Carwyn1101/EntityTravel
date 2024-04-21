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
    public partial class DangThongTinKhachSan : Form
    {
        ThongTinKhachSanDAO kSanDAO = new ThongTinKhachSanDAO();
        string tenAnh1, tenAnh2, tenAnh3, tenAnh4,tenDangNhap;
        int iDNguoiDung;
        public DangThongTinKhachSan()
        {
            InitializeComponent();
        }
        public DangThongTinKhachSan(int IDNguoiDung,string TenDangNhap)
        {
            InitializeComponent();
            iDNguoiDung = IDNguoiDung;
            tenDangNhap = TenDangNhap;
        }     
        private void btnDangBai_Click(object sender, EventArgs e)
        {
            ThongTinKhachSan kSan = new ThongTinKhachSan();
            kSan.TenKhachSan = txtTenKhachSan.Text;
            kSan.DiaDiemKhachSan = cboDiaDiem.Text;
            kSan.Loai = cboLoaiPhong.Text;
            kSan.MoTa = txtMoTa.Text;
            kSan.HinhAnh1 = tenAnh1;
            kSan.HinhAnh2 = tenAnh2;
            kSan.HinhAnh3 = tenAnh3;
            kSan.HinhAnh4 = tenAnh4;
            kSan.IDChuKhachSan = iDNguoiDung;
            kSanDAO.Them(kSan);
            this.Hide();
            TrangChuAdmin f = new TrangChuAdmin(tenDangNhap, iDNguoiDung);
            f.ShowDialog();
        }
        private void btnThemAnh1_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh1, out tenAnh1);
        }
        private void btnThemAnh2_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh2, out tenAnh2);
        }
        private void btnThemAnh3_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh3, out tenAnh3);
        }
        private void btnThemAnh4_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh4, out tenAnh4);
        }
    }
}
