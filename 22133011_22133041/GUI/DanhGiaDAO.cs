using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal class DanhGiaDAO
    {
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();
        public void LoadDataDanhGia(FlowLayoutPanel flpDanhGia, int iD)
        {
            var kSan = from p in db.DanhGias
                       where p.IDKhachSan == iD
                       select p;
            foreach (var p in kSan)
            {
                UCDanhGia uc = new UCDanhGia(p);
                flpDanhGia.Controls.Add(uc);
            }
        }
        public void Them(DanhGia dGia)
        {
            db.DanhGias.Add(dGia);
            db.SaveChanges();
            MessageBox.Show("Thêm đánh giá thành công!");
        }
    }
}
