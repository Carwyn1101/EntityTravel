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
        DoAnCuoiKyEntity dB = new DoAnCuoiKyEntity();
        
        public void Them(HoaDon hDon)
        {
            dB.HoaDons.Add(hDon);
            dB.SaveChanges();
            MessageBox.Show("Đặt phòng thành công!");
        } 
        
    }
}
