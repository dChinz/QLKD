using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_HH :ketnoi
    { 
        Khachhang kh = new Khachhang();

        public DataTable Loadhh()
        {
            return Load("select * from Hanghoa");
        }

        public void Insert(Hanghoa hh)
        {
            string sql = "insert into Hanghoa values ('"+hh.tenhang+"', '"+hh.chungloai+"', "+hh.dongia+", "+hh.soluong+")";
            thuchien(sql);
        }

        public void Update(Hanghoa hh) 
        {
            string sql = "update Hanghoa set Tenhang = '" + hh.tenhang + "', Chungloai = '"+hh.chungloai+"', Dongia = "+hh.dongia+", Soluong = "+hh.soluong+" where Mahang = '"+hh.mahang+"'";
            thuchien(sql);
        }

        public void Delete(Hanghoa hh) 
        {
            string sql = "delete from Hanghoa where Mahang = '" + hh.mahang + "'";
            thuchien(sql);
        }
    }
}
