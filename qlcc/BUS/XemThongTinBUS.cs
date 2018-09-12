using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class XemThongTinBUS
    {
        ThongTinNhanVienDAL dal = new ThongTinNhanVienDAL();

        public DataTable getdataNhanVien()
        {
            return dal.XemThongTin();
        } 

        public DataTable GetdataByMonth(string month)
        {
            return dal.GetDataNVByMonth(month);
        }

        public DataTable SeatchData(string str)
        {
            return dal.SearchData(str);
        }
    }
}
