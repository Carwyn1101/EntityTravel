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
    public partial class UCDanhGia : UserControl
    {
        public UCDanhGia()
        {
            InitializeComponent();
        }
        public UCDanhGia(DanhGia dGia)
        {
            InitializeComponent();
            lblTenKhachHang.Text = dGia.TenKhachHang;
            lblTraiNghiem.Text = dGia.TraiNghiem;
            lblDiemDanhGia.Text = dGia.DiemDanhGia.ToString();
            richTextBoxDanhGia.Text = dGia.DanhGiaNguoiDung;         
        }        
    }
}
