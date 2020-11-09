using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class TuyChon : Form
    {
        public TuyChon()
        {
            InitializeComponent();
        }

        private void TuyChon_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nhaphang a = new Nhaphang();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xuatkho a = new xuatkho();
            a.Show();
        }
    }
}
