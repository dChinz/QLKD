using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_HH
    {
        DAL_HH dalhh = new DAL_HH();

        public DataTable Loadhh()
        {
            return dalhh.Loadhh();
        }

        public void Insert(Hanghoa hh)
        {
            dalhh.Insert(hh);
        }

        public void Update(Hanghoa hh)
        {
            dalhh.Update(hh);
        }

        public void Delete(Hanghoa hh)
        {
            dalhh.Delete(hh);
        }
    }
}
