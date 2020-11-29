namespace WindowsFormsApp3
{
    partial class Them_HangHoa
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
            this.button3 = new System.Windows.Forms.Button();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_mh = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_
            // 
            this.txt_.Controls.Add(this.cb_mh);
            this.txt_.Controls.Add(this.button3);
            this.txt_.Controls.Add(this.txt_tenhang);
            this.txt_.Controls.Add(this.label2);
            this.txt_.Controls.Add(this.label1);
            this.txt_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_.Location = new System.Drawing.Point(221, 109);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(832, 100);
            this.txt_.TabIndex = 5;
            this.txt_.TabStop = false;
            this.txt_.Text = "Thông Tin Chung";
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
            // txt_tenhang
            // 
            this.txt_tenhang.Enabled = false;
            this.txt_tenhang.Location = new System.Drawing.Point(552, 43);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(191, 26);
            this.txt_tenhang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nhóm Hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // cb_mh
            // 
            this.cb_mh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mh.FormattingEnabled = true;
            this.cb_mh.Location = new System.Drawing.Point(188, 40);
            this.cb_mh.Name = "cb_mh";
            this.cb_mh.Size = new System.Drawing.Size(145, 28);
            this.cb_mh.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(222, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 257);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hàng Hóa";
            // 
            // Them_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 652);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_);
            this.Name = "Them_HangHoa";
            this.Text = "Them_HangHoa";
            this.Load += new System.EventHandler(this.Them_HangHoa_Load);
            this.txt_.ResumeLayout(false);
            this.txt_.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txt_;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_mh;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}