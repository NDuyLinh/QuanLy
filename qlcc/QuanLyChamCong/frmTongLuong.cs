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
    public partial class frmTongLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmTongLuong()
        {
            InitializeComponent();
        }
        TongLuongBUS bus = new TongLuongBUS();

        private void frmTongLuong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.GetData();
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                //string maNV = dataGridView1.Rows[i].Cells["MaNV"].Value.ToString();
                //dataGridView1.Rows[i].Cells[5].Value = bus.getSoNgayLam(maNV);
                string maNV = dataGridView1.Rows[i].Cells["MaNV"].Value.ToString();
                string songaylam = bus.getSoNgayLam(maNV);
                dataGridView1.Rows[i].Cells["SoNgayLam"].Value = songaylam;
                int luongcoban = int.Parse(dataGridView1.Rows[i].Cells["LuongCoBan"].Value.ToString());
                double tongluong = ((double)luongcoban / 26) * int.Parse(songaylam);
                dataGridView1.Rows[i].Cells["TongLuong"].Value = ((int)tongluong/1000)*1000;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}