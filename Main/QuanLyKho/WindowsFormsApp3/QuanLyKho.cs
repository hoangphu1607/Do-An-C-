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
    }
}
