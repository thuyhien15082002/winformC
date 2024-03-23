namespace GUI
{
    partial class Staff
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTaiKhoan = new TextBox();
            txtmatkhau = new TextBox();
            textBox_email = new TextBox();
            lblMaNV = new Label();
            button_them = new Button();
            button_sua = new Button();
            button_xoa = new Button();
            button_thoat = new Button();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(325, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(49, 83);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 142);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(371, 83);
            label4.Name = "label4";
            label4.Size = new Size(127, 23);
            label4.TabIndex = 3;
            label4.Text = "Mã nhân viên :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(371, 146);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 4;
            label5.Text = "Email :";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(152, 79);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(172, 27);
            txtTaiKhoan.TabIndex = 5;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(152, 142);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(172, 27);
            txtmatkhau.TabIndex = 6;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(441, 146);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(172, 27);
            textBox_email.TabIndex = 7;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(526, 85);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(42, 20);
            lblMaNV.TabIndex = 8;
            lblMaNV.Text = "MNV";
            // 
            // button_them
            // 
            button_them.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_them.Location = new Point(50, 191);
            button_them.Name = "button_them";
            button_them.Size = new Size(107, 39);
            button_them.TabIndex = 9;
            button_them.Text = "Thêm";
            button_them.UseVisualStyleBackColor = true;
            button_them.Click += button_them_Click;
            // 
            // button_sua
            // 
            button_sua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_sua.Location = new Point(241, 191);
            button_sua.Name = "button_sua";
            button_sua.Size = new Size(107, 39);
            button_sua.TabIndex = 10;
            button_sua.Text = "Sửa";
            button_sua.UseVisualStyleBackColor = true;
            button_sua.Click += button_sua_Click;
            // 
            // button_xoa
            // 
            button_xoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_xoa.Location = new Point(429, 191);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(107, 39);
            button_xoa.TabIndex = 11;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // button_thoat
            // 
            button_thoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_thoat.Location = new Point(614, 191);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(107, 39);
            button_thoat.TabIndex = 12;
            button_thoat.Text = "Thoát";
            button_thoat.UseVisualStyleBackColor = true;
            button_thoat.Click += button_thoat_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientActiveCaption;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(54, 246);
            label6.Name = "label6";
            label6.Size = new Size(667, 38);
            label6.TabIndex = 13;
            label6.Text = "                        Danh sách nhân viên                         ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(665, 253);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(button_thoat);
            Controls.Add(button_xoa);
            Controls.Add(button_sua);
            Controls.Add(button_them);
            Controls.Add(lblMaNV);
            Controls.Add(textBox_email);
            Controls.Add(txtmatkhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Location = new Point(241, 9);
            Name = "Staff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTaiKhoan;
        private TextBox txtmatkhau;
        private TextBox textBox_email;
        private Label lblMaNV;
        private Button button_them;
        private Button button_sua;
        private Button button_xoa;
        private Button button_thoat;
        private Label label6;
        private DataGridView dataGridView1;
        private Label label7;
    }
}