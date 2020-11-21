namespace WindowsFormsApp3
{
    partial class ThongTinHangHoa
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
            this.dgv_HangHoa = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhomHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_HangHoa
            // 
            this.dgv_HangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.MaNhomHang,
            this.TenHang,
            this.DonViTinh,
            this.MaNhaCungCap,
            this.SoLuong,
            this.DonGia});
            this.dgv_HangHoa.Location = new System.Drawing.Point(417, 144);
            this.dgv_HangHoa.Name = "dgv_HangHoa";
            this.dgv_HangHoa.Size = new System.Drawing.Size(872, 452);
            this.dgv_HangHoa.TabIndex = 0;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaHang.HeaderText = "Mã Hàng Hóa";
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            // 
            // MaNhomHang
            // 
            this.MaNhomHang.DataPropertyName = "MaNhomHang";
            this.MaNhomHang.HeaderText = "Mã Nhóm Hàng";
            this.MaNhomHang.Name = "MaNhomHang";
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên Hàng Hóa";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn Vị TÍnh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            this.MaNhaCungCap.HeaderText = "Mã Nhà Cung Cấp";
            this.MaNhaCungCap.Name = "MaNhaCungCap";
            this.MaNhaCungCap.ReadOnly = true;
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
            this.DonGia.HeaderText = "Đon Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThongTinHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 930);
            this.Controls.Add(this.dgv_HangHoa);
            this.Name = "ThongTinHangHoa";
            this.Text = "ThongTinHangHoa";
            this.Load += new System.EventHandler(this.ThongTinHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_HangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhomHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}