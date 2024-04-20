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
            lblTrangThai.Text = kSan.TrangThai;
            lblSoGiaTien.Text = kSan.GiaPhong;
            iD = kSan.IDPhong;
        }
        public void LoadData(FlowLayoutPanel flpTrangChuKhachSan, int id)
        {
            ThongTinPhongKhachSanDAO khachSanDAO = new ThongTinPhongKhachSanDAO();
            List<UCThongTinPhongKhachSanUser> PhongList = khachSanDAO.LoadData(id);
            foreach (UCThongTinPhongKhachSanUser uc in PhongList)
            {
                flpTrangChuKhachSan.Controls.Add(uc);
            }
        }

        private void linklblChiTietPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChiTietPhongCuaKhachSanUser f = new ChiTietPhongCuaKhachSanUser(iD);
            f.ShowDialog();
        }
    }
}
