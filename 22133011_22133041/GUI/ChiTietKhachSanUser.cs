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
        ThongTinKhachSanDAO kSanDAO = new ThongTinKhachSanDAO();
        int iDKSan;
        public ChiTietKhachSanUser()
        {
            InitializeComponent();
        }
        public ChiTietKhachSanUser(int iD)
        {
            InitializeComponent();
            iDKSan = iD;
        }               
        private void ChiTietKhachSanUser_Load(object sender, EventArgs e)
        {
            kSanDAO.LoadChiTietKhachSanUser(this,iDKSan);           
        }
        private void btnXemPhongTrong_Click(object sender, EventArgs e)
        {
            XemPhongCuaKhachSan f = new XemPhongCuaKhachSan(iDKSan);
            f.ShowDialog();
        }
        private void linklbDanhGia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DanhGiaCuaKhachHang f = new DanhGiaCuaKhachHang(iDKSan);
            f.ShowDialog();
        }
    }
}
