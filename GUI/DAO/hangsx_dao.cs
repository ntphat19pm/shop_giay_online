using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class hangsx_dao
    {
        static SqlConnection con;
        public static List<hangsx_dto> LayDShangsx()
        {
            string sTruyVan = "select * from HANGSX";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<hangsx_dto> lsthangsx = new List<DTO.hangsx_dto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                hangsx_dto hsx = new hangsx_dto();
                hsx.Smahang = dt.Rows[i]["MAHANG"].ToString();
                hsx.Stenhang = dt.Rows[i]["TENHANG"].ToString();

                lsthangsx.Add(hsx);
            }
            DataProvider.DongKetNoi(con);
            return lsthangsx;
        }
        public static bool ThemNhanVien(hangsx_dto hsx)
        {
            string sTruyVan = string.Format(@"insert into HANGSX values(N'{0}', N'{1}')",
            hsx.Smahang, hsx.Stenhang);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static hangsx_dto TimhsxTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from HANGSX where MAHANG=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            hangsx_dto hsx = new hangsx_dto();
            hsx.Smahang = dt.Rows[0]["MAHANG"].ToString();
            hsx.Stenhang = dt.Rows[0]["TENHANG"].ToString();
            DataProvider.DongKetNoi(con);
            return hsx;
        }
        public static List<hangsx_dto> TimhsxTheoTen(string ten)

        {
            string sTruyVan = string.Format(@"select * from HANGSX where TENHANG like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)

            {
                return null;

            }
            List<hangsx_dto> lsthangsx = new List<DTO.hangsx_dto>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                hangsx_dto hsx = new hangsx_dto();
                hsx.Smahang = dt.Rows[i]["MAHANG"].ToString();
                hsx.Stenhang = dt.Rows[i]["TENHANG"].ToString();
               
                lsthangsx.Add(hsx);
            }
            DataProvider.DongKetNoi(con);
            return lsthangsx;
        }
        public static bool SuaNhanVien(hangsx_dto hsx)
        {
            string sTruyVan = string.Format(@"UPDATE HANGSX SET TENHANG=N'{1}'WHERE MAHANG=N'{0}'",
            hsx.Smahang,hsx.Stenhang);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaNhanVien(hangsx_dto hsx)
        {
            string sTruyVan = string.Format(@"DELETE HANGSX WHERE MAHANG=N'{0}'", hsx.Smahang);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
