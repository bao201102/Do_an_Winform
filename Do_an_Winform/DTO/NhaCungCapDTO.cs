using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
    class NhaCungCapDTO
    {
		private string _MaNCC;
		public string MaNCC
		{
			get { return _MaNCC; }
			set { _MaNCC = value; }
		}

		private string _TenNCC;
		public string TenNCC
		{
			get { return _TenNCC; }
			set { _TenNCC = value; }
		}

		private string _SDT;
		public string SDT
		{
			get { return _SDT; }
			set { _SDT = value; }
		}

		private string _Email;
		public string Email
		{
			get { return _Email; }
			set { _Email = value; }
		}

		private string _DiaChi;
		public string DiaChi
		{
			get { return _DiaChi; }
			set { _DiaChi = value; }
		}

		private string _TrangThai;
		public string TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}
		public NhaCungCapDTO(string MaNCC_, string TenNCC_, string SDT_, string Email_, string DiaChi_, string TrangThai_)
		{
			this.MaNCC = MaNCC_;
			this.TenNCC = TenNCC_;
			this.SDT = SDT_;
			this.Email = Email_;
			this.DiaChi = DiaChi_;
			this.TrangThai = TrangThai_;
		}

		public NhaCungCapDTO()
        {
			this.MaNCC = "";
			this.TenNCC = "";
			this.SDT = "";
			this.Email = "";
			this.DiaChi = "";
			this.TrangThai = "";
		}
    }
}
