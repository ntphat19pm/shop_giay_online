using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string sMaNV;
        private string sTenNV;
        private string sDiaChi;
        private string sDienThoai;
        private string sPhai;
        private DateTime dtNgaySinh;
        private string sMaCV;

        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string STenNV { get => sTenNV; set => sTenNV = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string SDienThoai { get => sDienThoai; set => sDienThoai = value; }
        public string SPhai { get => sPhai; set => sPhai = value; }
        public DateTime DtNgaySinh { get => dtNgaySinh; set => dtNgaySinh = value; }
        public string SMaCV { get => sMaCV; set => sMaCV = value; }
    }
}
