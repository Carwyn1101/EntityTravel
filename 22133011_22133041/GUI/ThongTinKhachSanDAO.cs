using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class ThongTinKhachSanDAO
    {
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();
        string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public void LoadData(FlowLayoutPanel flpTrangChu, int iDNguoiDung)
        {
            var ketqua = from c in db.ThongTinKhachSans where c.IDChuKhachSan == iDNguoiDung select c;
            foreach (var k in ketqua)
            {
                UCThongTinKhachSanAdmin uc = new UCThongTinKhachSanAdmin(k);
                flpTrangChu.Controls.Add(uc);
            }
        }
        public void Them(ThongTinKhachSan f)
        {
            db.ThongTinKhachSans.Add(f);
            db.SaveChanges();
            MessageBox.Show("Thêm thông tin khách sạn thành công!");           
        }
        public void Xoa(int iDKhachSan)
        {
            var khachSanToRemove = db.ThongTinKhachSans.FirstOrDefault(k => k.IDKhachSan == iDKhachSan);
            if (khachSanToRemove != null)
            {
                db.ThongTinKhachSans.Remove(khachSanToRemove);
                db.SaveChanges();
            }
            MessageBox.Show("Xoá thông tin khách sạn thành công!");
        }
        public void Sua(ThongTinKhachSan f)
        {
            var khachSanToUpdate = db.ThongTinKhachSans.FirstOrDefault(k => k.IDKhachSan == f.IDKhachSan);
            if (khachSanToUpdate != null)
            {
                khachSanToUpdate.TenKhachSan = f.TenKhachSan;
                khachSanToUpdate.DiaDiemKhachSan = f.DiaDiemKhachSan;
                khachSanToUpdate.MoTa = f.MoTa;
                khachSanToUpdate.Loai = f.Loai;
                khachSanToUpdate.HinhAnh1 = f.HinhAnh1;
                khachSanToUpdate.HinhAnh2 = f.HinhAnh2;
                khachSanToUpdate.HinhAnh3 = f.HinhAnh3;
                khachSanToUpdate.HinhAnh4 = f.HinhAnh4;
                db.SaveChanges();
            }
            MessageBox.Show("Sửa thông tin khách sạn thành công!");
        }
        public void SaveImage(PictureBox image, out string filename)
        {
            filename = string.Empty;
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                image.Image = Image.FromFile(opf.FileName);
                filename = Path.GetFileName(opf.FileName);
                string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string dest = Path.Combine(appDirectory, filename);
                File.Copy(opf.FileName, dest, true);
            }
        }
        public void GetAllKhachSan(FlowLayoutPanel flpTrangChu)
        {            
            var kSan = from p in db.ThongTinKhachSans select p;
            foreach (var p in kSan)
            {
                UCThongTinKhachSanUser uc = new UCThongTinKhachSanUser(p);
                flpTrangChu.Controls.Add(uc);
            }
        }
        public void SearchKhachSanByDiaDiem(FlowLayoutPanel flpTrangChuUser, string diaDiem)
        {
            var kSan = from p in db.ThongTinKhachSans
                       where p.DiaDiemKhachSan == diaDiem
                       select p; 
            foreach (var p in kSan)
            {
                UCThongTinKhachSanUser uc = new UCThongTinKhachSanUser(p);
                flpTrangChuUser.Controls.Add(uc);
            }
        }
        public void LoadChiTietKhachSanUser(ChiTietKhachSanUser f,int iDKSan)
        {
            var kSan = (from p in db.ThongTinKhachSans
                        where p.IDKhachSan == iDKSan
                        select p).SingleOrDefault();
            if (kSan != null)
            {
                f.txtTenKhachSan.Text = kSan.TenKhachSan;
                f.lblDiaDiem.Text = kSan.DiaDiemKhachSan;
                f.lblLoai.Text = kSan.Loai;
                f.richTextBoxMoTa.Text = kSan.MoTa;
                string image1 = Path.Combine(appDirectory, kSan.HinhAnh1);
                string image2 = Path.Combine(appDirectory, kSan.HinhAnh2);
                string image3 = Path.Combine(appDirectory, kSan.HinhAnh3);
                string image4 = Path.Combine(appDirectory, kSan.HinhAnh4);
                f.pic_Anh1.Image = Image.FromFile(image1);
                f.pic_Anh2.Image = Image.FromFile(image2);
                f.pic_Anh3.Image = Image.FromFile(image3);
                f.pic_Anh4.Image = Image.FromFile(image4);
            }
        }
        public void LoadChiTietKhachSanAdmin(ChiTietKhachSanAdmin f, int iDKhachSan, out string tenAnh1, out string tenAnh2, out string tenAnh3, out string tenAnh4, out int iDChuKhachSan)
        {
            tenAnh1 = string.Empty; tenAnh2 = string.Empty; tenAnh3 = string.Empty; tenAnh4 = string.Empty; iDChuKhachSan = 0;
            var kSan = (from p in db.ThongTinKhachSans
                        where p.IDKhachSan == iDKhachSan
                        select p).SingleOrDefault();
            if (kSan != null)
            {
                f.txtTenKhachSan.Text = kSan.TenKhachSan;
                f.txtDiaDiem.Text = kSan.DiaDiemKhachSan;
                f.txtLoai.Text = kSan.Loai;
                f.richTextBoxMoTa.Text = kSan.MoTa;
                tenAnh1 = kSan.HinhAnh1;
                tenAnh2 = kSan.HinhAnh2;
                tenAnh3 = kSan.HinhAnh3;
                tenAnh4 = kSan.HinhAnh4;
                iDChuKhachSan = (int)kSan.IDChuKhachSan;
                string image1 = Path.Combine(appDirectory, kSan.HinhAnh1);
                string image2 = Path.Combine(appDirectory, kSan.HinhAnh2);
                string image3 = Path.Combine(appDirectory, kSan.HinhAnh3);
                string image4 = Path.Combine(appDirectory, kSan.HinhAnh4);
                f.pic_Anh1.Image = Image.FromFile(image1);
                f.pic_Anh2.Image = Image.FromFile(image2);
                f.pic_Anh3.Image = Image.FromFile(image3);
                f.pic_Anh4.Image = Image.FromFile(image4);
            }
        }
    }
}

