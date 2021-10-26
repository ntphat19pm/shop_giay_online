using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Security.Cryptography;
using GUI;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        public static List<TaiKhoan_DTO> LayDSTaiKhoan()
        {
            return TaiKhoan_DAO.LayDSTaiKhoan();
        }
        public static bool ThemTaiKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.ThemTaiKhoan(tk);
        }
        public static bool SuaTaiKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.SuaTaiKhoan(tk);
        }
        public static bool XoaTaiKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.XoaTaiKhoan(tk);
        }


       

       
    }
}
