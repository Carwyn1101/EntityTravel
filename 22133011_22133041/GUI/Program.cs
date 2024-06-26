﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        public static TrangChuAdmin TrangChuAdminInstance;
        public static XemPhongCuaKhachSan XemPhongCuaKhachSanInstance;
        public static LichSuBook LichSuBookInstance;
        public static FlowLayoutPanel flpPhongInstance;
        public static ChiTietKhachSanUser ChiTietKhachSanUserInstance;
        public static int iDTaiKhoanInstance;
        public static int iDKhachSanInstance;
        public static int iDPhongInstance;
        public static DateTime ngayNhanInstance;
        public static DateTime ngayTraInstance;
        // public static 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);          
            Application.Run(new DangNhap());
            TrangChuAdminInstance = new TrangChuAdmin();
            ChiTietKhachSanUserInstance = new ChiTietKhachSanUser();
            XemPhongCuaKhachSanInstance = new XemPhongCuaKhachSan();
            LichSuBookInstance = new LichSuBook();
            flpPhongInstance = new FlowLayoutPanel();
        }       
    }
}
