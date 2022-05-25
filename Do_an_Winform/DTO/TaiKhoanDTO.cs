using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
	public class TaiKhoanDTO
	{
		private string _MaNguoiDung;
		public string MaNguoiDung
		{
			get { return _MaNguoiDung; }
			set { _MaNguoiDung = value; }
		}

		private string _UserName;
		public string UserName
		{
			get { return _UserName; }
			set { _UserName = value; }
		}

		private string _MatKhau;
		public string MatKhau
		{
			get { return _MatKhau; }
			set { _MatKhau = value; }
		}

		private string _MaLoaiNV;
		public string MaLoaiNV
		{
			get { return _MaLoaiNV; }
			set { _MaLoaiNV = value; }
		}

		public TaiKhoanDTO()
		{
			this.MaNguoiDung = "";
			this.UserName = "";
			this.MatKhau = "";
			this.MaLoaiNV = "";
		}
		public TaiKhoanDTO(string MaNguoiDung_, string UserName_, string MatKhau_, string MaLoaiNV_)
		{
			this.MaNguoiDung = MaNguoiDung_;
			this.UserName = UserName_;
			this.MatKhau = MatKhau_;
			this.MaLoaiNV = MaLoaiNV_;
		}
	}
}
