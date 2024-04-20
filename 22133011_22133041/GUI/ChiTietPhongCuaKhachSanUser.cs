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
        int iD;
        public ChiTietPhongCuaKhachSanUser(int iD)
        {
            InitializeComponent();
            this.iD = iD;
        }

        private void ChiTietPhongCuaKhachSanUser_Load(object sender, EventArgs e)
        {
            var kSan = (from p in db.ThongTinPhongCuaKhachSans
                        where p.IDPhong == iD
                        select p).SingleOrDefault();

            if (kSan != null)
            {
                lblTenPhong.Text = kSan.TenPhong;
                lblKichThuocPhong.Text = kSan.KichThuocPhong;
                lblGiaPhong.Text = kSan.GiaPhong;
                lblTienNghiPhongTam1.Text = kSan.TienNghiPhongTam1;
                lblTienNghiPhongTam2.Text = kSan.TienNghiPhongTam2;
                lblTienNghiPhongTam3.Text = kSan.TienNghiPhongTam3;
                lblTienNghiPhongTam4.Text = kSan.TienNghiPhongTam4;
                lblHuongTamNhin1.Text = kSan.HuongTamNhin1;
                lblHuongTamNhin2.Text = kSan.HuongTamNhin2;
                lblTienNghiPhong1.Text = kSan.TienNghiPhong1;
                lblTienNghiPhong2.Text = kSan.TienNghiPhong2;
                lblTienNghiPhong3.Text = kSan.TienNghiPhong3;
                lblTienNghiPhong4.Text = kSan.TienNghiPhong4;
                lblTienNghiPhong5.Text = kSan.TienNghiPhong5;
                lblTienNghiPhong6.Text = kSan.TienNghiPhong6;
                lblHutThuoc1.Text = kSan.HutThuoc1;
                lblHutThuoc2.Text = kSan.HutThuoc2;
            }
        }
    }
}
