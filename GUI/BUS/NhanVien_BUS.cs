﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVien_BUS
    {
        //Lấy DS nhân viên
        public static List<NhanVien_DTO> LayDSNhanVien()
        {
            return NhanVien_DAO.LayDSNhanVien();
        }
        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.ThemNhanVien(nv);
        }
        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.SuaNhanVien(nv);
        }
        public static bool XoaNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.XoaNhanVien(nv);
        }
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            return NhanVien_DAO.TimNhanVienTheoMa(ma);
        }
        public static List<NhanVien_DTO> TimNhanVienTheoTen(string ten)
        {
            return NhanVien_DAO.TimNhanVienTheoTen(ten);
        }
    }
}


