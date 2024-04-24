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
    public partial class UCThongTinPhongKhachSanUser : UserControl
    {
        int iDPhong, iDKhachSan;
        public UCThongTinPhongKhachSanUser()
        {
            InitializeComponent();
        }
        public UCThongTinPhongKhachSanUser(ThongTinPhongCuaKhachSan kSan)
        {
            InitializeComponent();
            linklblChiTietPhong.Text = kSan.TenPhong;
            lblKichThuocPhong.Text = kSan.KichThuocPhong;
            lblTrangThai.Text = kSan.TrangThai;
            lblSoGiaTien.Text = kSan.GiaPhong;
            iDPhong = kSan.IDPhong;
            iDKhachSan = (int)kSan.IDKhachSan;
        }
        private void linklblChiTietPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.iDPhongInstance = iDPhong;  
            ChiTietPhongCuaKhachSanUser f = new ChiTietPhongCuaKhachSanUser();
            f.ShowDialog();
        }
    }
}
