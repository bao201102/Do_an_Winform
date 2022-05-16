using Do_an_Winform.BLL;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Nhanvien
{
    public partial class UserControlSanPham : UserControl
    {
        List<SanPhamDTO> listSanPham = new List<SanPhamDTO>();
        public UserControlSanPham()
        {
            InitializeComponent();
            dgvAllProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllProduct.ReadOnly = true;
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserControlSanPham_Load(object sender, EventArgs e)
        {
            listSanPham = SanPhamBLL.GetProduct();
            foreach(SanPhamDTO sanPham in listSanPham)
            {
                
            }
        }
    }
}
