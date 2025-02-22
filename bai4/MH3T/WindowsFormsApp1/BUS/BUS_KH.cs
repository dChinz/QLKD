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
    public class BUS_KH
    {
        DAL_KH dalkh = new DAL_KH();

        public DataTable Loadkh()
        {
            return dalkh.Loadkh();
        }

        public void Insert(Khachhang kh)
        {
            dalkh.Insert(kh);
        }

        public void Update(Khachhang kh)
        {
            dalkh.Update(kh);
        }

        public void Delete(Khachhang kh)
        {
            dalkh.Delete(kh);
        }
    }
}
