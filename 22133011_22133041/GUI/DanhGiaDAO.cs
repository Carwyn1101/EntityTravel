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
        DoAnCuoiKyEntity dB = new DoAnCuoiKyEntity();
        public void LoadDataDanhGia(FlowLayoutPanel flpDanhGia, int iD)
        {
            var kSan = from p in dB.DanhGias
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
            dB.DanhGias.Add(dGia);
            dB.SaveChanges();
            MessageBox.Show("Thêm đánh giá thành công!");
        }
    }
}
