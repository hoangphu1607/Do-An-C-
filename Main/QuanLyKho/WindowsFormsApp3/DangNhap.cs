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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        SqlCommand comm;
        private void button1_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Closed)
                conn.Open();
            if (txt_tk.Text.Equals(""))
            {
                MessageBox.Show("Chưa Nhập Tài Khoảng");
                return;
            }
            if (txt_mk.Text.Equals(""))
            {
                MessageBox.Show("Mật Khẩu Chưa Nhập");
                return;
            }
            string sql = "SELECT COUNT(*) FROM dbo.DangNhap WHERE Ten_Dang_Nhap = '"+txt_tk.Text+"' AND Mat_Khau = '"+txt_mk.Text+"'";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            dap.Fill(table);

            if (table.Rows[0][0].ToString().Equals("1"))
            {
               
                sql = "SELECT MaQuyen FROM DangNhap WHERE Ten_Dang_Nhap = '" + txt_tk.Text + "' AND Mat_Khau = '" + txt_mk.Text + "'";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, conn);
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);
                if (dataTable.Rows[0][0].ToString().Equals("2"))
                {
                    QuanLyKho.quyen = "2";
                }
                else if (dataTable.Rows[0][0].ToString().Equals("1"))
                {
                    QuanLyKho.quyen = "1";
                }
                else
                {
                    QuanLyKho.quyen = "0";
                }
            }
            else
            {
                MessageBox.Show("Tài Khoảng Hoặc Mật Khẩu Không Đúng");
                return;
            }
                
            this.Hide();
            this.Enabled = false;
            QuanLyKho a = new QuanLyKho();
            a.Show();
            conn.Close();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_mk.UseSystemPasswordChar = false;
            }
            else {
                txt_mk.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
