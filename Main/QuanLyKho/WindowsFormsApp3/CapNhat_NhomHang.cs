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
    public partial class CapNhat_NhomHang : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        SqlCommand comm;
        string sql;
        public CapNhat_NhomHang()
        {
            InitializeComponent();
        }

        private void CapNhat_NhomHang_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM NHOM_HANG", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            //dgv_khachhang.AutoGenerateColumns = false;
            dgv_hanghoa.DataSource = table;

            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_hanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int numrow;
                numrow = e.RowIndex;
                txt_manhom.Text = dgv_hanghoa.Rows[numrow].Cells[0].Value.ToString();
                txt_tennhom.Text = dgv_hanghoa.Rows[numrow].Cells[1].Value.ToString();
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "UPDATE NHOM_HANG SET TenNhom = N'" + txt_tennhom.Text + "' WHERE MaNhom = '" + txt_manhom.Text + "'";
            comm = new SqlCommand(sql, conn);
            comm.ExecuteNonQuery();
            this.loadData();
            conn.Close();
        }

        public void loadData()
        {
            
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM NHOM_HANG", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            //dgv_khachhang.AutoGenerateColumns = false;
            dgv_hanghoa.DataSource = table;

            
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            
        }
    }
}
