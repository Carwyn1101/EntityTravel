using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal class MaGiamGiaDAO
    {
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();
        public void Them(MaGiamGia giamGia)
        {
            db.MaGiamGias.Add(giamGia);
            db.SaveChanges();
            MessageBox.Show("Thêm thành công!");
        }
    }
}
