using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;


namespace DAL
{
    public class DanhSachNVNghiLamDAL
    {
        DBConnect db = new DBConnect();

        public DataTable GetData()
        {
            return db.GetData("DanhSachNhanVienNghiLam");
        }
        //SELECT nhanvien.MaNhanVien,nhanvien.TenNV,chamcong.Ngay FROM nhanvien INNER JOIN chamcong on nhanvien.MaNhanVien = chamcong.MaNhanVien where chamcong.Ngay = ''

        public DataTable GetDataNVNghiCoPhep()
        {
            return db.GetData("DanhSachNhanVienNghiLamCoPhep");
        }

        public DataTable SelectDataNVNghiCoPhepByID(ChamCong obj)
        {
            return db.GetData("SELECT nhanvien.MaNhanVien, nhanvien.TenNV, chamcong.Ngay FROM `chamcong` JOIN nhanvien on chamcong.MaNhanVien = nhanvien.MaNhanVien WHERE chamcong.TinhTrang = 'Nghỉ Làm Có Phép' and chamcong.Ngay = '" + obj.Ngay + "'");
        }

        //public DataTable SelectDataNVNghiCoPhepByID(string date)
        //{
        //    MySqlParameter[] para = new MySqlParameter
        //    {
        //         new MySqlParameter("date",date)
        //    }
        //    return db.GetData("DanhSachNhanVienNghiLamCoPhep_By_ID",para);
        //}

        public DataTable SelectNVNghiTheoThang(String month)
        {
            return db.GetData("SELECT nhanvien.MaNhanVien, nhanvien.TenNV, chamcong.Ngay FROM chamcong INNER JOIN nhanvien ON chamcong.MaNhanVien = nhanvien.MaNhanVien WHERE MONTH(Ngay) = '"+month+"' AND YEAR(Ngay) = YEAR(NOW())");
        }
    }
}
