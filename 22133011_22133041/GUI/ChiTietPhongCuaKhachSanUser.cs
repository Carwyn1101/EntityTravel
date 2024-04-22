using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChiTietPhongCuaKhachSanUser : Form
    {        
        int iDPhong, iDKhachSan;
        ThongTinPhongKhachSanDAO pKSanDAO = new ThongTinPhongKhachSanDAO();
        public ChiTietPhongCuaKhachSanUser(int iDPhong, int iDKhachSan)
        {
            InitializeComponent();
            this.iDPhong = iDPhong;
            this.iDKhachSan = iDKhachSan;
        }
        private void ChiTietPhongCuaKhachSanUser_Load(object sender, EventArgs e)
        {
            pKSanDAO.LoadChiTietPhongUser(this, iDPhong);
        }
        private void btnThue_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietKhachHang f = new ChiTietKhachHang(iDPhong,iDKhachSan);
            f.ShowDialog();
            f = null;
            this.Close();
        }
    }
}
