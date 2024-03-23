using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SanPham : Form
    {
        private ProductAccess productAccess;
        public SanPham()
        {
            InitializeComponent();
            productAccess = new ProductAccess();
        }

        private async void SanPham_Load(object sender, EventArgs e)
        {
            List<Product> products = await productAccess.GetAllProduct();

            dtgProduct.DataSource = products;
        }

        private void dtgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgProduct.Rows.Count)
            {
                DataGridViewRow selectedRow = dtgProduct.Rows[e.RowIndex];

                // Hiển thị giá trị từ mọi cột của dòng được chọn
                txtIDProduct.Text = selectedRow.Cells["mã sản phẩm"].Value.ToString();
                txtNamePro.Text = selectedRow.Cells["Tên sản phẩm"].Value.ToString();
                txtImportPrice.Text = selectedRow.Cells["Giá nhập"].Value.ToString();
                txtMaterial.Text = selectedRow.Cells["Chất liệu"].Value.ToString();
                txtExportPrice.Text = selectedRow.Cells["Giá bán"].Value.ToString();
                txtOrigin.Text = selectedRow.Cells["Xuất xứ"].Value.ToString();
                txtQuality.Text = selectedRow.Cells["Số lượng"].Value.ToString();
                txtSell.Text = selectedRow.Cells["Đã bán"].Value.ToString();

            }
        }

        private void dtgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
