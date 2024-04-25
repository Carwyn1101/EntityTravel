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
       
        public UCThongTinPhongKhachSanUser()
        {
            InitializeComponent();
        }
        public UCThongTinPhongKhachSanUser(ThongTinPhongCuaKhachSan kSan)
        {
            InitializeComponent();
            linklblChiTietPhong.Text = kSan.TenPhong;
            lblKichThuocPhong.Text = kSan.KichThuocPhong;
            lblTrangThai.Text = kSan.TrangThai ;
            lblUuDai.Text = kSan.UuDai ;
            lblSoGiaTien.Text = kSan.GiaPhong;           
            if (string.IsNullOrEmpty(lblUuDai.Text))
            {
                lblTienGoc.Text = lblSoGiaTien.Text;
                lblUuDai.Text = "0";
            }  
            else
            {
                decimal tmpSoGiaTien = decimal.Parse(lblSoGiaTien.Text);
                decimal tmpUuDai = decimal.Parse(lblUuDai.Text);
                decimal sum = tmpSoGiaTien/(1- tmpUuDai/100);
                lblTienGoc.Text = sum.ToString("N0");
            }
            Program.iDPhongInstance = kSan.IDPhong;          
        }
        private void linklblChiTietPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChiTietPhongCuaKhachSanUser f = new ChiTietPhongCuaKhachSanUser();
            f.ShowDialog();
        }
    }
}
