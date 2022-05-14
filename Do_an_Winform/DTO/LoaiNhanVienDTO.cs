using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
	public class LoaiNhanVienDTO
	{
		private string _MaLoaiNV;
		public string MaLoaiNV
		{
			get { return _MaLoaiNV; }
			set { _MaLoaiNV = value; }
		}

		private string _TenLoaiNV;
		public string TenLoaiNV
		{
			get { return _TenLoaiNV; }
			set { _TenLoaiNV = value; }
		}

		public LoaiNhanVienDTO()
        {
			this.MaLoaiNV = "";
			this.TenLoaiNV = "";
        }
		public LoaiNhanVienDTO(string MaLoaiNV_, string TenLoaiNV_)
		{
			this.MaLoaiNV = MaLoaiNV_;
			this.TenLoaiNV = TenLoaiNV_;
		}
	}
}
