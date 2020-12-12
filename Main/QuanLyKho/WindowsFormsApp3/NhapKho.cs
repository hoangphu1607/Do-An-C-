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
    public partial class NhapKho : Form
    {
        public NhapKho()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        SqlCommand comm;
        string moi = "";
        int dem = 0,tinh_trang=0;
        double number = 0;
        private void NhapKho_Load(object sender, EventArgs e)
        {
            //đổ dữ liệu từ sql sang combox nhân viên

            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM NHAN_VIEN", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            cb_tennv.DataSource = table;
            cb_tennv.DisplayMember = "TenNhanVien";
            cb_tennv.ValueMember = "MaNhanVien";

            //đổ dữ liệu từ sql sang combox nhà cung cấp

            dap = new SqlDataAdapter("SELECT * FROM NHA_CUNG_CAP", conn);
            table = new DataTable();
            dap.Fill(table);
            cb_nhacungcap.DataSource = table;
            
            cb_nhacungcap.ValueMember = "MaNhaCungCap";
            cb_nhacungcap.DisplayMember = "TenNhaCungCap";
            txt_manv.Text = cb_tennv.SelectedValue.ToString();

            //đổ dữ liệu từ sql sang 
            dap = new SqlDataAdapter("SELECT * FROM HANG_HOA", conn);
            //DataSet ds = new DataSet();
            table = new DataTable();
            dap.Fill(table);
            cb_tensp.DataSource = table;
            cb_tensp.DisplayMember = "TenHang";
            cb_tensp.ValueMember = "MaHang";

            txt_masp.DataBindings.Clear();
            txt_masp.DataBindings.Add("Text", cb_tensp.DataSource, "MaHang");

            txt_dongia.DataBindings.Clear();
            txt_dongia.DataBindings.Add("Text", cb_tensp.DataSource, "DonGia");

            txt_donvitinh.DataBindings.Clear();
            txt_donvitinh.DataBindings.Add("Text", cb_tensp.DataSource, "DonViTinh");


            //txt_tensanpham.Text = cb_masanpham.SelectedValue.ToString();
            conn.Close();
            if (tinh_trang == 0)
            {
                groupBox2.Enabled = false;
                bt_them.Enabled = false;
                bt_xoa.Enabled = false;
                bt_hoan_thanh.Enabled = false;
            }
            
        }

        private void cb_manhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {            
            txt_manv.Text = cb_tennv.SelectedValue.ToString(); 
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        public bool check_dk()
        {
            if (dgv_NhapHang.Rows.Count == 0)
                return true;
            else
            {
                string check = txt_masp.Text, mahang;
                for (int i = 0; i < dgv_NhapHang.Rows.Count; i++)
                {
                    mahang = dgv_NhapHang.Rows[i].Cells["MaHang"].Value.ToString();
                    if (mahang.Equals(check))
                    {
                        return false;
                    }
                }
                return true;
            }
           
        }
        private void cb_masanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                txt_masp.DataBindings.Clear();
                txt_masp.DataBindings.Add("Text", cb_tensp.DataSource, "MaHang");

                txt_dongia.DataBindings.Clear();
                txt_dongia.DataBindings.Add("Text", cb_tensp.DataSource, "DonGia");

                txt_donvitinh.DataBindings.Clear();
                txt_donvitinh.DataBindings.Add("Text", cb_tensp.DataSource, "DonViTinh");
            
           

            
        }

        private void txt_tensanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_nhacungcap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (check_dk())
            {
                if (txt_masophieu.Text.Equals(""))
                {
                    MessageBox.Show("Không được bỏ trống");
                    return;
                }
                dgv_NhapHang.Rows.Add(cb_tensp.Text, txt_masp.Text, txt_donvitinh.Text, nbu_sl.Value.ToString(), txt_dongia.Text);
            }
            else
            {
                MessageBox.Show("Dữ Liệu Bạn Chọn Bị Trùng");
                return;
            }    
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            foreach (DataGridViewRow item in this.dgv_NhapHang.SelectedRows)
            {
                dgv_NhapHang.Rows.RemoveAt(item.Index);
            }
            conn.Close();
        }

        private void dgv_NhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int numrow;
                numrow = e.RowIndex;
                cb_tensp.Text = dgv_NhapHang.Rows[numrow].Cells[0].Value.ToString();
                txt_masp.Text = dgv_NhapHang.Rows[numrow].Cells[1].Value.ToString();
                nbu_sl.Text = dgv_NhapHang.Rows[numrow].Cells[2].Value.ToString();
                txt_dongia.Text = dgv_NhapHang.Rows[numrow].Cells[3].Value.ToString();
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //if (dgv_NhapHang.SelectedRows.Count != 1)
            //{
            //    MessageBox.Show("Sai dữ liệu");
            //    return;
            //}
                
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(conn.State ==ConnectionState.Closed)
                conn.Open();
            if(dgv_NhapHang.Rows.Count == 0 || tinh_trang==0)
            {
                MessageBox.Show("Không Có Dữ Liệu");
                return;
            }
            try
            {             
                string maphieu, mahang, soluong, dongia;
                maphieu = txt_masophieu.Text;

                for (int i = 0; i < dgv_NhapHang.Rows.Count; i++)
                {
                    mahang = dgv_NhapHang.Rows[i].Cells["MaHang"].Value.ToString();
                    soluong = dgv_NhapHang.Rows[i].Cells["SoLuong"].Value.ToString();
                    dongia = dgv_NhapHang.Rows[i].Cells["DonGia"].Value.ToString();

                    string sql = "INSERT INTO CHI_TIET_NHAP VALUES ('" + maphieu + "', '" + mahang + "', '" + soluong + "','" + dongia + "')";
                    comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();

                }
                tinh_trang = 0;
                if(tinh_trang == 0)
                {
                    bt_huy_phieu.Enabled = false;
                    groupBox2.Enabled = false;
                    bt_them.Enabled = false;
                    bt_xoa.Enabled = false;
                    bt_hoan_thanh.Enabled = false;
                    bt_lap_phieu.Enabled = true;
                    bt_themPhieu.Enabled = true;
                    dateTimePicker1.Enabled = true;
                    cb_tennv.Enabled = true;
                    txt_masophieu.Clear();
                }
                MessageBox.Show("Hàng Hóa Vào Kho Thành Công");

                dgv_NhapHang.Rows.Clear();
                dgv_NhapHang.Refresh();
            }
            catch
            {
                
                //MessageBox.Show("Thêm Dữ Liệu Thất Bại!!!");
            }            




            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ////TimeSpan te = ngayhientai + 1;
            //TimeSpan Time = ngaynhap - ngayhientai;
            ////MessageBox.Show(Time.Days.ToString());
            //MessageBox.Show("Ngay - Thang - Nam: "+ngay+thang+nam);
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
                    kq += drd["MaPhieuNhap"].ToString();
                }
                //chuyen cac so cuoi thanh so
                number = Convert.ToDouble(kq.Substring(2));
                //doi number thanh so            
                txt_masophieu.Text = "PN" + (number + 1);
                conn.Close();
                moi = "PN" + (number + 1);
            }
            else
            {
                txt_masophieu.Text = "PN" + (number + dem);
                moi = "PN" + (number + dem);
                conn.Close();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lb_spmoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Them_HangHoa themHang = new Them_HangHoa();
            themHang.MdiParent = this.MdiParent;
            themHang.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) {
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
                conn.Open();
                try
                {
                    string sql = "Insert into  PHIEU_NHAP VALUES ('" + txt_masophieu.Text + "','" + dateTimePicker1.Text + "','" + txt_manv.Text + "')";
                    comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Lập Phiếu Nhập Thành Công");

                    sql = "UPDATE MaMoiNhat SET MaPhieuNhap = '" + txt_masophieu.Text + "'";
                    comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    MessageBox.Show("Mã Phiếu đã tồn tại");
                }
                

                dateTimePicker1.Enabled = false;
                bt_themPhieu.Enabled = false;
                cb_tennv.Enabled = false;
                txt_manv.Enabled = false;
                bt_lap_phieu.Enabled = false;
                tinh_trang++;
                if (tinh_trang == 1)
                {
                    groupBox2.Enabled = true;
                    bt_them.Enabled = true;
                    bt_xoa.Enabled = true;
                    bt_hoan_thanh.Enabled = true;
                    bt_huy_phieu.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Không Thể Kết Nối Đến Dữ Liệu");
            }
        }

        private void bt_huy_phieu_Click(object sender, EventArgs e)
        {
            txt_masophieu.Clear();
            dateTimePicker1.Enabled = true;
            bt_themPhieu.Enabled = true;
            cb_tennv.Enabled = true;
            //txt_manv.Enabled = true;
            bt_lap_phieu.Enabled = true;
            tinh_trang = 0;
            if(tinh_trang == 0)
            {
                groupBox2.Enabled = false;
                bt_them.Enabled = false;
                bt_xoa.Enabled = false;
                bt_hoan_thanh.Enabled = false;
            }
        }
    }
}
