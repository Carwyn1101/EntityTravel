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
    public partial class ThemUuDai : Form
    {
        public ThemUuDai()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MaGiamGia maGiamGia = new MaGiamGia();
            txtMaGiamGia.Text = maGiamGia.MaGiam;
        }
    }
}