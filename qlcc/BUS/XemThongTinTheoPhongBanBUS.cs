using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class XemThongTinTheoPhongBanBUS
    {
        XemThongTinTheoPhongBanDAL dal = new XemThongTinTheoPhongBanDAL();

        public DataTable XemThongTin()
        {
            return dal.GetDataByPB();
        }

        public DataTable GetDataByID(string id)
        {
            return dal.GetDataByID(id);
        }
    }
}
