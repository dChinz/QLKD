using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hanghoa
    {
        public int mahang { get; set; }

        public string tenhang { get; set; }
        public string chungloai { get; set; }
        public float dongia { get; set; }
        public int soluong { get; set; }

        public Hanghoa() { }
        public Hanghoa(int mahang, string tenhang, string chungloai, float dongia, int soluong)
        {
            this.mahang = mahang;
            this.tenhang = tenhang;
            this.chungloai = chungloai;
            this.dongia = dongia;
            this.soluong = soluong;
        }
    }
}
