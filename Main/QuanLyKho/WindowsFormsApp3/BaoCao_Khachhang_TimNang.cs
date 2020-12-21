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
    public partial class BaoCao_Khachhang_TimNang : Form
    {
        public BaoCao_Khachhang_TimNang()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        //biến comm là biến chạy câu lệnh sql và thực thi trên sql
        SqlCommand comm;
        public static string loaiKH = "";
        private void BaoCao_Khachhang_TimNang_Load(object sender, EventArgs e)
        {
            conn.Open();

            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM dbo.KHACH_HANG WHERE LoaiKh = N'"+loaiKH+"'", conn);
            DataTable table = new DataTable();
            dap.Fill(table);

            DS_KhachHang cry = new DS_KhachHang();
            cry.SetDataSource(table);
            crystalReportViewer1.ReportSource = cry;
            conn.Close();
        }
    }
}
