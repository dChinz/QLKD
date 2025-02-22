using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Report
    {
        public DateTime ngaymua { get; set; }
        public int soluong { get; set; }
        public string tenkh { get; set; }

        public string tenhang { get; set; }
        public double dongia { get; set; }
    }
}
