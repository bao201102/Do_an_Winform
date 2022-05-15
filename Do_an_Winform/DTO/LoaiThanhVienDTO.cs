using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
	public class LoaiThanhVienDTO
	{
		private string _MaLoaiTVien;
		public string MaLoaiTVien
		{
			get { return _MaLoaiTVien; }
			set { _MaLoaiTVien = value; }
		}

		private string _TenLoaiTVien;
		public string TenLoaiTVien
		{
			get { return _TenLoaiTVien; }
			set { _TenLoaiTVien = value; }
		}

		public LoaiThanhVienDTO()
        {
			this.MaLoaiTVien = "";
			this.TenLoaiTVien = "";
        }
		public LoaiThanhVienDTO(string MaLoaiTVien_, string TenLoaiTVien_)
		{
			this.MaLoaiTVien = MaLoaiTVien_;
			this.TenLoaiTVien = TenLoaiTVien_;
		}
	}
}
