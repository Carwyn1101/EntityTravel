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
        public void Them(DatPhong dPhong)
        {
            dB.DatPhongs.Add(dPhong);
            dB.SaveChanges();
        }
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
        public void TrangThaiLoad(object sender, EventArgs e)
        {
            var kq = from c in dB.DatPhongs select c;
            foreach(var k in kq) 
            {
                if(k.NgayTraPhong < check)
                {
                    var trangThai = dB.ThongTinPhongCuaKhachSans.FirstOrDefault(h => h.IDPhong == k.IDPhong);                  
                    
                }
            }
            dB.SaveChanges();
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
    }
}
