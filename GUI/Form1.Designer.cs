namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            MenuPro = new ToolStripMenuItem();
            MenuCate = new ToolStripMenuItem();
            MenuAcc = new ToolStripMenuItem();
            MenuAccInfo = new ToolStripMenuItem();
            menuUserInfo = new ToolStripMenuItem();
            MenuLogout = new ToolStripMenuItem();
            MenuRevenue = new ToolStripMenuItem();
            MenuHelp = new ToolStripMenuItem();
            label2 = new Label();
            label1 = new Label();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = SystemColors.ButtonFace;
            menu.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { MenuPro, MenuCate, MenuAcc, MenuRevenue, MenuHelp });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(712, 28);
            menu.TabIndex = 4;
            menu.Text = "menuStrip1";
            // 
            // MenuPro
            // 
            MenuPro.Name = "MenuPro";
            MenuPro.Size = new Size(87, 24);
            MenuPro.Text = "Sản phẩm";
            MenuPro.Click += MenuPro_Click;
            // 
            // MenuCate
            // 
            MenuCate.Name = "MenuCate";
            MenuCate.Size = new Size(90, 24);
            MenuCate.Text = "Danh mục";
            MenuCate.Click += MenuCate_Click;
            // 
            // MenuAcc
            // 
            MenuAcc.DropDownItems.AddRange(new ToolStripItem[] { MenuAccInfo, menuUserInfo, MenuLogout });
            MenuAcc.Name = "MenuAcc";
            MenuAcc.Size = new Size(86, 24);
            MenuAcc.Text = "Tài khoản";
            // 
            // MenuAccInfo
            // 
            MenuAccInfo.Name = "MenuAccInfo";
            MenuAccInfo.Size = new Size(231, 26);
            MenuAccInfo.Text = "Thông tin khách hàng";
            MenuAccInfo.Click += MenuAccInfo_Click;
            // 
            // menuUserInfo
            // 
            menuUserInfo.Name = "menuUserInfo";
            menuUserInfo.Size = new Size(231, 26);
            menuUserInfo.Text = "Thông tin nhân viên";
            menuUserInfo.Click += menuUserInfo_Click;
            // 
            // MenuLogout
            // 
            MenuLogout.Name = "MenuLogout";
            MenuLogout.Size = new Size(231, 26);
            MenuLogout.Text = "Đăng xuất";
            // 
            // MenuRevenue
            // 
            MenuRevenue.Name = "MenuRevenue";
            MenuRevenue.Size = new Size(91, 24);
            MenuRevenue.Text = "Doanh thu";
            MenuRevenue.Click += MenuRevenue_Click;
            // 
            // MenuHelp
            // 
            MenuHelp.Name = "MenuHelp";
            MenuHelp.Size = new Size(76, 24);
            MenuHelp.Text = "Trợ giúp";
            MenuHelp.Click += MenuHelp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 197);
            label2.Name = "label2";
            label2.Size = new Size(584, 39);
            label2.TabIndex = 6;
            label2.Text = "QUẢN LÝ CỬA HÀNG ÁO QUẦN c#";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(242, 128);
            label1.Name = "label1";
            label1.Size = new Size(162, 29);
            label1.TabIndex = 5;
            label1.Text = "XIN CHÀO ADMIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 450);
            Controls.Add(menu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quản Lý";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem MenuPro;
        private ToolStripMenuItem MenuCate;
        private ToolStripMenuItem MenuAcc;
        private ToolStripMenuItem MenuAccInfo;
        private ToolStripMenuItem MenuLogout;
        private ToolStripMenuItem MenuRevenue;
        private ToolStripMenuItem MenuHelp;
        private Label label2;
        private Label label1;
        private ToolStripMenuItem menuUserInfo;
    }
}
