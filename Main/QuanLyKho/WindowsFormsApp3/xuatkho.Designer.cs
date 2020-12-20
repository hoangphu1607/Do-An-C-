namespace WindowsFormsApp3
{
    partial class xuatkho
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
            this.cb_tenKH = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.cb_tennv = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_masophieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_ttsp = new System.Windows.Forms.GroupBox();
            this.txt_slTon = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_nhacc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nbu_slXuat = new System.Windows.Forms.NumericUpDown();
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
            this.label12 = new System.Windows.Forms.Label();
            this.dgv_xuatkho = new System.Windows.Forms.DataGridView();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_hoanThanh = new System.Windows.Forms.Button();
            this.bt_huy_phieu = new System.Windows.Forms.Button();
            this.bt_lap_phieu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_giamgia = new System.Windows.Forms.Label();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_ttsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbu_slXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xuatkho)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_tenKH);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_maKH);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_manv);
            this.groupBox1.Controls.Add(this.cb_tennv);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txt_masophieu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(98, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1135, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cb_tenKH
            // 
            this.cb_tenKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tenKH.FormattingEnabled = true;
            this.cb_tenKH.Location = new System.Drawing.Point(540, 48);
            this.cb_tenKH.Name = "cb_tenKH";
            this.cb_tenKH.Size = new System.Drawing.Size(173, 29);
            this.cb_tenKH.TabIndex = 21;
            this.cb_tenKH.SelectedIndexChanged += new System.EventHandler(this.cb_tenKH_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.daucong;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(292, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 29);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mã Khách Hàng";
            // 
            // txt_maKH
            // 
            this.txt_maKH.Enabled = false;
            this.txt_maKH.Location = new System.Drawing.Point(540, 87);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(173, 29);
            this.txt_maKH.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(387, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 21);
            this.label13.TabIndex = 11;
            this.label13.Text = "Tên Khách Hàng";
            // 
            // txt_manv
            // 
            this.txt_manv.Enabled = false;
            this.txt_manv.Location = new System.Drawing.Point(916, 89);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(206, 29);
            this.txt_manv.TabIndex = 10;
            // 
            // cb_tennv
            // 
            this.cb_tennv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tennv.FormattingEnabled = true;
            this.cb_tennv.Location = new System.Drawing.Point(916, 44);
            this.cb_tennv.Name = "cb_tennv";
            this.cb_tennv.Size = new System.Drawing.Size(206, 29);
            this.cb_tennv.TabIndex = 8;
            this.cb_tennv.SelectedIndexChanged += new System.EventHandler(this.cb_tennv_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 29);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_masophieu
            // 
            this.txt_masophieu.Enabled = false;
            this.txt_masophieu.Location = new System.Drawing.Point(138, 48);
            this.txt_masophieu.Name = "txt_masophieu";
            this.txt_masophieu.Size = new System.Drawing.Size(136, 29);
            this.txt_masophieu.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(780, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên nhân viên";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(780, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu";
            // 
            // gb_ttsp
            // 
            this.gb_ttsp.Controls.Add(this.txt_slTon);
            this.gb_ttsp.Controls.Add(this.label14);
            this.gb_ttsp.Controls.Add(this.cb_nhacc);
            this.gb_ttsp.Controls.Add(this.label11);
            this.gb_ttsp.Controls.Add(this.nbu_slXuat);
            this.gb_ttsp.Controls.Add(this.txt_donvitinh);
            this.gb_ttsp.Controls.Add(this.txt_masp);
            this.gb_ttsp.Controls.Add(this.txt_dongia);
            this.gb_ttsp.Controls.Add(this.cb_tensp);
            this.gb_ttsp.Controls.Add(this.label10);
            this.gb_ttsp.Controls.Add(this.label9);
            this.gb_ttsp.Controls.Add(this.label8);
            this.gb_ttsp.Controls.Add(this.label7);
            this.gb_ttsp.Controls.Add(this.label6);
            this.gb_ttsp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ttsp.Location = new System.Drawing.Point(98, 239);
            this.gb_ttsp.Name = "gb_ttsp";
            this.gb_ttsp.Size = new System.Drawing.Size(1135, 150);
            this.gb_ttsp.TabIndex = 2;
            this.gb_ttsp.TabStop = false;
            this.gb_ttsp.Text = "Thông tin sản phẩm";
            // 
            // txt_slTon
            // 
            this.txt_slTon.Enabled = false;
            this.txt_slTon.Location = new System.Drawing.Point(745, 89);
            this.txt_slTon.Name = "txt_slTon";
            this.txt_slTon.Size = new System.Drawing.Size(120, 29);
            this.txt_slTon.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(627, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 21);
            this.label14.TabIndex = 17;
            this.label14.Text = "Số Lượng Tồn";
            // 
            // cb_nhacc
            // 
            this.cb_nhacc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nhacc.FormattingEnabled = true;
            this.cb_nhacc.Location = new System.Drawing.Point(916, 33);
            this.cb_nhacc.Name = "cb_nhacc";
            this.cb_nhacc.Size = new System.Drawing.Size(206, 29);
            this.cb_nhacc.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(776, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 21);
            this.label11.TabIndex = 15;
            this.label11.Text = "Nhà Cung Cấp";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // nbu_slXuat
            // 
            this.nbu_slXuat.Location = new System.Drawing.Point(496, 89);
            this.nbu_slXuat.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.nbu_slXuat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbu_slXuat.Name = "nbu_slXuat";
            this.nbu_slXuat.Size = new System.Drawing.Size(120, 29);
            this.nbu_slXuat.TabIndex = 14;
            this.nbu_slXuat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_donvitinh
            // 
            this.txt_donvitinh.Enabled = false;
            this.txt_donvitinh.Location = new System.Drawing.Point(1002, 92);
            this.txt_donvitinh.Name = "txt_donvitinh";
            this.txt_donvitinh.Size = new System.Drawing.Size(120, 29);
            this.txt_donvitinh.TabIndex = 13;
            this.txt_donvitinh.TextChanged += new System.EventHandler(this.txt_donvitinh_TextChanged);
            // 
            // txt_masp
            // 
            this.txt_masp.Enabled = false;
            this.txt_masp.Location = new System.Drawing.Point(496, 38);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(173, 29);
            this.txt_masp.TabIndex = 11;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Enabled = false;
            this.txt_dongia.Location = new System.Drawing.Point(170, 92);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(136, 29);
            this.txt_dongia.TabIndex = 10;
            // 
            // cb_tensp
            // 
            this.cb_tensp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tensp.FormattingEnabled = true;
            this.cb_tensp.Location = new System.Drawing.Point(170, 38);
            this.cb_tensp.Name = "cb_tensp";
            this.cb_tensp.Size = new System.Drawing.Size(174, 29);
            this.cb_tensp.TabIndex = 9;
            this.cb_tensp.SelectedIndexChanged += new System.EventHandler(this.cb_tensp_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(884, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Đơn vị tính";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Số lượng Xuất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã sản phẩm";
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(608, 395);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(120, 43);
            this.bt_xoa.TabIndex = 8;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(379, 395);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(120, 43);
            this.bt_them.TabIndex = 6;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(577, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 36);
            this.label12.TabIndex = 3;
            this.label12.Text = "XUẤT KHO";
            // 
            // dgv_xuatkho
            // 
            this.dgv_xuatkho.AllowUserToAddRows = false;
            this.dgv_xuatkho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_xuatkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_xuatkho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHang,
            this.MaHang,
            this.TenNhaCungCap,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgv_xuatkho.Location = new System.Drawing.Point(98, 461);
            this.dgv_xuatkho.Name = "dgv_xuatkho";
            this.dgv_xuatkho.ReadOnly = true;
            this.dgv_xuatkho.Size = new System.Drawing.Size(1135, 441);
            this.dgv_xuatkho.TabIndex = 9;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên Sản Phẩm";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã Sản Phẩm";
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            this.TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            this.TenNhaCungCap.HeaderText = "Nhà Cung Cấp";
            this.TenNhaCungCap.Name = "TenNhaCungCap";
            this.TenNhaCungCap.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // bt_hoanThanh
            // 
            this.bt_hoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_hoanThanh.Location = new System.Drawing.Point(815, 395);
            this.bt_hoanThanh.Name = "bt_hoanThanh";
            this.bt_hoanThanh.Size = new System.Drawing.Size(148, 43);
            this.bt_hoanThanh.TabIndex = 10;
            this.bt_hoanThanh.Text = "Hoàn Thành";
            this.bt_hoanThanh.UseVisualStyleBackColor = true;
            this.bt_hoanThanh.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_huy_phieu
            // 
            this.bt_huy_phieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy_phieu.Location = new System.Drawing.Point(706, 183);
            this.bt_huy_phieu.Name = "bt_huy_phieu";
            this.bt_huy_phieu.Size = new System.Drawing.Size(119, 40);
            this.bt_huy_phieu.TabIndex = 22;
            this.bt_huy_phieu.Text = "Hủy Phiếu";
            this.bt_huy_phieu.UseVisualStyleBackColor = true;
            this.bt_huy_phieu.Click += new System.EventHandler(this.bt_huy_phieu_Click);
            // 
            // bt_lap_phieu
            // 
            this.bt_lap_phieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lap_phieu.Location = new System.Drawing.Point(436, 183);
            this.bt_lap_phieu.Name = "bt_lap_phieu";
            this.bt_lap_phieu.Size = new System.Drawing.Size(119, 40);
            this.bt_lap_phieu.TabIndex = 23;
            this.bt_lap_phieu.Text = "Lập Phiếu";
            this.bt_lap_phieu.UseVisualStyleBackColor = true;
            this.bt_lap_phieu.Click += new System.EventHandler(this.bt_lap_phieu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_giamgia);
            this.groupBox2.Controls.Add(this.txt_ThanhTien);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1347, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 252);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TỔNG TIỀN";
            // 
            // lb_giamgia
            // 
            this.lb_giamgia.AutoSize = true;
            this.lb_giamgia.Location = new System.Drawing.Point(56, 209);
            this.lb_giamgia.Name = "lb_giamgia";
            this.lb_giamgia.Size = new System.Drawing.Size(0, 22);
            this.lb_giamgia.TabIndex = 2;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Enabled = false;
            this.txt_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhTien.ForeColor = System.Drawing.Color.Red;
            this.txt_ThanhTien.Location = new System.Drawing.Point(51, 108);
            this.txt_ThanhTien.Multiline = true;
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(219, 97);
            this.txt_ThanhTien.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label15.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label15.Location = new System.Drawing.Point(44, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(237, 40);
            this.label15.TabIndex = 0;
            this.label15.Text = "THÀNH TIỀN";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1055, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 43);
            this.button1.TabIndex = 25;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // xuatkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1677, 931);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_huy_phieu);
            this.Controls.Add(this.bt_hoanThanh);
            this.Controls.Add(this.bt_lap_phieu);
            this.Controls.Add(this.dgv_xuatkho);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gb_ttsp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.bt_xoa);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "xuatkho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất Kho";
            this.Load += new System.EventHandler(this.xuatkho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_ttsp.ResumeLayout(false);
            this.gb_ttsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbu_slXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xuatkho)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.ComboBox cb_tennv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_ttsp;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_masophieu;
        private System.Windows.Forms.ComboBox cb_tenKH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nbu_slXuat;
        private System.Windows.Forms.ComboBox cb_nhacc;
        private System.Windows.Forms.DataGridView dgv_xuatkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button bt_hoanThanh;
        private System.Windows.Forms.TextBox txt_slTon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bt_huy_phieu;
        private System.Windows.Forms.Button bt_lap_phieu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_giamgia;
    }
}