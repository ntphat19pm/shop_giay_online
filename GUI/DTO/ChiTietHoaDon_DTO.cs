using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class ChiTietHoaDon_DTO
    {
        private string sMaHD;
        private string sMaSP;
        private string sMauSac;
        private string sKieu;
        private int sSoLuong;
        private float sGiamGia;
        private float sDonGia;
        private float sThanhTien;
        private string sBaoHanh;

        public string SMaHD { get => sMaHD; set => sMaHD = value; }
        public string SMaSP { get => sMaSP; set => sMaSP = value; }
        public string SMauSac { get => sMauSac; set => sMauSac = value; }
        public string SKieu { get => sKieu; set => sKieu = value; }
        public int SSoLuong { get => sSoLuong; set => sSoLuong = value; }
        public float SGiamGia { get => sGiamGia; set => sGiamGia = value; }
        public float SDonGia { get => sDonGia; set => sDonGia = value; }
        public float SThanhTien { get => sThanhTien; set => sThanhTien = value; }
        public string SBaoHanh { get => sBaoHanh; set => sBaoHanh = value; }
    }
}
