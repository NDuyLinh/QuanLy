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

namespace QuanLyChamCong
{
    public partial class frmSoNgayDiLam : DevExpress.XtraEditors.XtraForm
    {
        public frmSoNgayDiLam()
        {
            InitializeComponent();
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
    }
}