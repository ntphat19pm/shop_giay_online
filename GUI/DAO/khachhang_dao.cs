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
    public class khachhang_dao
    {
        static SqlConnection con;
        public static List<khachhang_dto> LayDSkhachhang()
        {
            string sTruyVan = "select * from KHACHHANG";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<khachhang_dto> lstkh = new List<DTO.khachhang_dto>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                khachhang_dto kh = new khachhang_dto();
                kh.Smakh = dt.Rows[i]["MAKH"].ToString();
                kh.Stenkh = dt.Rows[i]["TENKH"].ToString();
                kh.Sdiachi = dt.Rows[i]["DIACHI"].ToString();
                kh.Sdienthoai = dt.Rows[i]["DIENTHOAI"].ToString();
                lstkh.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstkh;
        }
        public static bool Themkhachhang(khachhang_dto kh)
        {
            string sTruyVan = string.Format(@"insert into KHACHHANG values(N'{0}', N'{1}',N'{2}',N'{3}')",
            kh.Smakh, kh.Stenkh, kh.Sdiachi, kh.Sdienthoai);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static khachhang_dto TimkhTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from KHACHHANG where MAKH=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            khachhang_dto kh = new khachhang_dto();
            kh.Smakh = dt.Rows[0]["MAKH"].ToString();
            kh.Stenkh = dt.Rows[0]["TENKH"].ToString();
            kh.Sdiachi = dt.Rows[0]["DIACHI"].ToString();
            kh.Sdienthoai = dt.Rows[0]["DIENTHOAI"].ToString();
            DataProvider.DongKetNoi(con);
            return kh;
        }
        public static List<khachhang_dto> TimkhTheoTen(string ten)

        {
            string sTruyVan = string.Format(@"select * from KHACHHANG where TENKH like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)

            {
                return null;

            }
            List<khachhang_dto> lstkh = new List<DTO.khachhang_dto>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                khachhang_dto kh = new khachhang_dto();
                kh.Smakh = dt.Rows[i]["MAKH"].ToString();
                kh.Stenkh = dt.Rows[i]["TENKH"].ToString();
                kh.Sdiachi = dt.Rows[i]["DIACHI"].ToString();
                kh.Sdienthoai = dt.Rows[i]["DIENTHOAI"].ToString();
                lstkh.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstkh;
        }
        public static bool Suakhachhang(khachhang_dto kh)
        {
            string sTruyVan = string.Format(@"UPDATE KHACHHANG SET TENKH=N'{1}',DIACHI=N'{2}',DIENTHOAI=N'{3}'WHERE MAKH=N'{0}'",
            kh.Smakh, kh.Stenkh, kh.Sdiachi, kh.Sdienthoai);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool Xoakhachhang(khachhang_dto kh)
        {
            string sTruyVan = string.Format(@"DELETE KHACHHANG WHERE MAKH=N'{0}'", kh.Smakh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
