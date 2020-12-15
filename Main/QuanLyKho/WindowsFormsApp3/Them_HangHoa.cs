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
    public partial class Them_HangHoa : Form
    {
        public Them_HangHoa()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        SqlCommand comm;
        string moi;
        double dem = 0,number = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_nhomhang.Enabled = true;
            txt_nhomhang.Text = "";
            cb_mh.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void Them_HangHoa_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter daps = new SqlDataAdapter("SELECT * FROM NHA_CUNG_CAP", conn);
            DataTable table1 = new DataTable();
            daps.Fill(table1);
            cb_nhacungcap.DataSource = table1;
            cb_nhacungcap.DisplayMember = "TenNhaCungCap";
            cb_nhacungcap.ValueMember = "MaNhaCungCap";
            txt_mancc.DataBindings.Clear();
            txt_mancc.DataBindings.Add("Text", cb_nhacungcap.DataSource, "MaNhaCungCap");

            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM NHOM_HANG", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            cb_mh.DataSource = table;
            cb_mh.DisplayMember = "TenNhom";
            cb_mh.ValueMember = "MaNhom";
            txt_nhomhang.DataBindings.Clear();
            txt_nhomhang.DataBindings.Add("Text", cb_mh.DataSource, "MaNhom");

            

            conn.Close();
        }

        private void cb_mh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_nhomhang.DataBindings.Clear();
            txt_nhomhang.DataBindings.Add("Text", cb_mh.DataSource, "MaNhom");
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            conn.Open();
            if(txt_tensp.Text.Equals("") || txt_dongia.Text.Equals("") || txt_donvitinh.Text.Equals("") || cb_mh.Text.Equals("") || txt_nhomhang.Text.Equals("") || txt_masp.Text.Equals(""))
            {
                MessageBox.Show("Thông Tin Bị Thiếu");
                return;
            }
            string sql;

            sql = "INSERT INTO dbo.HANG_HOA( MaHang ,TenHang ,DonViTinh ,MaNhomHang ,MaNhaCungCap ,SoLuong ,DonGia)  VALUES  ('" + txt_masp.Text+"',N'"+txt_tensp.Text+"',N'"+txt_donvitinh.Text+"','"+txt_nhomhang.Text+"','"+txt_mancc.Text+"','0','"+txt_dongia.Text+"')";
            comm = new SqlCommand(sql, conn);
            comm.ExecuteNonQuery();

            sql = "UPDATE MaMoiNhat SET MaHang = '"+txt_masp.Text+"'";
            comm = new SqlCommand(sql, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Thêm Dữ Liệu Thành Công");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                sql = "INSERT INTO NHOM_HANG( MaNhom, TenNhom ) VALUES ('" + cb_mh.Text + "',N'" + txt_nhomhang.Text + "')";
                comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Cập Nhật Dữ Liệu Thành Công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu Đã Tồn Tại Hoặc Lỗi!!!");
            }
        }

        private void txt_donvitinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_nhacungcap_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txt_mancc.DataBindings.Clear();
            txt_mancc.DataBindings.Add("Text",cb_nhacungcap.DataSource,"MaNhaCungCap");
        }

        private void lb_spmoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Them_NhomHang frm = new Them_NhomHang();
            frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void bt_lammoi_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM NHOM_HANG", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            cb_mh.DataSource = table;
            cb_mh.DisplayMember = "TenNhom";
            cb_mh.ValueMember = "MaNhom";
            txt_nhomhang.DataBindings.Clear();
            txt_nhomhang.DataBindings.Add("Text", cb_mh.DataSource, "MaNhom");
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
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
                    kq += drd["MaHang"].ToString();
                }
                //chuyen cac so cuoi thanh so
                number = Convert.ToDouble(kq);
                //doi number thanh so            
                txt_masp.Text =  (number + 1)+"";
                conn.Close();
                moi = (number + 1)+"";
            }
            else
            {
                txt_masp.Text = (number + dem)+"";
                moi = (number + dem)+"";
                conn.Close();
            }
        }
    }
}
