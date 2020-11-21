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
    public partial class CapNhat_NhanVien : Form
    {
        public CapNhat_NhanVien()
        {
            InitializeComponent();
        }
        //tao connection den co so du lieu
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        //biến comm là biến chạy câu lệnh sql và thực thi trên sql
        SqlCommand comm;
        //biến sql là biến lưu chuỗi các câu lệnh sql như : insert, update, delete.....        
        string sql = "";
        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int numrow;
                numrow = e.RowIndex;
                txt_manv.Text = dgv_nhanvien.Rows[numrow].Cells[0].Value.ToString();
                txt_tennv.Text = dgv_nhanvien.Rows[numrow].Cells[1].Value.ToString();
                cbb_diachi.Text = dgv_nhanvien.Rows[numrow].Cells[2].Value.ToString();
                txt_sdt.Text = dgv_nhanvien.Rows[numrow].Cells[3].Value.ToString();
            }
        }

        private void CapNhat_NhanVien_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM NHAN_VIEN", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            //dgv_khachhang.AutoGenerateColumns = false;
            dgv_nhanvien.DataSource = table;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txt_manv.Text.Equals(""))
            {
                //kiểm tra xem tên nhân viên có trống hay không => nếu trống thì không thêm
                if (txt_tennv.Text.Equals(""))
                {
                    MessageBox.Show("Tên Không Được Trống");
                    return;
                }

                if (txt_sdt.Text.Length >= 1 && txt_sdt.Text.Length <= 9 || txt_sdt.Text.Length > 10)
                {
                    MessageBox.Show("Số Điện Thoại Sai");
                    return;
                }

                conn.Open();
                sql = "UPDATE NHAN_VIEN SET DienThoai = '" + txt_sdt.Text + "' WHERE MaNhanVien = '" + txt_manv.Text + "';";
                comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();

                sql = "UPDATE NHAN_VIEN SET TenNhanVien = N'" + txt_tennv.Text + "' WHERE MaNhanVien = '" + txt_manv.Text + "';";
                comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();

                sql = "UPDATE NHAN_VIEN SET DiaChi = '" + cbb_diachi.SelectedItem.ToString() + "' WHERE MaNhanVien = '" + txt_manv.Text + "';";
                comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();

                //sql = "UPDATE KHACH_HANG SET LoaiKH = N'" + cbb_loaikh.SelectedItem.ToString() + "' WHERE MaKhachHang = '" + txt_makh.Text + "';";
                //comm = new SqlCommand(sql, conn);
                //comm.ExecuteNonQuery();

                conn.Close();
                this.loadData();
            }
            else
                MessageBox.Show("Không có dữ liệu");
        }
        public void loadData()
        {
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM NHAN_VIEN", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            //dgv_khachhang.AutoGenerateColumns = false;
            dgv_nhanvien.DataSource = table;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!txt_manv.Text.Equals(""))
            {
                conn.Open();
                sql = "DELETE FROM NHAN_VIEN WHERE MaNhanVien = '" + txt_manv.Text + "';";
                comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                this.loadData();
                txt_manv.Clear();
                txt_sdt.Clear();
                txt_tennv.Clear();


            }
            else
                MessageBox.Show("Không có dữ liệu");
        }
    }
}
