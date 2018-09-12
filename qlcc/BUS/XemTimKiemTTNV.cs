using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class XemTimKiemTTNV
    {
        TimKiemTTNVDAL dal = new TimKiemTTNVDAL();

        public DataTable GetData()
        {
            return dal.GetData();
        }

        public DataTable TimKiemTen(string name)
        {
            return dal.TimKiemTheoTen(name);
        }

        public DataTable TImKiemtheogioitinh(string gioitinh)
        {
            return dal.TimKiemTheoGioiTinh(gioitinh);
        }
    }
}
