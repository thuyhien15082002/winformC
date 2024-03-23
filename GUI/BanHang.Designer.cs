namespace GUI
{
    partial class BanHang
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 36);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm sản phẩm";
            // 
            // button1
            // 
            button1.Location = new Point(355, 80);
            button1.Name = "button1";
            button1.Size = new Size(94, 48);
            button1.TabIndex = 2;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(413, 334);
            dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(505, 171);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(407, 257);
            dataGridView2.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(505, 478);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 27);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(505, 446);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 6;
            label2.Text = "Tổng tiền";
            // 
            // button2
            // 
            button2.Location = new Point(818, 446);
            button2.Name = "button2";
            button2.Size = new Size(94, 59);
            button2.TabIndex = 7;
            button2.Text = "Hoá đơn";
            button2.UseVisualStyleBackColor = true;
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 592);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "BanHang";
            Text = "BanHang";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox textBox2;
        private Label label2;
        private Button button2;
    }
}