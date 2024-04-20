using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class TaiKhoanDAO
    {
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();        
        public void DangNhap(DangNhap f, string TenDangNhap,string loaiTaiKhoan) 
        {
            var kq = (from c in db.TaiKhoans where c.TenDangNhap == TenDangNhap select c).SingleOrDefault();         
            if (f.txtTenDangNhap.Text == kq.TenDangNhap && f.txtMatKhau.Text == kq.MatKhau && kq.LoaiNguoiDung == loaiTaiKhoan)
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                f.Hide();
                TrangChuAdmin tChu = new TrangChuAdmin(kq.TenDangNhap,kq.IDNguoiDung);
                tChu.ShowDialog();
                tChu = null;
                f.Close();
            }           
        }
    }
}
