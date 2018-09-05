using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ValueObject;
namespace BUS
{
    public class DanhSachNVNghiLamBUS
    {
        DanhSachNVNghiLamDAL dal = new DanhSachNVNghiLamDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }

        public DataTable GetDataNVNghiCoPhep()
        {
            return dal.GetDataNVNghiCoPhep();
        }

        public DataTable SelectDataNVNghiCoPhep(ChamCong obj)
        {
            return dal.SelectDataNVNghiCoPhepByID(obj);
        }

        public DataTable SelectNVNghiTheoMonth(string month)
        {
            return dal.SelectNVNghiTheoThang(month);
        }
    }
}
