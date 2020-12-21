using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    public partial class QuanLyKho : Form
    {
        public QuanLyKho()
        {
            InitializeComponent();
        }
        public static string quyen;
        private void QuanLyKho_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.
        }

        private void QuanLyKho_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mn_capnhatKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MdiParent = this;
            kh.Show();
            //kh.MdiParent = this;
        }

        private void QuanLyKho_Load(object sender, EventArgs e)
        {
            if (quyen.Equals("1"))
            {
                ThongTinHangHoa.Visible = false;
                NhanVien.Visible = false;
                mn_dskh.Visible = false;
                mn_cnkh.Visible = false;
                mn_baocao.Visible = false;
                mn_xemHangNhap.Visible = false;
                mn_XemHangXuat.Visible = false;
            }
            else if (quyen.Equals("2"))
            {

            }
            else
            {
                NhapHang.Visible = false;
                XuatHang.Visible = false;
                ThongTinHangHoa.Visible = false;

            }
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kháchHàngTìmNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds_khachhangtiemnang dskh_tn = new ds_khachhangtiemnang();
            dskh_tn.MdiParent = this;
            dskh_tn.Show();
        }

        private void kháchHàngThânThiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds_khachhangthanthiet dskh_tt = new ds_khachhangthanthiet();
            dskh_tt.MdiParent = this;
            dskh_tt.Show();
        }

        private void mn_cnkh_Click(object sender, EventArgs e)
        {
            CapNhatThongTin_KH capnhat_kh = new CapNhatThongTin_KH();
            capnhat_kh.MdiParent = this;
            capnhat_kh.Show();
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSach_NhanVien a = new DanhSach_NhanVien();
            a.MdiParent = this;
            a.Show();
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Them_NhanVien a = new Them_NhanVien();
            a.MdiParent = this;
            a.Show();
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhat_NhanVien a = new CapNhat_NhanVien();
            a.MdiParent = this;
            a.Show();
        }

        private void thôngTinHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinHangHoa a = new ThongTinHangHoa();
            a.MdiParent = this;
            a.Show();
        }

        private void nhậpHàngVàoKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapKho a = new NhapKho();
            a.MdiParent = this;
            a.Show();

        }

        private void xuấtHàngKhỏiKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xuatkho xuatkho = new xuatkho();
            xuatkho.MdiParent = this;
            xuatkho.Show();
        }

        private void thêmNhómHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Them_NhomHang frm = new Them_NhomHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thêmHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Them_HangHoa frm = new Them_HangHoa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cậpNhậtHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhat_HangHoa frm = new CapNhat_HangHoa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cậpNhậtNhómHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhat_NhomHang frm = new CapNhat_NhomHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hàngTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe_HangTrongKho frm = new ThongKe_HangTrongKho();
            frm.MdiParent = this;
            frm.Show();
        }

        private void xemHàngĐãXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hang_Da_Xuat_Kho FRM = new Hang_Da_Xuat_Kho();
            FRM.MdiParent = this;
            FRM.Show();
        }

        private void xemHàngĐãNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hang_Nhap_Kho frm = new Hang_Nhap_Kho();
            frm.MdiParent = this;
            frm.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangNhap frm = new DangNhap();
            frm.ShowDialog();

        }

        private void hàngBánChạyNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChonThang.trangthai = 1;
            ChonThang frm = new ChonThang();
            frm.ShowDialog();

        }

        private void danhThuThángNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChonThang_Cho_BaoCaoThangNay frm = new ChonThang_Cho_BaoCaoThangNay();
            frm.ShowDialog();
        }

        private void hàngHóaNhậpNhiềuNhâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChonThang.trangthai = 3;
            ChonThang frm = new ChonThang();
            frm.ShowDialog();
        }

        private void hàngHóaNhậpTrongThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChonThang.trangthai = 4;
            ChonThang frm = new ChonThang();
            frm.ShowDialog();
        }
    }
}
