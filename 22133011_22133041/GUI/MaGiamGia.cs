//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaGiamGia
    {
        public int STTMa { get; set; }
        public string MaGiam { get; set; }
        public Nullable<int> GiaTri { get; set; }
        public Nullable<int> IDKhachSan { get; set; }
    
        public virtual ThongTinKhachSan ThongTinKhachSan { get; set; }
    }
}