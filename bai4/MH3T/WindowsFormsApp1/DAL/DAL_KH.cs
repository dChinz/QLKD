using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_KH :ketnoi
    {
        Khachhang kh = new Khachhang();

        public DataTable Loadkh()
        {
            return Load("select * from Khachhang");
        }

        public void Insert(Khachhang kh)
        {
            string sql = "insert into Khachhang values ('"+kh.tenkh+"', '"+kh.ngaysinh+"')";
            thuchien(sql);
        }

        public void Update(Khachhang kh)
        {
            string sql = "update Khachhang set Hoten = '" + kh.tenkh + "', Ngaysinh = '" + kh.ngaysinh + "' where Makh = '" + kh.makh + "'";
            thuchien(sql);
        }
        public void Delete(Khachhang kh)
        {
            string sql = "delete from Khachhang set Makh = '" + kh.makh + "'";
        }
    }
}
