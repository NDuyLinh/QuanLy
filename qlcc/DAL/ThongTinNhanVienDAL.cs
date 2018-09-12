using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     public class ThongTinNhanVienDAL
    {
        DBConnect db = new DBConnect();

        public DataTable XemThongTin()
        {
            return db.GetData("SELECT nhanvien.MaNhanVien,nhanvien.TenNV,chamcong.TinhTrang,chamcong.Ngay FROM nhanvien INNER JOIN chamcong on nhanvien.MaNhanVien = chamcong.MaNhanVien");
        }

        public DataTable GetDataNVByMonth(string month)
        {
            return db.GetData("SELECT nhanvien.MaNhanVien,nhanvien.TenNV,chamcong.TinhTrang,chamcong.Ngay FROM nhanvien INNER JOIN chamcong on nhanvien.MaNhanVien = chamcong.MaNhanVien WHERE Month(ngay) = '" + month + "'");
        }

        public DataTable SearchData(string str)
        {
            return db.GetData("SELECT nhanvien.MaNhanVien,nhanvien.TenNV,chamcong.TinhTrang,chamcong.Ngay FROM nhanvien INNER JOIN chamcong on nhanvien.MaNhanVien = chamcong.MaNhanVien WHERE nhanvien.TenNV LIKE '%"+str+"%' ");
        }
    }
}
