//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace nhom_cnpm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        public string MaSP { get; set; }
        public string MaNCC { get; set; }
        public string MaLoai { get; set; }
        public string TenSP { get; set; }
        public string MoTaSP { get; set; }
        public string AnhDaiDien { get; set; }
        public Nullable<int> DonGia { get; set; }
        public string DonViTinh { get; set; }
    
        public virtual Loai Loai { get; set; }
        public virtual NCC NCC { get; set; }
    }
}
