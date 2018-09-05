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
using ValueObject;
using BUS;

namespace QuanLyChamCong
{
    public partial class frmDanhSachNVNghiLamCoPhep : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachNVNghiLamCoPhep()
        {
            InitializeComponent();
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "dd/MM/yyyy";
            date.ShowUpDown = true;
        }

        DanhSachNVNghiLamBUS bus = new DanhSachNVNghiLamBUS();
        ChamCong obj = new ChamCong();

        private void frmDanhSachNVNghiLamCoPhep_Load(object sender, EventArgs e)
        {
            data.DataSource = bus.GetDataNVNghiCoPhep();
            SetMyCustomFormat();
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
                string date1 = date.Value.Date.ToString("yyyy/MM/dd");
                //bus.SelectDataNVNghiCoPhep(obj.Ngay);
                //MessageBox.Show(obj.Ngay = date.Value.Date.ToString("yyyy/MM/dd"));
                obj.Ngay = date1;
                try
                {
                    bus.SelectDataNVNghiCoPhep(obj);
                    data.DataSource = bus.SelectDataNVNghiCoPhep(obj);
                    //data.Rows[0].Cells[2].Value = date.Value.ToString();
                }
                catch
                {

                }
         
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            data.DataSource = bus.GetDataNVNghiCoPhep();
        }

     
    }
}