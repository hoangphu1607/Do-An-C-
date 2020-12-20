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
    public partial class BaoCao_XuatHang : Form
    {
        public BaoCao_XuatHang()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        SqlCommand comm;

        public static string maphieu;
        private void BaoCao_XuatHang_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            cry_XuatHang cry = new cry_XuatHang();

            SqlDataAdapter dap = new SqlDataAdapter("TT_XuatHang '"+maphieu+"'", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            try
            {
                string loaiKH = table.Rows[0][16].ToString();
            }
            catch (Exception)
            {

                
            }
            
            //MessageBox.Show(loaiKH);
            cry.SetDataSource(table);
            crystalReportViewer1.ReportSource = cry;
           
            conn.Close();
        }
    }
}
