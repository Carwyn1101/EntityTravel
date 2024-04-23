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
    public partial class ChiTietKhachHang : Form
    {
        ThongTinKhachHangDAO kHangDAO = new ThongTinKhachHangDAO();
        ThongTinPhongKhachSanDAO pKSanDAO = new ThongTinPhongKhachSanDAO();
        int iDPhong, iDKhachSan;
        public ChiTietKhachHang()
        {
            InitializeComponent();
        }
        public ChiTietKhachHang(int iDPhong, int iDKhachSan)
        {
            InitializeComponent();
            this.iDPhong = iDPhong;
            this.iDKhachSan = iDKhachSan;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinKhachHang kHang = new ThongTinKhachHang();
            kHang.IDKhachHang = Program.iDTaiKhoanInstance; 
            kHang.TenKhachHang = txtTenKhachHang.Text;
            kHang.SDT = txtSoDienThoai.Text;
            kHang.CCCD = txtCCCD.Text;
            kHang.Mail = txtMail.Text;           
            kHangDAO.Them(kHang);            
            ChiTietHoaDon f = new ChiTietHoaDon(iDKhachSan,iDPhong);
            f.ShowDialog();
        }       
    }
}
