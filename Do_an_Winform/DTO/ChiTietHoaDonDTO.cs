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

		private int _SoLuong;
		public int SoLuong
		{
			get { return _SoLuong; }
			set { _SoLuong = value; }
		}


		public ChiTietHoaDonDTO(string MaHD_, string MaSP_, int SoLuong_)
		{
			this.MaHD = MaHD_;
			this.MaSP = MaSP_;
			this.SoLuong = SoLuong_;
		}
		public ChiTietHoaDonDTO()
		{
			this.MaHD = "";
			this.MaSP = "";
			this.SoLuong = 0;
		}
	}
}
