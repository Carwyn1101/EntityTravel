using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal class HoaDonDAO
    {
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();
        public void Them(HoaDon hDon)
        {
            db.HoaDons.Add(hDon);
            db.SaveChanges();
            MessageBox.Show("Thuê thành công!");
        }
        public void LoadData(ChiTietKhachHangAdmin f)
        {
            var chiTietKhachHang = db.HoaDons.FirstOrDefault(c => c.IDPhong == Program.iDPhongInstance);
            f.txtTenKhachHang.Text = chiTietKhachHang.TenKhachHang; 
            f.txtSoDienThoai.Text = chiTietKhachHang.SDT;
            f.txtCCCD.Text = chiTietKhachHang.CCCD;
            f.txtMail.Text = chiTietKhachHang.Mail;
            f.txtNgayNhan.Text = chiTietKhachHang.NgayNhanPhong.ToString();
            f.txtNgayTra.Text = chiTietKhachHang.NgayTraPhong.ToString();
            f.txtTongTienThanhToan.Text = chiTietKhachHang.TongTien;
        }
        
    }
}
