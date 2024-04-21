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
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();
        string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
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
            var kSan = (from p in db.ThongTinPhongCuaKhachSans
                        where p.IDPhong == iDPhong
                        select p).SingleOrDefault();

            if (kSan != null)
            {
                iDPhong = kSan.IDPhong;
                cboTenPhong.Text = kSan.TenPhong;
                txtKichThuocPhong.Text = kSan.KichThuocPhong;
                txtGiaPhong.Text = kSan.GiaPhong;
                cboTienNghiPhongTam1.Text = kSan.TienNghiPhongTam1;
                cboTienNghiPhongTam2.Text = kSan.TienNghiPhongTam2;
                cboTienNghiPhongTam3.Text = kSan.TienNghiPhongTam3;
                cboTienNghiPhongTam4.Text = kSan.TienNghiPhongTam4;
                cboHuongTamNhin1.Text = kSan.HuongTamNhin1;
                cboHuongTamNhin2.Text = kSan.HuongTamNhin2;
                cboTienNghiPhong1.Text = kSan.TienNghiPhong1;
                cboTienNghiPhong2.Text = kSan.TienNghiPhong2;
                cboTienNghiPhong3.Text = kSan.TienNghiPhong3;
                cboTienNghiPhong4.Text = kSan.TienNghiPhong4;
                cboTienNghiPhong5.Text = kSan.TienNghiPhong5;
                cboTienNghiPhong6.Text = kSan.TienNghiPhong6;
                cboHutThuoc1.Text = kSan.HutThuoc1;
                cboHutThuoc2.Text = kSan.HutThuoc2;
                txtTrangThai.Text = kSan.TrangThai;
                tenAnh1 = kSan.HinhAnh1;
                tenAnh2 = kSan.HinhAnh2;
                string image1 = Path.Combine(appDirectory, kSan.HinhAnh1);
                string image2 = Path.Combine(appDirectory, kSan.HinhAnh2);               
                pic_Anh1.Image = Image.FromFile(image1);
                pic_Anh2.Image = Image.FromFile(image2);             
            }
        }
    }
}
