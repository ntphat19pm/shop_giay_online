using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        private string sMaNV;
        private string sMatKhau;
        private int sQuyen;

        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string SMatKhau { get => sMatKhau; set => sMatKhau = value; }
        public int SQuyen { get => sQuyen; set => sQuyen = value; }
    }
}
