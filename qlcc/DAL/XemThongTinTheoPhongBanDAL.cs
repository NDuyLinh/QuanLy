using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XemThongTinTheoPhongBanDAL
    {
        DBConnect db = new DBConnect();

        public DataTable GetDataByPB()
        {
            return db.GetData("SELECT nhanvien.MaNhanVien,phongban.TenPB,nhanvien.TenNV,nhanvien.NgayVaoLam FROM phongban JOIN nhanvien on nhanvien.MaPB = phongban.MaPB");
        }

        public DataTable GetDataByID(string id)
        {
            return db.GetData("SELECT nhanvien.MaNhanVien,nhanvien.TenNV,nhanvien.NgayVaoLam,phongban.TenPB FROM phongban inner JOIN nhanvien ON phongban.MaPB = nhanvien.MaPB where phongban.MaPB = '" + id+"'");
        }
    }
}
