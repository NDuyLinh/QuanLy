using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;


namespace QuanLyChamCong
{
    public partial class FrmTimKiemTTNV : DevExpress.XtraEditors.XtraForm
    {
        public FrmTimKiemTTNV()
        {
            InitializeComponent();
        }

        XemTimKiemTTNV bus = new XemTimKiemTTNV();

        private void FrmTimKiemTTNV_Load(object sender, EventArgs e)
        {
            data.DataSource = bus.GetData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string aaa = textBox1.Text;
             data.DataSource = bus.TimKiemTen(aaa);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Text = "Nam";
            radioButton2.Text = "Nữ";
            if (radioButton1.Checked)
            {
                data.DataSource = bus.TImKiemtheogioitinh(radioButton1.Text.ToString());
            }
            else
            {
                data.DataSource = bus.TImKiemtheogioitinh(radioButton2.Text.ToString());
            
            }
        }

        
    }
}
