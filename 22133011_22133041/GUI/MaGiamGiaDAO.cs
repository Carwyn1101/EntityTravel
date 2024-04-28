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
        DoAnCuoiKyEntity dB = new DoAnCuoiKyEntity();
        public void Them(MaGiamGia giamGia)
        {
            dB.MaGiamGias.Add(giamGia);
            dB.SaveChanges();
            MessageBox.Show("Thêm thành công!");
        }
    }
}
