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
    public partial class ds_khachhangtiemnang : Form
    {
        public ds_khachhangtiemnang()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");

        SqlCommand comm;
        string sql = "";

        private void dgv_khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ds_khachhang_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM KHACH_HANG WHERE LoaiKH = N'Khách Hàng Tiềm Năng'", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            //dgv_khachhang.AutoGenerateColumns = false;
            dgv_khachhang.DataSource = table;
            conn.Close();


        }
    }
}
