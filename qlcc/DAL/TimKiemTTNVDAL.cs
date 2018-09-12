using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TimKiemTTNVDAL
    {

        DBConnect db = new DBConnect();

        public DataTable GetData()
        {
            return db.GetData("SELECT nhanvien.MaNhanVien,nhanvien.TenNV,nhanvien.GioiTinh,chucvu.TenCV FROM chucvu inner JOIN nhanvien ON chucvu.MaCV = nhanvien.MaCV");
        }


        public DataTable TimKiemTheoTen(string name)
        {
            return db.GetData("SELECT nhanvien.MaNhanVien,nhanvien.TenNV,chucvu.TenCV,nhanvien.GioiTinh FROM nhanvien INNER JOIN chucvu on nhanvien.MaCV = chucvu.MaCV WHERE nhanvien.TenNV LIKE '%" + name + "%' ");
        }

        public DataTable TimKiemTheoGioiTinh(string gioitinh)
        {
            return db.GetData("SELECT nhanvien.MaNhanVien,nhanvien.TenNV,chucvu.TenCV,nhanvien.GioiTinh FROM nhanvien INNER JOIN chucvu on nhanvien.MaCV = chucvu.MaCV WHERE nhanvien.GioiTinh = '"+gioitinh+"'");
        }
    }
}
