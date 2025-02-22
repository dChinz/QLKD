using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khachhang
    {
        public int makh {  get; set; }
        public string tenkh { get; set; }
        public DateTime ngaysinh { get; set; }

        public Khachhang() { }

        public Khachhang(int makh, string tenkh, DateTime ngaysinh)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.ngaysinh = ngaysinh;   
        }

        public Khachhang(string tenkh, DateTime ngaysinh)
        {
            this.tenkh = tenkh;
            this.ngaysinh = ngaysinh;
        }
    }
}
