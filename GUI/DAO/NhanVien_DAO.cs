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
    public class NhanVien_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả nhân viên
        public static List<NhanVien_DTO> LayDSNhanVien()
        {
            string sTruyVan = "select * from NHANVIEN";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<DTO.NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = dt.Rows[i]["MANV"].ToString();
                nv.STenNV = dt.Rows[i]["TENNV"].ToString();
                nv.SDiaChi = dt.Rows[i]["DIACHI"].ToString();
                nv.SDienThoai = dt.Rows[i]["DIENTHOAI"].ToString();
                nv.SPhai = dt.Rows[i]["PHAI"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["NGAYSINH"].ToString());
                nv.SMaCV = dt.Rows[i]["MACV"].ToString();
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"insert into NHANVIEN values(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')",
     nv.SMaNV, nv.STenNV, nv.SDiaChi, nv.SDienThoai, nv.SPhai, nv.DtNgaySinh, nv.SMaCV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from NHANVIEN where MANV=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = dt.Rows[0]["MANV"].ToString();
            nv.STenNV = dt.Rows[0]["TENNV"].ToString();
            nv.SDiaChi = dt.Rows[0]["DIACHI"].ToString();
            nv.SDienThoai = dt.Rows[0]["DIENTHOAI"].ToString();
            nv.SPhai = dt.Rows[0]["PHAI"].ToString();
            nv.DtNgaySinh = DateTime.Parse(dt.Rows[0]["NGAYSINH"].ToString());
            nv.SMaCV = dt.Rows[0]["MACV"].ToString();
            DataProvider.DongKetNoi(con);
            return nv;
        }
        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"UPDATE NHANVIEN SET TENNV=N'{1}', DIACHI=N'{2}',DIENTHOAI=N'{3}',PHAI=N'{4}',NGAYSINH='{5}',MACV=N'{6}'WHERE MANV=N'{0}'",
     nv.SMaNV, nv.STenNV, nv.SDiaChi, nv.SDienThoai, nv.SPhai, nv.DtNgaySinh, nv.SMaCV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"DELETE NHANVIEN WHERE MANV=N'{0}'", nv.SMaNV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static List<NhanVien_DTO> TimNhanVienTheoTen(string ten)

        {
            string sTruyVan = string.Format(@"select * from NHANVIEN where TENNV like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)

            {
                return null;

            }
            List<NhanVien_DTO> lstNhanVien = new List<DTO.NhanVien_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = dt.Rows[i]["MANV"].ToString();
                nv.STenNV = dt.Rows[i]["TENNV"].ToString();
                nv.SDiaChi = dt.Rows[i]["DIACHI"].ToString();
                nv.SDienThoai = dt.Rows[i]["DIENTHOAI"].ToString();
                nv.SPhai = dt.Rows[i]["PHAI"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["NGAYSINH"].ToString());
                nv.SMaCV = dt.Rows[i]["MACV"].ToString();
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
    }
}
