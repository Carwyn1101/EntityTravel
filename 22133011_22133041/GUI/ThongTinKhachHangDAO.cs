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
        DateTime date = DateTime.Now;
        public void Them(ThongTinKhachHang kHang)
        {           
            dB.ThongTinKhachHangs.Add(kHang);            
            dB.SaveChanges();
        }
        public void LoadKhachHang(int idPhong, FlowLayoutPanel flp)
        {
            var ketQua = from c in dB.HoaDons where c.IDPhong == idPhong select c;
            foreach (var tmp in ketQua)
            {
                if (tmp.NgayNhanPhong.Value.Date >= date.Date)
                {
                    UCThongTinKhachHang uc = new UCThongTinKhachHang(tmp);
                    flp.Controls.Add(uc);
                }
            }
        }
    }
}
