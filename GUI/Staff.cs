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

namespace GUI
{
    public partial class Staff : Form
    {
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        DTO.TaiKhoan taiKhoan = new DTO.TaiKhoan();
        public Staff()
        {
            InitializeComponent();
        }
        DatabaseAccess DatabaseAccess = new DatabaseAccess();
        private void Staff_Load(object sender, EventArgs e)
        {
            GridViewLoad();
        }

        public void GridViewLoad()
        {
            dataGridView1.DataSource = DatabaseAccess.Table("Select * from tbl_taikhoan where FK_iMaQuyen = 2");

        }

        private void lblMaNV_Click(object sender, EventArgs e)
        {

        }

        private void button_them_Click(object sender, EventArgs e)
        {
            DTO.TaiKhoan taiKhoan = new DTO.TaiKhoan();
            taiKhoan.sTaiKhoan = txtTaiKhoan.Text;
            taiKhoan.sMatKhau = txtmatkhau.Text;
            taiKhoan.sEmail = textBox_email.Text;
            string getuser = TKBLL.CheckLogic(taiKhoan);
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tai khoan khong duoc de trong ");
                    return;

                case "requeid_matkhau":
                    MessageBox.Show("Mat khau khong duoc de trong ");
                    return;
                case "requeid_email":
                    MessageBox.Show("Email khong duoc de trong ");
                    return;
            }

            bool added = TKBLL.CheckAddStaff(taiKhoan);
            if (added)
            {

                MessageBox.Show("Them thanh cong!");
                GridViewLoad();
                //dataGridView1.DataSource = DatabaseAccess.Table("Select * from tbl_taikhoan where FK_iMaQuyen = 2");
            }
            else
            {
                MessageBox.Show("Them khong thanh cong !");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTaiKhoan.Text = "";
            txtmatkhau.Text = "";
            lblMaNV.Text = "";
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtTaiKhoan.Text = Convert.ToString(row.Cells["sTaiKhoan"].Value);
            lblMaNV.Text = Convert.ToString(row.Cells["sMaTK"].Value);
            txtmatkhau.Text = Convert.ToString(row.Cells["sMatKhau"].Value);
            textBox_email.Text = Convert.ToString(row.Cells["sEmail"].Value);
        }

        private void button_sua_Click(object sender, EventArgs e)
        {

            DTO.TaiKhoan taiKhoan = new DTO.TaiKhoan();
            taiKhoan.sMaTK = lblMaNV.Text;
            taiKhoan.sTaiKhoan = txtTaiKhoan.Text;
            taiKhoan.sMatKhau = txtmatkhau.Text;
            taiKhoan.sEmail = textBox_email.Text;
            string getuser = TKBLL.CheckLogic(taiKhoan);
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tai khoan khong duoc de trong ");
                    return;

                case "requeid_matkhau":
                    MessageBox.Show("Mat khau khong duoc de trong ");
                    return;
                case "requeid_email":
                    MessageBox.Show("Email khong duoc de trong ");
                    return;
            }
            bool added = TKBLL.CheckUpdateStaff(taiKhoan);
            if (added)
            {

                MessageBox.Show("Sua thanh cong!");
                GridViewLoad();
                //dataGridView1.DataSource = DatabaseAccess.Table("Select * from tbl_taikhoan where FK_iMaQuyen = 2");
            }
            else
            {
                MessageBox.Show("Sua khong thanh cong !");
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {

            DTO.TaiKhoan taiKhoan = new DTO.TaiKhoan();
            taiKhoan.sMaTK = lblMaNV.Text;
            bool added = TKBLL.CheckDeleteStaff(taiKhoan);
            if (added)
            {
                MessageBox.Show("Xoa thanh cong!");
                GridViewLoad();
                //dataGridView1.DataSource = DatabaseAccess.Table("Select * from tbl_taikhoan where FK_iMaQuyen = 2");
            }
            else
            {
                MessageBox.Show("Xoa khong thanh cong !");
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat khong!", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
                if (Application.OpenForms["Form1"] == null)
                {
                    Form1 home = new Form1();
                    home.Show();
                }
                else
                {
                    // Nếu Form1 đã được tạo, thì đưa nó ra phía trước
                    Application.OpenForms["Form1"].BringToFront();
                }
            }
        }


    }
}
