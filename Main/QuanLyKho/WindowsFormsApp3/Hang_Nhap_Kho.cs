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
    public partial class Hang_Nhap_Kho : Form
    {
        public Hang_Nhap_Kho()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N15KRQ0\SQLEXPRESS;Initial Catalog=QLKho;Integrated Security=True");
        SqlCommand comm;
        string maphieu;
        private void cbb_MaPhieuXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM dbo.PHIEU_NHAP  WHERE  MaSoPhieuNhap = '" + cbb_MaPhieuXuat.Text + "'", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            dgv_Hang_Nhap.DataSource = table;


            conn.Close();
        }

        private void dtb_ngaytim_ValueChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM dbo.PHIEU_NHAP WHERE NgayLapPhieu = '" + dtb_ngaytim.Text + "'", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            dgv_Hang_Nhap.DataSource = table;


            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ngay1, thang1, nam1;
            DateTime ngaynhap = dt_ngaybt.Value;
            ngay1 = ngaynhap.Day;
            thang1 = ngaynhap.Month;
            nam1 = ngaynhap.Year;
            DateTime ngaykt = dt_ngaykt.Value;
            int ngay, thang, nam;
            ngay = ngaykt.Day;
            thang = ngaykt.Month;
            nam = ngaykt.Year;

            bool checkday = false;
            if (nam - nam1 >= 0)
            {
                if (thang - thang1 >= 0)
                {
                    if (ngay - ngay1 >= 0)
                    {
                        MessageBox.Show("Hợp Lệ");
                        checkday = true;
                    }
                }
            }
            if (checkday == false)
            {
                MessageBox.Show("Ngày Tìm Kiếm Không Hợp Lệ");
                return;
            }
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM dbo.PHIEU_NHAP  WHERE  NgayLapPhieu BETWEEN '" + dt_ngaybt.Text + "' and   '" + dt_ngaykt.Text + "' ORDER BY NgayLapPhieu ASC", conn);
                DataTable table = new DataTable();
                dap.Fill(table);
                dgv_Hang_Nhap.DataSource = table;


                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Không Thể Kết Nối CSDL");
            }
        }

        private void Hang_Nhap_Kho_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM PHIEU_NHAP", conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbb_MaPhieuXuat.DataSource = table;
            cbb_MaPhieuXuat.DisplayMember = "MaSoPhieuNhap";
            cbb_MaPhieuXuat.ValueMember = "MaSoPhieuNhap";
            conn.Close();
        }

        private void dgv_Hang_Xuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int number;
                number = e.RowIndex;
                maphieu = "";
                maphieu = dgv_Hang_Nhap.Rows[number].Cells[0].Value.ToString();
                conn.Open();

                string sql = "SELECT * FROM dbo.CHI_TIET_NHAP WHERE MaPhieu = '"+maphieu+"'";
                SqlDataAdapter dap = new SqlDataAdapter(sql,conn);
                DataTable table = new DataTable();
                dap.Fill(table);
                dgv_chitietnhap.DataSource = table;

                conn.Close();
            }
        }

        private void dgv_Hang_Xuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bt_baocao_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maphieu);
            BaoCao_HangNhap.maphieu = maphieu;
            BaoCao_HangNhap frm = new BaoCao_HangNhap();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
