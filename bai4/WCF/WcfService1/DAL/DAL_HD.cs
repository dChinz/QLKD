using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_HD : ketnoi
    {
        public List<Hoadon> Loadhd()
        {
            List<Hoadon> hoadons = new List<Hoadon>();
            DataTable dt = Load("select * from Hoadon");
            foreach (DataRow dr in dt.Rows)
            {
                Hoadon hoadon = new Hoadon
                {
                    mahd = Convert.ToInt32(dr["Mahd"].ToString()),
                    ngaymua = Convert.ToDateTime(dr["Ngaymua"].ToString()),
                    makh = Convert.ToInt32(dr["Makh"].ToString()),
                    mahang = Convert.ToInt32(dr["Mahang"].ToString()),
                    soluong = Convert.ToInt32(dr["Soluong"].ToString())
                };
                hoadons.Add(hoadon);
            }
            return hoadons;
        }

        public void Insert(Hoadon hd)
        {
            string sql = "insert into Hoadon values ('" + hd.ngaymua + "', " + hd.makh + ", " + hd.mahang + ", " + hd.soluong + ")";
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
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GK5VJ4R;Initial Catalog=QLKinhdoanh;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Mahang", Mahang);
                object result = cmd.ExecuteScalar();
                if (result != null)
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
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GK5VJ4R;Initial Catalog=QLKinhdoanh;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SL", SL);
                cmd.Parameters.AddWithValue("@Mahang", Mahh);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Report> data(string month)
        {
            List<Report> list = new List<Report>();

            string sql = @"select Hoadon.Ngaymua, Hoadon.Soluong, Khachhang.Hoten, Hanghoa.Tenhang, Hanghoa.Dongia
                            from Hoadon 
                            inner join Khachhang on Hoadon.Makh = Khachhang.Makh
                            inner join Hanghoa on Hanghoa.Mahang = Hoadon.Mahang
                            where (MONTH(Hoadon.Ngaymua) = @month)";
            using(SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GK5VJ4R;Initial Catalog=QLKinhdoanh;Integrated Security=True;"))
            {
                using(SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("month", month);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        list.Add(new Report()
                        {
                            ngaymua = Convert.ToDateTime(dr["Ngaymua"].ToString()),
                            soluong = Convert.ToInt32(dr["Soluong"].ToString()),
                            tenhang = dr["Tenhang"].ToString(),
                            tenkh = dr["Hoten"].ToString(),
                            dongia = Convert.ToDouble(dr["Dongia"].ToString())
                        });
                    }
                }
            }
            return list;
        }
    }
}
