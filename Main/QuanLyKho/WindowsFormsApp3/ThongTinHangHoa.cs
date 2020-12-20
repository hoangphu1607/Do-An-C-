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
    public partial class ThongTinHangHoa : Form
    {
        public ThongTinHangHoa()
        {
            InitializeComponent();
        }
        //tao connection den co so du lieu
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        //biến comm là biến chạy câu lệnh sql và thực thi trên sql
        SqlCommand comm;
        //biến sql là biến lưu chuỗi các câu lệnh sql như : insert, update, delete.....        
        string sql = "";
        private void ThongTinHangHoa_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM HANG_HOA", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            //dgv_khachhang.AutoGenerateColumns = false;
            dgv_HangHoa.DataSource = table;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongKe_HangTrongKho FRM = new ThongKe_HangTrongKho();
            FRM.Show(); 
        }
    }
}
