using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
    class ChiTietPhieuXuatDTO
    {
		private string _MaPX;
		public string MaPX
		{
			get { return _MaPX; }
			set { _MaPX = value; }
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

		public ChiTietPhieuXuatDTO()
        {
			this.MaPX = "";
			this.MaSP = "";
			this.SoLuong = 0;
			this.MaNSX = "";
		}

		public ChiTietPhieuXuatDTO(string MaPX_, string MaSP_, int SoLuong_, string MaNSX_)
		{
			this.MaPX = MaPX_;
			this.MaSP = MaSP_;
			this.SoLuong = SoLuong_;
			this.MaNSX = MaNSX_;
		}
	}
}
