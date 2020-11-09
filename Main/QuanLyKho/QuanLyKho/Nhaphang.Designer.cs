namespace QuanLyKho
{
    partial class Nhaphang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tennhanvien = new System.Windows.Forms.TextBox();
            this.cb_manhanvien = new System.Windows.Forms.ComboBox();
            this.cb_nhacungcap = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_sophieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.txt_donvitinh = new System.Windows.Forms.TextBox();
            this.txt_soluongnhap = new System.Windows.Forms.TextBox();
            this.txt_tensanpham = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.cb_masanpham = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tennhanvien);
            this.groupBox1.Controls.Add(this.cb_manhanvien);
            this.groupBox1.Controls.Add(this.cb_nhacungcap);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txt_sophieu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(54, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(808, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_tennhanvien
            // 
            this.txt_tennhanvien.Enabled = false;
            this.txt_tennhanvien.Location = new System.Drawing.Point(581, 92);
            this.txt_tennhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tennhanvien.Name = "txt_tennhanvien";
            this.txt_tennhanvien.Size = new System.Drawing.Size(114, 27);
            this.txt_tennhanvien.TabIndex = 5;
            // 
            // cb_manhanvien
            // 
            this.cb_manhanvien.FormattingEnabled = true;
            this.cb_manhanvien.Location = new System.Drawing.Point(581, 37);
            this.cb_manhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_manhanvien.Name = "cb_manhanvien";
            this.cb_manhanvien.Size = new System.Drawing.Size(138, 28);
            this.cb_manhanvien.TabIndex = 8;
            // 
            // cb_nhacungcap
            // 
            this.cb_nhacungcap.FormattingEnabled = true;
            this.cb_nhacungcap.Location = new System.Drawing.Point(145, 144);
            this.cb_nhacungcap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_nhacungcap.Name = "cb_nhacungcap";
            this.cb_nhacungcap.Size = new System.Drawing.Size(138, 28);
            this.cb_nhacungcap.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 92);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 27);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(267, 28);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Tạo mã";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_sophieu
            // 
            this.txt_sophieu.Location = new System.Drawing.Point(104, 31);
            this.txt_sophieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sophieu.Name = "txt_sophieu";
            this.txt_sophieu.Size = new System.Drawing.Size(114, 27);
            this.txt_sophieu.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã nhân viên";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "NHẬP KHO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_xoa);
            this.groupBox2.Controls.Add(this.bt_sua);
            this.groupBox2.Controls.Add(this.bt_them);
            this.groupBox2.Controls.Add(this.txt_thanhtien);
            this.groupBox2.Controls.Add(this.txt_donvitinh);
            this.groupBox2.Controls.Add(this.txt_soluongnhap);
            this.groupBox2.Controls.Add(this.txt_tensanpham);
            this.groupBox2.Controls.Add(this.txt_dongia);
            this.groupBox2.Controls.Add(this.cb_masanpham);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(54, 267);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(819, 217);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(520, 187);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(86, 31);
            this.bt_xoa.TabIndex = 13;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(386, 187);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(86, 31);
            this.bt_sua.TabIndex = 12;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(237, 187);
            this.bt_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(86, 31);
            this.bt_them.TabIndex = 11;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Enabled = false;
            this.txt_thanhtien.Location = new System.Drawing.Point(698, 115);
            this.txt_thanhtien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(114, 27);
            this.txt_thanhtien.TabIndex = 10;
            // 
            // txt_donvitinh
            // 
            this.txt_donvitinh.Enabled = false;
            this.txt_donvitinh.Location = new System.Drawing.Point(696, 53);
            this.txt_donvitinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_donvitinh.Name = "txt_donvitinh";
            this.txt_donvitinh.Size = new System.Drawing.Size(114, 27);
            this.txt_donvitinh.TabIndex = 9;
            // 
            // txt_soluongnhap
            // 
            this.txt_soluongnhap.Location = new System.Drawing.Point(403, 108);
            this.txt_soluongnhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soluongnhap.Name = "txt_soluongnhap";
            this.txt_soluongnhap.Size = new System.Drawing.Size(114, 27);
            this.txt_soluongnhap.TabIndex = 8;
            // 
            // txt_tensanpham
            // 
            this.txt_tensanpham.Enabled = false;
            this.txt_tensanpham.Location = new System.Drawing.Point(399, 43);
            this.txt_tensanpham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tensanpham.Name = "txt_tensanpham";
            this.txt_tensanpham.Size = new System.Drawing.Size(114, 27);
            this.txt_tensanpham.TabIndex = 5;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Enabled = false;
            this.txt_dongia.Location = new System.Drawing.Point(88, 116);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(114, 27);
            this.txt_dongia.TabIndex = 7;
            // 
            // cb_masanpham
            // 
            this.cb_masanpham.FormattingEnabled = true;
            this.cb_masanpham.Location = new System.Drawing.Point(104, 47);
            this.cb_masanpham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_masanpham.Name = "cb_masanpham";
            this.cb_masanpham.Size = new System.Drawing.Size(138, 28);
            this.cb_masanpham.TabIndex = 6;
            this.cb_masanpham.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(615, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Thành tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(615, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Đơn vị tính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Số lượng nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tên sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã sản phẩm";
            // 
            // Nhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Nhaphang";
            this.Text = "Nhaphang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_sophieu;
        private System.Windows.Forms.ComboBox cb_manhanvien;
        private System.Windows.Forms.ComboBox cb_nhacungcap;
        private System.Windows.Forms.TextBox txt_tennhanvien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_masanpham;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.TextBox txt_donvitinh;
        private System.Windows.Forms.TextBox txt_soluongnhap;
        private System.Windows.Forms.TextBox txt_tensanpham;
        private System.Windows.Forms.TextBox txt_dongia;
    }
}