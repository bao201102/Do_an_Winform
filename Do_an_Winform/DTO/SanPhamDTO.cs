using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
    class SanPhamDTO
    {
		private string _MaSP;
		public string MaSP
		{
			get { return _MaSP; }
			set { _MaSP = value; }
		}

		private string _TenSP;
		public string TenSP
		{
			get { return _TenSP; }
			set { _TenSP = value; }
		}

		private int _SoLuong;
		public int SoLuong
		{
			get { return _SoLuong; }
			set { _SoLuong = value; }
		}

		private int _DonGia;
		public int DonGia
		{
			get { return _DonGia; }
			set { _DonGia = value; }
		}

		private string _MaLoaiSP;
		public string MaLoaiSP
		{
			get { return _MaLoaiSP; }
			set { _MaLoaiSP = value; }
		}

		private string _MaNhaSX;
		public string MaNhaSX
		{
			get { return _MaNhaSX; }
			set { _MaNhaSX = value; }
		}

		private string _TrangThai;
		public string TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}

		public SanPhamDTO(string MaSP_, string TenSP_, int SoLuong_, int DonGia_, string MaLoaiSP_, string MaNhaSX_, string TrangThai_)
		{
			this.MaSP = MaSP_;
			this.TenSP = TenSP_;
			this.SoLuong = SoLuong_;
			this.DonGia = DonGia_;
			this.MaLoaiSP = MaLoaiSP_;
			this.MaNhaSX = MaNhaSX_;
			this.TrangThai = TrangThai_;
		}

		public SanPhamDTO()
        {
			this.MaSP = "";
			this.TenSP = "";
			this.SoLuong = 0;
			this.DonGia = 0;
			this.MaLoaiSP = "";
			this.MaNhaSX = "";
			this.TrangThai = "";
		}
	}
}
