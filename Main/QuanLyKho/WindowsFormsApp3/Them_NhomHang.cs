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
    public partial class Them_NhomHang : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        SqlCommand comm;
        public Them_NhomHang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
                string sql = "INSERT INTO NHOM_HANG VALUES ('" + txt_manhom.Text + "',N'" + txt_tennhom.Text + "');";
                comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm Dữ Liệu Thành Công");
            }
            catch (Exception)
            {
                //throw;
                MessageBox.Show("Dữ liệu đã tồn tại hoặc bị lỗi");
            }
            
        }

        private void Them_NhomHang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
