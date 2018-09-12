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
    public partial class frmXemThongTinTheoPB : DevExpress.XtraEditors.XtraForm
    {
        public frmXemThongTinTheoPB()
        {
            InitializeComponent();
        }

        PhongBanBUS bus1 = new PhongBanBUS();

        XemThongTinTheoPhongBanBUS bus = new XemThongTinTheoPhongBanBUS(); 

        private void frmXemThongTinTheoPB_Load(object sender, EventArgs e)
        {
            data.DataSource = bus.XemThongTin();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.DataSource = bus1.GetData();
            comboBox1.DisplayMember = "TenPB";
            comboBox1.ValueMember = "MaPB";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aaa = comboBox1.SelectedValue.ToString();
            data.DataSource = bus.GetDataByID(aaa);
        }
    }
}