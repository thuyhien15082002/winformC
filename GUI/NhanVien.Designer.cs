namespace GUI
{
    partial class NhanVien
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
            label4 = new Label();
            label5 = new Label();
            textBox_MaNhanVien = new TextBox();
            textBox_TaiKhoan = new TextBox();
            textBox_MatKhau = new TextBox();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            btn_resert = new Button();
            btn_thoat = new Button();
            label6 = new Label();
            dtgDSNV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgDSNV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(224, 9);
            label1.Name = "label1";
            label1.Size = new Size(309, 38);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Nhân Viên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 69);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(424, 69);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(39, 141);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 4;
            label5.Text = "Tài khoản :";
            // 
            // textBox_MaNhanVien
            // 
            textBox_MaNhanVien.Location = new Point(190, 70);
            textBox_MaNhanVien.Name = "textBox_MaNhanVien";
            textBox_MaNhanVien.Size = new Size(185, 27);
            textBox_MaNhanVien.TabIndex = 9;
            // 
            // textBox_TaiKhoan
            // 
            textBox_TaiKhoan.Location = new Point(190, 139);
            textBox_TaiKhoan.Name = "textBox_TaiKhoan";
            textBox_TaiKhoan.Size = new Size(185, 27);
            textBox_TaiKhoan.TabIndex = 10;
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Location = new Point(570, 69);
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.Size = new Size(185, 27);
            textBox_MatKhau.TabIndex = 11;
            // 
            // btn_them
            // 
            btn_them.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_them.Location = new Point(48, 222);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(86, 29);
            btn_them.TabIndex = 12;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sua.Location = new Point(190, 222);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(86, 29);
            btn_sua.TabIndex = 13;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_xoa.Location = new Point(349, 222);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(86, 29);
            btn_xoa.TabIndex = 14;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_resert
            // 
            btn_resert.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_resert.Location = new Point(499, 222);
            btn_resert.Name = "btn_resert";
            btn_resert.Size = new Size(86, 29);
            btn_resert.TabIndex = 15;
            btn_resert.Text = "Resert";
            btn_resert.UseVisualStyleBackColor = true;

            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thoat.Location = new Point(643, 222);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(86, 29);
            btn_thoat.TabIndex = 16;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Turquoise;
            label6.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(71, 279);
            label6.Name = "label6";
            label6.Size = new Size(658, 33);
            label6.TabIndex = 17;
            label6.Text = "                               Danh sách nhân viên                            ";
            // 
            // dtgDSNV
            // 
            dtgDSNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDSNV.Location = new Point(71, 315);
            dtgDSNV.Name = "dtgDSNV";
            dtgDSNV.RowHeadersWidth = 51;
            dtgDSNV.RowTemplate.Height = 29;
            dtgDSNV.Size = new Size(658, 216);
            dtgDSNV.TabIndex = 18;
            dtgDSNV.CellContentClick += dtgDSNV_CellContentClick;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 543);
            Controls.Add(dtgDSNV);
            Controls.Add(label6);
            Controls.Add(btn_thoat);
            Controls.Add(btn_resert);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(textBox_MatKhau);
            Controls.Add(textBox_TaiKhoan);
            Controls.Add(textBox_MaNhanVien);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhanVien";
            Load += NhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDSNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox_MaNhanVien;
        private TextBox textBox_TaiKhoan;
        private TextBox textBox_MatKhau;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_resert;
        private Button btn_thoat;
        private Label label6;
        private DataGridView dtgDSNV;
    }
}