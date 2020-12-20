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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        //string strConn = @"server=DESKTOP-N15KRQ0\SQLEXPRESS;database=QLKho;uid";

        //Connection conn = new Connection();

        SqlConnection conn= new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
                
        SqlCommand comm;
        string sql = "",moi = "",up="";
        double number = 0;
        int dem =0, somoi;
        private void KhachHang_Load(object sender, EventArgs e)
        {
            conn.Open();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM KHACH_HANG", conn);
        //    DataTable table = new DataTable();
        //    dap.Fill(table);
        //    //dgv_khachhang.AutoGenerateColumns = false;
        //    dgv_khachhang.DataSource = table;

        //}

        private void KhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txt_makh.Text.Equals(""))
            {
                MessageBox.Show("Mã Khách Hàng Không Được Trống");
                return;
            }
            if (txt_ten.Text.Equals(""))
            {
                MessageBox.Show("Tên Không Được Trống");
                return;
            }  
            if(txt_sdt.Text.Length >= 1 && txt_sdt.Text.Length <= 9 || txt_sdt.Text.Length > 10)
            {
                MessageBox.Show("Số Điện Thoại Sai");
                return;
            }

            //string[] arr = txt_ten.Text.Split(' ');

            dgv_khachhang.Rows.Add(txt_makh.Text,txt_ten.Text,txt_sdt.Text,cbb_diachi.Text,cbb_loaikh.Text);
            txt_makh.Clear();
            txt_ten.Clear();
            txt_sdt.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moi += "";
            if (conn.State == ConnectionState.Closed)
                conn.Open();            
            dem++;
            if (dem == 1)
            {                               
                string sql = "Select * from MaMoiNhat";
                //tao 1 lenh command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //chay datareader
                SqlDataReader drd = cmd.ExecuteReader();
                string kq = "";
                while (drd.Read())
                {
                    kq += drd["MaKhachHang"].ToString();
                }
                //chuyen cac so cuoi thanh so
                number = Convert.ToDouble(kq.Substring(4));                
                //doi number thanh so            
                txt_makh.Text = "KHTN" + (number + 1);
                conn.Close();
                moi = "KHTN" + (number + 1);
            }
            else
            {                              
                txt_makh.Text = "KHTN" + (number + dem);
                moi = "KHTN" + (number + dem);
                conn.Close();
            }
            
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            foreach (DataGridViewRow item in this.dgv_khachhang.SelectedRows)
            {
                dgv_khachhang.Rows.RemoveAt(item.Index);
            }
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string makh = "", tenkhach = "", sdt = "", diachi = "";
            makh += dgv_khachhang.Rows[0].Cells["MaKhachHang"].Value;
            tenkhach += dgv_khachhang.Rows[0].Cells["TenKhach"].Value;
            sdt += dgv_khachhang.Rows[0].Cells["SDT"].Value;
            diachi += dgv_khachhang.Rows[0].Cells["Diachi"].Value;

            string sql = @"INSERT INTO KHACH_HANG VALUES ('" + makh + @"', N''" + tenkhach + @"', '" + sdt + @"', N''" + diachi + @"');";

            MessageBox.Show(sql);

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (dgv_khachhang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }
            int i = 0;
            string makh, tenkhach, sdt, diachi,loaikh;
            for (i = 0; i < dgv_khachhang.Rows.Count; i++)
            {                
                makh = dgv_khachhang.Rows[i].Cells["MaKhachHang"].Value.ToString();
                tenkhach = dgv_khachhang.Rows[i].Cells["TenKhach"].Value.ToString();
                sdt = dgv_khachhang.Rows[i].Cells["SDT"].Value.ToString();
                diachi = dgv_khachhang.Rows[i].Cells["Diachi"].Value.ToString();
                loaikh = dgv_khachhang.Rows[i].Cells["LoaiKH"].Value.ToString();

                string sql = "INSERT INTO KHACH_HANG VALUES ('" + makh + "', N'" + tenkhach + "', N'" + diachi + "','" + sdt + "', N'"+ loaikh + "');";
                comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                //makh = "";
                //tenkhach = "";
                //sdt = "";
                //diachi = "";

            }

            up = "UPDATE MaMoiNhat SET MaKhachHang = '" + moi + "';";
            comm = new SqlCommand(up, conn);
            comm.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Cập Nhật Dữ Liệu Thành Công!");
            txt_makh.Clear();
            txt_ten.Clear();
            txt_sdt.Clear();

            //dataTable.Clear();
            dgv_khachhang.Rows.Clear();
            dgv_khachhang.Refresh();

            ////if(i == dgv_khachhang.Rows.Count - 1)
            ////{
            ////    up = @"UPDATE" 
            ////}
        }
    }
}
