using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;


namespace DAL
{
    public class DanhSachNhanVienDAL
    {
        DBConnect db = new DBConnect();

        public DataTable GetData()
        {
            return db.GetData("DanhSachNhanVienNghiLam");
        }
        //SELECT nhanvien.MaNhanVien,nhanvien.TenNV,chamcong.Ngay FROM nhanvien INNER JOIN chamcong on nhanvien.MaNhanVien = chamcong.MaNhanVien where chamcong.Ngay = ''
    }
}
