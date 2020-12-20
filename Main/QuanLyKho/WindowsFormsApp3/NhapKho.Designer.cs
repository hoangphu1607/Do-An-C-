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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_huy_phieu = new System.Windows.Forms.Button();
            this.bt_lap_phieu = new System.Windows.Forms.Button();
            this.bt_themPhieu = new System.Windows.Forms.Button();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.cb_tennv = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_masophieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_nhacungcap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lb_spmoi = new System.Windows.Forms.LinkLabel();
            this.nbu_sl = new System.Windows.Forms.NumericUpDown();
            this.txt_donvitinh = new System.Windows.Forms.TextBox();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.cb_tensp = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.dgv_NhapHang = new System.Windows.Forms.DataGridView();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_hoan_thanh = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbu_sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_huy_phieu);
            this.groupBox1.Controls.Add(this.bt_lap_phieu);
            this.groupBox1.Controls.Add(this.bt_themPhieu);
            this.groupBox1.Controls.Add(this.txt_manv);
            this.groupBox1.Controls.Add(this.cb_tennv);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txt_masophieu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(375, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_huy_phieu
            // 
            this.bt_huy_phieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy_phieu.Location = new System.Drawing.Point(566, 133);
            this.bt_huy_phieu.Name = "bt_huy_phieu";
            this.bt_huy_phieu.Size = new System.Drawing.Size(119, 40);
            this.bt_huy_phieu.TabIndex = 11;
            this.bt_huy_phieu.Text = "Hủy Phiếu";
            this.bt_huy_phieu.UseVisualStyleBackColor = true;
            this.bt_huy_phieu.Click += new System.EventHandler(this.bt_huy_phieu_Click);
            // 
            // bt_lap_phieu
            // 
            this.bt_lap_phieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lap_phieu.Location = new System.Drawing.Point(296, 133);
            this.bt_lap_phieu.Name = "bt_lap_phieu";
            this.bt_lap_phieu.Size = new System.Drawing.Size(119, 40);
            this.bt_lap_phieu.TabIndex = 12;
            this.bt_lap_phieu.Text = "Lập Phiếu";
            this.bt_lap_phieu.UseVisualStyleBackColor = true;
            this.bt_lap_phieu.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_themPhieu
            // 
            this.bt_themPhieu.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.daucong;
            this.bt_themPhieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_themPhieu.Location = new System.Drawing.Point(415, 33);
            this.bt_themPhieu.Name = "bt_themPhieu";
            this.bt_themPhieu.Size = new System.Drawing.Size(32, 29);
            this.bt_themPhieu.TabIndex = 11;
            this.bt_themPhieu.UseVisualStyleBackColor = true;
            this.bt_themPhieu.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_manv
            // 
            this.txt_manv.Enabled = false;
            this.txt_manv.Location = new System.Drawing.Point(695, 81);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(177, 26);
            this.txt_manv.TabIndex = 10;
            // 
            // cb_tennv
            // 
            this.cb_tennv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tennv.FormattingEnabled = true;
            this.cb_tennv.Location = new System.Drawing.Point(695, 35);
            this.cb_tennv.Name = "cb_tennv";
            this.cb_tennv.Size = new System.Drawing.Size(177, 28);
            this.cb_tennv.TabIndex = 9;
            this.cb_tennv.SelectedIndexChanged += new System.EventHandler(this.cb_manhanvien_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(294, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // txt_masophieu
            // 
            this.txt_masophieu.Enabled = false;
            this.txt_masophieu.Location = new System.Drawing.Point(294, 34);
            this.txt_masophieu.Name = "txt_masophieu";
            this.txt_masophieu.Size = new System.Drawing.Size(100, 26);
            this.txt_masophieu.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu mới";
            // 
            // cb_nhacungcap
            // 
            this.cb_nhacungcap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nhacungcap.FormattingEnabled = true;
            this.cb_nhacungcap.Location = new System.Drawing.Point(745, 114);
            this.cb_nhacungcap.Name = "cb_nhacungcap";
            this.cb_nhacungcap.Size = new System.Drawing.Size(224, 28);
            this.cb_nhacungcap.TabIndex = 8;
            this.cb_nhacungcap.SelectedIndexChanged += new System.EventHandler(this.cb_nhacungcap_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà cung cấp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.lb_spmoi);
            this.groupBox2.Controls.Add(this.nbu_sl);
            this.groupBox2.Controls.Add(this.txt_donvitinh);
            this.groupBox2.Controls.Add(this.cb_nhacungcap);
            this.groupBox2.Controls.Add(this.txt_masp);
            this.groupBox2.Controls.Add(this.txt_dongia);
            this.groupBox2.Controls.Add(this.cb_tensp);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(375, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(976, 187);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(289, 82);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 20);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Làm Mới";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lb_spmoi
            // 
            this.lb_spmoi.AutoSize = true;
            this.lb_spmoi.Location = new System.Drawing.Point(53, 82);
            this.lb_spmoi.Name = "lb_spmoi";
            this.lb_spmoi.Size = new System.Drawing.Size(156, 20);
            this.lb_spmoi.TabIndex = 16;
            this.lb_spmoi.TabStop = true;
            this.lb_spmoi.Text = "Thêm Sản Phẩm Mới";
            this.lb_spmoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_spmoi_LinkClicked);
            // 
            // nbu_sl
            // 
            this.nbu_sl.Location = new System.Drawing.Point(506, 116);
            this.nbu_sl.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nbu_sl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbu_sl.Name = "nbu_sl";
            this.nbu_sl.Size = new System.Drawing.Size(64, 26);
            this.nbu_sl.TabIndex = 15;
            this.nbu_sl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbu_sl.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txt_donvitinh
            // 
            this.txt_donvitinh.Enabled = false;
            this.txt_donvitinh.Location = new System.Drawing.Point(830, 44);
            this.txt_donvitinh.Name = "txt_donvitinh";
            this.txt_donvitinh.Size = new System.Drawing.Size(100, 26);
            this.txt_donvitinh.TabIndex = 13;
            // 
            // txt_masp
            // 
            this.txt_masp.Enabled = false;
            this.txt_masp.Location = new System.Drawing.Point(506, 44);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(179, 26);
            this.txt_masp.TabIndex = 11;
            this.txt_masp.TextChanged += new System.EventHandler(this.txt_tensanpham_TextChanged);
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(172, 115);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(186, 26);
            this.txt_dongia.TabIndex = 10;
            // 
            // cb_tensp
            // 
            this.cb_tensp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tensp.FormattingEnabled = true;
            this.cb_tensp.Location = new System.Drawing.Point(172, 44);
            this.cb_tensp.Name = "cb_tensp";
            this.cb_tensp.Size = new System.Drawing.Size(186, 28);
            this.cb_tensp.TabIndex = 9;
            this.cb_tensp.SelectedIndexChanged += new System.EventHandler(this.cb_masanpham_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(741, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Đơn vị tính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Số lượng nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã sản phẩm";
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(800, 508);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(119, 40);
            this.bt_xoa.TabIndex = 8;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(475, 508);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(119, 40);
            this.bt_them.TabIndex = 6;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dgv_NhapHang
            // 
            this.dgv_NhapHang.AllowUserToAddRows = false;
            this.dgv_NhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHang,
            this.MaHang,
            this.DonViTinh,
            this.SoLuong,
            this.DonGia});
            this.dgv_NhapHang.Location = new System.Drawing.Point(375, 565);
            this.dgv_NhapHang.Name = "dgv_NhapHang";
            this.dgv_NhapHang.Size = new System.Drawing.Size(976, 337);
            this.dgv_NhapHang.TabIndex = 9;
            this.dgv_NhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhapHang_CellClick);
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenHang.HeaderText = "Tên Sản Phẩm";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.Name = "MaHang";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonViTinh.DefaultCellStyle = dataGridViewCellStyle4;
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle5;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle6;
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // bt_hoan_thanh
            // 
            this.bt_hoan_thanh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_hoan_thanh.Location = new System.Drawing.Point(1091, 508);
            this.bt_hoan_thanh.Name = "bt_hoan_thanh";
            this.bt_hoan_thanh.Size = new System.Drawing.Size(119, 40);
            this.bt_hoan_thanh.TabIndex = 10;
            this.bt_hoan_thanh.Text = "Hoàn Thành";
            this.bt_hoan_thanh.UseVisualStyleBackColor = true;
            this.bt_hoan_thanh.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(718, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 46);
            this.label11.TabIndex = 22;
            this.label11.Text = "NHẬP KHO";
            // 
            // NhapKho
            // 
            this.AcceptButton = this.bt_hoan_thanh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1668, 925);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bt_hoan_thanh);
            this.Controls.Add(this.dgv_NhapHang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Name = "NhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Kho";
            this.Load += new System.EventHandler(this.NhapKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbu_sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.ComboBox cb_tennv;
        private System.Windows.Forms.ComboBox cb_nhacungcap;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_masophieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_donvitinh;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.ComboBox cb_tensp;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nbu_sl;
        private System.Windows.Forms.DataGridView dgv_NhapHang;
        private System.Windows.Forms.Button bt_hoan_thanh;
        private System.Windows.Forms.Button bt_themPhieu;
        private System.Windows.Forms.LinkLabel lb_spmoi;
        private System.Windows.Forms.Button bt_huy_phieu;
        private System.Windows.Forms.Button bt_lap_phieu;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Label label11;
    }
}