using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
	public class ChiTietHoaDonDTO
	{
		private string _MaHD;
		public string MaHD
		{
			get { return _MaHD; }
			set { _MaHD = value; }
		}

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

		private int _ThanhTien;
		public int ThanhTien
		{
			get { return _ThanhTien; }
			set { _ThanhTien = value; }
		}

		private string _TrangThai;
		public string TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}

		
		public ChiTietHoaDonDTO()
		{
			this.MaHD = "";
			this.MaSP = "";
			this.TenSP = "";
			this.SoLuong = 0;
			this.ThanhTien = 0;
			this.TrangThai = "";
			

		}
		public ChiTietHoaDonDTO(string MaHD_, string MaSP_, string TenSP_, int SoLuong_, int ThanhTien_, string TrangThai_)
		{
			this.MaHD = MaHD_;
			this.MaSP = MaSP_;
			this.TenSP = TenSP_;
			this.SoLuong = SoLuong_;
			this.ThanhTien = ThanhTien_;
			this.TrangThai = TrangThai_;
			

		}
	}
}
