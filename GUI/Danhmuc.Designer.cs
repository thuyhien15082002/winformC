
namespace GUI
{
    partial class Danhmuc
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
            label9 = new Label();
            txtIdCate = new TextBox();
            txtNameCate = new TextBox();
            txtDescription = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnRefresh = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            vScrollBar1 = new VScrollBar();
            dtgCate = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgCate).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(21, 195);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 4;
            label9.Text = "Mô tả";
            // 
            // txtIdCate
            // 
            txtIdCate.BackColor = SystemColors.ButtonHighlight;
            txtIdCate.Location = new Point(154, 36);
            txtIdCate.Name = "txtIdCate";
            txtIdCate.Size = new Size(188, 27);
            txtIdCate.TabIndex = 2;
            // 
            // txtNameCate
            // 
            txtNameCate.BackColor = SystemColors.ButtonHighlight;
            txtNameCate.Location = new Point(154, 112);
            txtNameCate.Name = "txtNameCate";
            txtNameCate.Size = new Size(188, 27);
            txtNameCate.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.ButtonHighlight;
            txtDescription.Location = new Point(154, 188);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(188, 27);
            txtDescription.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(33, 199);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(21, 119);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên danh mục";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(21, 36);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã danh mục";
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.refresh;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(584, 36);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(128, 44);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Nhập lại";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(584, 171);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(128, 44);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.edit;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(403, 171);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(128, 44);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.plus;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(403, 36);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(128, 44);
            btnThem.TabIndex = 0;
            btnThem.Text = "     Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 15);
            label1.Name = "label1";
            label1.Size = new Size(216, 29);
            label1.TabIndex = 9;
            label1.Text = "DANH SÁCH DANH MỤC";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(690, 17);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 266);
            vScrollBar1.TabIndex = 4;
            // 
            // dtgCate
            // 
            dtgCate.BackgroundColor = SystemColors.ButtonHighlight;
            dtgCate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCate.Location = new Point(15, 17);
            dtgCate.Name = "dtgCate";
            dtgCate.RowHeadersWidth = 51;
            dtgCate.RowTemplate.Height = 29;
            dtgCate.Size = new Size(701, 266);
            dtgCate.TabIndex = 0;
            dtgCate.CellClick += dtgCate_CellClick;

            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(vScrollBar1);
            panel1.Controls.Add(dtgCate);
            panel1.Location = new Point(20, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 307);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtIdCate);
            panel2.Controls.Add(txtNameCate);
            panel2.Controls.Add(txtDescription);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Location = new Point(20, 401);
            panel2.Name = "panel2";
            panel2.Size = new Size(732, 237);
            panel2.TabIndex = 10;
            // 
            // btnThoat
            // 
            btnThoat.Image = Properties.Resources.logout;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(488, 103);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(128, 44);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Danhmuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 669);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Danhmuc";
            Text = "Danh mục";
            Load += Danhmuc_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCate).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label9;
        private TextBox txtIdCate;
        private TextBox txtNameCate;
        private TextBox txtDescription;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnRefresh;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private VScrollBar vScrollBar1;
        private DataGridView dtgCate;
        private Panel panel1;
        private Panel panel2;
        private Button btnThoat;
    }
}