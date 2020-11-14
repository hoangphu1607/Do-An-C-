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
            kh.Show();
        }

        private void QuanLyKho_Load(object sender, EventArgs e)
        {
            
        }
    }
}
