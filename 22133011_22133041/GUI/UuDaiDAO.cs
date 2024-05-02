using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    internal class UuDaiDAO
    {
        DoAnCuoiKyEntity dB = new DoAnCuoiKyEntity();
        public void Load(ThemUuDai f, int iDKSan)
        {
            var kq = from p in dB.MaGiamGias where p.IDKhachSan == iDKSan select new { p.STTMa, p.MaGiam, p.GiaTri };
            f.dtgvDanhSachMaGiam.DataSource = kq.ToList();
            f.dtgvDanhSachMaGiam.Refresh();        
        }
        public void AddBinding(ThemUuDai f)
        {
            f.txtMaGiamGia.DataBindings.Clear(); // Xóa các binding hiện có trước khi thêm mới
            f.cboGiaTriMa.DataBindings.Clear();
            f.txtMaGiamGia.DataBindings.Add(new Binding("Text", f.dtgvDanhSachMaGiam.DataSource, "MaGiam", true, DataSourceUpdateMode.Never));
            f.cboGiaTriMa.DataBindings.Add(new Binding("Text", f.dtgvDanhSachMaGiam.DataSource, "GiaTri", true, DataSourceUpdateMode.Never));
        }
        public void ThemUuDai(MaGiamGia f)
        {
            dB.MaGiamGias.Add(f);
            dB.SaveChanges();
            MessageBox.Show("Thêm Ưu Đãi Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void XoaUuDai(string maGiam)
        {
            var kq = (from p in dB.MaGiamGias where p.MaGiam == maGiam select p).SingleOrDefault();
            dB.MaGiamGias.Remove(kq);
            dB.SaveChanges();
            MessageBox.Show("Xóa Ưu Đãi Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void SuaUuDai(ThemUuDai f, int maGiam)
        {
            MaGiamGia mGiam = dB.MaGiamGias.Find(maGiam);
            mGiam.MaGiam = f.txtMaGiamGia.Text;
            mGiam.GiaTri = int.Parse(f.cboGiaTriMa.Text);           
            dB.SaveChanges();
            MessageBox.Show("Sửa Ưu Đãi Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public int? LoadGiaTriVoucher(int idKhachSan, string tenMa)
        {
            var ketQua = (from c in dB.MaGiamGias where c.IDKhachSan == idKhachSan && c.MaGiam == tenMa select c).SingleOrDefault();
            if (ketQua == null)
            {
                return 0;
            }    
            return ketQua.GiaTri;
        }
    }
}
