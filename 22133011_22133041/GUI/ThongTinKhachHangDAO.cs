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
        DoAnCuoiKyEntity dB = new DoAnCuoiKyEntity();
        public void Them(ThongTinKhachHang kHang)
        {           
            dB.ThongTinKhachHangs.Add(kHang);            
            dB.SaveChanges();
        }
    }
}
