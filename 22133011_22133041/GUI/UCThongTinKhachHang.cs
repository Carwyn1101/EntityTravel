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
    public partial class UCThongTinKhachHang : UserControl
    {
        public UCThongTinKhachHang()
        {
            InitializeComponent();
        }
        public UCThongTinKhachHang(HoaDon hd)
        {
            InitializeComponent();
            lblTen.Text = hd.TenKhachHang;
            lblSDT.Text = hd.SDT;
            lblEMail.Text = hd.Mail;
            lblCCCD.Text = hd.CCCD;
            lblNgayNhan.Text = hd.NgayNhanPhong?.ToString("dd/MM/yyyy");
            lblNgayTra.Text = hd.NgayTraPhong?.ToString("dd/MM/yyyy");
            lblTien.Text = hd.TongTien + " " + "VND";
        }
    }
}
