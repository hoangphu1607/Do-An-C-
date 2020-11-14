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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        //string strConn = @"server=DESKTOP-N15KRQ0\SQLEXPRESS;database=QLKho;uid";

        //Connection conn = new Connection();

        SqlConnection conn= new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");

        private void KhachHang_Load(object sender, EventArgs e)
        {
            //chay dc
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM KHACH_HANG", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;

        }
    }
}
