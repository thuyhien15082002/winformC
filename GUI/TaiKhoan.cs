using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TaiKhoan : Form
    {
        private AccountBLL accountBLL;
        public TaiKhoan()
        {
            InitializeComponent();
            accountBLL = new AccountBLL();
        }
        public async void load()
        {
            List<Account> accounts = await accountBLL.GetAllAccount();

            dtgAccount.DataSource = accounts;
        }

        private async void TaiKhoan_Load(object sender, EventArgs e)
        {
            load();
        }




        private void dtgAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgAccount.Rows.Count)
            {
                DataGridViewRow selectedRow = dtgAccount.Rows[e.RowIndex];

                txtIDAccount.Text = selectedRow.Cells[0].Value.ToString();
                txtNameAccount.Text = selectedRow.Cells[1].Value.ToString();
                txtPhone.Text = selectedRow.Cells[2].Value.ToString();
                txtDayofBirth.Text = selectedRow.Cells[4].Value.ToString();



            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem txtIDAccount có chứa thông tin hay không
                if (string.IsNullOrWhiteSpace(txtIDAccount.Text))
                {
                    MessageBox.Show("Mã khách hàng rỗng.");
                    return;
                }

                string accIdToDelete = txtIDAccount.Text;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //await accountBLL.DeleteAccount(accIdToDelete);
                    load();

                    MessageBox.Show("Xoá thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }






        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có thông tin nào trống không
                if (string.IsNullOrWhiteSpace(txtIDAccount.Text) || string.IsNullOrWhiteSpace(txtNameAccount.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtDayofBirth.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Kiểm tra xem ID đã tồn tại chưa
                bool Exists = await accountBLL.AccExists(txtIDAccount.Text);

                if (!Exists)
                {
                    MessageBox.Show("ID không tồn tại. Vui lòng chọn một ID khác.");
                    return;
                }

                Account updated = new Account
                {
                    AccountID = txtIDAccount.Text,
                    AccountName = txtNameAccount.Text,
                    Phone = txtPhone.Text,
                    DateOfBirth = DateTime.TryParseExact(txtDayofBirth.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate) ? parsedDate : DateTime.MinValue
                };

                bool success = await accountBLL.UpdateAcc(updated);

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
            txtNameAccount.Text = "";
            txtPhone.Text = "";
            txtIDAccount.Text = "";
            txtDayofBirth.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
