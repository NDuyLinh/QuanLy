using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TongLuongDAL
    {
        DBConnect db = new DBConnect();

        public DataTable GetData()
        {
            return db.GetData("SELECT nhanvien.MaNhanVien,nhanvien.TenNV,nhanvien.SoCM,phongban.TenPB,chucvu.TenCV,luong.LuongCB FROM `nhanvien` INNER JOIN phongban ON nhanvien.MaPB = phongban.MaPB INNER JOIN chucvu on nhanvien.MaCV = chucvu.MaCV INNER JOIN luong ON nhanvien.HeSoLuong = luong.HeSoLuong");
        }
        public DataTable GetNhanVien(string MaNV)
        {
            return db.GetData("SELECT nhanvien.MaNhanVien,nhanvien.TenNV,COUNT(Ngay) FROM chamcong INNER JOIN nhanvien ON chamcong.MaNhanVien = nhanvien.MaNhanVien WHERE chamcong.TinhTrang = 'Đi Làm' and Month(Ngay) = Month(now()) and chamcong.MaNhanVien = '" + MaNV + "' GROUP BY(MaNhanVien)");
        }
    }
}
