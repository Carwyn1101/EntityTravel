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
        DatPhongDAO datPhongDAO = new DatPhongDAO();
        string loaiPhong;
        public XemPhongCuaKhachSan()
        {
            InitializeComponent();
        }
        public XemPhongCuaKhachSan(int iDKhachSan)
        {
            InitializeComponent();           
            flpTrangChuKhachSan.Controls.Clear();
            //pKSanDAO.LoadDanhSachPhongUser(flpTrangChuKhachSan, Program.iDKhachSanInstance);
            Program.XemPhongCuaKhachSanInstance = this;
            dtpNgayNhanPhong.Value = DateTime.Now;
            dtpNgayTraPhong.Value = DateTime.Now;
        }     
        public void ReLoad()
        {
            pKSanDAO.LoadDanhSachPhongUser(flpTrangChuKhachSan, Program.iDKhachSanInstance);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            flpTrangChuKhachSan.Controls.Clear();
            loaiPhong = cboLoaiPhong.Text;
            Program.ngayNhanInstance = dtpNgayNhanPhong.Value;
            Program.ngayTraInstance = dtpNgayTraPhong.Value;
            pKSanDAO.LoadPhongTheoLoaiPhong(flpTrangChuKhachSan, loaiPhong, Program.iDKhachSanInstance);
            datPhongDAO.LoadPhongTrong(Program.ngayNhanInstance, Program.ngayTraInstance, flpTrangChuKhachSan);
        }
    }
}
