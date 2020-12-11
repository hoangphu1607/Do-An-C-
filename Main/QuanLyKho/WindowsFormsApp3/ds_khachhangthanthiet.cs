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
    public partial class ds_khachhangthanthiet : Form
    {
        public ds_khachhangthanthiet()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");

        SqlCommand comm;
        string sql = "";
        private void ds_khachhangthanthiet_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM KHACH_HANG WHERE LoaiKH = N'Khách Hàng Thân Thiết'", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            //dgv_khachhang.AutoGenerateColumns = false;
            dgv_khachhang.DataSource = table;
            conn.Close();
        }
    }
}
