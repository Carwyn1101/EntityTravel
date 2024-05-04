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
    public partial class UCThongTinPhongKhachSanAdmin : UserControl
    {
        int iDPhong;
        public UCThongTinPhongKhachSanAdmin()
        {
            InitializeComponent();
        }
        public UCThongTinPhongKhachSanAdmin(ThongTinPhongCuaKhachSan pKSan)
        {
            InitializeComponent();
            linklblChiTietPhong.Text = pKSan.TenPhong;
            lblKichThuocPhong.Text = pKSan.KichThuocPhong;
            lblSoGiaTien.Text = pKSan.GiaPhong?.ToString("N0") + " " + "VND";
            iDPhong = (int)pKSan.IDPhong;
        }
        private void linklblChiTietPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.iDPhongInstance = iDPhong;
            ChiTietPhongCuaKhachSanAdmin f = new ChiTietPhongCuaKhachSanAdmin();
            f.ShowDialog();
        }
    }
}
