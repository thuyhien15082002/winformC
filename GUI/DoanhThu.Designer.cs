namespace GUI
{
    partial class DoanhThu
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
            dataGridView1 = new DataGridView();
            Ngay = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            btnXuatFile = new Button();
            btnSapXep = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ngay, Column1, Column2, Column3 });
            dataGridView1.Location = new Point(42, 260);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(633, 459);
            dataGridView1.TabIndex = 18;
            // 
            // Ngay
            // 
            Ngay.HeaderText = "Ngày";
            Ngay.MinimumWidth = 6;
            Ngay.Name = "Ngay";
            Ngay.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "TenSP";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Giá";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Khách";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(321, 101);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 14;
            label2.Text = "Đến ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 27);
            label1.Name = "label1";
            label1.Size = new Size(107, 29);
            label1.TabIndex = 13;
            label1.Text = "THỐNG KÊ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(425, 96);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(42, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // btnXuatFile
            // 
            btnXuatFile.Image = Properties.Resources.import;
            btnXuatFile.ImageAlign = ContentAlignment.TopCenter;
            btnXuatFile.Location = new Point(552, 178);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(123, 55);
            btnXuatFile.TabIndex = 16;
            btnXuatFile.Text = "Xuất file PDF";
            btnXuatFile.TextImageRelation = TextImageRelation.TextAboveImage;
            btnXuatFile.UseVisualStyleBackColor = true;
            // 
            // btnSapXep
            // 
            btnSapXep.Image = Properties.Resources.sort;
            btnSapXep.ImageAlign = ContentAlignment.MiddleLeft;
            btnSapXep.Location = new Point(42, 181);
            btnSapXep.Name = "btnSapXep";
            btnSapXep.Size = new Size(123, 53);
            btnSapXep.TabIndex = 17;
            btnSapXep.Text = "Sắp xếp";
            btnSapXep.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.bar_chart;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(216, 181);
            button1.Name = "button1";
            button1.Size = new Size(123, 53);
            button1.TabIndex = 17;
            button1.Text = "  Thống kê";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.filter;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(377, 180);
            button2.Name = "button2";
            button2.Size = new Size(123, 53);
            button2.TabIndex = 17;
            button2.Text = "Lọc";
            button2.UseVisualStyleBackColor = true;
            // 
            // DoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 746);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnXuatFile);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSapXep);
            Name = "DoanhThu";
            Text = "Doanh Thu";
            Load += DoanhThu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Ngay;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button btnXuatFile;
        private Button btnSapXep;
        private Button button1;
        private Button button2;
    }
}