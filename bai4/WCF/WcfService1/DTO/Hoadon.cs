using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hoadon
    {
        public int mahd { get; set; }

        public DateTime ngaymua { get; set; }

        public int makh { get; set; }

        public int mahang { get; set; }
        public int soluong { get; set; }

        public Hoadon() { }
        public Hoadon(int mahd, DateTime ngaymua, int makh, int mahang, int soluong)
        {
            this.mahd = mahd;
            this.ngaymua = ngaymua;
            this.makh = makh;
            this.mahang = mahang;
            this.soluong = soluong;
        }
    }
}
