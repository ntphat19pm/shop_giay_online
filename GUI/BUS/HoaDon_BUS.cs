using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.DTO;
using GUI.DAO;

namespace GUI.BUS
{
   public class HoaDon_BUS
    {
        public static bool ThemHoaDon(HoaDon_DTO hd)
        {
            return HoaDon_DAO.ThemHoaDon(hd);
        }
        public static bool XoaHoaDon(HoaDon_DTO hd)
        {
            return HoaDon_DAO.XoaHoaDon(hd);
        }

    }
}
