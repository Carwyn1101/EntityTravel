using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class ThongTinPhongKhachSanDAO
    {
        DoAnCuoiKyEntity db = new DoAnCuoiKyEntity();
        public List<UCThongTinPhongKhachSanUser> LoadData(int id)
        {
            List<UCThongTinPhongKhachSanUser> PhongList = new List<UCThongTinPhongKhachSanUser>();
            var kSan = from p in db.ThongTinPhongCuaKhachSans
                       where p.IDKhachSan == id
                       select p;
            foreach (var p in kSan)
            {
                UCThongTinPhongKhachSanUser uc = new UCThongTinPhongKhachSanUser(p);
                PhongList.Add(uc);
            }
            return PhongList;
        }
    }
}
