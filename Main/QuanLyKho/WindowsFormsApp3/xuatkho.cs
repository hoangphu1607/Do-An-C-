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
    public partial class xuatkho : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        SqlCommand comm;
        string moi = "";
        int dem = 0,tinh_trang=0;
        double number = 0;
        public xuatkho()
        {
            InitializeComponent();
        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void xuatkho_Load(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM NHAN_VIEN", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            cb_tennv.DataSource = table;
            cb_tennv.DisplayMember = "TenNhanVien";
            cb_tennv.ValueMember = "MaNhanVien";

            txt_manv.DataBindings.Clear();
            txt_manv.DataBindings.Add("Text", cb_tennv.DataSource, "MaNhanVien");

            SqlDataAdapter dapp = new SqlDataAdapter("SELECT * FROM KHACH_HANG", conn);
            DataTable tablee = new DataTable();
            dapp.Fill(tablee);
            cb_tenKH.DataSource = tablee;
            cb_tenKH.DisplayMember = "TenKhach";
            cb_tenKH.ValueMember = "MaKhachHang";

            txt_maKH.DataBindings.Clear();
            txt_maKH.DataBindings.Add("Text", cb_tenKH.DataSource, "MaKhachHang");

            SqlDataAdapter dap1 = new SqlDataAdapter("SELECT * FROM HANG_HOA", conn);
            DataTable table1 = new DataTable();
            dap1.Fill(table1);
            cb_tensp.DataSource = table1;
            cb_tensp.DisplayMember = "TenHang";
            cb_tensp.ValueMember = "MaHang";

            txt_masp.DataBindings.Clear();
            txt_masp.DataBindings.Add("Text", cb_tensp.DataSource, "MaHang");
            txt_dongia.DataBindings.Clear();
            txt_dongia.DataBindings.Add("Text", cb_tensp.DataSource, "DonGia");
            txt_donvitinh.DataBindings.Clear();
            txt_donvitinh.DataBindings.Add("Text", cb_tensp.DataSource, "DonViTinh");
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", cb_tensp.DataSource, "SoLuong");
            SqlDataAdapter dap2 = new SqlDataAdapter("SELECT * FROM HANG_HOA WHERE TenHang = N'"+cb_tensp.Text+"'", conn);
            DataTable table2 = new DataTable();
            dap2.Fill(table2);
            cb_nhacc.DataSource = table2;
            cb_nhacc.DisplayMember = "TenNhaCungCap";
            cb_nhacc.ValueMember = "MaNhaCungCap";

            cb_nhacc.DataBindings.Clear();
            cb_nhacc.DataBindings.Add("Text",cb_nhacc.DataSource,"MaNhaCungCap");


            conn.Close();
            if (tinh_trang == 0)
            {
                gb_ttsp.Enabled = false;
                bt_them.Enabled = false;
                bt_xoa.Enabled = false;
                bt_hoanThanh.Enabled = false;
                bt_huy_phieu.Enabled = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cb_tennv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_manv.DataBindings.Clear();
            txt_manv.DataBindings.Add("Text", cb_tennv.DataSource, "MaNhanVien");
        }

        private void cb_tenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_maKH.DataBindings.Clear();
            txt_maKH.DataBindings.Add("Text", cb_tenKH.DataSource, "MaKhachHang");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_donvitinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_tensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_masp.DataBindings.Clear();
            txt_masp.DataBindings.Add("Text", cb_tensp.DataSource, "MaHang");
            txt_dongia.DataBindings.Clear();
            txt_dongia.DataBindings.Add("Text", cb_tensp.DataSource, "DonGia");
            txt_donvitinh.DataBindings.Clear();
            txt_donvitinh.DataBindings.Add("Text", cb_tensp.DataSource, "DonViTinh");
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", cb_tensp.DataSource, "SoLuong");

            SqlDataAdapter dap2 = new SqlDataAdapter("SELECT * FROM HANG_HOA WHERE TenHang = N'" + cb_tensp.Text + "'", conn);
            DataTable table2 = new DataTable();
            dap2.Fill(table2);
            cb_nhacc.DataSource = table2;
            cb_nhacc.DisplayMember = "TenNhaCungCap";
            cb_nhacc.ValueMember = "MaNhaCungCap";

            cb_nhacc.DataBindings.Clear();
            cb_nhacc.DataBindings.Add("Text", cb_nhacc.DataSource, "MaNhaCungCap");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moi += "";
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            dem++;
            //double number = 0;
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
                    kq += drd["MaPhieuXuat"].ToString();
                }
                //chuyen cac so cuoi thanh so
                number = Convert.ToDouble(kq.Substring(2));
                //doi number thanh so            
                txt_masophieu.Text = "PX" + (number + 1);
                conn.Close();
                moi = "PX" + (number + 1);
            }
            else
            {
                txt_masophieu.Text = "PX" + (number + dem);
                moi = "PX" + (number + dem);
                conn.Close();
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (check_dk())
            {
                double thanhtien = 0, sl, dongia;
                sl = Convert.ToDouble(numericUpDown1.Value.ToString());
                dongia = Convert.ToDouble(txt_dongia.Text);
                thanhtien = sl * dongia;
                dgv_xuatkho.Rows.Add(cb_tensp.Text,txt_masp.Text, cb_nhacc.Text, numericUpDown1.Value.ToString(), txt_dongia.Text, thanhtien.ToString());

            }
            else
            {
                MessageBox.Show("Dữ Liệu Bị Trùng");
                return;
            }
        }

        public bool check_dk()
        {
            if (dgv_xuatkho.Rows.Count == 0)
                return true;
            else
            {
                string check = txt_masp.Text, mahang;
                for (int i = 0; i < dgv_xuatkho.Rows.Count; i++)
                {
                    mahang = dgv_xuatkho.Rows[i].Cells["MaHang"].Value.ToString();
                    if (mahang.Equals(check))
                    {
                        return false;
                    }
                }
                return true;
            }

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            foreach (DataGridViewRow item in this.dgv_xuatkho.SelectedRows)
            {
                dgv_xuatkho.Rows.RemoveAt(item.Index);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            
            if (dgv_xuatkho.Rows.Count == 0 )
            {
                MessageBox.Show("Không Có Dữ Liệu");
                return;
            }
            try
            {
                
                string maphieu, mahang, soluong, dongia,sql;
                maphieu = txt_masophieu.Text;

                for (int i = 0; i < dgv_xuatkho.Rows.Count; i++)
                {
                    mahang = dgv_xuatkho.Rows[i].Cells["MaHang"].Value.ToString();
                    soluong = dgv_xuatkho.Rows[i].Cells["SoLuong"].Value.ToString();
                    dongia = dgv_xuatkho.Rows[i].Cells["DonGia"].Value.ToString();

                    sql = "INSERT INTO CHI_TIET_XUAT VALUES ('" + maphieu + "', '" + mahang + "', '" + soluong + "','" + dongia + "')";
                    comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Xuất Kho Thành Công");

                }
            }
            catch (Exception)
            {

                throw;
            }
            txt_masophieu.Text = "";

            groupBox1.Enabled = true;
            gb_ttsp.Enabled = false;
            bt_xoa.Enabled = false;
            bt_them.Enabled = false;
            bt_hoanThanh.Enabled = false;
            bt_huy_phieu.Enabled = false;
            bt_lap_phieu.Enabled = true;
            dgv_xuatkho.Rows.Clear();
            dgv_xuatkho.Refresh();
            conn.Close();
        }

        private void bt_huy_phieu_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            bt_lap_phieu.Enabled = true;
            gb_ttsp.Enabled = false;
            bt_xoa.Enabled = false;
            bt_them.Enabled = false;
            bt_hoanThanh.Enabled = false;
            txt_masophieu.Text = "";
        }

        private void bt_lap_phieu_Click(object sender, EventArgs e)
        {
            if(txt_masophieu.Text == "")
            {
                MessageBox.Show("Mã Phiếu Không Tồn Tại");
                return;
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            DateTime ngayhientai = DateTime.Today;
            int ngay, thang, nam;
            ngay = ngayhientai.Day;
            thang = ngayhientai.Month;
            nam = ngayhientai.Year;

            int ngay1, thang1, nam1;
            DateTime ngaynhap = dateTimePicker1.Value;
            ngay1 = ngaynhap.Day;
            thang1 = ngaynhap.Month;
            nam1 = ngaynhap.Year;
            bool checkday = false;
            if (nam - nam1 == 0)
            {
                if (thang - thang1 == 0)
                {
                    if (ngay - ngay1 < 7 && ngay - ngay1 >= 0)
                    {
                        MessageBox.Show("Hợp Lệ");
                        checkday = true;
                    }
                }
            }
            if (checkday == false)
            {
                MessageBox.Show("Ngày Không Hợp Lệ");
                return;
            }
            try
            {
                string sql = "INSERT INTO PHIEU_XUAT VALUES  ( '" + txt_masophieu.Text + "' , '" + dateTimePicker1.Text + "' ,'" + txt_manv.Text + "' ,'" + txt_maKH.Text + "')";
                comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Thêm Dữ Liệu Thành Công");

                sql = "UPDATE MaMoiNhat SET MaPhieuXuat = '" + txt_masophieu.Text + "'";
                comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();

            }
            catch (Exception)
            {

                
            }
            groupBox1.Enabled = false;
            bt_lap_phieu.Enabled = false;
            gb_ttsp.Enabled = true;
            bt_hoanThanh.Enabled = true;
            bt_them.Enabled = true;
            bt_xoa.Enabled = true;
            bt_huy_phieu.Enabled = true;
            conn.Close();


        }
    }
}
