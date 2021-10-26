using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using GUI.DTO;
using DAO;
using System;
using GUI;

namespace GUI.DAO
{
    public class ChiTietHoaDon_DAO
    {
        static SqlConnection con;
        
        public static bool ThemCTHoaDon(ChiTietHoaDon_DTO cthd)
        {
            string sTruyVan = string.Format(@"insert into CHITIETHOADON values(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')",
        cthd.SMaHD, cthd.SMaSP, cthd.SMauSac, cthd.SKieu, cthd.SSoLuong, cthd.SGiamGia, cthd.SDonGia, cthd.SThanhTien, cthd.SBaoHanh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaCTHoaDon(ChiTietHoaDon_DTO cthd)
        {
            string sTruyVan = string.Format(@"DELETE CHITIETHOADON WHERE MAHD=N'{0}'", cthd.SMaHD);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

    }
}
