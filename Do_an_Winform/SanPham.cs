//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Do_an_Winform
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.HoaDons = new HashSet<HoaDon>();
            this.PhieuNhapHangs = new HashSet<PhieuNhapHang>();
            this.PhieuXuatHangs = new HashSet<PhieuXuatHang>();
        }
    
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int DonGia { get; set; }
        public string MaLoaiSP { get; set; }
        public string MaTrangThai { get; set; }
        public string MaNhaSX { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public virtual NhaSanXuat NhaSanXuat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhapHang> PhieuNhapHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXuatHang> PhieuXuatHangs { get; set; }
        public virtual TrangThai TrangThai { get; set; }
    }
}
