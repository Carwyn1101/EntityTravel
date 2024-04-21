﻿using System;
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
        int iDPhong;
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
        }
        private void linklblChiTietPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChiTietPhongCuaKhachSanUser f = new ChiTietPhongCuaKhachSanUser(iDPhong);
            f.ShowDialog();
        }
    }
}
