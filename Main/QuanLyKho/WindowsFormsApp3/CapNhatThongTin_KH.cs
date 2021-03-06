﻿using System;
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
    public partial class CapNhatThongTin_KH : Form
    {
        public CapNhatThongTin_KH()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");

        SqlCommand comm;
        string sql = "";
        private void CapNhatThongTin_KH_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM KHACH_HANG", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            //dgv_khachhang.AutoGenerateColumns = false;
            dgv_khachhang.DataSource = table;
            conn.Close();
        }

        public void loadData()
        {
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM KHACH_HANG", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            //dgv_khachhang.AutoGenerateColumns = false;
            dgv_khachhang.DataSource = table;
            conn.Close();
        }

        private void dgv_khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dgv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {               
                int numrow;
                numrow = e.RowIndex;
                txt_makh.Text = dgv_khachhang.Rows[numrow].Cells[0].Value.ToString();
                txt_ten.Text = dgv_khachhang.Rows[numrow].Cells[1].Value.ToString();
                cbb_diachi.Text = dgv_khachhang.Rows[numrow].Cells[2].Value.ToString();
                txt_sdt.Text = dgv_khachhang.Rows[numrow].Cells[3].Value.ToString();                
                cbb_loaikh.Text = dgv_khachhang.Rows[numrow].Cells[4].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txt_makh.Text.Equals(""))
            {
                //kiểm tra xem tên nhân viên có trống hay không => nếu trống thì không thêm
                if (txt_ten.Text.Equals(""))
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
                sql = "UPDATE KHACH_HANG SET SDT = '" + txt_sdt.Text + "',TenKhach = N'" + txt_ten.Text+"', Diachi = N'"+ cbb_diachi.SelectedItem.ToString() + "', LoaiKH = N'" + cbb_loaikh.SelectedItem.ToString() + "' WHERE MaKhachHang = '" + txt_makh.Text + "';";
                comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Cập Nhật Thành Công");
                //sql = "UPDATE KHACH_HANG SET TenKhach = N'" + txt_ten.Text + "' WHERE MaKhachHang = '" + txt_makh.Text + "';";
                //comm = new SqlCommand(sql, conn);
                //comm.ExecuteNonQuery();

                //sql = "UPDATE KHACH_HANG SET Diachi = '" + cbb_diachi.SelectedItem.ToString() + "' WHERE MaKhachHang = '" + txt_makh.Text + "';";
                //comm = new SqlCommand(sql, conn);
                //comm.ExecuteNonQuery();

                //sql = "UPDATE KHACH_HANG SET LoaiKH = N'" + cbb_loaikh.SelectedItem.ToString() + "' WHERE MaKhachHang = '" + txt_makh.Text + "';";
                //comm = new SqlCommand(sql, conn);
                //comm.ExecuteNonQuery();

                conn.Close();
                this.loadData();
            }
            else
                MessageBox.Show("Không có dữ liệu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!txt_makh.Text.Equals(""))
            {
                conn.Open();
                sql = "DELETE FROM KHACH_HANG WHERE MaKhachHang = '" + txt_makh.Text + "';";
                comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                this.loadData();
                txt_makh.Clear();
                txt_sdt.Clear();
                txt_ten.Clear();
                

            }
            else
                MessageBox.Show("Không có dữ liệu");
        }
    }
}
