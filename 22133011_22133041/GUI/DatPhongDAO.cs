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
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();
        DateTime check = DateTime.Now;
        public void Them(DatPhong dPhong)
        {
            db.DatPhongs.Add(dPhong);
            db.SaveChanges();
        }
        public void Xoa(int maDatPhong)
        {
            var remove = db.DatPhongs.FirstOrDefault(k => k.MaDatPhong == maDatPhong);
            var trangThai = db.ThongTinPhongCuaKhachSans.FirstOrDefault(h=> h.IDPhong == remove.IDPhong);           
            db.SaveChanges();
            if (remove != null)
            {
                db.DatPhongs.Remove(remove);
                db.SaveChanges();
            }
            MessageBox.Show("Hủy phòng khách sạn thành công!");
        }
        public void TrangThaiLoad(object sender, EventArgs e)
        {
            var kq = from c in db.DatPhongs select c;
            foreach(var k in kq) 
            {
                if(k.NgayTraPhong < check)
                {
                    var trangThai = db.ThongTinPhongCuaKhachSans.FirstOrDefault(h => h.IDPhong == k.IDPhong);                  
                    
                }
            }
            db.SaveChanges();
        }
        public void LichSuBookLoad(FlowLayoutPanel flpLichSuBook)
        {
            var kq = from c in db.DatPhongs where c.IDKhachHang == Program.iDTaiKhoanInstance select c;
            foreach (var k in kq)
            {
                var tenKhachSan = db.ThongTinKhachSans.FirstOrDefault(tmp => tmp.IDKhachSan == k.IDKhachSan);
                var tenPhong = db.ThongTinPhongCuaKhachSans.FirstOrDefault(tmp => tmp.IDPhong == k.IDPhong);
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
