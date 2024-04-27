
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
            foreach (var p in phongAdmin)
            {
                UCThongTinPhongKhachSanAdmin uc = new UCThongTinPhongKhachSanAdmin(p);
                uc.Margin = new Padding(5);
                flpTrangChuAdmin.Controls.Add(uc);
            }
        }
        public void Them(ThongTinPhongCuaKhachSan f)
        {
            db.ThongTinPhongCuaKhachSans.Add(f);
            db.SaveChanges();
            MessageBox.Show("Thêm thông tin phòng khách sạn thành công!");
        }
        public void Xoa(int iDPhongKhachSan)
        {           
            var phong = from c1 in db.ThongTinPhongCuaKhachSans where c1.IDPhong == iDPhongKhachSan select c1;
            if (phong.Any())
            {
                MessageBox.Show("Phòng đang được thuê không thể thực hiện!");
            }
            else
            {
                var datPhong = from p in db.DatPhongs where p.IDPhong == iDPhongKhachSan select p;
                if (datPhong.Any())
                {
                    foreach (var tmp in datPhong)
                    {
                        db.DatPhongs.Remove(tmp);
                    }
                    db.SaveChanges();
                }
                var hDon = from b in db.HoaDons where b.IDPhong == iDPhongKhachSan select b;
                if (hDon.Any())
                {
                    foreach (var tmp in hDon)
                    {
                        db.HoaDons.Remove(tmp);
                    }
                    db.SaveChanges();
                }
                var phongKS = db.ThongTinPhongCuaKhachSans.FirstOrDefault(c2 => c2.IDPhong == iDPhongKhachSan);
                db.ThongTinPhongCuaKhachSans.Remove(phongKS);
                db.SaveChanges();
                MessageBox.Show("Xoá thông tin phòng khách sạn thành công!");
            }
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
                khachSanToUpdate.HuongTamNhin1 = f.HuongTamNhin1;
                khachSanToUpdate.HuongTamNhin2 = f.HuongTamNhin2;
                khachSanToUpdate.TienNghiPhong1 = f.TienNghiPhong1;
                khachSanToUpdate.TienNghiPhong2 = f.TienNghiPhong2;
                khachSanToUpdate.TienNghiPhong3 = f.TienNghiPhong3;
                khachSanToUpdate.TienNghiPhong4 = f.TienNghiPhong4;
                khachSanToUpdate.TienNghiPhong5 = f.TienNghiPhong5;
                khachSanToUpdate.TienNghiPhong6 = f.TienNghiPhong6;
                khachSanToUpdate.HutThuoc1 = f.HutThuoc1;
                khachSanToUpdate.HutThuoc2 = f.HutThuoc2;
                khachSanToUpdate.UuDai = f.UuDai;
                khachSanToUpdate.HinhAnh1 = f.HinhAnh1;
                khachSanToUpdate.HinhAnh2 = f.HinhAnh2;               
            }
            db.SaveChanges();
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
        public void LoadPhongTheoLoaiPhong(FlowLayoutPanel flpTrangChuKhachSan, string loaiPhong, int iDKhachSan)
        {
            var kSan = from p in db.ThongTinPhongCuaKhachSans
                       where p.TenPhong == loaiPhong && p.IDKhachSan == iDKhachSan
                       select p;
            foreach (var p in kSan)
            {
                UCThongTinPhongKhachSanUser uc = new UCThongTinPhongKhachSanUser(p);
                flpTrangChuKhachSan.Controls.Add(uc);
            }
        }
        public void CapNhatTrangThaiPhong(int iDPhong)
        {
            var tmp = from p in db.ThongTinPhongCuaKhachSans where p.IDPhong == iDPhong
                      select p;
            if (tmp != null)
            {
                ThongTinPhongCuaKhachSan pKSan = db.ThongTinPhongCuaKhachSans.Find(iDPhong);
                db.SaveChanges();
            }
        }
        public void LoadChiTietPhongAdmin(ChiTietPhongCuaKhachSanAdmin f, int iDPhong, out string tenAnh1, out string tenAnh2)
        {
            tenAnh1 = string.Empty; tenAnh2 = string.Empty; 
            var kSan = (from p in db.ThongTinPhongCuaKhachSans
                        where p.IDPhong == iDPhong
                        select p).SingleOrDefault();
            if (kSan != null)
            {
                iDPhong = kSan.IDPhong;
                f.cboTenPhong.Text = kSan.TenPhong;
                f.txtKichThuocPhong.Text = kSan.KichThuocPhong;
                f.txtGiaPhong.Text = kSan.GiaPhong;
                f.cboTienNghiPhongTam1.Text = kSan.TienNghiPhongTam1;
                f.cboTienNghiPhongTam2.Text = kSan.TienNghiPhongTam2;
                f.cboTienNghiPhongTam3.Text = kSan.TienNghiPhongTam3;
                f.cboTienNghiPhongTam4.Text = kSan.TienNghiPhongTam4;
                f.cboHuongTamNhin1.Text = kSan.HuongTamNhin1;
                f.cboHuongTamNhin2.Text = kSan.HuongTamNhin2;
                f.cboTienNghiPhong1.Text = kSan.TienNghiPhong1;
                f.cboTienNghiPhong2.Text = kSan.TienNghiPhong2;
                f.cboTienNghiPhong3.Text = kSan.TienNghiPhong3;
                f.cboTienNghiPhong4.Text = kSan.TienNghiPhong4;
                f.cboTienNghiPhong5.Text = kSan.TienNghiPhong5;
                f.cboTienNghiPhong6.Text = kSan.TienNghiPhong6;
                f.cboHutThuoc1.Text = kSan.HutThuoc1;
                f.cboHutThuoc2.Text = kSan.HutThuoc2;
                tenAnh1 = kSan.HinhAnh1;
                tenAnh2 = kSan.HinhAnh2;
                string image1 = Path.Combine(appDirectory, kSan.HinhAnh1);
                string image2 = Path.Combine(appDirectory, kSan.HinhAnh2);
                f.pic_Anh1.Image = Image.FromFile(image1);
                f.pic_Anh2.Image = Image.FromFile(image2);
            }
        }
    }
}
