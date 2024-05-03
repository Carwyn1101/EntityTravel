using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{
    internal class DatPhongDAO
    {
        DoAnCuoiKyEntity dB = new DoAnCuoiKyEntity();
        DateTime check = DateTime.Now;
        public void Xoa(int maDatPhong)
        {
            var remove = dB.DatPhongs.FirstOrDefault(k => k.MaDatPhong == maDatPhong);
            var trangThai = dB.ThongTinPhongCuaKhachSans.FirstOrDefault(h => h.IDPhong == remove.IDPhong);
            dB.SaveChanges();
            if (remove != null)
            {
                dB.DatPhongs.Remove(remove);
                dB.SaveChanges();
            }
            MessageBox.Show("Hủy phòng khách sạn thành công!");
        }
        public void LichSuBookLoad(FlowLayoutPanel flpLichSuBook)
        {
            var kq = from c in dB.DatPhongs where c.IDKhachHang == Program.iDTaiKhoanInstance select c;
            foreach (var k in kq)
            {
                var tenKhachSan = dB.ThongTinKhachSans.FirstOrDefault(tmp => tmp.IDKhachSan == k.IDKhachSan);
                var tenPhong = dB.ThongTinPhongCuaKhachSans.FirstOrDefault(tmp => tmp.IDPhong == k.IDPhong);
                if (k.NgayTraPhong < check)
                {
                    UCHoanThanh uc = new UCHoanThanh(tenKhachSan.TenKhachSan, tenPhong.TenPhong, k.NgayNhanPhong.Value, k.NgayTraPhong.Value);
                    flpLichSuBook.Controls.Add(uc);
                }
                else
                {
                    UCChuaHoanThanh uc = new UCChuaHoanThanh(tenKhachSan.TenKhachSan, tenPhong.TenPhong, k.NgayNhanPhong.Value, k.NgayTraPhong.Value, k.MaDatPhong);
                    flpLichSuBook.Controls.Add(uc);
                }
            }
        }
        public void Them(DatPhong dPhong)
        {
            dPhong.TrangThai = "Đã được thuê";
            dB.DatPhongs.Add(dPhong);
            dB.SaveChanges();
        }
        public void LoadPhongTrong(DateTime ngayNhan, DateTime ngayTra, FlowLayoutPanel flp)
        {
            var phongTrong = dB.ThongTinPhongCuaKhachSans.Where(p => p.IDKhachSan == Program.iDKhachSanInstance && !dB.DatPhongs.Any(d => d.IDPhong == p.IDPhong && d.IDKhachSan == Program.iDKhachSanInstance &&
                                            ((ngayNhan >= d.NgayNhanPhong && ngayNhan < d.NgayTraPhong) || (ngayTra > d.NgayNhanPhong && ngayTra <= d.NgayTraPhong) || (ngayNhan <= d.NgayNhanPhong && ngayTra >= d.NgayTraPhong)))).ToList();
            foreach (var tmp in phongTrong)
            {
                UCThongTinPhongKhachSanUser uc = new UCThongTinPhongKhachSanUser(tmp);
                flp.Controls.Add(uc);
            }
        }
        enum TieuChiPhong
        {
            PhoBien1 = 0,
            PhoBien2 = 1,
            PhoBien3 = 2,
            PhoBien4 = 3,
            HuongTamNhin1 = 4,
            HuongTamNhin2 = 5,
            TienNghi1 = 6,
            TienNghi2 = 7,
            TienNghi3 = 8,
        }     
        public void LoadPhongTrongVoiTieuChiLoc(DateTime ngayNhan, DateTime ngayTra, FlowLayoutPanel flp, bool[] tieuChiLoc)
        {
            var phongTrong = dB.ThongTinPhongCuaKhachSans
                                .Where(p => p.IDKhachSan == Program.iDKhachSanInstance &&
                                            !dB.DatPhongs.Any(d => d.IDPhong == p.IDPhong && d.IDKhachSan == Program.iDKhachSanInstance &&
                                            ((ngayNhan >= d.NgayNhanPhong && ngayNhan < d.NgayTraPhong) ||
                                            (ngayTra > d.NgayNhanPhong && ngayTra <= d.NgayTraPhong) ||
                                            (ngayNhan <= d.NgayNhanPhong && ngayTra >= d.NgayTraPhong))))
                                .ToList();

            foreach (var tmp in phongTrong)
            {
                bool phongPhuHop = true;               
                for (int i = 0; i < tieuChiLoc.Length; i++)
                {
                    if (tieuChiLoc[i]) 
                    {                      
                        switch ((TieuChiPhong)i)
                        {
                            case TieuChiPhong.PhoBien1:
                                if (!(tmp.TienNghiPhongTam1 == "Bồn tắm" || tmp.TienNghiPhongTam2 == "Bồn tắm" || tmp.TienNghiPhongTam3 == "Bồn tắm" || tmp.TienNghiPhongTam4 == "Bồn tắm"))
                                    phongPhuHop = false;
                                break;
                            case TieuChiPhong.PhoBien2:
                                if (!(tmp.TienNghiPhong1 == "Máy lạnh" || tmp.TienNghiPhong2 == "Máy lạnh" || tmp.TienNghiPhong3 == "Máy lạnh" || tmp.TienNghiPhong4 == "Máy lạnh" || tmp.TienNghiPhong5 == "Máy lạnh" || tmp.TienNghiPhong6 == "Máy lạnh"))
                                    phongPhuHop = false;
                                break;
                            case TieuChiPhong.PhoBien3:
                                if (!(tmp.HutThuoc1 == "Được hút thuốc"))
                                    phongPhuHop = false;
                                break;
                            case TieuChiPhong.PhoBien4:
                                if (!(tmp.TienNghiPhong1 == "Ban công" || tmp.TienNghiPhong2 == "Ban công" || tmp.TienNghiPhong3 == "Ban công" || tmp.TienNghiPhong4 == "Ban công" || tmp.TienNghiPhong5 == "Ban công" || tmp.TienNghiPhong6 == "Ban công"))
                                    phongPhuHop = false;
                                break;
                            case TieuChiPhong.HuongTamNhin1:
                                if (!(tmp.HuongTamNhin1 == "Nhìn ra biển" || tmp.HuongTamNhin2 == "Nhìn ra biển"))
                                    phongPhuHop = false;
                                break;
                            case TieuChiPhong.HuongTamNhin2:
                                if (!(tmp.HuongTamNhin1 == "Nhìn ra thành phố" || tmp.HuongTamNhin2 == "Nhìn ra thành phố"))
                                    phongPhuHop = false;
                                break;
                            case TieuChiPhong.TienNghi1:
                                if (!(tmp.TienNghiPhong1 == "TV" || tmp.TienNghiPhong2 == "TV" || tmp.TienNghiPhong3 == "TV" || tmp.TienNghiPhong4 == "TV" || tmp.TienNghiPhong5 == "TV" || tmp.TienNghiPhong6 == "TV"))
                                    phongPhuHop = false;
                                break;
                            case TieuChiPhong.TienNghi2:
                                if (!(tmp.TienNghiPhong1 == "Tủ lạnh" || tmp.TienNghiPhong2 == "Tủ lạnh" || tmp.TienNghiPhong3 == "Tủ lạnh" || tmp.TienNghiPhong4 == "Tủ lạnh" || tmp.TienNghiPhong5 == "Tủ lạnh" || tmp.TienNghiPhong6 == "Tủ lạnh"))
                                    phongPhuHop = false;
                                break;
                            case TieuChiPhong.TienNghi3:
                                if (!(tmp.TienNghiPhong1 == "Wifi miễn phí" || tmp.TienNghiPhong2 == "Wifi miễn phí" || tmp.TienNghiPhong3 == "Wifi miễn phí" || tmp.TienNghiPhong4 == "Wifi miễn phí" || tmp.TienNghiPhong5 == "Wifi miễn phí" || tmp.TienNghiPhong6 == "Wifi miễn phí"))
                                    phongPhuHop = false;
                                break;

                            default:                             
                                break;
                        }
                    }
                }             
                if (phongPhuHop)
                {
                    UCThongTinPhongKhachSanUser uc = new UCThongTinPhongKhachSanUser(tmp);
                    flp.Controls.Add(uc);
                }
            }
            if (flp.Controls.Count == 0)
            {
                MessageBox.Show("Không có phòng nào phù hợp dành cho bạn!");
            }
        }
    }
    
}
