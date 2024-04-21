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
    public partial class ChiTietKhachSanAdmin : Form
    {
        string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();   
        ThongTinKhachSanDAO kSanDAO = new ThongTinKhachSanDAO();
        ThongTinPhongKhachSanDAO pKSanDAO = new ThongTinPhongKhachSanDAO();
        string tenAnh1, tenAnh2, tenAnh3, tenAnh4;
        int iDKhachSan, iDChuKhachSan;    
        public ChiTietKhachSanAdmin()
        {
            InitializeComponent();         
        }
        public ChiTietKhachSanAdmin(int IDKhachSan)
        {
            InitializeComponent();
            iDKhachSan = IDKhachSan;           
            pKSanDAO.LoadDanhSachPhongAdmin(flpPhongKhachSan, iDKhachSan);
        }
        private void ChiTietKhachSanAdmin_Load(object sender, EventArgs e)
        {
            var kSan = (from p in db.ThongTinKhachSans
                        where p.IDKhachSan == iDKhachSan
                        select p).SingleOrDefault();

            if (kSan != null)
            {
                txtTenKhachSan.Text = kSan.TenKhachSan;
                txtDiaDiem.Text = kSan.DiaDiemKhachSan;
                txtLoai.Text = kSan.Loai;
                richTextBoxMoTa.Text = kSan.MoTa;
                tenAnh1 = kSan.HinhAnh1;
                tenAnh2 = kSan.HinhAnh2;
                tenAnh3 = kSan.HinhAnh3;
                tenAnh4 = kSan.HinhAnh4;
                iDChuKhachSan = (int)kSan.IDChuKhachSan;
                string image1 = Path.Combine(appDirectory, kSan.HinhAnh1);
                string image2 = Path.Combine(appDirectory, kSan.HinhAnh2);
                string image3 = Path.Combine(appDirectory, kSan.HinhAnh3);
                string image4 = Path.Combine(appDirectory, kSan.HinhAnh4);
                pic_Anh1.Image = Image.FromFile(image1);
                pic_Anh2.Image = Image.FromFile(image2);
                pic_Anh3.Image = Image.FromFile(image3);
                pic_Anh4.Image = Image.FromFile(image4);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            kSanDAO.Xoa(iDKhachSan);
            this.Close();
            Program.TrangChuAdminInstance.flpTrangChu.Controls.Clear();
            kSanDAO.LoadData(Program.TrangChuAdminInstance.flpTrangChu, iDChuKhachSan);
            Program.TrangChuAdminInstance.Show();
        }       
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThongTinKhachSan kSan = new ThongTinKhachSan();
            kSan.IDKhachSan = iDKhachSan;
            kSan.TenKhachSan = txtTenKhachSan.Text;
            kSan.DiaDiemKhachSan = txtDiaDiem.Text;
            kSan.Loai = txtLoai.Text;
            kSan.MoTa = richTextBoxMoTa.Text;
            kSan.HinhAnh1 = tenAnh1;
            kSan.HinhAnh2 = tenAnh2;
            kSan.HinhAnh3 = tenAnh3;
            kSan.HinhAnh4 = tenAnh4; 
            kSan.IDChuKhachSan = iDChuKhachSan;
            kSanDAO.Sua(kSan);
            this.Close();
            Program.TrangChuAdminInstance.flpTrangChu.Controls.Clear();
            kSanDAO.LoadData(Program.TrangChuAdminInstance.flpTrangChu, iDChuKhachSan);
            Program.TrangChuAdminInstance.Show();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            ThemPhongChoKhachSan f = new ThemPhongChoKhachSan(iDKhachSan);
            f.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            flpPhongKhachSan.Controls.Clear();
            pKSanDAO.LoadDanhSachPhongAdmin(flpPhongKhachSan, iDKhachSan);
        }
        private void btnSuaAnh1_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh1, out tenAnh1);
        }
        private void btnSuaAnh2_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh2, out tenAnh2);
        }
        private void btnSuaAnh3_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh3, out tenAnh3);
        }
        private void btnSuaAnh4_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh4, out tenAnh4);
        }
    }
}
