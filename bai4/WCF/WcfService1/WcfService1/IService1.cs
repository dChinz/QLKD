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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Khachhang> Loadkh();
        [OperationContract]
        void Insertkh(Khachhang hachhang);
        [OperationContract]
        void Updatekh(Khachhang hachhang);
        [OperationContract]
        void Deletekh(Khachhang hachhang);
        [OperationContract]
        List<Hanghoa> Loadhh();
        [OperationContract]
        void Inserthh(Hanghoa hanghoa);
        [OperationContract]
        void Updatehh(Hanghoa hanghoa);
        [OperationContract]
        void Deletehh(Hanghoa hanghoa);
        [OperationContract]
        List<Hoadon> Loadhd();
        [OperationContract]
        void Inserthd(Hoadon hadon);
        [OperationContract]
        void Updatehd(Hoadon hadon);
        [OperationContract]
        void Deletehd(Hoadon hadon);
        [OperationContract]
        int GetSL(string Mahang);
        [OperationContract]
        int GetSL_2(string Mahd);
        [OperationContract]
        void UpdateSL(string Mahang, int SL);

        [OperationContract]
        List<Report> data(string month);
    }
}
