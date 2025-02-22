using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        DAL_KH dalkh = new DAL_KH();

        public List<Khachhang> Loadkh()
        {
            return dalkh.Loadkh();
        }

        public void Insertkh(Khachhang kh)
        {
            dalkh.Insert(kh);
        }

        public void Updatekh(Khachhang kh)
        {
            dalkh.Update(kh);
        }

        public void Deletekh(Khachhang kh)
        {
            dalkh.Delete(kh);
        }

        DAL_HH dalhh = new DAL_HH();

        public List<Hanghoa> Loadhh()
        {
            return dalhh.Loadhh();
        }

        public void Inserthh(Hanghoa hanghoa)
        {
            dalhh.Insert(hanghoa);
        }
        public void Updatehh(Hanghoa hanghoa)
        {
            dalhh.Update(hanghoa);
        }
        public void Deletehh(Hanghoa hanghoa)
        {
            dalhh.Delete(hanghoa);
        }
        
        DAL_HD dalhd = new DAL_HD();

        public List<Hoadon> Loadhd()
        {
            return dalhd.Loadhd();
        }

        public void Inserthd(Hoadon hoadon)
        {
            dalhd.Insert(hoadon);
        }

        public void Updatehd(Hoadon hoadon)
        {
            dalhd.Update(hoadon);
        }

        public void Deletehd(Hoadon hoadon)
        {
            dalhd.Delete(hoadon);
        }

        public int GetSL(string Mahang)
        {
            return dalhd.GetSL(Mahang);
        }

        public int GetSL_2(string Mahd)
        {
            return dalhd.GetSL_2(Mahd);
        }

        public void UpdateSL(string Mahang, int SL)
        {
            dalhd.UpdateSL(Mahang, SL);
        }

        public List<Report> data(string month)
        {
            return dalhd.data(month);
        }

    }
}
