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
    public partial class Them_NhanVien : Form
    {
        public Them_NhanVien()
        {
            InitializeComponent();
        }
        //tao connection den co so du lieu
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        //biến comm là biến chạy câu lệnh sql và thực thi trên sql
        SqlCommand comm;
        //biến sql là biến lưu chuỗi các câu lệnh sql như : insert, update, delete.....
        //biến mới lưu mã nhân viên mới khi bấm vào dấu cộng
        string sql = "", moi = "",up = "";
        //đếm số lần bấm vào dấu cộng để tăng mã nhân viên
        int dem = 0;
        //number dùng để lưu các số phía sau mã nhân viên vd: NVTT202012 => number = 202012
        double number;

        private void txt_tennv_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kiểm tra xem mã nhân viên có trống hay không => nếu trống thì không thêm
            if (txt_manv.Text.Equals(""))
            {
                MessageBox.Show("Mã Nhân Viên Không Được Trống");
                return;
            }
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

            string[] arr = txt_tennv.Text.Split(' ');

            dgv_nhanvien.Rows.Add(txt_manv.Text, txt_tennv.Text, cbb_diachi.Text, txt_sdt.Text);
            //khi thêm xong sẽ xóa các text box vừa nhập
            txt_manv.Clear();
            txt_tennv.Clear();
            txt_sdt.Clear();

        }

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int numrow;
                numrow = e.RowIndex;
                //txt_manv.Text = dgv_nhanvien.Rows[numrow].Cells[0].Value.ToString();
                txt_tennv.Text = dgv_nhanvien.Rows[numrow].Cells[1].Value.ToString();
                cbb_diachi.Text = dgv_nhanvien.Rows[numrow].Cells[2].Value.ToString();
                txt_sdt.Text = dgv_nhanvien.Rows[numrow].Cells[3].Value.ToString();
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            foreach (DataGridViewRow item in this.dgv_nhanvien.SelectedRows)
            {
                dgv_nhanvien.Rows.RemoveAt(item.Index);
            }
            conn.Close();
        }

        private void Them_NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (dgv_nhanvien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }
            int i = 0;
            string manv, tennv, sdt, diachi;
            for (i = 0; i < dgv_nhanvien.Rows.Count; i++)
            {
                manv = dgv_nhanvien.Rows[i].Cells["MaNhanVien"].Value.ToString();
                tennv = dgv_nhanvien.Rows[i].Cells["TenNhanVien"].Value.ToString();
                sdt = dgv_nhanvien.Rows[i].Cells["DienThoai"].Value.ToString();
                diachi = dgv_nhanvien.Rows[i].Cells["DiaChi"].Value.ToString();
                

                string sql = "INSERT INTO NHAN_VIEN VALUES ('" + manv + "', N'" + tennv + "', N'" + diachi + "','" + sdt + "');";
                comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                //makh = "";
                //tenkhach = "";
                //sdt = "";
                //diachi = "";

            }

            up = "UPDATE MaNhanVienMoiNhat SET MaNhanVien = '" + moi + "';";
            comm = new SqlCommand(up, conn);
            comm.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Cập Nhật Dữ Liệu Thành Công!");
            txt_manv.Clear();
            txt_tennv.Clear();
            txt_sdt.Clear();

            //dataTable.Clear();
            //foreach (DataGridViewRow row in dgv_nhanvien.Rows)
            //{
            //    try
            //    {
            //        dgv_nhanvien.Rows.Remove(row);
            //    }
            //    catch (Exception) { }
            //}
            dgv_nhanvien.Rows.Clear();
            dgv_nhanvien.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moi += "";
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            dem++;
            if (dem == 1)
            {
                string sql = "Select * from MaNhanVienMoiNhat";
                //tao 1 lenh command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //chay datareader
                SqlDataReader drd = cmd.ExecuteReader();
                string kq = "";
                while (drd.Read())
                {
                    kq += drd["MaNhanVien"].ToString();
                }
                //chuyen cac so cuoi thanh so
                number = Convert.ToDouble(kq.Substring(4));
                //doi number thanh so            
                txt_manv.Text = "NNTT" + (number + 1);
                conn.Close();
                moi = "NNTT" + (number + 1);
            }
            else
            {
                txt_manv.Text = "NNTT" + (number + dem);
                moi = "NNTT" + (number + dem);
                conn.Close();
            }
        }
    }
}
