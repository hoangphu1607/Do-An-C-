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
    public partial class BaoCao_NhapHangThangNay : Form
    {
        public BaoCao_NhapHangThangNay()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        //biến comm là biến chạy câu lệnh sql và thực thi trên sql
        SqlCommand comm;
        public static int thang;
        private void BaoCao_NhapHangThangNay_Load(object sender, EventArgs e)
        {
            conn.Open();
            Tong_Nhap_Hang cry = new Tong_Nhap_Hang();

            SqlDataAdapter dap = new SqlDataAdapter("TongNhapHang '" + thang + "'", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            cry.SetDataSource(table);
            crystalReportViewer1.ReportSource = cry;

            conn.Close();
        }
    }
}
