namespace GUI
{
    partial class TaiKhoan
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
            panel2 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            txtIDAccount = new TextBox();
            txtNameAccount = new TextBox();
            txtDayofBirth = new TextBox();
            txtPhone = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            btnRefresh = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            label1 = new Label();
            vScrollBar1 = new VScrollBar();
            dtgAccount = new DataGridView();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgAccount).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(rdNu);
            panel2.Controls.Add(rdNam);
            panel2.Controls.Add(txtIDAccount);
            panel2.Controls.Add(txtNameAccount);
            panel2.Controls.Add(txtDayofBirth);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Location = new Point(664, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 431);
            panel2.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Image = Properties.Resources.search;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(393, 357);
            button1.Name = "button1";
            button1.Size = new Size(94, 47);
            button1.TabIndex = 6;
            button1.Text = "Tìm kiếm";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 377);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 384);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Tìm kiếm";
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(267, 233);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(50, 24);
            rdNu.TabIndex = 3;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new Point(154, 233);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(62, 24);
            rdNam.TabIndex = 3;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // txtIDAccount
            // 
            txtIDAccount.BackColor = SystemColors.ButtonHighlight;
            txtIDAccount.Location = new Point(154, 24);
            txtIDAccount.Name = "txtIDAccount";
            txtIDAccount.ReadOnly = true;
            txtIDAccount.Size = new Size(188, 27);
            txtIDAccount.TabIndex = 2;
            // 
            // txtNameAccount
            // 
            txtNameAccount.BackColor = SystemColors.ButtonHighlight;
            txtNameAccount.Location = new Point(154, 91);
            txtNameAccount.Name = "txtNameAccount";
            txtNameAccount.Size = new Size(188, 27);
            txtNameAccount.TabIndex = 2;
            // 
            // txtDayofBirth
            // 
            txtDayofBirth.BackColor = SystemColors.ButtonHighlight;
            txtDayofBirth.Location = new Point(154, 301);
            txtDayofBirth.Name = "txtDayofBirth";
            txtDayofBirth.Size = new Size(188, 27);
            txtDayofBirth.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.ButtonHighlight;
            txtPhone.Location = new Point(154, 154);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(188, 27);
            txtPhone.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(19, 308);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 1;
            label7.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(19, 237);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 1;
            label6.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(19, 161);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 1;
            label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(19, 98);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(21, 24);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã khách hàng";
            // 
            // button2
            // 
            button2.Image = Properties.Resources.logout;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(375, 237);
            button2.Name = "button2";
            button2.Size = new Size(128, 44);
            button2.TabIndex = 0;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.refresh;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(375, 161);
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
            btnXoa.Location = new Point(375, 24);
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
            btnSua.Location = new Point(375, 91);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(128, 44);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 24);
            label1.Name = "label1";
            label1.Size = new Size(239, 29);
            label1.TabIndex = 12;
            label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(540, 17);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 341);
            vScrollBar1.TabIndex = 4;
            // 
            // dtgAccount
            // 
            dtgAccount.BackgroundColor = SystemColors.ButtonHighlight;
            dtgAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAccount.Location = new Point(15, 17);
            dtgAccount.Name = "dtgAccount";
            dtgAccount.RowHeadersWidth = 51;
            dtgAccount.RowTemplate.Height = 29;
            dtgAccount.Size = new Size(551, 387);
            dtgAccount.TabIndex = 0;
            dtgAccount.CellClick += dtgAccount_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(vScrollBar1);
            panel1.Controls.Add(dtgAccount);
            panel1.Location = new Point(51, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 431);
            panel1.TabIndex = 11;
            // 
            // TaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 532);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "TaiKhoan";
            Text = "Tài Khoản";
            Load += TaiKhoan_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgAccount).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button1;
        private TextBox textBox1;
        private Label label5;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private TextBox txtIDAccount;
        private TextBox txtNameAccount;
        private TextBox txtPhone;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnRefresh;
        private Button btnXoa;
        private Button btnSua;
        private Label label1;
        private VScrollBar vScrollBar1;
        private DataGridView dtgAccount;
        private Panel panel1;
        private TextBox txtDayofBirth;
        private Label label7;
        private Button button2;
    }
}