namespace WindowsFormsApp3
{
    partial class KhachHang
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
            this.dgv_khachhang = new System.Windows.Forms.DataGridView();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_loaikh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_diachi = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_khachhang
            // 
            this.dgv_khachhang.AllowUserToAddRows = false;
            this.dgv_khachhang.AllowUserToDeleteRows = false;
            this.dgv_khachhang.AllowUserToResizeColumns = false;
            this.dgv_khachhang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_khachhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhachHang,
            this.TenKhach,
            this.SDT,
            this.DiaChi,
            this.LoaiKH});
            this.dgv_khachhang.Location = new System.Drawing.Point(373, 420);
            this.dgv_khachhang.Name = "dgv_khachhang";
            this.dgv_khachhang.Size = new System.Drawing.Size(832, 436);
            this.dgv_khachhang.TabIndex = 0;
            this.dgv_khachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khachhang_CellClick);
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaKhachHang.Frozen = true;
            this.MaKhachHang.HeaderText = "ID";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.ReadOnly = true;
            this.MaKhachHang.Width = 120;
            // 
            // TenKhach
            // 
            this.TenKhach.DataPropertyName = "TenKhach";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKhach.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenKhach.Frozen = true;
            this.TenKhach.HeaderText = "Tên Khách Hàng";
            this.TenKhach.Name = "TenKhach";
            this.TenKhach.ReadOnly = true;
            this.TenKhach.Width = 250;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDT.DefaultCellStyle = dataGridViewCellStyle4;
            this.SDT.Frozen = true;
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "Diachi";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChi.DefaultCellStyle = dataGridViewCellStyle5;
            this.DiaChi.Frozen = true;
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // LoaiKH
            // 
            this.LoaiKH.DataPropertyName = "LoaiKH";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiKH.DefaultCellStyle = dataGridViewCellStyle6;
            this.LoaiKH.Frozen = true;
            this.LoaiKH.HeaderText = "Loại Khách Hàng";
            this.LoaiKH.Name = "LoaiKH";
            this.LoaiKH.ReadOnly = true;
            this.LoaiKH.Width = 170;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_loaikh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbb_diachi);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_makh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(373, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Khách Hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbb_loaikh
            // 
            this.cbb_loaikh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loaikh.FormattingEnabled = true;
            this.cbb_loaikh.Items.AddRange(new object[] {
            "Khách Hàng Tiềm Năng",
            "Khách Hàng Thân Thiết"});
            this.cbb_loaikh.Location = new System.Drawing.Point(188, 135);
            this.cbb_loaikh.Name = "cbb_loaikh";
            this.cbb_loaikh.Size = new System.Drawing.Size(191, 28);
            this.cbb_loaikh.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Loại Khách Hàng";
            // 
            // cbb_diachi
            // 
            this.cbb_diachi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_diachi.FormattingEnabled = true;
            this.cbb_diachi.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Tĩnh",
            "Hải Dương",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái",
            "Phú Yên",
            "Cần Thơ",
            "Đà Nẵng",
            "Hải Phòng",
            "Hà Nội",
            "TP HCM"});
            this.cbb_diachi.Location = new System.Drawing.Point(552, 88);
            this.cbb_diachi.Name = "cbb_diachi";
            this.cbb_diachi.Size = new System.Drawing.Size(191, 28);
            this.cbb_diachi.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.daucong;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(351, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 29);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa Chỉ";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(188, 90);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(145, 26);
            this.txt_sdt.TabIndex = 5;
            this.txt_sdt.TextChanged += new System.EventHandler(this.txt_sdt_TextChanged);
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Điện Thoại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(552, 43);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(191, 26);
            this.txt_ten.TabIndex = 3;
            this.txt_ten.TextChanged += new System.EventHandler(this.txt_ten_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // txt_makh
            // 
            this.txt_makh.Enabled = false;
            this.txt_makh.Location = new System.Drawing.Point(188, 40);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(145, 26);
            this.txt_makh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(444, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm Vào Danh Sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(690, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Xóa Khỏi Danh Sách";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(925, 349);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "Hoàn Thành";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(573, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(405, 46);
            this.label6.TabIndex = 23;
            this.label6.Text = "THÊM KHÁCH HÀNG";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1675, 915);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_khachhang);
            this.Name = "KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Khách Hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KhachHang_FormClosed);
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_khachhang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbb_diachi;
        private System.Windows.Forms.ComboBox cbb_loaikh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKH;
        private System.Windows.Forms.Label label6;
    }
}