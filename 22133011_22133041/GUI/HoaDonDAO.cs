using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal class HoaDonDAO
    {
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();
        public void Them(HoaDon hDon)
        {
            db.HoaDons.Add(hDon);
            db.SaveChanges();
            MessageBox.Show("Thuê thành công!");
        }
        
    }
}
