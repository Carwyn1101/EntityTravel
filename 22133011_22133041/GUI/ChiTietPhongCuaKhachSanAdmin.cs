using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChiTietPhongCuaKhachSanAdmin : Form
    {
        int iDKhachSan, iDPhong; string tenAnh1, tenAnh2;     
        ThongTinKhachSanDAO kSanDAO = new ThongTinKhachSanDAO();
        ThongTinPhongKhachSanDAO pKSanDAO = new ThongTinPhongKhachSanDAO();
        public ChiTietPhongCuaKhachSanAdmin()
        {
            InitializeComponent();
        }
        public ChiTietPhongCuaKhachSanAdmin(int IDKhachSan,int IDPhong)
        {
            InitializeComponent();
            iDKhachSan = IDKhachSan;
            iDPhong = IDPhong;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            pKSanDAO.Xoa(iDPhong);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThongTinPhongCuaKhachSan kSan = new ThongTinPhongCuaKhachSan();
            kSan.TenPhong = cboTenPhong.Text;
            kSan.KichThuocPhong = txtKichThuocPhong.Text;
            kSan.GiaPhong = txtGiaPhong.Text;
            kSan.TienNghiPhongTam1 = cboTienNghiPhongTam1.Text;
            kSan.TienNghiPhongTam2 = cboTienNghiPhongTam2.Text;
            kSan.TienNghiPhongTam3 = cboTienNghiPhongTam3.Text;
            kSan.TienNghiPhongTam4 = cboTienNghiPhongTam4.Text;
            kSan.HuongTamNhin1 = cboHuongTamNhin1.Text;
            kSan.HuongTamNhin2 = cboHuongTamNhin2.Text;
            kSan.TienNghiPhong1 = cboTienNghiPhong1.Text;
            kSan.TienNghiPhong2 = cboTienNghiPhong2.Text;
            kSan.TienNghiPhong3 = cboTienNghiPhong3.Text;
            kSan.TienNghiPhong4 = cboTienNghiPhong4.Text;
            kSan.TienNghiPhong5 = cboTienNghiPhong5.Text;
            kSan.TienNghiPhong6 = cboTienNghiPhong6.Text;
            kSan.HutThuoc1 = cboHutThuoc1.Text;
            kSan.HutThuoc2 = cboHutThuoc2.Text;
            kSan.UuDai = null;
            kSan.TrangThai = txtTrangThai.Text;
            kSan.HinhAnh1 = tenAnh1;
            kSan.HinhAnh2 = tenAnh2;
            pKSanDAO.Sua(kSan);
            this.Close();
        }
        private void btnSuaAnh1_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh1, out tenAnh1);
        }

        private void btnSuaAnh2_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh1, out tenAnh1);
        }
        private void ChiTietPhongCuaKhachSanAdmin_Load(object sender, EventArgs e)
        {
            pKSanDAO.LoadChiTietPhongAdmin(this, iDPhong, out tenAnh1, out tenAnh2);
        }
    }
}
