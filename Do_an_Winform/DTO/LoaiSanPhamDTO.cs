using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
	public class LoaiSanPhamDTO
	{
		private string _MaLoaiSP;
		public string MaLoaiSP
		{
			get { return _MaLoaiSP; }
			set { _MaLoaiSP = value; }
		}

		private string _TenLoaiSP;
		public string TenLoaiSP
		{
			get { return _TenLoaiSP; }
			set { _TenLoaiSP = value; }
		}

		public LoaiSanPhamDTO()
        {
			this.MaLoaiSP = "";
			this.TenLoaiSP = "";
        }
		public LoaiSanPhamDTO(string MaLoaiSP_, string TenLoaiSP_)
		{
			this.MaLoaiSP = MaLoaiSP_;
			this.TenLoaiSP = TenLoaiSP_;
		}
	}
}
