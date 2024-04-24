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
        ThongTinKhachSanDAO kSanDAO = new ThongTinKhachSanDAO();
        public ChiTietKhachSanUser()
        {
            InitializeComponent();
        }                     
        private void ChiTietKhachSanUser_Load(object sender, EventArgs e)
        {
            kSanDAO.LoadChiTietKhachSanUser(this, Program.iDKhachSanInstance);           
        }
        private void btnXemPhongTrong_Click(object sender, EventArgs e)
        {
            XemPhongCuaKhachSan f = new XemPhongCuaKhachSan(Program.iDKhachSanInstance);
            f.ShowDialog();
        }
        private void linklbDanhGia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DanhGiaCuaKhachHang f = new DanhGiaCuaKhachHang();
            f.ShowDialog();
        }
    }
}
