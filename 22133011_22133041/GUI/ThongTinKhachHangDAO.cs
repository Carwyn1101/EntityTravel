using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal class ThongTinKhachHangDAO
    {
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();
        public void Them(ThongTinKhachHang kHang)
        {           
            db.ThongTinKhachHangs.Add(kHang);            
            db.SaveChanges();
           // MessageBox.Show("Thuê thành công!");
        }

    }
}
