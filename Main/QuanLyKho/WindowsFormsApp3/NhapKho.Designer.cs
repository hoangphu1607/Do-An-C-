namespace WindowsFormsApp3
{
    partial class NhapKho
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ck_taoma = new System.Windows.Forms.CheckBox();
            this.txt_masophieu = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_nhacungcap = new System.Windows.Forms.ComboBox();
            this.cb_manhanvien = new System.Windows.Forms.ComboBox();
            this.txt_tennhanvien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.cb_masanpham = new System.Windows.Forms.ComboBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_tensanpham = new System.Windows.Forms.TextBox();
            this.txt_soluongnhap = new System.Windows.Forms.TextBox();
            this.txt_donvitinh = new System.Windows.Forms.TextBox();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.txt_masophieu);
            this.groupBox1.Controls.Add(this.ck_taoma);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_thanhtien);
            this.groupBox2.Controls.Add(this.txt_donvitinh);
            this.groupBox2.Controls.Add(this.txt_soluongnhap);
            this.groupBox2.Controls.Add(this.txt_tensanpham);
            this.groupBox2.Controls.Add(this.txt_dongia);
            this.groupBox2.Controls.Add(this.cb_masanpham);
            this.groupBox2.Controls.Add(this.bt_xoa);
            this.groupBox2.Controls.Add(this.bt_sua);
            this.groupBox2.Controls.Add(this.bt_them);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(38, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên nhân viên";
            // 
            // ck_taoma
            // 
            this.ck_taoma.AutoSize = true;
            this.ck_taoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_taoma.Location = new System.Drawing.Point(213, 25);
            this.ck_taoma.Name = "ck_taoma";
            this.ck_taoma.Size = new System.Drawing.Size(68, 17);
            this.ck_taoma.TabIndex = 5;
            this.ck_taoma.Text = "Tạo mã";
            this.ck_taoma.UseVisualStyleBackColor = true;
            // 
            // txt_masophieu
            // 
            this.txt_masophieu.Location = new System.Drawing.Point(107, 25);
            this.txt_masophieu.Name = "txt_masophieu";
            this.txt_masophieu.Size = new System.Drawing.Size(100, 20);
            this.txt_masophieu.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // cb_nhacungcap
            // 
            this.cb_nhacungcap.FormattingEnabled = true;
            this.cb_nhacungcap.Location = new System.Drawing.Point(107, 115);
            this.cb_nhacungcap.Name = "cb_nhacungcap";
            this.cb_nhacungcap.Size = new System.Drawing.Size(121, 21);
            this.cb_nhacungcap.TabIndex = 8;
            // 
            // cb_manhanvien
            // 
            this.cb_manhanvien.FormattingEnabled = true;
            this.cb_manhanvien.Location = new System.Drawing.Point(478, 40);
            this.cb_manhanvien.Name = "cb_manhanvien";
            this.cb_manhanvien.Size = new System.Drawing.Size(121, 21);
            this.cb_manhanvien.TabIndex = 9;
            // 
            // txt_tennhanvien
            // 
            this.txt_tennhanvien.Enabled = false;
            this.txt_tennhanvien.Location = new System.Drawing.Point(482, 115);
            this.txt_tennhanvien.Name = "txt_tennhanvien";
            this.txt_tennhanvien.Size = new System.Drawing.Size(100, 20);
            this.txt_tennhanvien.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Số lượng nhập";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Đơn vị tính";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(479, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Thành tiền";
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(180, 126);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.TabIndex = 6;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(290, 126);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 7;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(395, 126);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.TabIndex = 8;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            // 
            // cb_masanpham
            // 
            this.cb_masanpham.FormattingEnabled = true;
            this.cb_masanpham.Location = new System.Drawing.Point(113, 32);
            this.cb_masanpham.Name = "cb_masanpham";
            this.cb_masanpham.Size = new System.Drawing.Size(121, 21);
            this.cb_masanpham.TabIndex = 9;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Enabled = false;
            this.txt_dongia.Location = new System.Drawing.Point(113, 78);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(100, 20);
            this.txt_dongia.TabIndex = 10;
            // 
            // txt_tensanpham
            // 
            this.txt_tensanpham.Enabled = false;
            this.txt_tensanpham.Location = new System.Drawing.Point(369, 27);
            this.txt_tensanpham.Name = "txt_tensanpham";
            this.txt_tensanpham.Size = new System.Drawing.Size(185, 20);
            this.txt_tensanpham.TabIndex = 11;
            // 
            // txt_soluongnhap
            // 
            this.txt_soluongnhap.Location = new System.Drawing.Point(327, 77);
            this.txt_soluongnhap.Name = "txt_soluongnhap";
            this.txt_soluongnhap.Size = new System.Drawing.Size(100, 20);
            this.txt_soluongnhap.TabIndex = 12;
            // 
            // txt_donvitinh
            // 
            this.txt_donvitinh.Enabled = false;
            this.txt_donvitinh.Location = new System.Drawing.Point(627, 32);
            this.txt_donvitinh.Name = "txt_donvitinh";
            this.txt_donvitinh.Size = new System.Drawing.Size(100, 20);
            this.txt_donvitinh.TabIndex = 13;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Enabled = false;
            this.txt_thanhtien.Location = new System.Drawing.Point(544, 70);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(100, 20);
            this.txt_thanhtien.TabIndex = 14;
            // 
            // NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhapKho";
            this.Text = "NhapKho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tennhanvien;
        private System.Windows.Forms.ComboBox cb_manhanvien;
        private System.Windows.Forms.ComboBox cb_nhacungcap;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_masophieu;
        private System.Windows.Forms.CheckBox ck_taoma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.TextBox txt_donvitinh;
        private System.Windows.Forms.TextBox txt_soluongnhap;
        private System.Windows.Forms.TextBox txt_tensanpham;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.ComboBox cb_masanpham;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}