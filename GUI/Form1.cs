namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuPro_Click(object sender, EventArgs e)
        {
            SanPham product = new SanPham();
            product.Show();

        }

        private void MenuCate_Click(object sender, EventArgs e)
        {
            Danhmuc danhmuc = new Danhmuc();
            danhmuc.Show();
        }

        private void MenuAccInfo_Click(object sender, EventArgs e)
        {
            TaiKhoan taikhoan = new TaiKhoan();
            taikhoan.Show();
        }

        private void MenuRevenue_Click(object sender, EventArgs e)
        {
            DoanhThu doanhthu = new DoanhThu();
            doanhthu.Show();
        }


        private void MenuHelp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuUserInfo_Click(object sender, EventArgs e)
        {
            Staff nv = new Staff();
            nv.GridViewLoad();
            nv.Show();
        }
    }
}
