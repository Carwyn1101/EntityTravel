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
        int iD;
        public UCThongTinPhongKhachSanUser()
        {
            InitializeComponent();
        }
        public UCThongTinPhongKhachSanUser(ThongTinPhongCuaKhachSan kSan)
        {
            InitializeComponent();
            linklblChiTietPhong.Text = kSan.TenPhong;
            lblKichThuocPhong.Text = kSan.KichThuocPhong;
            lblSoGiaTien.Text = kSan.GiaPhong?.ToString("N0");
            iD = kSan.IDPhong;          
        }
        private void linklblChiTietPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.iDPhongInstance = iD;
            ChiTietPhongCuaKhachSanUser f = new ChiTietPhongCuaKhachSanUser();
            f.ShowDialog();
            Program.ChiTietKhachSanUserInstance.Close();
        }
    }
}
