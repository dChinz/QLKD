using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_HD : ketnoi
    {
        Hoadon hd = new Hoadon();

        public DataTable Loadhd()
        {
            return Load("select * from Hoadon");
        }

        public void Insert(Hoadon hd)
        {
            string sql = "insert into Hoadon values ('"+hd.ngaymua+"', "+hd.makh+", "+hd.mahang+", "+hd.soluong+")";
            thuchien(sql);
        }

        public void Update(Hoadon hd)
        {
            string sql = "update Hoadon set Ngaymua = '" + hd.ngaymua + "', Makh = " + hd.makh + ", Mahang = " + hd.mahang + ", Soluong = " + hd.soluong + " where Mahd = " + hd.mahd + "";
            thuchien(sql);
        }

        public void Delete(Hoadon hd)
        {
            string sql = "delete from Hoadon where Mahd = " + hd.mahd + "";
            thuchien(sql);
        }

        public int GetSL(string Mahang)
        {
            int SL = 0;
            string sql = "select Soluong from Hanghoa where Mahang = @Mahang";
            using(SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GK5VJ4R;Initial Catalog=QLKinhdoanh;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Mahang", Mahang);
                object result = cmd.ExecuteScalar();
                if(result != null)
                {
                    SL = (int)result;
                }
            }
            return SL;
        }

        public int GetSL_2(string Mahd)
        {
            int SL = 0;
            string sql = "select Soluong from Hoadon where Mahd = @Mahd";
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GK5VJ4R;Initial Catalog=QLKinhdoanh;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Mahd", Mahd);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    SL = (int)result;
                }
            }
            return SL;
        }

        public void UpdateSL(string Mahh, int SL)
        {
            string sql = "update Hanghoa set Soluong = @Sl where Mahang = @Mahang";
            using(SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GK5VJ4R;Initial Catalog=QLKinhdoanh;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SL", SL);
                cmd.Parameters.AddWithValue("@Mahang", Mahh);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable data(string month)
        {
            string sql = @"select Hoadon.Ngaymua, Hoadon.Soluong, Khachhang.Hoten, Hanghoa.Tenhang, Hanghoa.Dongia
                            from Hoadon 
                            inner join Khachhang on Hoadon.Makh = Khachhang.Makh
                            inner join Hanghoa on Hanghoa.Mahang = Hoadon.Mahang
                            where (MONTH(Hoadon.Ngaymua) = @month)";

            using(SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GK5VJ4R;Initial Catalog=QLKinhdoanh;Integrated Security=True;"))
            {
                using(SqlCommand cmd = new SqlCommand(sql,conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@month", month);
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
