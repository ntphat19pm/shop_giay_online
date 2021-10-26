using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using GUI.DTO;
using DAO;

namespace GUI.DAO
{
    public class HoaDon_DAO
    {
        static SqlConnection con;
        public static bool ThemHoaDon(HoaDon_DTO hd)
        {
            string sTruyVan = string.Format(@"insert into HOADON values(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}')",
        hd.SMaHD, hd.SMaNV, hd.SMaKH, hd.DtNgayBan, hd.STongTien);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaHoaDon(HoaDon_DTO hd)
        {
            string sTruyVan = string.Format(@"DELETE HOADON WHERE MAHD=N'{0}'", hd.SMaHD);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }

}
