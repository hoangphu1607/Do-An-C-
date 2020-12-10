namespace WindowsFormsApp3
{
    partial class Them_NhomHang
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
            this.button2 = new System.Windows.Forms.Button();
            this.txt_ = new System.Windows.Forms.GroupBox();
            this.txt_tennhom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_manhom = new System.Windows.Forms.TextBox();
            this.txt_.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_
            // 
            this.txt_.Controls.Add(this.txt_manhom);
            this.txt_.Controls.Add(this.txt_tennhom);
            this.txt_.Controls.Add(this.label2);
            this.txt_.Controls.Add(this.label1);
            this.txt_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_.Location = new System.Drawing.Point(31, 137);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(757, 100);
            this.txt_.TabIndex = 16;
            this.txt_.TabStop = false;
            this.txt_.Text = "Thông Tin Chung";
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
            // txt_manhom
            // 
            this.txt_manhom.Location = new System.Drawing.Point(173, 40);
            this.txt_manhom.Name = "txt_manhom";
            this.txt_manhom.Size = new System.Drawing.Size(191, 26);
            this.txt_manhom.TabIndex = 4;
            // 
            // Them_NhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_);
            this.Name = "Them_NhomHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Them_NhomHang";
            this.Load += new System.EventHandler(this.Them_NhomHang_Load);
            this.txt_.ResumeLayout(false);
            this.txt_.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox txt_;
        private System.Windows.Forms.TextBox txt_tennhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_manhom;
    }
}