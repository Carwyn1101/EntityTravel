using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChiTietHoaDon : Form
    {
        HoaDonDAO hoaDonDAO = new HoaDonDAO();
        DatPhongDAO datPhongDAO = new DatPhongDAO();
        ThongTinPhongKhachSanDAO pKSanDAO = new ThongTinPhongKhachSanDAO();
        DoAnCuoiKyEntity dB = new DoAnCuoiKyEntity();
        CheckGiaTri check = new CheckGiaTri();       
        int stt;
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }
        public ChiTietHoaDon(ThongTinKhachHang kHang)
        {
            InitializeComponent();
            stt = kHang.SoThuTu;
            txtTenKhachHang.Text = kHang.TenKhachHang;
            txtSoDienThoai.Text = kHang.SDT;
            txtCCCD.Text = kHang.CCCD;
            txtMail.Text = kHang.Mail;
            var tmp = (from c in dB.ThongTinPhongCuaKhachSans where c.IDPhong == Program.iDPhongInstance select c).FirstOrDefault();
            txtGiaPhong.Text = tmp.GiaPhong.ToString();
            txtNgayNhanPhong.Text = Program.ngayNhanInstance.ToString("yyyy-MM-dd");
            txtNgayTraPhong.Text = Program.ngayTraInstance.ToString("yyyy-MM-dd");
            TinhTongTien();
        }
        private void btnThue_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.SoThuTuKhachHang = stt;
            hd.TenKhachHang = txtTenKhachHang.Text;
            hd.SDT = txtSoDienThoai.Text;
            hd.CCCD = txtCCCD.Text;
            hd.Mail = txtMail.Text;
            hd.NgayDatPhong = DateTime.Now;
            hd.NgayNhanPhong = DateTime.ParseExact(txtNgayNhanPhong.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            hd.NgayTraPhong = DateTime.ParseExact(txtNgayTraPhong.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            hd.TongTien = txtTongTienThanhToan.Text;
            hd.IDPhong = Program.iDPhongInstance;
            hoaDonDAO.Them(hd);
            DatPhong dp = new DatPhong();
            dp.NgayNhanPhong = DateTime.ParseExact(txtNgayNhanPhong.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            dp.NgayTraPhong = DateTime.ParseExact(txtNgayTraPhong.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            dp.IDPhong = Program.iDPhongInstance;
            dp.IDKhachSan = Program.iDKhachSanInstance;
            dp.IDKhachHang = Program.iDTaiKhoanInstance;
            datPhongDAO.Them(dp);
            pKSanDAO.CapNhatTrangThaiPhong(Program.iDPhongInstance);
            Program.XemPhongCuaKhachSanInstance.Close();
            XemPhongCuaKhachSan f = new XemPhongCuaKhachSan(Program.iDKhachSanInstance);
            f.ShowDialog();
        }
        private void TinhTongTien()
        {        
            DateTime tmpNgayNhanPhong = DateTime.ParseExact(txtNgayNhanPhong.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime tmpNgayTraPhong = DateTime.ParseExact(txtNgayTraPhong.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            TimeSpan khoangThoiGianThue = tmpNgayTraPhong - tmpNgayNhanPhong;
            int soNgayThue = khoangThoiGianThue.Days;
            decimal giaPhong = decimal.Parse(txtGiaPhong.Text);  
            decimal tongTien = soNgayThue * giaPhong;      
            txtTongTienThanhToan.Text = tongTien.ToString("N0"); 
        }    
    }
}
