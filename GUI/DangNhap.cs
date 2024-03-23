using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;


namespace GUI
{
    public partial class DangNhap : Form
    {
        DTO.TaiKhoan taiKhoan = new DTO.TaiKhoan();
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        public DangNhap()
        {
            InitializeComponent();
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogic_Click(object sender, EventArgs e)
        {
            taiKhoan.sTaiKhoan = txtTaiKhoan.Text;
            taiKhoan.sMatKhau = txtMatKhau.Text;
            string getuser = TKBLL.CheckLogic(taiKhoan);
            int userQuyen = Int32.Parse(getuser);
            // the hien tra lai ket qua neu khong dung
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tai khoan khong duoc de trong ");
                    return;

                case "requeid_matkhau":
                    MessageBox.Show("Mat khau khong duoc de trong ");
                    return;

                case "Tai khoan hoac mat khau khong chinh xac!":
                    MessageBox.Show("Tai khoan hoac mat khau khong chinh xac !");
                    return;
            }
            MessageBox.Show("Ban da dang nhap thanh cong he thong !");
            this.Hide();

            if (userQuyen == 1)
            {
                Form1 form1 = new Form1();
                form1.Show();
            }
            if (userQuyen == 2)
            {
                //hiển thị form nhân viên
                SanPham form = new SanPham();
                form.Show();
            }
            //this.Close();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }


    }
}
