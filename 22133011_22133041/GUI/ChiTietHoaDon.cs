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
        ThongTinPhongKhachSanDAO pKSanDAO = new ThongTinPhongKhachSanDAO();
        int iDKhachSan, iDPhong;
        public ChiTietHoaDon()
        {
            InitializeComponent();

        }
        public ChiTietHoaDon(int iDKhachSan, int iDPhong)
        {
            InitializeComponent();
            this.iDKhachSan = iDKhachSan;
            this.iDPhong = iDPhong;
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
           HoaDon hd = new HoaDon();
           hoaDonDAO.Them(hd);
           pKSanDAO.CapNhatTrangThaiPhong(iDPhong);
           Program.XemPhongCuaKhachSanInstance.Close();
           XemPhongCuaKhachSan f = new XemPhongCuaKhachSan(iDKhachSan);
           f.ShowDialog();
        }
    }
}
