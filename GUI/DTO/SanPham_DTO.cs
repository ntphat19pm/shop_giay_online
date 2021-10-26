using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class SanPham_DTO
    {
        private string sMaSP;
        private string sTenSP;
        private string sMaHang;
        private string sMauSac;
        private string sKieu;
        private float sGiaNhap;
        private float sGiaBan;
        private int sSoLuong;
        private DateTime dtNgayNhap;
        private string sThoiGianBaoHanh;
        private string sAnh;

        public string SMaSP { get => sMaSP; set => sMaSP = value; }
        public string STenSP { get => sTenSP; set => sTenSP = value; }
        public string SMaHang { get => sMaHang; set => sMaHang = value; }
        public string SMauSac { get => sMauSac; set => sMauSac = value; }
        public string SKieu { get => sKieu; set => sKieu = value; }
        public float SGiaNhap { get => sGiaNhap; set => sGiaNhap = value; }
        public float SGiaBan { get => sGiaBan; set => sGiaBan = value; }
        public int SSoLuong { get => sSoLuong; set => sSoLuong = value; }
        public DateTime DtNgayNhap { get => dtNgayNhap; set => dtNgayNhap = value; }
        public string SThoiGianBaoHanh { get => sThoiGianBaoHanh; set => sThoiGianBaoHanh = value; }
        public string SAnh { get => sAnh; set => sAnh = value; }
    }
}
