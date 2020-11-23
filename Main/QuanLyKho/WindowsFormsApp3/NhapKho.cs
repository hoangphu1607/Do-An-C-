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
        private void NhapKho_Load(object sender, EventArgs e)
        {
            //đổ dữ liệu từ sql sang combox nhân viên

            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM NHAN_VIEN", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            cb_manhanvien.DataSource = table;
            cb_manhanvien.DisplayMember = "MaNhanVien";
            cb_manhanvien.ValueMember = "TenNhanVien";

            //đổ dữ liệu từ sql sang combox nhà cung cấp

            dap = new SqlDataAdapter("SELECT * FROM NHA_CUNG_CAP", conn);
            table = new DataTable();
            dap.Fill(table);
            cb_nhacungcap.DataSource = table;
            
            cb_nhacungcap.ValueMember = "MaNhaCungCap";
            cb_nhacungcap.DisplayMember = "TenNhaCungCap";
            txt_tennhanvien.Text = cb_manhanvien.SelectedValue.ToString();

            //đổ dữ liệu từ sql sang 
            dap = new SqlDataAdapter("SELECT * FROM HANG_HOA", conn);
            //DataSet ds = new DataSet();
            table = new DataTable();
            dap.Fill(table);
            cb_masanpham.DataSource = table;
            cb_masanpham.DisplayMember = "MaHang";
            cb_masanpham.ValueMember = "MaHang";

            txt_tensanpham.DataBindings.Clear();
            txt_tensanpham.DataBindings.Add("Text", cb_masanpham.DataSource, "TenHang");

            txt_dongia.DataBindings.Clear();
            txt_dongia.DataBindings.Add("Text", cb_masanpham.DataSource, "DonGia");

            txt_donvitinh.DataBindings.Clear();
            txt_donvitinh.DataBindings.Add("Text", cb_masanpham.DataSource, "DonViTinh");


            //txt_tensanpham.Text = cb_masanpham.SelectedValue.ToString();
            conn.Close();
        }

        private void cb_manhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {            
            txt_tennhanvien.Text = cb_manhanvien.SelectedValue.ToString(); 
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cb_masanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_tensanpham.DataBindings.Clear();
            txt_tensanpham.DataBindings.Add("Text", cb_masanpham.DataSource, "TenHang");

            txt_dongia.DataBindings.Clear();
            txt_dongia.DataBindings.Add("Text", cb_masanpham.DataSource, "DonGia");

            txt_donvitinh.DataBindings.Clear();
            txt_donvitinh.DataBindings.Add("Text", cb_masanpham.DataSource, "DonViTinh");
        }

        private void txt_tensanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_nhacungcap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (txt_masophieu.Text.Equals(""))
            {
                MessageBox.Show("Không được bỏ trống");
                return;
            }
            dgv_NhapHang.Rows.Add(cb_masanpham.Text,txt_tensanpham.Text,nbu_sl.Value,txt_dongia.Text);



            
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
                cb_masanpham.Text = dgv_NhapHang.Rows[numrow].Cells[0].Value.ToString();
                txt_tensanpham.Text = dgv_NhapHang.Rows[numrow].Cells[1].Value.ToString();
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
    }
}
