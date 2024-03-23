using BLL;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Danhmuc : Form
    {

        private CategoryBLL categoryBLL;
        public Danhmuc()
        {
            InitializeComponent();
            categoryBLL = new CategoryBLL();
        }

        public async void load()
        {
            List<Category> categories = await categoryBLL.GetAllCategories();

            dtgCate.DataSource = categories;
        }
        private async void Danhmuc_Load(object sender, EventArgs e)
        {
            load();

        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có thông tin nào trống không
                if (string.IsNullOrWhiteSpace(txtIdCate.Text) || string.IsNullOrWhiteSpace(txtNameCate.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Kiểm tra xem ID đã tồn tại chưa
                if (await categoryBLL.CategoryExists(txtIdCate.Text))
                {
                    MessageBox.Show("ID đã tồn tại. Vui lòng chọn một ID khác.");
                    return;
                }

                Category category = new Category
                {
                    CategoryID = txtIdCate.Text,
                    CategoryName = txtNameCate.Text,
                    Description = txtDescription.Text
                };

                bool success = await categoryBLL.InsertCategory(category);

                if (success)
                {
                    load();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }




        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có thông tin nào trống không
                if (string.IsNullOrWhiteSpace(txtIdCate.Text) || string.IsNullOrWhiteSpace(txtNameCate.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Kiểm tra xem ID đã tồn tại chưa
                bool categoryExists = await categoryBLL.CategoryExists(txtIdCate.Text);

                if (!categoryExists)
                {
                    MessageBox.Show("ID không tồn tại. Vui lòng chọn một ID khác hoặc thêm mới danh mục.");
                    return;
                }

                Category updatedCategory = new Category
                {
                    CategoryID = txtIdCate.Text,
                    CategoryName = txtNameCate.Text,
                    Description = txtDescription.Text
                };

                bool success = await categoryBLL.UpdateCategory(updatedCategory);

                if (success)
                {
                    load();
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }





        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtIdCate.Text = "";
            txtNameCate.Text = "";
            txtDescription.Text = "";
        }

        private void dtgCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgCate.Rows.Count)
            {
                DataGridViewRow selectedRow = dtgCate.Rows[e.RowIndex];

                // Hiển thị giá trị từ mọi cột của dòng được chọn
                txtIdCate.Text = selectedRow.Cells[0].Value.ToString();
                txtNameCate.Text = selectedRow.Cells[1].Value.ToString();
                txtDescription.Text = selectedRow.Cells[2].Value.ToString();
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem txtIdCate có chứa thông tin hay không
                if (string.IsNullOrWhiteSpace(txtIdCate.Text))
                {
                    MessageBox.Show("Mã danh mục rỗng.");
                    return;
                }

                string categoryIdToDelete = txtIdCate.Text;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //await categoryBLL.DeleteCategory(categoryIdToDelete);
                    load();

                    MessageBox.Show("Xoá thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }





        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                base.Close();
            }
        }


    }
}
