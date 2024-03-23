namespace GUI
{
    partial class Bill
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(212, 655);
            button1.Name = "button1";
            button1.Size = new Size(94, 55);
            button1.TabIndex = 0;
            button1.Text = "Xuất";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(411, 206);
            dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 503);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 27);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(213, 25);
            label1.Name = "label1";
            label1.Size = new Size(107, 31);
            label1.TabIndex = 4;
            label1.Text = "Hoá đơn";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(139, 82);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(269, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(269, 27);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 147);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 7;
            label2.Text = "Người lập hoá đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 203);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 7;
            label3.Text = "Đơn hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 562);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "Tổng tiền";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(213, 555);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(269, 27);
            textBox3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 510);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 7;
            label5.Text = "Chiết khấu";
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 722);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Bill";
            Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
    }
}