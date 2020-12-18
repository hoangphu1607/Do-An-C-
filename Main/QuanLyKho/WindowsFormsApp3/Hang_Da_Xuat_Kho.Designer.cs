namespace WindowsFormsApp3
{
    partial class Hang_Da_Xuat_Kho
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Hang_Xuat = new System.Windows.Forms.DataGridView();
            this.MaSoPhieuXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb_MaPhieuXuat = new System.Windows.Forms.ComboBox();
            this.dtb_ngaytim = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dt_ngaybt = new System.Windows.Forms.DateTimePicker();
            this.dt_ngaykt = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_chitietxuat = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hang_Xuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM";
            // 
            // dgv_Hang_Xuat
            // 
            this.dgv_Hang_Xuat.AllowUserToAddRows = false;
            this.dgv_Hang_Xuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Hang_Xuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hang_Xuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSoPhieuXuat,
            this.NgayLapPhieu,
            this.MaNhanVien,
            this.MaKhachHang});
            this.dgv_Hang_Xuat.Location = new System.Drawing.Point(140, 222);
            this.dgv_Hang_Xuat.Name = "dgv_Hang_Xuat";
            this.dgv_Hang_Xuat.ReadOnly = true;
            this.dgv_Hang_Xuat.RowHeadersVisible = false;
            this.dgv_Hang_Xuat.Size = new System.Drawing.Size(577, 395);
            this.dgv_Hang_Xuat.TabIndex = 1;
            this.dgv_Hang_Xuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hang_Xuat_CellClick);
            this.dgv_Hang_Xuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hang_Xuat_CellContentClick);
            // 
            // MaSoPhieuXuat
            // 
            this.MaSoPhieuXuat.DataPropertyName = "MaSoPhieuXuat";
            this.MaSoPhieuXuat.HeaderText = "MÃ PHIẾU";
            this.MaSoPhieuXuat.Name = "MaSoPhieuXuat";
            this.MaSoPhieuXuat.ReadOnly = true;
            // 
            // NgayLapPhieu
            // 
            this.NgayLapPhieu.DataPropertyName = "NgayLapPhieu";
            this.NgayLapPhieu.HeaderText = "Ngày Lập Phiếu";
            this.NgayLapPhieu.Name = "NgayLapPhieu";
            this.NgayLapPhieu.ReadOnly = true;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân VIên";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Mã Khách Hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.ReadOnly = true;
            // 
            // cbb_MaPhieuXuat
            // 
            this.cbb_MaPhieuXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_MaPhieuXuat.FormattingEnabled = true;
            this.cbb_MaPhieuXuat.ItemHeight = 13;
            this.cbb_MaPhieuXuat.Location = new System.Drawing.Point(24, 31);
            this.cbb_MaPhieuXuat.Name = "cbb_MaPhieuXuat";
            this.cbb_MaPhieuXuat.Size = new System.Drawing.Size(121, 21);
            this.cbb_MaPhieuXuat.TabIndex = 2;
            this.cbb_MaPhieuXuat.SelectedIndexChanged += new System.EventHandler(this.cbb_MaPhieuXuat_SelectedIndexChanged);
            // 
            // dtb_ngaytim
            // 
            this.dtb_ngaytim.CustomFormat = "MM-dd-yyyy";
            this.dtb_ngaytim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtb_ngaytim.Location = new System.Drawing.Point(24, 58);
            this.dtb_ngaytim.Name = "dtb_ngaytim";
            this.dtb_ngaytim.Size = new System.Drawing.Size(139, 20);
            this.dtb_ngaytim.TabIndex = 3;
            this.dtb_ngaytim.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_MaPhieuXuat);
            this.groupBox1.Controls.Add(this.dtb_ngaytim);
            this.groupBox1.Location = new System.Drawing.Point(298, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dt_ngaybt);
            this.groupBox2.Controls.Add(this.dt_ngaykt);
            this.groupBox2.Location = new System.Drawing.Point(796, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dt_ngaybt
            // 
            this.dt_ngaybt.CustomFormat = "MM-dd-yyyy";
            this.dt_ngaybt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaybt.Location = new System.Drawing.Point(31, 21);
            this.dt_ngaybt.Name = "dt_ngaybt";
            this.dt_ngaybt.Size = new System.Drawing.Size(139, 20);
            this.dt_ngaybt.TabIndex = 6;
            // 
            // dt_ngaykt
            // 
            this.dt_ngaykt.CustomFormat = "MM-dd-yyyy";
            this.dt_ngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaykt.Location = new System.Drawing.Point(31, 54);
            this.dt_ngaykt.Name = "dt_ngaykt";
            this.dt_ngaykt.Size = new System.Drawing.Size(139, 20);
            this.dt_ngaykt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(848, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1016, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Xuất Báo Cáo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_chitietxuat
            // 
            this.dgv_chitietxuat.AllowUserToAddRows = false;
            this.dgv_chitietxuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chitietxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitietxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.MaHang,
            this.SoLuong,
            this.DonGia});
            this.dgv_chitietxuat.Location = new System.Drawing.Point(725, 222);
            this.dgv_chitietxuat.MultiSelect = false;
            this.dgv_chitietxuat.Name = "dgv_chitietxuat";
            this.dgv_chitietxuat.ReadOnly = true;
            this.dgv_chitietxuat.RowHeadersVisible = false;
            this.dgv_chitietxuat.Size = new System.Drawing.Size(550, 395);
            this.dgv_chitietxuat.TabIndex = 12;
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã Phiếu";
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.ReadOnly = true;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
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
            // Hang_Da_Xuat_Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 650);
            this.Controls.Add(this.dgv_chitietxuat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Hang_Xuat);
            this.Controls.Add(this.label1);
            this.Name = "Hang_Da_Xuat_Kho";
            this.Text = "Hang_Da_Xuat_Kho";
            this.Load += new System.EventHandler(this.Hang_Da_Xuat_Kho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hang_Xuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietxuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Hang_Xuat;
        private System.Windows.Forms.ComboBox cbb_MaPhieuXuat;
        private System.Windows.Forms.DateTimePicker dtb_ngaytim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dt_ngaybt;
        private System.Windows.Forms.DateTimePicker dt_ngaykt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSoPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_chitietxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}