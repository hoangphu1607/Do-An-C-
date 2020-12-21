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
                if(conn.State == ConnectionState.Closed)
                    conn.Open();
                sql = "UPDATE NHAN_VIEN SET DienThoai = '" + txt_sdt.Text + "', TenNhanVien = N'" +txt_tennv.Text +"', DiaChi = N'"+cbb_diachi.SelectedItem.ToString()+"' WHERE MaNhanVien = '" + txt_manv.Text + "';";
                comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();

                MessageBox.Show("Cập Nhật Thành Công");

                

                conn.Close();
                this.loadData();
            }
            else
                MessageBox.Show("Không có dữ liệu");
        }
        public void loadData()
        {
            if(conn.State == ConnectionState.Closed)
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

                sql = "SELECT MaSoPhieuNhap FROM dbo.PHIEU_NHAP WHERE MaNhanVien='" + txt_manv.Text + "' GROUP BY MaSoPhieuNhap";
                SqlDataAdapter dap = new SqlDataAdapter(sql,conn);
                DataTable table = new DataTable();
                dap.Fill(table);

                
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    string maphieunhap = table.Rows[i][0].ToString();
                    string xoa = "DELETE FROM dbo.CHI_TIET_NHAP WHERE MaPhieu = '" + maphieunhap + "'";
                    comm = new SqlCommand(xoa, conn);
                    comm.ExecuteNonQuery();
                    xoa = "DELETE FROM dbo.PHIEU_NHAP WHERE MaSoPhieuNhap = '" + maphieunhap + "'";
                    comm = new SqlCommand(xoa, conn);
                    comm.ExecuteNonQuery();                

                }

                sql = "SELECT MaSoPhieuXuat FROM dbo.PHIEU_XUAT WHERE MaNhanVien ='"+txt_manv.Text+"' GROUP BY MaSoPhieuXuat";
                 dap = new SqlDataAdapter(sql, conn);
                 table = new DataTable();
                dap.Fill(table);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string maphieuxuat = table.Rows[i][0].ToString();
                    string xoa = "DELETE FROM  dbo.CHI_TIET_XUAT WHERE MaPhieu = '"+ maphieuxuat + "'";
                    comm = new SqlCommand(xoa, conn);
                    comm.ExecuteNonQuery();
                    xoa = "DELETE FROM dbo.PHIEU_XUAT WHERE MaSoPhieuXuat = '"+maphieuxuat+"'";
                    comm = new SqlCommand(xoa, conn);
                    comm.ExecuteNonQuery();

                }

                string xoa_nhanvien = "DELETE FROM dbo.NHAN_VIEN WHERE MaNhanVien = '" + txt_manv.Text + "'";
                comm = new SqlCommand(xoa_nhanvien, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Xóa Thành Công");
                conn.Close();
                this.loadData();
                MessageBox.Show("Xóa Thành Công");
                txt_manv.Clear();
                txt_sdt.Clear();
                txt_tennv.Clear();
                


            }
            else
                MessageBox.Show("Không có dữ liệu");
        }
    }
}
