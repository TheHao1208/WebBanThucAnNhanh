//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyThucAnNhanh.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TinTuc
    {
        public int Ma { get; set; }
        public string TieuDe { get; set; }
        public string MoTaNgan { get; set; }
        public string MoTa { get; set; }
        public string Anh { get; set; }
        public int MaCM { get; set; }
        public Nullable<System.DateTime> NgayDang { get; set; }
        public string TacGia { get; set; }
    
        public virtual ChuyenMuc ChuyenMuc { get; set; }
    }
}
