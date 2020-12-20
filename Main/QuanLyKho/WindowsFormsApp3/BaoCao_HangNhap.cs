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
    public partial class BaoCao_HangNhap : Form
    {
        public BaoCao_HangNhap()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        //biến comm là biến chạy câu lệnh sql và thực thi trên sql
        SqlCommand comm;
        public static string maphieu;
        private void BaoCao_HangNhap_Load(object sender, EventArgs e)
        {
            conn.Open();
            cry_NhapHang cry = new cry_NhapHang();

            SqlDataAdapter dap = new SqlDataAdapter("TT_NhapHang '"+maphieu+"'", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            cry.SetDataSource(table);
            crystalReportViewer1.ReportSource = cry;            

            conn.Close();
        }
    }
}
