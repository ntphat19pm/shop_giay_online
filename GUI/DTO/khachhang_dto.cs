using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class khachhang_dto
    {
        private string smakh;
        private string stenkh;
        private string sdiachi;
        private string sdienthoai;

        public string Smakh { get => smakh; set => smakh = value; }
        public string Stenkh { get => stenkh; set => stenkh = value; }
        public string Sdiachi { get => sdiachi; set => sdiachi = value; }
        public string Sdienthoai { get => sdienthoai; set => sdienthoai = value; }
    }
}
