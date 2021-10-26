using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class hangsx_bus
    {
        public static List<hangsx_dto> LayDShangsx()
        {
            return hangsx_dao.LayDShangsx();
        }
        public static bool ThemNhanVien(hangsx_dto hsx)
        {
            return hangsx_dao.ThemNhanVien(hsx);
        }
        public static bool SuaNhanVien(hangsx_dto hsx)
        {
            return hangsx_dao.SuaNhanVien(hsx);
        }
        public static bool XoaNhanVien(hangsx_dto hsx)
        {
            return hangsx_dao.XoaNhanVien(hsx);
        }
        public static hangsx_dto TimHSXTheoMa(string ma)
        {
            return hangsx_dao.TimhsxTheoMa(ma);
        }
        public static List<hangsx_dto> TimHSXTheoTen(string ten)
        {
            return hangsx_dao.TimhsxTheoTen(ten);
        }
    }
}

