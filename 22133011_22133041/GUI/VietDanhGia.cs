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
    public partial class VietDanhGia : Form
    {
        int iDKSan;
        DanhGiaDAO dGiaDAO = new DanhGiaDAO();
        public VietDanhGia()
        {
            InitializeComponent();
        }
        public VietDanhGia(int iD)
        {
            InitializeComponent();
            iDKSan = iD;
        }

        private void btnDangBai_Click(object sender, EventArgs e)
        {
            DanhGia dGia = new DanhGia();
            dGia.IDKhachSan = iDKSan;
            dGia.TenKhachHang = cboTenKhachHang.Text;
            dGia.TraiNghiem = cboTraiNghiem.Text;
            dGia.DiemDanhGia = cboDiemDanhGia.Text;
            dGia.DanhGiaNguoiDung = richTextBoxDanhGia.Text;
            dGiaDAO.Them(dGia);
            this.Hide();
            DanhGiaCuaKhachHang f = new DanhGiaCuaKhachHang(iDKSan);
            f.ShowDialog();
            f.ReLoadData();
            f = null;
            this.Close();
        }
    }
}