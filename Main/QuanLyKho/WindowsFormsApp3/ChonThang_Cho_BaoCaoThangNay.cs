using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class ChonThang_Cho_BaoCaoThangNay : Form
    {
        public ChonThang_Cho_BaoCaoThangNay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaoCao_DanhThuThangNay.thang = (int)numericUpDown1.Value;
            BaoCao_DanhThuThangNay frm = new BaoCao_DanhThuThangNay();
            frm.Show();

        }
    }
}
