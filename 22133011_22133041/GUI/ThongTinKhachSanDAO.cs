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
            db.ThongTinKhachSans.Add(new ThongTinKhachSan
            {
                TenKhachSan = f.TenKhachSan,
                DiaDiemKhachSan = f.DiaDiemKhachSan,
                MoTa = f.MoTa,
                Loai = f.Loai,
                HinhAnh1 = f.HinhAnh1,
                HinhAnh2 = f.HinhAnh2,
                HinhAnh3 = f.HinhAnh3,
                HinhAnh4 = f.HinhAnh4,
                IDChuKhachSan = f.IDChuKhachSan,
            });
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
            MessageBox.Show("Xoa thông tin khách sạn thành công!");
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
        public List<UCThongTinKhachSanUser> GetAllKhachSan()
        {
            List<UCThongTinKhachSanUser> khachSanList = new List<UCThongTinKhachSanUser>();

            var kSan = from p in db.ThongTinKhachSans select p;

            foreach (var p in kSan)
            {
                UCThongTinKhachSanUser uc = new UCThongTinKhachSanUser(p);
                khachSanList.Add(uc);
            }
            return khachSanList;
        }
        public List<UCThongTinKhachSanUser> SearchKhachSanByDiaDiem(string diaDiem)
        {
            List<UCThongTinKhachSanUser> khachSanList = new List<UCThongTinKhachSanUser>();
            var kSan = from p in db.ThongTinKhachSans
                       where p.DiaDiemKhachSan == diaDiem
                       select p;
            foreach (var p in kSan)
            {
                UCThongTinKhachSanUser uc = new UCThongTinKhachSanUser(p);
                khachSanList.Add(uc);
            }
            return khachSanList;
        }
        public List<UCDanhGia> DataDanhGia(int id)
        {
            List<UCDanhGia> khachSanList = new List<UCDanhGia>();
            var kSan = from p in db.DanhGias
                       where p.IDKhachSan == id
                       select p;
            foreach (var p in kSan)
            {
                UCDanhGia uc = new UCDanhGia(p);
                khachSanList.Add(uc);
            }              
            return khachSanList;
        }
    }
}

