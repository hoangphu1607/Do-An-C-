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
    public partial class CapNhat_HangHoa : Form
    {
        public CapNhat_HangHoa()
        {
            InitializeComponent();
        }
        //tao connection den co so du lieu
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        //biến comm là biến chạy câu lệnh sql và thực thi trên sql
        SqlCommand comm;
        //biến sql là biến lưu chuỗi các câu lệnh sql như : insert, update, delete.....        
        string sql = "";
        private void CapNhat_HangHoa_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM HANG_HOA", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            //dgv_khachhang.AutoGenerateColumns = false;
            dgv_HangHoa.DataSource = table;
            conn.Close();
        }

        private void dgv_HangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int numrow;
                numrow = e.RowIndex;
                txt_masp.Text = dgv_HangHoa.Rows[numrow].Cells[0].Value.ToString();
                txt_nhomhang.Text = dgv_HangHoa.Rows[numrow].Cells[3].Value.ToString();
                txt_tensp.Text = dgv_HangHoa.Rows[numrow].Cells[1].Value.ToString();
                txt_donvitinh.Text = dgv_HangHoa.Rows[numrow].Cells[2].Value.ToString();
                txt_dongia.Text = dgv_HangHoa.Rows[numrow].Cells[6].Value.ToString();
                txt_mancc.Text = dgv_HangHoa.Rows[numrow].Cells[4].Value.ToString();
                txt_soLuong.Text = dgv_HangHoa.Rows[numrow].Cells[5].Value.ToString();
                txt_giaban.Text = dgv_HangHoa.Rows[numrow].Cells[7].Value.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_tensp_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "UPDATE HANG_HOA set TenHang = N'"+txt_tensp.Text+"', DonGia = '"+txt_dongia.Text+"', DonViTinh = N'"+txt_donvitinh.Text+"', SoLuong = '"+txt_soLuong.Text+"', GiaXuatKho = '"+txt_giaban.Text+"' where mahang = '"+txt_masp.Text+"'";
            comm = new SqlCommand(sql,conn);
            comm.ExecuteNonQuery();
            this.loadData();
            conn.Close();
        }
        public void loadData()
        {
            
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM HANG_HOA", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            //dgv_khachhang.AutoGenerateColumns = false;
            dgv_HangHoa.DataSource = table;
            
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "DELETE FROM HANG_HOA WHERE MaHang = '" + txt_masp.Text + "'";
                comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                this.loadData();
                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Không Thể Xóa");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
