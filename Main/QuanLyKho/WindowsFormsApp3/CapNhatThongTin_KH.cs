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
    public partial class CapNhatThongTin_KH : Form
    {
        public CapNhatThongTin_KH()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");

        SqlCommand comm;
        string sql = "";
        private void CapNhatThongTin_KH_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT TenKhach, Diachi, SDT, LoaiKH FROM KHACH_HANG", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            //dgv_khachhang.AutoGenerateColumns = false;
            dgv_khachhang.DataSource = table;
            conn.Close();
        }

        private void dgv_khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dgv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //DataGridViewRow row = this.dgv_khachhang.Rows[e.RowIndex];
                //txt_ten.Text = row.Cells[0].Value.ToString();
                //txt_sdt.Text = row.Cells[1].Value.ToString();
                //cbb_diachi.Text = row.Cells[2].Value.ToString();
                ////cbb_loaikh.Text = row.Cells[3].Value.ToString();
                int numrow;
                numrow = e.RowIndex;
                txt_ten.Text = dgv_khachhang.Rows[numrow].Cells[0].Value.ToString();
                txt_sdt.Text = dgv_khachhang.Rows[numrow].Cells[2].Value.ToString();
                cbb_diachi.Text = dgv_khachhang.Rows[numrow].Cells[1].Value.ToString();
                cbb_loaikh.Text = dgv_khachhang.Rows[numrow].Cells[3].Value.ToString();
            }
        }
    }
}
