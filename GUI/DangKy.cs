using BLL;
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
    public partial class DangKy : Form
    {
        //TaiKhoan taiKhoan1 = new TaiKhoan();
        DTO.TaiKhoan taiKhoan = new DTO.TaiKhoan();
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        public DangKy()
        {
            InitializeComponent();
        }

        private void tbnDangKy_Click(object sender, EventArgs e)
        {
            taiKhoan.sTaiKhoan = txtDKTaiKhoan.Text;
            taiKhoan.sMatKhau = txtDKMatKhau.Text;
            taiKhoan.sEmail = txtDKEmail.Text;
            if (txtDKMatKhau.Text != txtDKXNMatKhau.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không hợp lệ!!");
                return;
            }
            string getuser = TKBLL.checkRegisterExist(taiKhoan);
            // the hien tra lai ket qua neu khong dung
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tai khoan khong duoc de trong ");
                    return;
                case "requeid_matkhau":
                    MessageBox.Show("Mat khau khong duoc de trong ");
                    return;
                case "requeid_email":
                    MessageBox.Show("Email khong duoc de trong");
                    return;
                case "email_exist":
                    MessageBox.Show("Email da duoc su dung.Vui long nhap email khac!");
                    return;
            }
            bool register = TKBLL.checkRegister(taiKhoan);
            if (register)
            {
                if (MessageBox.Show("Dang ky thanh cong! Ban co muon dang nhap khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Dang ky khong thanh cong !");
            }

        }


    }
}
