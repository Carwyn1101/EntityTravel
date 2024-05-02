using System;
using System.Collections.Generic;
using System.Linq;
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
            var trangThai = dB.ThongTinPhongCuaKhachSans.FirstOrDefault(h=> h.IDPhong == remove.IDPhong);
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
            var phongTrong = dB.ThongTinPhongCuaKhachSans.Where(p => p.IDKhachSan == Program.iDKhachSanInstance &&!dB.DatPhongs.Any(d => d.IDPhong == p.IDPhong && d.IDKhachSan == Program.iDKhachSanInstance &&
                                            ((ngayNhan >= d.NgayNhanPhong && ngayNhan < d.NgayTraPhong)||(ngayTra > d.NgayNhanPhong && ngayTra <= d.NgayTraPhong)))).ToList();

            foreach (var tmp in phongTrong)
            {
                UCThongTinPhongKhachSanUser uc = new UCThongTinPhongKhachSanUser(tmp);
                flp.Controls.Add(uc);
            }    
        }
    }
}
