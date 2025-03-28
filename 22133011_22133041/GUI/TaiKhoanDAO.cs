﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class TaiKhoanDAO
    {
        DoAnCuoiKyEntity dB = new DoAnCuoiKyEntity();
        public void DangNhap(DangNhap f, string tenDangNhap,string loaiTaiKhoan) 
        {           
            var kq = (from c in dB.TaiKhoans where c.TenDangNhap == tenDangNhap select c).SingleOrDefault();
            Program.iDTaiKhoanInstance = kq.IDNguoiDung;
            if (f.txtTenDangNhap.Text == kq.TenDangNhap && f.txtMatKhau.Text == kq.MatKhau && kq.LoaiNguoiDung == loaiTaiKhoan)
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                f.Hide();
                if(kq.LoaiNguoiDung == "admin")
                {
                    TrangChuAdmin tChu = new TrangChuAdmin(kq.TenDangNhap, kq.IDNguoiDung);
                    tChu.ShowDialog();
                    tChu = null;
                    f.Close();
                }    
                else
                {
                    TrangChuUser tChu = new TrangChuUser(kq.TenDangNhap, kq.IDNguoiDung);
                    tChu.ShowDialog();
                    tChu = null;
                    f.Close();
                }                   
            }
            else
            {
                f.txtTenDangNhap.ResetText();
                f.txtMatKhau.ResetText();
                f.chkAccAdmin.Checked = false;
                f.chkAccUser.Checked = false;
                MessageBox.Show("Đăng nhập thất bại, vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }
    }
}
