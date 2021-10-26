using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.DTO;
using GUI.DAO;

namespace GUI.BUS
{
    public class SanPham_BUS
    {
        public static List<SanPham_DTO> LayDSSanPham()
        {
            return SanPham_DAO.LayDSSanPham();
        }
        public static bool ThemSanPham(SanPham_DTO sp)
        {
            return SanPham_DAO.ThemSanPham(sp);
        }
        public static SanPham_DTO TimSanPhamTheoMa(string ma)
        {
            return SanPham_DAO.TimSanPhamTheoMa(ma);
        }
        public static List<SanPham_DTO> TimSanPhamTheoTen(string ten)
        {
            return SanPham_DAO.TimSanPhamTheoTen(ten);
        }
        public static bool SuaSanPham(SanPham_DTO sp)
        {
            return SanPham_DAO.SuaSanPham(sp);
        }
        public static bool XoaSanPham(SanPham_DTO sp)
        {
            return SanPham_DAO.XoaSanPham(sp);
        }
    }
}
