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
    public partial class Them_HangHoa : Form
    {
        public Them_HangHoa()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        SqlCommand comm;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_tenhang.Enabled = true;
        }

        private void Them_HangHoa_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT MaHang FROM HANG_HOA", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            cb_mh.DataSource = table;
            cb_mh.DisplayMember = "MaHang";
            cb_mh.ValueMember = "MaHang";
            conn.Close();
        }
    }
}
