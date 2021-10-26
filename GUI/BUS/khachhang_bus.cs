using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class khachhang_bus
    {
        public static List<khachhang_dto> LayDSkh()
        {
            return khachhang_dao.LayDSkhachhang();
        }
        public static bool ThemKhachHang(khachhang_dto kh)
        {
            return khachhang_dao.Themkhachhang(kh);
        }
        public static khachhang_dto TimKHTheoMa(string ma)
        {
            return khachhang_dao.TimkhTheoMa(ma);
        }
        public static List<khachhang_dto> TimKHTheoTen(string ten)
        {
            return khachhang_dao.TimkhTheoTen(ten);
        }
        public static bool SuaKhachHang(khachhang_dto kh)
        {
            return khachhang_dao.Suakhachhang(kh);
        }
        public static bool XoaKhachHang(khachhang_dto kh)
        {
            return khachhang_dao.Xoakhachhang(kh);
        }
    }
}
