namespace WindowsFormsApp3
{
    partial class CapNhat_NhomHang
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
            this.txt_ = new System.Windows.Forms.GroupBox();
            this.txt_manhom = new System.Windows.Forms.TextBox();
            this.txt_tennhom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_hanghoa = new System.Windows.Forms.DataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_sua = new System.Windows.Forms.Button();
            this.txt_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_
            // 
            this.txt_.Controls.Add(this.txt_manhom);
            this.txt_.Controls.Add(this.txt_tennhom);
            this.txt_.Controls.Add(this.label2);
            this.txt_.Controls.Add(this.label1);
            this.txt_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_.Location = new System.Drawing.Point(25, 34);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(757, 100);
            this.txt_.TabIndex = 17;
            this.txt_.TabStop = false;
            this.txt_.Text = "Thông Tin Chung";
            // 
            // txt_manhom
            // 
            this.txt_manhom.Enabled = false;
            this.txt_manhom.Location = new System.Drawing.Point(173, 40);
            this.txt_manhom.Name = "txt_manhom";
            this.txt_manhom.Size = new System.Drawing.Size(191, 26);
            this.txt_manhom.TabIndex = 4;
            // 
            // txt_tennhom
            // 
            this.txt_tennhom.Location = new System.Drawing.Point(552, 40);
            this.txt_tennhom.Name = "txt_tennhom";
            this.txt_tennhom.Size = new System.Drawing.Size(191, 26);
            this.txt_tennhom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nhóm Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhóm Hàng";
            // 
            // dgv_hanghoa
            // 
            this.dgv_hanghoa.AllowUserToAddRows = false;
            this.dgv_hanghoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hanghoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.TenNhom});
            this.dgv_hanghoa.Location = new System.Drawing.Point(25, 203);
            this.dgv_hanghoa.Name = "dgv_hanghoa";
            this.dgv_hanghoa.Size = new System.Drawing.Size(757, 317);
            this.dgv_hanghoa.TabIndex = 18;
            this.dgv_hanghoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hanghoa_CellClick);
            this.dgv_hanghoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaNhom
            // 
            this.MaNhom.DataPropertyName = "MaNhom";
            this.MaNhom.HeaderText = "Mã Nhóm";
            this.MaNhom.Name = "MaNhom";
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "Tên Nhóm";
            this.TenNhom.Name = "TenNhom";
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(355, 154);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 19;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // CapNhat_NhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.dgv_hanghoa);
            this.Controls.Add(this.txt_);
            this.Name = "CapNhat_NhomHang";
            this.Text = "CapNhat_NhomHang";
            this.Load += new System.EventHandler(this.CapNhat_NhomHang_Load);
            this.txt_.ResumeLayout(false);
            this.txt_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hanghoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txt_;
        private System.Windows.Forms.TextBox txt_manhom;
        private System.Windows.Forms.TextBox txt_tennhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_hanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.Button bt_sua;
    }
}