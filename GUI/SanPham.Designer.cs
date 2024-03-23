namespace GUI
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            panel1 = new Panel();
            vScrollBar1 = new VScrollBar();
            dtgProduct = new DataGridView();
            panel2 = new Panel();
            pbxAnh = new PictureBox();
            btnImage = new Button();
            label13 = new Label();
            txtOrigin = new TextBox();
            label12 = new Label();
            cboStatus = new ComboBox();
            cboDate = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cboCate = new ComboBox();
            txtIDProduct = new TextBox();
            txtNamePro = new TextBox();
            txtImportPrice = new TextBox();
            txtMaterial = new TextBox();
            txtSell = new TextBox();
            txtQuality = new TextBox();
            txtExportPrice = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnRefresh = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProduct).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxAnh).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(vScrollBar1);
            panel1.Controls.Add(dtgProduct);
            panel1.Location = new Point(24, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 307);
            panel1.TabIndex = 8;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(942, 17);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 266);
            vScrollBar1.TabIndex = 4;
            // 
            // dtgProduct
            // 
            dtgProduct.BackgroundColor = SystemColors.ButtonHighlight;
            dtgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProduct.Location = new Point(15, 17);
            dtgProduct.Name = "dtgProduct";
            dtgProduct.RowHeadersWidth = 51;
            dtgProduct.RowTemplate.Height = 29;
            dtgProduct.Size = new Size(953, 266);
            dtgProduct.TabIndex = 0;
            dtgProduct.CellClick += dtgProduct_CellClick;
            dtgProduct.CellContentClick += dtgProduct_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(pbxAnh);
            panel2.Controls.Add(btnImage);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txtOrigin);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(cboStatus);
            panel2.Controls.Add(cboDate);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(cboCate);
            panel2.Controls.Add(txtIDProduct);
            panel2.Controls.Add(txtNamePro);
            panel2.Controls.Add(txtImportPrice);
            panel2.Controls.Add(txtMaterial);
            panel2.Controls.Add(txtSell);
            panel2.Controls.Add(txtQuality);
            panel2.Controls.Add(txtExportPrice);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Location = new Point(27, 413);
            panel2.Name = "panel2";
            panel2.Size = new Size(987, 372);
            panel2.TabIndex = 10;
            // 
            // pbxAnh
            // 
            pbxAnh.Image = Properties.Resources.hoanghon;
            pbxAnh.Location = new Point(745, 196);
            pbxAnh.Name = "pbxAnh";
            pbxAnh.Size = new Size(219, 139);
            pbxAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxAnh.TabIndex = 10;
            pbxAnh.TabStop = false;
            // 
            // btnImage
            // 
            btnImage.Image = Properties.Resources.upload;
            btnImage.ImageAlign = ContentAlignment.MiddleLeft;
            btnImage.Location = new Point(876, 134);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(88, 41);
            btnImage.TabIndex = 9;
            btnImage.Text = "Chọn";
            btnImage.TextAlign = ContentAlignment.MiddleRight;
            btnImage.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(740, 144);
            label13.Name = "label13";
            label13.Size = new Size(103, 20);
            label13.TabIndex = 8;
            label13.Text = "Ảnh sản phẩm";
            // 
            // txtOrigin
            // 
            txtOrigin.BackColor = SystemColors.ButtonHighlight;
            txtOrigin.Location = new Point(817, 84);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(147, 27);
            txtOrigin.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(740, 91);
            label12.Name = "label12";
            label12.Size = new Size(59, 20);
            label12.TabIndex = 6;
            label12.Text = "Xuất xứ";
            // 
            // cboStatus
            // 
            cboStatus.BackColor = SystemColors.ButtonHighlight;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(542, 84);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(167, 28);
            cboStatus.TabIndex = 5;
            // 
            // cboDate
            // 
            cboDate.BackColor = SystemColors.ButtonHighlight;
            cboDate.FormattingEnabled = true;
            cboDate.Location = new Point(545, 134);
            cboDate.Name = "cboDate";
            cboDate.Size = new Size(167, 28);
            cboDate.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(403, 315);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 4;
            label11.Text = "Chất liệu";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(403, 261);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 4;
            label10.Text = "Đã bán";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(403, 199);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 4;
            label9.Text = "Số lượng nhập";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(407, 144);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 4;
            label8.Text = "Ngày nhập";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(407, 95);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 4;
            label7.Text = "Tình trạng";
            // 
            // cboCate
            // 
            cboCate.BackColor = SystemColors.ButtonHighlight;
            cboCate.FormattingEnabled = true;
            cboCate.Location = new Point(153, 191);
            cboCate.Name = "cboCate";
            cboCate.Size = new Size(189, 28);
            cboCate.TabIndex = 3;
            // 
            // txtIDProduct
            // 
            txtIDProduct.BackColor = SystemColors.ButtonHighlight;
            txtIDProduct.Location = new Point(154, 85);
            txtIDProduct.Name = "txtIDProduct";
            txtIDProduct.ReadOnly = true;
            txtIDProduct.Size = new Size(188, 27);
            txtIDProduct.TabIndex = 2;
            // 
            // txtNamePro
            // 
            txtNamePro.BackColor = SystemColors.ButtonHighlight;
            txtNamePro.Location = new Point(154, 137);
            txtNamePro.Name = "txtNamePro";
            txtNamePro.Size = new Size(188, 27);
            txtNamePro.TabIndex = 2;
            // 
            // txtImportPrice
            // 
            txtImportPrice.BackColor = SystemColors.ButtonHighlight;
            txtImportPrice.Location = new Point(154, 254);
            txtImportPrice.Name = "txtImportPrice";
            txtImportPrice.Size = new Size(188, 27);
            txtImportPrice.TabIndex = 2;
            // 
            // txtMaterial
            // 
            txtMaterial.BackColor = SystemColors.ButtonHighlight;
            txtMaterial.Location = new Point(542, 304);
            txtMaterial.Name = "txtMaterial";
            txtMaterial.Size = new Size(170, 27);
            txtMaterial.TabIndex = 2;
            // 
            // txtSell
            // 
            txtSell.BackColor = SystemColors.ButtonHighlight;
            txtSell.Location = new Point(542, 254);
            txtSell.Name = "txtSell";
            txtSell.Size = new Size(170, 27);
            txtSell.TabIndex = 2;
            // 
            // txtQuality
            // 
            txtQuality.BackColor = SystemColors.ButtonHighlight;
            txtQuality.Location = new Point(542, 192);
            txtQuality.Name = "txtQuality";
            txtQuality.Size = new Size(170, 27);
            txtQuality.TabIndex = 2;
            // 
            // txtExportPrice
            // 
            txtExportPrice.BackColor = SystemColors.ButtonHighlight;
            txtExportPrice.Location = new Point(154, 308);
            txtExportPrice.Name = "txtExportPrice";
            txtExportPrice.Size = new Size(188, 27);
            txtExportPrice.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(33, 311);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 1;
            label6.Text = "Giá xuất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(33, 261);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 1;
            label5.Text = "Giá nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(33, 199);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 1;
            label4.Text = "Danh mục";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(36, 144);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(36, 92);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã sản phẩm";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Image = Properties.Resources.refresh;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(584, 24);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(128, 44);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "  Nhập lại";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(403, 24);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(128, 44);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Image = Properties.Resources.edit;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(214, 24);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(128, 44);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(33, 24);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(128, 44);
            btnThem.TabIndex = 0;
            btnThem.Text = "  Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 30);
            label1.Name = "label1";
            label1.Size = new Size(211, 29);
            label1.TabIndex = 9;
            label1.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 815);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Name = "SanPham";
            Text = "Sản Phẩm";
            Load += SanPham_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgProduct).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private VScrollBar vScrollBar1;
        private DataGridView dtgProduct;
        private Panel panel2;
        private Button btnImage;
        private Label label13;
        private TextBox txtOrigin;
        private Label label12;
        private ComboBox cboStatus;
        private ComboBox cboDate;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox cboCate;
        private TextBox txtIDProduct;
        private TextBox txtNamePro;
        private TextBox txtImportPrice;
        private TextBox txtMaterial;
        private TextBox txtSell;
        private TextBox txtQuality;
        private TextBox txtExportPrice;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnRefresh;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private PictureBox pbxAnh;
    }
}