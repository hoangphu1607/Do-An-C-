namespace WindowsFormsApp3
{
    partial class CapNhat_HangHoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_HangHoa = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhomHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaXuatKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_donvitinh = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mancc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ = new System.Windows.Forms.GroupBox();
            this.txt_nhomhang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangHoa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.txt_.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_HangHoa
            // 
            this.dgv_HangHoa.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_HangHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_HangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_HangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.MaNhomHang,
            this.TenHang,
            this.DonViTinh,
            this.MaNhaCungCap,
            this.SoLuong,
            this.DonGia,
            this.GiaXuatKho});
            this.dgv_HangHoa.Location = new System.Drawing.Point(176, 381);
            this.dgv_HangHoa.Name = "dgv_HangHoa";
            this.dgv_HangHoa.ReadOnly = true;
            this.dgv_HangHoa.RowHeadersVisible = false;
            this.dgv_HangHoa.Size = new System.Drawing.Size(1131, 452);
            this.dgv_HangHoa.TabIndex = 1;
            this.dgv_HangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HangHoa_CellClick);
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaHang.HeaderText = "Mã Hàng Hóa";
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            // 
            // MaNhomHang
            // 
            this.MaNhomHang.DataPropertyName = "MaNhomHang";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhomHang.DefaultCellStyle = dataGridViewCellStyle4;
            this.MaNhomHang.HeaderText = "Mã Nhóm Hàng";
            this.MaNhomHang.Name = "MaNhomHang";
            this.MaNhomHang.ReadOnly = true;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHang.DefaultCellStyle = dataGridViewCellStyle5;
            this.TenHang.HeaderText = "Tên Hàng Hóa";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonViTinh.DefaultCellStyle = dataGridViewCellStyle6;
            this.DonViTinh.HeaderText = "Đơn Vị TÍnh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhaCungCap.DefaultCellStyle = dataGridViewCellStyle7;
            this.MaNhaCungCap.HeaderText = "Mã Nhà Cung Cấp";
            this.MaNhaCungCap.Name = "MaNhaCungCap";
            this.MaNhaCungCap.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle8;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle9;
            this.DonGia.HeaderText = "Đon Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // GiaXuatKho
            // 
            this.GiaXuatKho.DataPropertyName = "GiaXuatKho";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaXuatKho.DefaultCellStyle = dataGridViewCellStyle10;
            this.GiaXuatKho.HeaderText = "Giá Bán";
            this.GiaXuatKho.Name = "GiaXuatKho";
            this.GiaXuatKho.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_giaban);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_soLuong);
            this.groupBox2.Controls.Add(this.lb2);
            this.groupBox2.Controls.Add(this.txt_masp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_tensp);
            this.groupBox2.Controls.Add(this.txt_donvitinh);
            this.groupBox2.Controls.Add(this.txt_dongia);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(574, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 220);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txt_giaban
            // 
            this.txt_giaban.Location = new System.Drawing.Point(573, 177);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Size = new System.Drawing.Size(186, 29);
            this.txt_giaban.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Giá Bán";
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(188, 180);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(186, 29);
            this.txt_soLuong.TabIndex = 20;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(74, 180);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(85, 21);
            this.lb2.TabIndex = 19;
            this.lb2.Text = "Số Lượng";
            // 
            // txt_masp
            // 
            this.txt_masp.Enabled = false;
            this.txt_masp.Location = new System.Drawing.Point(188, 47);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(186, 29);
            this.txt_masp.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Sản Phẩm";
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(573, 46);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(186, 29);
            this.txt_tensp.TabIndex = 16;
            this.txt_tensp.TextChanged += new System.EventHandler(this.txt_tensp_TextChanged);
            // 
            // txt_donvitinh
            // 
            this.txt_donvitinh.Location = new System.Drawing.Point(573, 115);
            this.txt_donvitinh.Name = "txt_donvitinh";
            this.txt_donvitinh.Size = new System.Drawing.Size(138, 29);
            this.txt_donvitinh.TabIndex = 13;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(188, 115);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(186, 29);
            this.txt_dongia.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(461, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Đơn vị tính";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên sản phẩm";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đơn giá";
            // 
            // txt_mancc
            // 
            this.txt_mancc.Enabled = false;
            this.txt_mancc.Location = new System.Drawing.Point(208, 116);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(191, 29);
            this.txt_mancc.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mã Nhà Cung Cấp";
            // 
            // txt_
            // 
            this.txt_.Controls.Add(this.txt_mancc);
            this.txt_.Controls.Add(this.label5);
            this.txt_.Controls.Add(this.txt_nhomhang);
            this.txt_.Controls.Add(this.label1);
            this.txt_.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_.Location = new System.Drawing.Point(132, 92);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(417, 220);
            this.txt_.TabIndex = 13;
            this.txt_.TabStop = false;
            this.txt_.Text = "Thông Tin Chung";
            // 
            // txt_nhomhang
            // 
            this.txt_nhomhang.Enabled = false;
            this.txt_nhomhang.Location = new System.Drawing.Point(208, 50);
            this.txt_nhomhang.Name = "txt_nhomhang";
            this.txt_nhomhang.Size = new System.Drawing.Size(191, 29);
            this.txt_nhomhang.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhóm Hàng";
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(815, 318);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(108, 35);
            this.bt_xoa.TabIndex = 17;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(574, 318);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(108, 35);
            this.bt_sua.TabIndex = 16;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(413, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(655, 46);
            this.label4.TabIndex = 18;
            this.label4.Text = "CẬP NHẬT THÔNG TIN HÀNG HÓA";
            // 
            // CapNhat_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1483, 835);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_);
            this.Controls.Add(this.dgv_HangHoa);
            this.Name = "CapNhat_HangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Hàng Hóa";
            this.Load += new System.EventHandler(this.CapNhat_HangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangHoa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.txt_.ResumeLayout(false);
            this.txt_.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_HangHoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_mancc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_donvitinh;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox txt_;
        private System.Windows.Forms.TextBox txt_nhomhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txt_giaban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhomHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaXuatKho;
        private System.Windows.Forms.Label label4;
    }
}