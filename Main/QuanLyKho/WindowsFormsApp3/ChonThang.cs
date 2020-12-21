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
    public partial class ChonThang : Form
    {
        public ChonThang()
        {
            InitializeComponent();
        }
        public static int trangthai;

        private void button1_Click(object sender, EventArgs e)
        {
            if(trangthai == 1)
            {
                BaoCao_BanNhieuNhat.thang = (int)numericUpDown1.Value;
                BaoCao_BanNhieuNhat frm = new BaoCao_BanNhieuNhat();
                frm.Show();
            }
            else if(trangthai == 3)
            {
                BaoCao_HangNhapNhieuNhat.thang = (int)numericUpDown1.Value;
                BaoCao_HangNhapNhieuNhat frm = new BaoCao_HangNhapNhieuNhat();
                frm.Show();
            }
            else if(trangthai == 4)
            {
                BaoCao_NhapHangThangNay.thang = (int)numericUpDown1.Value;
                BaoCao_NhapHangThangNay frm = new BaoCao_NhapHangThangNay();
                frm.Show();
            }
            
        }

        private void ChonThang_Load(object sender, EventArgs e)
        {

        }
    }
}
