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
    public class TaiKhoan_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả nhân viên
        public static List<TaiKhoan_DTO> LayDSTaiKhoan()
        {
            string sTruyVan = "select * from TAIKHOAN";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TaiKhoan_DTO> lstTaiKhoan = new List<DTO.TaiKhoan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                tk.SMaNV = dt.Rows[i]["MANV"].ToString();
                tk.SMatKhau = dt.Rows[i]["MATKHAU"].ToString();
                tk.SQuyen = Convert.ToInt32(dt.Rows[i]["QUYEN"].ToString());

                lstTaiKhoan.Add(tk);
            }
            DataProvider.DongKetNoi(con);
            return lstTaiKhoan;
        }

        public static bool ThemTaiKhoan(TaiKhoan_DTO tk)
        {
            string sTruyVan = string.Format(@"insert into TAIKHOAN values(N'{0}', N'{1}',N'{2}')",
     tk.SMaNV, tk.SMatKhau, tk.SQuyen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaTaiKhoan(TaiKhoan_DTO tk)
        {
            string sTruyVan = string.Format(@"UPDATE TAIKHOAN SET MATKHAU=N'{1}', QUYEN=N'{2}'WHERE MANV=N'{0}'",
     tk.SMaNV, tk.SMatKhau, tk.SQuyen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaTaiKhoan(TaiKhoan_DTO tk)
        {
            string sTruyVan = string.Format(@"DELETE TAIKHOAN WHERE MANV=N'{0}'", tk.SMaNV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        
       
    }
}
