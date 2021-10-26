using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.DTO;
using GUI.DAO;

namespace GUI.BUS
{
   public class ChiTietHoaDon_BUS
    {
        
        public static bool ThemCTHoaDon(ChiTietHoaDon_DTO cthd)
        {
            return ChiTietHoaDon_DAO.ThemCTHoaDon(cthd);
        }
        public static bool XoaCTHoaDon(ChiTietHoaDon_DTO cthd)
        {
            return ChiTietHoaDon_DAO.XoaCTHoaDon(cthd);
        }
    }
}
