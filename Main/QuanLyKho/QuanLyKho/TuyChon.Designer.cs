namespace QuanLyKho
{
    partial class TuyChon
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 123);
            this.button1.TabIndex = 0;
            this.button1.Text = "NHẬP HÀNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(336, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 419);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHỨC NĂNG";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(488, 214);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 123);
            this.button6.TabIndex = 0;
            this.button6.Text = "THÔNG TIN HÀNG HÓA";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(283, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 123);
            this.button5.TabIndex = 0;
            this.button5.Text = "NHÀ CUNG CẤP";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(81, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 123);
            this.button4.TabIndex = 0;
            this.button4.Text = "KHÁCH HÀNG";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(488, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 123);
            this.button3.TabIndex = 0;
            this.button3.Text = "THÊM LOẠI HÀNG";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 123);
            this.button2.TabIndex = 0;
            this.button2.Text = "XUẤT HÀNG";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TuyChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 723);
            this.Controls.Add(this.groupBox1);
            this.Name = "TuyChon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TuyChon";
            this.Load += new System.EventHandler(this.TuyChon_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}