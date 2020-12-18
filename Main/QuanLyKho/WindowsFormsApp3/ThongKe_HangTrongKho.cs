using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class ThongKe_HangTrongKho : Form
    {
        public ThongKe_HangTrongKho()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        //biến comm là biến chạy câu lệnh sql và thực thi trên sql
        SqlCommand comm;
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void ThongKe_HangTrongKho_Load(object sender, EventArgs e)
        {
            conn.Open();
            
                Hang_Ton_Kho rp = new Hang_Ton_Kho();
                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM HANG_HOA", conn);
                //string sql = "select * from Hang_Hoa";
                DataTable table = new DataTable();
                dap.Fill(table);
                rp.SetDataSource(table);
                crystalReportViewer1.ReportSource = rp;
            
            conn.Close();
        }
    }
}
