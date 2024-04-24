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
    public partial class XemPhongCuaKhachSan : Form
    {
  
        ThongTinPhongKhachSanDAO pKSanDAO = new ThongTinPhongKhachSanDAO();
        public XemPhongCuaKhachSan()
        {
            InitializeComponent();
        }
        public XemPhongCuaKhachSan(int iDKhachSan)
        {
            InitializeComponent();           
            flpTrangChuKhachSan.Controls.Clear();
            pKSanDAO.LoadDanhSachPhongUser(flpTrangChuKhachSan, Program.iDKhachSanInstance);
            Program.XemPhongCuaKhachSanInstance = this;
        }     
        private void btnTimKiemPhong_Click(object sender, EventArgs e)
        {
            flpTrangChuKhachSan.Controls.Clear();
            string loaiPhong = cboLoaiPhong.Text;
            pKSanDAO.LoadPhongTheoLoaiPhong(flpTrangChuKhachSan, loaiPhong, Program.iDKhachSanInstance);
        }
        public void ReLoad()
        {
            pKSanDAO.LoadDanhSachPhongUser(flpTrangChuKhachSan, Program.iDKhachSanInstance);
        }
    }
}
