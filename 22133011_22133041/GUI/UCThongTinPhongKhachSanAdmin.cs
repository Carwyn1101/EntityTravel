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
        int iDKhachSan,iDPhong;
        public UCThongTinPhongKhachSanAdmin()
        {
            InitializeComponent();
        }
        public UCThongTinPhongKhachSanAdmin(ThongTinPhongCuaKhachSan pKSan)
        {
            InitializeComponent();
            linklblChiTietPhong.Text = pKSan.TenPhong;
            lblKichThuocPhong.Text = pKSan.KichThuocPhong;
            lblTrangThai.Text = pKSan.TrangThai;
            lblSoGiaTien.Text = pKSan.GiaPhong;
            iDPhong = (int)pKSan.IDPhong;
            iDKhachSan = (int)pKSan.IDKhachSan;
        }
        private void linklblChiTietPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChiTietPhongCuaKhachSanAdmin f = new ChiTietPhongCuaKhachSanAdmin(iDKhachSan,iDPhong);
            f.ShowDialog();
        }
    }
}
