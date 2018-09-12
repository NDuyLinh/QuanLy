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
    public partial class XemThongTin : DevExpress.XtraEditors.XtraForm
    {
        public XemThongTin()
        {
            InitializeComponent();
        }

        XemThongTinBUS bus = new XemThongTinBUS();

        private void XemThongTin_Load(object sender, EventArgs e)
        {
            data.DataSource = bus.getdataNhanVien();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";


            var items = new[] {
                new { Text = "tháng 1", Value = "1" },
                new { Text = "tháng 2", Value = "2" },
                new { Text = "tháng 3", Value = "3" },
                new { Text = "tháng 4", Value = "4" },
                new { Text = "tháng 5", Value = "5" },
                new { Text = "tháng 6", Value = "6" },
                new { Text = "tháng 7", Value = "7" },
                new { Text = "tháng 8", Value = "8" },
                new { Text = "tháng 9", Value = "9" },
                new { Text = "tháng 10", Value = "10" },
                new { Text = "tháng 11", Value = "11" },
                new { Text = "tháng 12", Value = "12" }
            };
            comboBox1.DataSource = items;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aaa = comboBox1.SelectedValue.ToString();
            bus.GetdataByMonth(aaa);
            data.DataSource = bus.GetdataByMonth(aaa);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string aaa = textBox1.Text;
            data.DataSource = bus.SeatchData(aaa);

        }
    }
}