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
    public class BUS_HD
    {
        DAL_HD dalhd = new DAL_HD();
        public DataTable Loadhd()
        {
            return dalhd.Loadhd();
        }

        public void Insert(Hoadon hd)
        {
            dalhd.Insert(hd);
        }

        public void Update(Hoadon hd)
        {
            dalhd.Update(hd);
        }

        public void Delete(Hoadon hd)
        {
            dalhd.Delete(hd);
        }

        public int GetSL(string Mahang)
        {
            return dalhd.GetSL(Mahang);
        }

        public int GetSL_2(string Mahd)
        {
            return dalhd.GetSL_2(Mahd);
        }

        public void UpdateSL(string Mahh, int SL)
        {
            dalhd.UpdateSL(Mahh, SL);
        }

        public DataTable data(string month)
        {
            return dalhd.data(month);
        }
    }
}
