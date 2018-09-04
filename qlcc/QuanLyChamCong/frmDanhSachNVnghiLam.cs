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
    public partial class frmDanhSachNVnghiLam : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachNVnghiLam()
        {
            InitializeComponent();
        }

        DanhSachNhanVienBUS bus = new DanhSachNhanVienBUS();

        private void frmDanhSachNVnghiLam_Load(object sender, EventArgs e)
        {
            data.DataSource = bus.GetData();
        }
    }
}