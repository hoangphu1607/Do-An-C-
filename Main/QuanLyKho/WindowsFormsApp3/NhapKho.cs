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
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM NHAN_VIEN", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            cb_manhanvien.DataSource = table;
            cb_manhanvien.DisplayMember = "MaNhanVien";
            cb_manhanvien.ValueMember = "TenNhanVien";

            dap = new SqlDataAdapter("SELECT * FROM NHA_CUNG_CAP", conn);
            table = new DataTable();
            dap.Fill(table);
            cb_nhacungcap.DataSource = table;
            cb_nhacungcap.DisplayMember = "MaNhaCungCap";
            cb_nhacungcap.ValueMember = "TenNhaCungCap";
            conn.Close();
        }

        private void cb_manhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {            
            txt_tennhanvien.Text = cb_manhanvien.SelectedValue.ToString(); 
        }
    }
}
