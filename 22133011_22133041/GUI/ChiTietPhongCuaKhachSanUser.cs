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
    public partial class ChiTietPhongCuaKhachSanUser : Form
    {
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();
        int iDPhong;
        ThongTinPhongKhachSanDAO pKSanDAO = new ThongTinPhongKhachSanDAO();
        public ChiTietPhongCuaKhachSanUser(int iDPhong)
        {
            InitializeComponent();
            this.iDPhong = iDPhong;
        }
        private void ChiTietPhongCuaKhachSanUser_Load(object sender, EventArgs e)
        {
            pKSanDAO.LoadChiTietPhongUser(this, iDPhong);
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietKhachHang f = new ChiTietKhachHang(iDPhong);
            f.ShowDialog();
            f = null;
            this.Close();
        }
    }
}
