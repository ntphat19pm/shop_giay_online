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
    public class SanPham_DAO
    {
        static SqlConnection con;
        public static List<SanPham_DTO> LayDSSanPham()
        {
            string sTruyVan = "select * from SANPHAM";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SanPham_DTO> lstSanPham = new List<DTO.SanPham_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.SMaSP = dt.Rows[i]["MASP"].ToString();
                sp.STenSP = dt.Rows[i]["TENSP"].ToString();
                sp.SMaHang = dt.Rows[i]["MAHANG"].ToString();
                sp.SMauSac = dt.Rows[i]["MAUSAC"].ToString();
                sp.SKieu = dt.Rows[i]["KIEU"].ToString();
                sp.SGiaNhap = (float)Double.Parse(dt.Rows[i]["GIANHAP"].ToString());
                sp.SGiaBan = (float)Double.Parse(dt.Rows[i]["GIABAN"].ToString());
                sp.SSoLuong = Convert.ToInt32(dt.Rows[i]["SOLUONG"].ToString());
                sp.DtNgayNhap = DateTime.Parse(dt.Rows[i]["NGAYNHAP"].ToString());
                sp.SThoiGianBaoHanh = dt.Rows[i]["THOIGIANBAOHANH"].ToString();
                sp.SAnh = dt.Rows[i]["ANH"].ToString();
                lstSanPham.Add(sp);
            }
            DataProvider.DongKetNoi(con);
            return lstSanPham;
        }
        public static bool ThemSanPham(SanPham_DTO sp)
        {
            string sTruyVan = string.Format(@"insert into SANPHAM values(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}','{5}','{6}','{7}', N'{8}', N'{9}', N'{10}')",
     sp.SMaSP, sp.STenSP, sp.SMaHang, sp.SMauSac, sp.SKieu, sp.SGiaNhap, sp.SGiaBan, sp.SSoLuong, sp.DtNgayNhap, sp.SThoiGianBaoHanh, sp.SAnh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static SanPham_DTO TimSanPhamTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from SANPHAM where MASP=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            SanPham_DTO sp = new SanPham_DTO();
            sp.SMaSP = dt.Rows[0]["MASP"].ToString();
            sp.STenSP = dt.Rows[0]["TENSP"].ToString();
            sp.SMaHang = dt.Rows[0]["MAHANG"].ToString();
            sp.SMauSac = dt.Rows[0]["MAUSAC"].ToString();
            sp.SKieu = dt.Rows[0]["KIEU"].ToString();
            sp.SGiaNhap = (float)Double.Parse(dt.Rows[0]["GIANHAP"].ToString());
            sp.SGiaBan = (float)Double.Parse(dt.Rows[0]["GIABAN"].ToString());
            sp.SSoLuong = Convert.ToInt32(dt.Rows[0]["SOLUONG"].ToString());
            sp.DtNgayNhap = DateTime.Parse(dt.Rows[0]["NGAYNHAP"].ToString());
            sp.SThoiGianBaoHanh = dt.Rows[0]["THOIGIANBAOHANH"].ToString();
            sp.SAnh = dt.Rows[0]["ANH"].ToString();
            DataProvider.DongKetNoi(con);
            return sp;
        }
        public static List<SanPham_DTO> TimSanPhamTheoTen(string ten)

        {
            string sTruyVan = string.Format(@"select * from SANPHAM where MASP like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)

            {
                return null;

            }
            List<SanPham_DTO> lstSanPham = new List<DTO.SanPham_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.SMaSP = dt.Rows[i]["MASP"].ToString();
                sp.STenSP = dt.Rows[i]["TENSP"].ToString();
                sp.SMaHang = dt.Rows[i]["MAHANG"].ToString();
                sp.SMauSac = dt.Rows[i]["MAUSAC"].ToString();
                sp.SKieu = dt.Rows[i]["KIEU"].ToString();
                sp.SGiaNhap = (float)Double.Parse(dt.Rows[i]["GIANHAP"].ToString());
                sp.SGiaBan = (float)Double.Parse(dt.Rows[i]["GIABAN"].ToString());
                sp.SSoLuong = Convert.ToInt32(dt.Rows[i]["SOLUONG"].ToString());
                sp.DtNgayNhap = DateTime.Parse(dt.Rows[i]["NGAYNHAP"].ToString());
                sp.SThoiGianBaoHanh = dt.Rows[i]["THOIGIANBAOHANH"].ToString();
                sp.SAnh = dt.Rows[i]["ANH"].ToString();
                lstSanPham.Add(sp);
            }
            DataProvider.DongKetNoi(con);
            return lstSanPham;
        }
        public static bool SuaSanPham(SanPham_DTO sp)
        {
            string sTruyVan = string.Format(@"UPDATE SANPHAM SET TENSP=N'{1}', MAHANG=N'{2}',MAUSAC=N'{3}',KIEU=N'{4}',GIANHAP='{5}',GIABAN='{6}',SOLUONG='{7}',NGAYNHAP=N'{8}',THOIGIANBAOHANH=N'{9}',ANH='{10}'WHERE MASP=N'{0}'",
     sp.SMaSP, sp.STenSP, sp.SMaHang, sp.SMauSac, sp.SKieu, sp.SGiaNhap, sp.SGiaBan, sp.SSoLuong, sp.DtNgayNhap, sp.SThoiGianBaoHanh, sp.SAnh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaSanPham(SanPham_DTO sp)
        {
            string sTruyVan = string.Format(@"DELETE SANPHAM WHERE MASP=N'{0}'", sp.SMaSP);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
