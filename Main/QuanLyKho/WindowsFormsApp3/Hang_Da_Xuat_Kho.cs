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
    public partial class Hang_Da_Xuat_Kho : Form
    {
        public Hang_Da_Xuat_Kho()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        SqlCommand comm;
        private void Hang_Da_Xuat_Kho_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM PHIEU_XUAT", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbb_MaPhieuXuat.DataSource = table;
            cbb_MaPhieuXuat.DisplayMember = "MaSoPhieuXuat";
            cbb_MaPhieuXuat.ValueMember = "MaSoPhieuXuat";
            conn.Close();
        }

        private void cbb_MaPhieuXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM dbo.CHI_TIET_XUAT WHERE MaPhieu = '"+cbb_MaPhieuXuat.Text+"'", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            dgv_Hang_Xuat.DataSource = table;
            

            conn.Close();
        }
    }
}
