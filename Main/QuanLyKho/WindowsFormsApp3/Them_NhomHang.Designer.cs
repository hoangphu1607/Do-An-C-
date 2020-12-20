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
            this.txt_manhom = new System.Windows.Forms.TextBox();
            this.txt_tennhom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(286, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 29);
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
            this.txt_.Location = new System.Drawing.Point(31, 177);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(757, 100);
            this.txt_.TabIndex = 16;
            this.txt_.TabStop = false;
            this.txt_.Text = "Thông Tin Chung";
            // 
            // txt_manhom
            // 
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(454, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(177, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(475, 46);
            this.label11.TabIndex = 25;
            this.label11.Text = "THÊM NHÓM HÀNG MỚI";
            // 
            // Them_NhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._1228c58b032f61bb61a3d2f4e8d6d1fb;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_);
            this.Name = "Them_NhomHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM NHÓM HÀNG";
            this.Load += new System.EventHandler(this.Them_NhomHang_Load);
            this.txt_.ResumeLayout(false);
            this.txt_.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox txt_;
        private System.Windows.Forms.TextBox txt_tennhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_manhom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
    }
}