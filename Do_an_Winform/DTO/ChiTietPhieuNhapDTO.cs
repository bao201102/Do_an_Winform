using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
    class ChiTietPhieuNhapDTO
    {
		private string _MaPN;
		public string MaPN
		{
			get { return _MaPN; }
			set { _MaPN = value; }
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

		private string _MaNSX;
		public string MaNSX
		{
			get { return _MaNSX; }
			set { _MaNSX = value; }
		}

		public ChiTietPhieuNhapDTO()
        {
			this.MaPN = "";
			this.MaSP = "";
			this.SoLuong = 0;
			this.MaNSX = "";
		}

		public ChiTietPhieuNhapDTO(string MaPN_, string MaSP_, int SoLuong_, string MaNSX_)
		{
			this.MaPN = MaPN_;
			this.MaSP = MaSP_;
			this.SoLuong = SoLuong_;
			this.MaNSX = MaNSX_;
		}
	}
}
