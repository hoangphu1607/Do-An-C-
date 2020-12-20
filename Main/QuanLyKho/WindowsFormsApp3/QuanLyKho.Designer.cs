namespace WindowsFormsApp3
{
    partial class QuanLyKho
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngVàoKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_xemHangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.XuatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtHàngKhỏiKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_XemHangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongTinHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNhómHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtNhómHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_capnhatKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_dskh = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngTìmNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngThânThiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_cnkh = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngTồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NhapHang,
            this.XuatHang,
            this.ThongTinHangHoa,
            this.NhanVien,
            this.KhachHang,
            this.mn_baocao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NhapHang
            // 
            this.NhapHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpHàngVàoKhoToolStripMenuItem,
            this.mn_xemHangNhap});
            this.NhapHang.Name = "NhapHang";
            this.NhapHang.Size = new System.Drawing.Size(106, 25);
            this.NhapHang.Text = "Nhập Hàng";
            this.NhapHang.Click += new System.EventHandler(this.nhậpKhoToolStripMenuItem_Click);
            // 
            // nhậpHàngVàoKhoToolStripMenuItem
            // 
            this.nhậpHàngVàoKhoToolStripMenuItem.Name = "nhậpHàngVàoKhoToolStripMenuItem";
            this.nhậpHàngVàoKhoToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.nhậpHàngVàoKhoToolStripMenuItem.Text = "Nhập Hàng Vào Kho";
            this.nhậpHàngVàoKhoToolStripMenuItem.Click += new System.EventHandler(this.nhậpHàngVàoKhoToolStripMenuItem_Click);
            // 
            // mn_xemHangNhap
            // 
            this.mn_xemHangNhap.Name = "mn_xemHangNhap";
            this.mn_xemHangNhap.Size = new System.Drawing.Size(237, 26);
            this.mn_xemHangNhap.Text = "Thống Kê Nhập Kho";
            this.mn_xemHangNhap.Click += new System.EventHandler(this.xemHàngĐãNhậpToolStripMenuItem_Click);
            // 
            // XuatHang
            // 
            this.XuatHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtHàngKhỏiKhoToolStripMenuItem,
            this.mn_XemHangXuat});
            this.XuatHang.Name = "XuatHang";
            this.XuatHang.Size = new System.Drawing.Size(101, 25);
            this.XuatHang.Text = "Xuất Hàng";
            // 
            // xuấtHàngKhỏiKhoToolStripMenuItem
            // 
            this.xuấtHàngKhỏiKhoToolStripMenuItem.Name = "xuấtHàngKhỏiKhoToolStripMenuItem";
            this.xuấtHàngKhỏiKhoToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.xuấtHàngKhỏiKhoToolStripMenuItem.Text = "Xuất Hàng Khỏi Kho";
            this.xuấtHàngKhỏiKhoToolStripMenuItem.Click += new System.EventHandler(this.xuấtHàngKhỏiKhoToolStripMenuItem_Click);
            // 
            // mn_XemHangXuat
            // 
            this.mn_XemHangXuat.Name = "mn_XemHangXuat";
            this.mn_XemHangXuat.Size = new System.Drawing.Size(237, 26);
            this.mn_XemHangXuat.Text = "Thống Kê Xuất Kho";
            this.mn_XemHangXuat.Click += new System.EventHandler(this.xemHàngĐãXuấtToolStripMenuItem_Click);
            // 
            // ThongTinHangHoa
            // 
            this.ThongTinHangHoa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmNhómHàngToolStripMenuItem,
            this.cậpNhậtNhómHàngToolStripMenuItem,
            this.thêmHàngHóaToolStripMenuItem,
            this.cậpNhậtHàngHóaToolStripMenuItem,
            this.thôngTinHàngHóaToolStripMenuItem});
            this.ThongTinHangHoa.Name = "ThongTinHangHoa";
            this.ThongTinHangHoa.Size = new System.Drawing.Size(180, 25);
            this.ThongTinHangHoa.Text = "Thông Tin Hàng Hóa";
            // 
            // thêmNhómHàngToolStripMenuItem
            // 
            this.thêmNhómHàngToolStripMenuItem.Name = "thêmNhómHàngToolStripMenuItem";
            this.thêmNhómHàngToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.thêmNhómHàngToolStripMenuItem.Text = "Thêm Nhóm Hàng";
            this.thêmNhómHàngToolStripMenuItem.Click += new System.EventHandler(this.thêmNhómHàngToolStripMenuItem_Click);
            // 
            // cậpNhậtNhómHàngToolStripMenuItem
            // 
            this.cậpNhậtNhómHàngToolStripMenuItem.Name = "cậpNhậtNhómHàngToolStripMenuItem";
            this.cậpNhậtNhómHàngToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.cậpNhậtNhómHàngToolStripMenuItem.Text = "Cập Nhật Nhóm Hàng";
            this.cậpNhậtNhómHàngToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtNhómHàngToolStripMenuItem_Click);
            // 
            // thêmHàngHóaToolStripMenuItem
            // 
            this.thêmHàngHóaToolStripMenuItem.Name = "thêmHàngHóaToolStripMenuItem";
            this.thêmHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.thêmHàngHóaToolStripMenuItem.Text = "Thêm Hàng Hóa";
            this.thêmHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.thêmHàngHóaToolStripMenuItem_Click);
            // 
            // cậpNhậtHàngHóaToolStripMenuItem
            // 
            this.cậpNhậtHàngHóaToolStripMenuItem.Name = "cậpNhậtHàngHóaToolStripMenuItem";
            this.cậpNhậtHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.cậpNhậtHàngHóaToolStripMenuItem.Text = "Cập Nhật Hàng Hóa";
            this.cậpNhậtHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtHàngHóaToolStripMenuItem_Click);
            // 
            // thôngTinHàngHóaToolStripMenuItem
            // 
            this.thôngTinHàngHóaToolStripMenuItem.Name = "thôngTinHàngHóaToolStripMenuItem";
            this.thôngTinHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.thôngTinHàngHóaToolStripMenuItem.Text = "Thông Tin Hàng Hóa";
            this.thôngTinHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.thôngTinHàngHóaToolStripMenuItem_Click);
            // 
            // NhanVien
            // 
            this.NhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmNhânViênToolStripMenuItem,
            this.danhSáchNhânViênToolStripMenuItem,
            this.cậpNhậtThôngTinToolStripMenuItem});
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Size = new System.Drawing.Size(99, 25);
            this.NhanVien.Text = "Nhân Viên";
            // 
            // thêmNhânViênToolStripMenuItem
            // 
            this.thêmNhânViênToolStripMenuItem.Name = "thêmNhânViênToolStripMenuItem";
            this.thêmNhânViênToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.thêmNhânViênToolStripMenuItem.Text = "Thêm Nhân Viên";
            this.thêmNhânViênToolStripMenuItem.Click += new System.EventHandler(this.thêmNhânViênToolStripMenuItem_Click);
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            this.danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            this.danhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.danhSáchNhânViênToolStripMenuItem.Text = "Danh Sách Nhân Viên";
            this.danhSáchNhânViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNhânViênToolStripMenuItem_Click);
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            this.cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            this.cậpNhậtThôngTinToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.cậpNhậtThôngTinToolStripMenuItem.Text = "Cập Nhật Thông Tin";
            this.cậpNhậtThôngTinToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtThôngTinToolStripMenuItem_Click);
            // 
            // KhachHang
            // 
            this.KhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_capnhatKhachHang,
            this.mn_dskh,
            this.mn_cnkh});
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.Size = new System.Drawing.Size(114, 25);
            this.KhachHang.Text = "Khách Hàng";
            // 
            // mn_capnhatKhachHang
            // 
            this.mn_capnhatKhachHang.Name = "mn_capnhatKhachHang";
            this.mn_capnhatKhachHang.Size = new System.Drawing.Size(258, 26);
            this.mn_capnhatKhachHang.Text = "Thêm Khách Hàng";
            this.mn_capnhatKhachHang.Click += new System.EventHandler(this.mn_capnhatKhachHang_Click);
            // 
            // mn_dskh
            // 
            this.mn_dskh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngTìmNăngToolStripMenuItem,
            this.kháchHàngThânThiếtToolStripMenuItem});
            this.mn_dskh.Name = "mn_dskh";
            this.mn_dskh.Size = new System.Drawing.Size(258, 26);
            this.mn_dskh.Text = "Danh Sách Khách Hàng";
            this.mn_dskh.Click += new System.EventHandler(this.danhSáchKháchHàngToolStripMenuItem_Click);
            // 
            // kháchHàngTìmNăngToolStripMenuItem
            // 
            this.kháchHàngTìmNăngToolStripMenuItem.Name = "kháchHàngTìmNăngToolStripMenuItem";
            this.kháchHàngTìmNăngToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.kháchHàngTìmNăngToolStripMenuItem.Text = "Khách Hàng Tìm Năng";
            this.kháchHàngTìmNăngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngTìmNăngToolStripMenuItem_Click);
            // 
            // kháchHàngThânThiếtToolStripMenuItem
            // 
            this.kháchHàngThânThiếtToolStripMenuItem.Name = "kháchHàngThânThiếtToolStripMenuItem";
            this.kháchHàngThânThiếtToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.kháchHàngThânThiếtToolStripMenuItem.Text = "Khách Hàng Thân Thiết";
            this.kháchHàngThânThiếtToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngThânThiếtToolStripMenuItem_Click);
            // 
            // mn_cnkh
            // 
            this.mn_cnkh.Name = "mn_cnkh";
            this.mn_cnkh.Size = new System.Drawing.Size(258, 26);
            this.mn_cnkh.Text = "Cập Nhật Thông Tin";
            this.mn_cnkh.Click += new System.EventHandler(this.mn_cnkh_Click);
            // 
            // mn_baocao
            // 
            this.mn_baocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hàngTồnKhoToolStripMenuItem});
            this.mn_baocao.Name = "mn_baocao";
            this.mn_baocao.Size = new System.Drawing.Size(88, 25);
            this.mn_baocao.Text = "Báo Cáo";
            this.mn_baocao.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // hàngTồnKhoToolStripMenuItem
            // 
            this.hàngTồnKhoToolStripMenuItem.Name = "hàngTồnKhoToolStripMenuItem";
            this.hàngTồnKhoToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.hàngTồnKhoToolStripMenuItem.Text = "Hàng Tồn Kho";
            this.hàngTồnKhoToolStripMenuItem.Click += new System.EventHandler(this.hàngTồnKhoToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1814, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 21);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng Xuất";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // QuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 964);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLyKho";
            this.Text = "PHẦN MỀM QUẢN LÝ KHO DỤNG CỤ HỌC TẬP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyKho_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuanLyKho_FormClosed);
            this.Load += new System.EventHandler(this.QuanLyKho_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NhapHang;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngVàoKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XuatHang;
        private System.Windows.Forms.ToolStripMenuItem ThongTinHangHoa;
        private System.Windows.Forms.ToolStripMenuItem mn_xemHangNhap;
        private System.Windows.Forms.ToolStripMenuItem xuấtHàngKhỏiKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_XemHangXuat;
        private System.Windows.Forms.ToolStripMenuItem thêmHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhanVien;
        private System.Windows.Forms.ToolStripMenuItem KhachHang;
        private System.Windows.Forms.ToolStripMenuItem mn_capnhatKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mn_dskh;
        private System.Windows.Forms.ToolStripMenuItem mn_cnkh;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngTìmNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngThânThiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNhómHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtNhómHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_baocao;
        private System.Windows.Forms.ToolStripMenuItem hàngTồnKhoToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}