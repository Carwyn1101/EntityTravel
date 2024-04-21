using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal class ThongTinPhongKhachSanDAO
    {
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();
        string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public void LoadDanhSachPhongUser(FlowLayoutPanel flpTrangChuKhachSan, int iDKhachSan)
        {           
            var kSan = from p in db.ThongTinPhongCuaKhachSans
                       where p.IDKhachSan == iDKhachSan
                       select p;
            foreach (var p in kSan)
            {
                UCThongTinPhongKhachSanUser uc = new UCThongTinPhongKhachSanUser(p);
                flpTrangChuKhachSan.Controls.Add(uc);
            }
        }
        public void LoadDanhSachPhongAdmin(FlowLayoutPanel flpTrangChuAdmin, int id)
        {
            var phongAdmin = from c in db.ThongTinPhongCuaKhachSans where c.IDKhachSan == id select c;
            foreach(var p in phongAdmin)
            {
                UCThongTinPhongKhachSanAdmin uc = new UCThongTinPhongKhachSanAdmin(p);
                flpTrangChuAdmin.Controls.Add(uc);
            }
        }
        public void Them(ThongTinPhongCuaKhachSan f)
        {
            db.ThongTinPhongCuaKhachSans.Add(new ThongTinPhongCuaKhachSan
            {
                TenPhong = f.TenPhong,
                KichThuocPhong = f.KichThuocPhong,
                GiaPhong = f.GiaPhong,
                TienNghiPhongTam1 = f.TienNghiPhongTam1,
                TienNghiPhongTam2 = f.TienNghiPhongTam2,
                TienNghiPhongTam3 = f.TienNghiPhongTam3,
                TienNghiPhongTam4 = f.TienNghiPhongTam4,
                HuongTamNhin1 = f.HuongTamNhin1,
                HuongTamNhin2 = f.HuongTamNhin2,
                TienNghiPhong1 = f.TienNghiPhong1,
                TienNghiPhong2 = f.TienNghiPhong2,
                TienNghiPhong3 = f.TienNghiPhong3,
                TienNghiPhong4 = f.TienNghiPhong4,
                TienNghiPhong5 = f.TienNghiPhong5,
                TienNghiPhong6 = f.TienNghiPhong6,
                HutThuoc1 = f.HutThuoc1,
                HutThuoc2 = f.HutThuoc2,
                UuDai = null,
                TrangThai = f.TrangThai,
                HinhAnh1 = f.HinhAnh1,
                HinhAnh2 = f.HinhAnh2,
                IDKhachSan = f.IDKhachSan,
            });
            db.SaveChanges();
            MessageBox.Show("Thêm thông tin phòng khách sạn thành công!");
        }
        public void Xoa(int iDPhongKhachSan)
        {
            var khachSanToRemove = db.ThongTinPhongCuaKhachSans.FirstOrDefault(k => k.IDPhong == iDPhongKhachSan);
            if (khachSanToRemove != null)
            {
                db.ThongTinPhongCuaKhachSans.Remove(khachSanToRemove);
                db.SaveChanges();
            }
            MessageBox.Show("Xoá thông tin phòng khách sạn thành công!");
        }
        public void Sua(ThongTinPhongCuaKhachSan f)
        {
            var khachSanToUpdate = db.ThongTinPhongCuaKhachSans.FirstOrDefault(k => k.IDPhong == f.IDPhong);
            if (khachSanToUpdate != null)
            {
                khachSanToUpdate.TenPhong = f.TenPhong;
                khachSanToUpdate.KichThuocPhong = f.KichThuocPhong;
                khachSanToUpdate.GiaPhong = f.GiaPhong;
                khachSanToUpdate.TienNghiPhongTam1 = f.TienNghiPhongTam1;
                khachSanToUpdate.TienNghiPhongTam2 = f.TienNghiPhongTam2;
                khachSanToUpdate.TienNghiPhongTam3 = f.TienNghiPhongTam3;
                khachSanToUpdate.TienNghiPhongTam4 = f.TienNghiPhongTam4;
                khachSanToUpdate.HuongTamNhin1  = f.HuongTamNhin1;
                khachSanToUpdate.HuongTamNhin2 = f.HuongTamNhin2;
                khachSanToUpdate.TienNghiPhong1 = f.TienNghiPhong1;
                khachSanToUpdate.TienNghiPhong2 = f.TienNghiPhong2;
                khachSanToUpdate.TienNghiPhong3 = f.TienNghiPhong3;
                khachSanToUpdate.TienNghiPhong4 = f.TienNghiPhong4;
                khachSanToUpdate.TienNghiPhong5 = f.TienNghiPhong5;
                khachSanToUpdate.TienNghiPhong6 = f.TienNghiPhong6;
                khachSanToUpdate.HutThuoc1 = f.HutThuoc1;
                khachSanToUpdate.HutThuoc2 = f.HutThuoc2;
                khachSanToUpdate.UuDai = null;
                khachSanToUpdate.TrangThai = f.TrangThai;
                khachSanToUpdate.HinhAnh1 = f.HinhAnh1;
                khachSanToUpdate.HinhAnh2 = f.HinhAnh2;              
                db.SaveChanges();
            }
            MessageBox.Show("Sửa thông tin phòng khách sạn thành công!");
        }
        public void LoadChiTietPhongUser(ChiTietPhongCuaKhachSanUser f, int iDPhong)
        {
            var kSan = (from p in db.ThongTinPhongCuaKhachSans
                        where p.IDPhong == iDPhong
                        select p).SingleOrDefault();
            if (kSan != null)
            {
                f.lblTenPhong.Text = kSan.TenPhong;
                f.lblKichThuocPhong.Text = kSan.KichThuocPhong;
                f.lblGiaPhong.Text = kSan.GiaPhong;
                f.lblTienNghiPhongTam1.Text = kSan.TienNghiPhongTam1;
                f.lblTienNghiPhongTam2.Text = kSan.TienNghiPhongTam2;
                f.lblTienNghiPhongTam3.Text = kSan.TienNghiPhongTam3;
                f.lblTienNghiPhongTam4.Text = kSan.TienNghiPhongTam4;
                f.lblHuongTamNhin1.Text = kSan.HuongTamNhin1;
                f.lblHuongTamNhin2.Text = kSan.HuongTamNhin2;
                f.lblTienNghiPhong1.Text = kSan.TienNghiPhong1;
                f.lblTienNghiPhong2.Text = kSan.TienNghiPhong2;
                f.lblTienNghiPhong3.Text = kSan.TienNghiPhong3;
                f.lblTienNghiPhong4.Text = kSan.TienNghiPhong4;
                f.lblTienNghiPhong5.Text = kSan.TienNghiPhong5;
                f.lblTienNghiPhong6.Text = kSan.TienNghiPhong6;
                f.lblHutThuoc1.Text = kSan.HutThuoc1;
                f.lblHutThuoc2.Text = kSan.HutThuoc2;
                string image1 = Path.Combine(appDirectory, kSan.HinhAnh1);
                string image2 = Path.Combine(appDirectory, kSan.HinhAnh2);
                f.pic_Anh1.Image = Image.FromFile(image1);
                f.pic_Anh2.Image = Image.FromFile(image2);
            }
        }
        public void LoadPhongTheoLoaiPhong(FlowLayoutPanel flpTrangChuKhachSan, string loaiPhong)
        {
            var kSan = from p in db.ThongTinPhongCuaKhachSans
                       where p.TenPhong == loaiPhong
                       select p;
            foreach (var p in kSan)
            {
                UCThongTinPhongKhachSanUser uc = new UCThongTinPhongKhachSanUser(p);
                flpTrangChuKhachSan.Controls.Add(uc);
            }
        }
        public void CapNhatTrangThaiPhong(int iDPhong)
        {
            var tmp = from p in db.ThongTinPhongCuaKhachSans                       
                      select p.ThongTinKhachHangs.Count;
            if (tmp != null)
            {
                ThongTinPhongCuaKhachSan pKSan = db.ThongTinPhongCuaKhachSans.Find(iDPhong);
                pKSan.TrangThai = "Đã được thuê";
                db.SaveChanges();
            }            
        }
    }
}
