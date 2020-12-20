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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_ = new System.Windows.Forms.GroupBox();
            this.txt_manhom = new System.Windows.Forms.TextBox();
            this.txt_tennhom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_hanghoa = new System.Windows.Forms.DataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_sua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            this.txt_.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_.Location = new System.Drawing.Point(25, 110);
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
            this.txt_manhom.Size = new System.Drawing.Size(191, 29);
            this.txt_manhom.TabIndex = 4;
            // 
            // txt_tennhom
            // 
            this.txt_tennhom.Location = new System.Drawing.Point(552, 40);
            this.txt_tennhom.Name = "txt_tennhom";
            this.txt_tennhom.Size = new System.Drawing.Size(191, 29);
            this.txt_tennhom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nhóm Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhóm Hàng";
            // 
            // dgv_hanghoa
            // 
            this.dgv_hanghoa.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_hanghoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_hanghoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hanghoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_hanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hanghoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.TenNhom});
            this.dgv_hanghoa.Location = new System.Drawing.Point(25, 255);
            this.dgv_hanghoa.Name = "dgv_hanghoa";
            this.dgv_hanghoa.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hanghoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_hanghoa.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_hanghoa.Size = new System.Drawing.Size(757, 317);
            this.dgv_hanghoa.TabIndex = 18;
            this.dgv_hanghoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hanghoa_CellClick);
            this.dgv_hanghoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaNhom
            // 
            this.MaNhom.DataPropertyName = "MaNhom";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhom.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaNhom.HeaderText = "Mã Nhóm";
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.ReadOnly = true;
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenNhom";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhom.DefaultCellStyle = dataGridViewCellStyle4;
            this.TenNhom.HeaderText = "Tên Nhóm";
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.ReadOnly = true;
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(355, 216);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(83, 33);
            this.bt_sua.TabIndex = 19;
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
            this.label4.Location = new System.Drawing.Point(68, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(691, 46);
            this.label4.TabIndex = 20;
            this.label4.Text = "CẬP NHẬT THÔNG TIN NHÓM HÀNG";
            // 
            // CapNhat_NhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.dgv_hanghoa);
            this.Controls.Add(this.txt_);
            this.Name = "CapNhat_NhomHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Thông Tin Nhóm Hàng";
            this.Load += new System.EventHandler(this.CapNhat_NhomHang_Load);
            this.txt_.ResumeLayout(false);
            this.txt_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox txt_;
        private System.Windows.Forms.TextBox txt_manhom;
        private System.Windows.Forms.TextBox txt_tennhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_hanghoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.Label label4;
    }
}