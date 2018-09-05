using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class TongLuongBUS
    {
        TongLuongDAL dal = new TongLuongDAL();

        public DataTable GetData()
        {
            return dal.GetData();
        }

        public string getSoNgayLam(string MaNV)
        {
            DataTable dt = dal.GetNhanVien(MaNV);
            if (dt.Rows.Count > 0)
                return dt.Rows[0][2].ToString();

            return "0";
        }
    }
}
