using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.WebRequestMethods;

namespace GUI
{
    public class ThongTinKhachSanDAO
    {
        DoAnCuoiKyEntity dB = new DoAnCuoiKyEntity();
        string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        DanhGiaDAO dGiaDAO = new DanhGiaDAO();
        ThongTinPhongKhachSanDAO pKSDAO = new ThongTinPhongKhachSanDAO();
        DateTime date = DateTime.Now;
        public void LoadData(FlowLayoutPanel flpTrangChu, int iDNguoiDung)
        {
            var ketqua = from c in dB.ThongTinKhachSans where c.IDChuKhachSan == iDNguoiDung select c;
            foreach (var k in ketqua)
            {
                UCThongTinKhachSanAdmin uc = new UCThongTinKhachSanAdmin(k);
                uc.Margin = new Padding(10);
                flpTrangChu.Controls.Add(uc);                                   
            }
        }
        public void Them(ThongTinKhachSan f)
        {
            dB.ThongTinKhachSans.Add(f);
            dB.SaveChanges();
            MessageBox.Show("Thêm thông tin khách sạn thành công!");           
        }
        public void Xoa(int iDKhachSan)
        {
            var datPhong = from p in dB.DatPhongs where p.IDKhachSan == iDKhachSan select p;
            if (datPhong.Any())
            {
                foreach (var tmp in datPhong)
                {
                    if (tmp.NgayTraPhong.Value.Date >= date.Date)
                    {
                        MessageBox.Show("Khách sạn đang có phòng được thuê không thể thực hiện!");
                    }                            
                    else
                    {
                        dB.DatPhongs.Remove(tmp);
                        dB.SaveChanges();
                        var danhGia = from c in dB.DanhGias where c.IDKhachSan == iDKhachSan select c;
                        if (danhGia.Any())
                        {
                            foreach (var tmp3 in danhGia)
                            {
                                dB.DanhGias.Remove(tmp3);
                            }
                            dB.SaveChanges();
                        }
                        var hDon = from b in dB.HoaDons where b.ThongTinPhongCuaKhachSan.IDKhachSan == iDKhachSan select b;
                        if (hDon.Any())
                        {
                            foreach (var tmp1 in hDon)
                            {
                                dB.HoaDons.Remove(tmp1);
                            }
                            dB.SaveChanges();
                        }
                        var maGiam = from p in dB.MaGiamGias where p.IDKhachSan == iDKhachSan select p;
                        if (maGiam.Any())
                        {
                            foreach (var tmp1 in maGiam)
                            {
                                dB.MaGiamGias.Remove(tmp1);
                            }
                            dB.SaveChanges();
                        }    
                        var phong1 = from c1 in dB.ThongTinPhongCuaKhachSans where c1.IDKhachSan == iDKhachSan select c1;
                        foreach (var tmp2 in phong1)
                        {
                            dB.ThongTinPhongCuaKhachSans.Remove(tmp2);
                        }
                        dB.SaveChanges();                       
                        var khachSan = dB.ThongTinKhachSans.FirstOrDefault(c2 => c2.IDKhachSan == iDKhachSan);
                        dB.ThongTinKhachSans.Remove(khachSan);
                        dB.SaveChanges();
                        MessageBox.Show("Xóa khách sạn thành công!");
                    }
                }               
            }
            else
            {
                var danhGia = from c in dB.DanhGias where c.IDKhachSan == iDKhachSan select c;
                if (danhGia.Any())
                {
                    foreach (var tmp3 in danhGia)
                    {
                        dB.DanhGias.Remove(tmp3);
                    }
                    dB.SaveChanges();
                }
                var hDon = from b in dB.HoaDons where b.ThongTinPhongCuaKhachSan.IDKhachSan == iDKhachSan select b;
                if (hDon.Any())
                {
                    foreach (var tmp1 in hDon)
                    {
                        dB.HoaDons.Remove(tmp1);
                    }
                    dB.SaveChanges();
                }
                var maGiam = from p in dB.MaGiamGias where p.IDKhachSan == iDKhachSan select p;
                if (maGiam.Any())
                {
                    foreach (var tmp1 in maGiam)
                    {
                        dB.MaGiamGias.Remove(tmp1);
                    }
                    dB.SaveChanges();
                }
                var phong1 = from c1 in dB.ThongTinPhongCuaKhachSans where c1.IDKhachSan == iDKhachSan select c1;
                foreach (var tmp2 in phong1)
                {
                    dB.ThongTinPhongCuaKhachSans.Remove(tmp2);
                }
                dB.SaveChanges();
                var khachSan = dB.ThongTinKhachSans.FirstOrDefault(c2 => c2.IDKhachSan == iDKhachSan);
                dB.ThongTinKhachSans.Remove(khachSan);
                dB.SaveChanges();
                MessageBox.Show("Xóa khách sạn thành công!");
            }
        }
        public void Sua(ThongTinKhachSan f)
        {
            var khachSanToUpdate = dB.ThongTinKhachSans.FirstOrDefault(k => k.IDKhachSan == f.IDKhachSan);
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
                dB.SaveChanges();
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
                System.IO.File.Copy(opf.FileName, dest, true);
            }
        }
        public void GetAllKhachSan(FlowLayoutPanel flpTrangChu)
        {            
            var kSan = from p in dB.ThongTinKhachSans select p;
            foreach (var p in kSan)
            {
                UCThongTinKhachSanUser uc = new UCThongTinKhachSanUser(p);
                uc.Margin = new Padding(10);
                double? diem; dGiaDAO.TrungBinhDiemDanhGia(p.IDKhachSan, out diem);
                uc.linklblDiemDanhGia.Text = diem.ToString();
                uc.lblGiaTien.Text = pKSDAO.TrungBinhGiaTien(p.IDKhachSan) + " " + "VND";
                flpTrangChu.Controls.Add(uc);
            }
        }
        public void SearchKhachSanByDiaDiem(FlowLayoutPanel flpTrangChuUser, string diaDiem, DateTime ngayNhan, DateTime ngayTra)
        {
            var phongTrong = dB.ThongTinPhongCuaKhachSans
                                .Where(p => !dB.DatPhongs.Any(d => d.IDPhong == p.IDPhong &&
                                           ((ngayNhan >= d.NgayNhanPhong && ngayNhan < d.NgayTraPhong) ||
                                            (ngayTra > d.NgayNhanPhong && ngayTra <= d.NgayTraPhong) ||
                                            (ngayNhan <= d.NgayNhanPhong && ngayTra >= d.NgayTraPhong))))
                                .Select(p => p.IDKhachSan)
                                .Distinct()
                                .ToList();
            var kSan = dB.ThongTinKhachSans.Where(k => k.DiaDiemKhachSan == diaDiem && phongTrong.Contains(k.IDKhachSan)).ToList();
            foreach (var khachSan in kSan)
            {
                UCThongTinKhachSanUser uc = new UCThongTinKhachSanUser(khachSan);
                uc.Margin = new Padding(10);
                flpTrangChuUser.Controls.Add(uc);
            }
        }
        public void LoadChiTietKhachSanUser(ChiTietKhachSanUser f, int iDKSan)
        {
            var kSan = (from p in dB.ThongTinKhachSans
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
        public void LoadChiTietKhachSanAdmin(ChiTietKhachSanAdmin f, int iDKhachSan, out string tenAnh1, out string tenAnh2, out string tenAnh3, out string tenAnh4)
        {
            tenAnh1 = string.Empty; tenAnh2 = string.Empty; tenAnh3 = string.Empty; tenAnh4 = string.Empty; 
            var kSan = (from p in dB.ThongTinKhachSans
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
        public Dictionary<string, double> LoadDoanhThu()
        {
            var danhSachDoanhThu = new Dictionary<string, double>();

            var danhSachKhachSan = dB.ThongTinKhachSans.ToList();
            foreach (var khachSan in danhSachKhachSan)
            {
                var kQua = khachSan.ThongTinPhongCuaKhachSans
                    .SelectMany(p => p.HoaDons.Select(q => q.TongTien))
                    .ToList();

                double tongDoanhThu = 0;
                foreach (var tongTien in kQua)
                {
                    if (double.TryParse(tongTien, out double giaTri))
                    {
                        tongDoanhThu += giaTri;
                    }
                }

                danhSachDoanhThu.Add(khachSan.TenKhachSan, tongDoanhThu);
            }

            return danhSachDoanhThu;
        }
    }
}

