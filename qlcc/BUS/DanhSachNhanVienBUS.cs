using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class DanhSachNhanVienBUS
    {
        DanhSachNhanVienDAL dal = new DanhSachNhanVienDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }
    }
}
