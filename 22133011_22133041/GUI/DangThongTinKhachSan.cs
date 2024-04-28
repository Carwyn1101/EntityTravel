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
        CheckGiaTri check = new CheckGiaTri();
        string tenAnh1, tenAnh2, tenAnh3, tenAnh4, tenDangNhap;
        int iDNguoiDung;
        public DangThongTinKhachSan()
        {
            InitializeComponent();
        }       
        public DangThongTinKhachSan(int iDNguoiDung,string tenDangNhap)
        {
            InitializeComponent();
            this.iDNguoiDung = iDNguoiDung;
            this.tenDangNhap = tenDangNhap;
        }     
        private void btnDangBai_Click(object sender, EventArgs e)
        {
            if (check.CheckValid(this))
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
            else
            {
                MessageBox.Show("Không được để trống, vui lòng nhập dữ liệu", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhachSan.Focus();
            }          
        }
        private void txtTenKhachSan_MouseClick(object sender, MouseEventArgs e)
        {
            txtTenKhachSan.Clear();
        }
        private void txtTenKhachSan_TextChanged(object sender, EventArgs e)
        {
            txtTenKhachSan.PlaceholderText = "Vui lòng nhập tên khách sạn của bạn";
            txtTenKhachSan.PlaceholderForeColor = System.Drawing.Color.DarkOrange;
        }
        private void btnThemAnh1_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh1, out tenAnh1);
            btnThemAnh1.SendToBack();
        }
        private void btnThemAnh2_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh2, out tenAnh2);
            btnThemAnh2.SendToBack();
        }
        private void btnThemAnh3_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh3, out tenAnh3);
            btnThemAnh3.SendToBack();
        }
        private void btnThemAnh4_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh4, out tenAnh4);
            btnThemAnh4.SendToBack();
        }
    }
}
