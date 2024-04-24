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
    public partial class ChiTietHoaDon : Form
    {
        HoaDonDAO hoaDonDAO = new HoaDonDAO();
        DatPhongDAO datPhongDAO = new DatPhongDAO();
        ThongTinPhongKhachSanDAO pKSanDAO = new ThongTinPhongKhachSanDAO();
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();
        DateTime ngayNhanPhong, ngayTraPhong;
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
            var tmp = (from c in db.ThongTinPhongCuaKhachSans where c.IDPhong == Program.iDPhongInstance select c).FirstOrDefault();
            txtGiaPhong.Text = tmp.GiaPhong;
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
            hd.NgayNhanPhong = ngayNhanPhong;
            hd.NgayTraPhong = ngayTraPhong;
            hd.TongTien = txtTongTienThanhToan.Text;
            hd.IDPhong = Program.iDPhongInstance;
            hoaDonDAO.Them(hd);
            //
            DatPhong dp = new DatPhong();
            dp.NgayNhanPhong = ngayNhanPhong;
            dp.NgayTraPhong = ngayTraPhong;
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
            ngayNhanPhong = dtpNgayNhanPhong.Value; //
            ngayTraPhong = dtpNgayTraPhong.Value; //

            DateTime tmpNgayNhanPhong = dtpNgayNhanPhong.Value.Date;
            DateTime tmpNgayTraPhong = dtpNgayTraPhong.Value.Date;         

            TimeSpan khoangThoiGianThue = tmpNgayTraPhong - tmpNgayNhanPhong;
            int soNgayThue = khoangThoiGianThue.Days;

            decimal giaPhong = decimal.Parse(txtGiaPhong.Text);  
            decimal tongTien = soNgayThue * giaPhong;
       
            txtTongTienThanhToan.Text = tongTien.ToString("N0"); 
        }
        private void dtpNgayNhanPhong_ValueChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }
        private void dtpNgayTraPhong_ValueChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }
    }
}
