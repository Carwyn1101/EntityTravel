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
            MessageBox.Show("Đặt phòng thành công, cám ơn quý khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Xoa(int maDatPhong)
        {
            var kQua = (from hD in dB.HoaDons
                        join dP in dB.DatPhongs on hD.IDPhong equals dP.IDPhong
                        where dP.MaDatPhong == maDatPhong 
                        select hD).FirstOrDefault();
            if (kQua != null)
            {
                dB.HoaDons.Remove(kQua);
                dB.SaveChanges();
            }
        }
    }
}
