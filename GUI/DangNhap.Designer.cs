namespace GUI
{
    partial class DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            btnRegister = new Button();
            btnThoat = new Button();
            btnLogic = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(320, 23);
            label1.Name = "label1";
            label1.Size = new Size(364, 41);
            label1.TabIndex = 7;
            label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avata;
            pictureBox1.Location = new Point(12, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnLogic);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTaiKhoan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 0, 192);
            groupBox1.Location = new Point(336, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(638, 250);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng nhập";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ActiveBorder;
            btnRegister.Location = new Point(241, 166);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(139, 47);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Đăng Ký";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ActiveBorder;
            btnThoat.Location = new Point(448, 166);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(139, 47);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnLogic
            // 
            btnLogic.BackColor = SystemColors.ActiveBorder;
            btnLogic.Location = new Point(33, 166);
            btnLogic.Name = "btnLogic";
            btnLogic.Size = new Size(139, 47);
            btnLogic.TabIndex = 4;
            btnLogic.Text = "Đăng Nhập";
            btnLogic.UseVisualStyleBackColor = false;
            btnLogic.Click += btnLogic_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.Location = new Point(6, 107);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(6, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(265, 107);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(322, 34);
            txtMatKhau.TabIndex = 3;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(265, 52);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(322, 34);
            txtTaiKhoan.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(71, 116);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 1;
            label3.Text = "Mật Khẩu :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(70, 55);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 0;
            label2.Text = "Tài Khoản :";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 450);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "DangNhap";
            Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Button btnLogic;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Button btnRegister;
        private Button btnThoat;
    }
}