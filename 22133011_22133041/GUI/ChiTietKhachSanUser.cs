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
    public partial class ChiTietKhachSanUser : Form
    {
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();
        int IDKSan;
        public ChiTietKhachSanUser()
        {
            InitializeComponent();
        }
        public ChiTietKhachSanUser(int iD)
        {
            InitializeComponent();
            IDKSan = iD;
        }               
        private void ChiTietKhachSanUser_Load(object sender, EventArgs e)
        {
            var kSan = (from p in db.ThongTinKhachSans
                        where p.IDKhachSan == IDKSan
                        select p).SingleOrDefault();

            if (kSan != null)
            {
                txtTenKhachSan.Text = kSan.TenKhachSan;
                lblDiaDiem.Text = kSan.DiaDiemKhachSan;
                lblLoai.Text = kSan.Loai;
                richTextBoxMoTa.Text = kSan.MoTa;
            }
        }
        private void btnXemPhongTrong_Click(object sender, EventArgs e)
        {
            XemPhongCuaKhachSan f = new XemPhongCuaKhachSan(IDKSan);
            f.ShowDialog();
        }

        private void linklbDanhGia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DanhGiaCuaKhachHang f = new DanhGiaCuaKhachHang(IDKSan);
            f.ShowDialog();
        }
    }
}
