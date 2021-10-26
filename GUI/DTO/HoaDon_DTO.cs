using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
      public class HoaDon_DTO
    {
        private string sMaHD;
        private string sMaNV;
        private string sMaKH;
        private DateTime dtNgayBan;
        private float sTongTien;

        public string SMaHD { get => sMaHD; set => sMaHD = value; }
        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string SMaKH { get => sMaKH; set => sMaKH = value; }
        public DateTime DtNgayBan { get => dtNgayBan; set => dtNgayBan = value; }
        public float STongTien { get => sTongTien; set => sTongTien = value; }
    }
}
