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
    public partial class BaoCao_NhanVien : Form
    {
        public BaoCao_NhanVien()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        SqlCommand comm;
        private void BaoCao_NhanVien_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "SELECT * FROM NHAN_VIEN";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            dap.Fill(table);

            Cry_DanhSachNhanVien cry = new Cry_DanhSachNhanVien();
            cry.SetDataSource(table);
            crystalReportViewer1.ReportSource = cry;
            conn.Close();

        }
    }
}
