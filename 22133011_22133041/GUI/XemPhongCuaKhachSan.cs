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
        int iDKhachSan;
        ThongTinPhongKhachSanDAO pKSanDAO = new ThongTinPhongKhachSanDAO();
        public XemPhongCuaKhachSan()
        {
            InitializeComponent();
        }
        public XemPhongCuaKhachSan(int iDKhachSan)
        {
            InitializeComponent();
            this.iDKhachSan = iDKhachSan;
        }

        private void XemPhongCuaKhachSan_Load(object sender, EventArgs e)
        {
            flpTrangChuKhachSan.Controls.Clear();
            pKSanDAO.LoadDanhSachPhongUser(flpTrangChuKhachSan, iDKhachSan);
        }

        private void btnTimKiemPhong_Click(object sender, EventArgs e)
        {
            flpTrangChuKhachSan.Controls.Clear();
            string loaiPhong = cboLoaiPhong.Text;
            pKSanDAO.LoadPhongTheoLoaiPhong(flpTrangChuKhachSan, loaiPhong);
        }
        public void ReLoad()
        {
            pKSanDAO.LoadDanhSachPhongUser(flpTrangChuKhachSan, iDKhachSan);
        }
    }
}
