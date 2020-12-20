namespace WindowsFormsApp3
{
    partial class Hang_Nhap_Kho
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dt_ngaybt = new System.Windows.Forms.DateTimePicker();
            this.dt_ngaykt = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_MaPhieuXuat = new System.Windows.Forms.ComboBox();
            this.dtb_ngaytim = new System.Windows.Forms.DateTimePicker();
            this.dgv_Hang_Nhap = new System.Windows.Forms.DataGridView();
            this.MaSoPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_chitietnhap = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_baocao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hang_Nhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietnhap)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1110, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dt_ngaybt);
            this.groupBox2.Controls.Add(this.dt_ngaykt);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(664, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm Nhiều Ngày";
            // 
            // dt_ngaybt
            // 
            this.dt_ngaybt.CustomFormat = "MM-dd-yyyy";
            this.dt_ngaybt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaybt.Location = new System.Drawing.Point(24, 46);
            this.dt_ngaybt.Name = "dt_ngaybt";
            this.dt_ngaybt.Size = new System.Drawing.Size(139, 29);
            this.dt_ngaybt.TabIndex = 6;
            // 
            // dt_ngaykt
            // 
            this.dt_ngaykt.CustomFormat = "MM-dd-yyyy";
            this.dt_ngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaykt.Location = new System.Drawing.Point(232, 46);
            this.dt_ngaykt.Name = "dt_ngaykt";
            this.dt_ngaykt.Size = new System.Drawing.Size(139, 29);
            this.dt_ngaykt.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_MaPhieuXuat);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(119, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm KiếmTheo  Đơn Hàng";
            // 
            // cbb_MaPhieuXuat
            // 
            this.cbb_MaPhieuXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_MaPhieuXuat.FormattingEnabled = true;
            this.cbb_MaPhieuXuat.ItemHeight = 21;
            this.cbb_MaPhieuXuat.Location = new System.Drawing.Point(18, 39);
            this.cbb_MaPhieuXuat.Name = "cbb_MaPhieuXuat";
            this.cbb_MaPhieuXuat.Size = new System.Drawing.Size(189, 29);
            this.cbb_MaPhieuXuat.TabIndex = 2;
            this.cbb_MaPhieuXuat.SelectedIndexChanged += new System.EventHandler(this.cbb_MaPhieuXuat_SelectedIndexChanged);
            // 
            // dtb_ngaytim
            // 
            this.dtb_ngaytim.CustomFormat = "MM-dd-yyyy";
            this.dtb_ngaytim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtb_ngaytim.Location = new System.Drawing.Point(30, 39);
            this.dtb_ngaytim.Name = "dtb_ngaytim";
            this.dtb_ngaytim.Size = new System.Drawing.Size(155, 29);
            this.dtb_ngaytim.TabIndex = 3;
            this.dtb_ngaytim.ValueChanged += new System.EventHandler(this.dtb_ngaytim_ValueChanged);
            // 
            // dgv_Hang_Nhap
            // 
            this.dgv_Hang_Nhap.AllowUserToAddRows = false;
            this.dgv_Hang_Nhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Hang_Nhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Hang_Nhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hang_Nhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSoPhieuNhap,
            this.NgayLapPhieu,
            this.MaNhanVien});
            this.dgv_Hang_Nhap.Location = new System.Drawing.Point(119, 275);
            this.dgv_Hang_Nhap.MultiSelect = false;
            this.dgv_Hang_Nhap.Name = "dgv_Hang_Nhap";
            this.dgv_Hang_Nhap.ReadOnly = true;
            this.dgv_Hang_Nhap.RowHeadersVisible = false;
            this.dgv_Hang_Nhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Hang_Nhap.Size = new System.Drawing.Size(493, 359);
            this.dgv_Hang_Nhap.TabIndex = 7;
            this.dgv_Hang_Nhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hang_Xuat_CellClick);
            this.dgv_Hang_Nhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hang_Xuat_CellContentClick);
            // 
            // MaSoPhieuNhap
            // 
            this.MaSoPhieuNhap.DataPropertyName = "MaSoPhieuNhap";
            this.MaSoPhieuNhap.HeaderText = "MÃ PHIẾU";
            this.MaSoPhieuNhap.Name = "MaSoPhieuNhap";
            this.MaSoPhieuNhap.ReadOnly = true;
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
            // dgv_chitietnhap
            // 
            this.dgv_chitietnhap.AllowUserToAddRows = false;
            this.dgv_chitietnhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chitietnhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_chitietnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitietnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.MaHang,
            this.SoLuong,
            this.DonGia});
            this.dgv_chitietnhap.Location = new System.Drawing.Point(664, 275);
            this.dgv_chitietnhap.MultiSelect = false;
            this.dgv_chitietnhap.Name = "dgv_chitietnhap";
            this.dgv_chitietnhap.ReadOnly = true;
            this.dgv_chitietnhap.RowHeadersVisible = false;
            this.dgv_chitietnhap.Size = new System.Drawing.Size(633, 359);
            this.dgv_chitietnhap.TabIndex = 11;
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
            // bt_baocao
            // 
            this.bt_baocao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_baocao.Location = new System.Drawing.Point(926, 640);
            this.bt_baocao.Name = "bt_baocao";
            this.bt_baocao.Size = new System.Drawing.Size(159, 38);
            this.bt_baocao.TabIndex = 13;
            this.bt_baocao.Text = "Xuất Báo Cáo";
            this.bt_baocao.UseVisualStyleBackColor = true;
            this.bt_baocao.Click += new System.EventHandler(this.bt_baocao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(497, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 46);
            this.label5.TabIndex = 22;
            this.label5.Text = "TÌM KIẾM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtb_ngaytim);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(381, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 100);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm Theo Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(249, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "PHIẾU NHẬP HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(861, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "HÀNG ĐÃ NHẬP VÀO KHO";
            // 
            // Hang_Nhap_Kho
            // 
            this.AcceptButton = this.bt_baocao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1341, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_baocao);
            this.Controls.Add(this.dgv_chitietnhap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Hang_Nhap);
            this.Name = "Hang_Nhap_Kho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Hàng Nhập Kho";
            this.Load += new System.EventHandler(this.Hang_Nhap_Kho_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hang_Nhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietnhap)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dt_ngaybt;
        private System.Windows.Forms.DateTimePicker dt_ngaykt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_MaPhieuXuat;
        private System.Windows.Forms.DateTimePicker dtb_ngaytim;
        private System.Windows.Forms.DataGridView dgv_Hang_Nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSoPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridView dgv_chitietnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Button bt_baocao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}