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
            this.cbb_MaPhieuXuat = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hang_Xuat)).BeginInit();
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
            this.dgv_Hang_Xuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hang_Xuat.Location = new System.Drawing.Point(250, 213);
            this.dgv_Hang_Xuat.Name = "dgv_Hang_Xuat";
            this.dgv_Hang_Xuat.Size = new System.Drawing.Size(872, 395);
            this.dgv_Hang_Xuat.TabIndex = 1;
            // 
            // cbb_MaPhieuXuat
            // 
            this.cbb_MaPhieuXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_MaPhieuXuat.FormattingEnabled = true;
            this.cbb_MaPhieuXuat.ItemHeight = 13;
            this.cbb_MaPhieuXuat.Location = new System.Drawing.Point(324, 109);
            this.cbb_MaPhieuXuat.Name = "cbb_MaPhieuXuat";
            this.cbb_MaPhieuXuat.Size = new System.Drawing.Size(121, 21);
            this.cbb_MaPhieuXuat.TabIndex = 2;
            this.cbb_MaPhieuXuat.SelectedIndexChanged += new System.EventHandler(this.cbb_MaPhieuXuat_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(562, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Hang_Da_Xuat_Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 650);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbb_MaPhieuXuat);
            this.Controls.Add(this.dgv_Hang_Xuat);
            this.Controls.Add(this.label1);
            this.Name = "Hang_Da_Xuat_Kho";
            this.Text = "Hang_Da_Xuat_Kho";
            this.Load += new System.EventHandler(this.Hang_Da_Xuat_Kho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hang_Xuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Hang_Xuat;
        private System.Windows.Forms.ComboBox cbb_MaPhieuXuat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}