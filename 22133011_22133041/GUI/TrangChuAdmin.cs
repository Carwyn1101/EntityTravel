﻿using System.Windows.Forms.DataVisualization.Charting;
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
    public partial class TrangChuAdmin : Form
    {    
        ThongTinKhachSanDAO kSDAO = new ThongTinKhachSanDAO();
        int iDNguoiDung; bool logOut;
        public TrangChuAdmin()
        {
            InitializeComponent();
        }       
        public TrangChuAdmin(string tenDangNhap, int iDNguoiDung)
        {
            InitializeComponent();
            lblTenTaiKhoan.Text = tenDangNhap;
            this.iDNguoiDung = iDNguoiDung;
            flpTrangChu.Controls.Clear();          
            Program.TrangChuAdminInstance = this;
        }
        private void btnChoThue_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangThongTinKhachSan f = new DangThongTinKhachSan(iDNguoiDung, lblTenTaiKhoan.Text);
            f.ShowDialog();
            f = null;
            this.Show();
        }
        private void pic_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                logOut = true; 
                this.Hide();
                DangNhap f = new DangNhap(logOut);
                f.ShowDialog();
                f = null;
                this.Close(); 
            }
        }
        private void TrangChuAdmin_Load(object sender, EventArgs e)
        {
            
            kSDAO.LoadData(flpTrangChu, iDNguoiDung);
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe thongKe = new ThongKe();
            Dictionary<string, double> danhSachDoanhThu = kSDAO.LoadDoanhThu(iDNguoiDung);
            thongKe.VeBieuDo(danhSachDoanhThu);
            thongKe.ShowDialog();
        }       
    }
}
