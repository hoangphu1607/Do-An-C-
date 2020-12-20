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
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hang_Xuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietxuat)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.cbb_MaPhieuXuat.ItemHeight = 21;
            this.cbb_MaPhieuXuat.Location = new System.Drawing.Point(25, 44);
            this.cbb_MaPhieuXuat.Name = "cbb_MaPhieuXuat";
            this.cbb_MaPhieuXuat.Size = new System.Drawing.Size(188, 29);
            this.cbb_MaPhieuXuat.TabIndex = 2;
            this.cbb_MaPhieuXuat.SelectedIndexChanged += new System.EventHandler(this.cbb_MaPhieuXuat_SelectedIndexChanged);
            // 
            // dtb_ngaytim
            // 
            this.dtb_ngaytim.CustomFormat = "MM-dd-yyyy";
            this.dtb_ngaytim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtb_ngaytim.Location = new System.Drawing.Point(36, 41);
            this.dtb_ngaytim.Name = "dtb_ngaytim";
            this.dtb_ngaytim.Size = new System.Drawing.Size(139, 29);
            this.dtb_ngaytim.TabIndex = 3;
            this.dtb_ngaytim.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_MaPhieuXuat);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(140, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Theo Đơn Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dt_ngaybt);
            this.groupBox2.Controls.Add(this.dt_ngaykt);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(780, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm Nhiều Ngày";
            // 
            // dt_ngaybt
            // 
            this.dt_ngaybt.CustomFormat = "MM-dd-yyyy";
            this.dt_ngaybt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaybt.Location = new System.Drawing.Point(19, 44);
            this.dt_ngaybt.Name = "dt_ngaybt";
            this.dt_ngaybt.Size = new System.Drawing.Size(139, 29);
            this.dt_ngaybt.TabIndex = 6;
            // 
            // dt_ngaykt
            // 
            this.dt_ngaykt.CustomFormat = "MM-dd-yyyy";
            this.dt_ngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaykt.Location = new System.Drawing.Point(205, 44);
            this.dt_ngaykt.Name = "dt_ngaykt";
            this.dt_ngaykt.Size = new System.Drawing.Size(139, 29);
            this.dt_ngaykt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1172, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(937, 625);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 37);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(531, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 46);
            this.label5.TabIndex = 21;
            this.label5.Text = "TÌM KIẾM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtb_ngaytim);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(503, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm Theo Ngày";
            // 
            // Hang_Da_Xuat_Kho
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1321, 674);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_chitietxuat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Hang_Xuat);
            this.Name = "Hang_Da_Xuat_Kho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Hàng Đã Xuất Kho";
            this.Load += new System.EventHandler(this.Hang_Da_Xuat_Kho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hang_Xuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietxuat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}