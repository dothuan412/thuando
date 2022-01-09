using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_THUESANBONG
{
    public class DAL_Thuesanbong : DBConnection
    {
        public DataTable getListThuesanbong(int ls)
        {
            string str = string.Format("select mahoadon, tenkhachhang, thuesanbong.soCMND, thuesanbong.masanbong, ngaythuesanbong, hoten, songuoi, tensanbong from thuesanbong inner join sanbong on thuesanbong.masanbong = sanbong.masanbong inner join nhanvien on nhanvien.idnhanvien = thuesanbong.idnhanvienduasanbong or nhanvien.idnhanvien = thuesanbong.idnhanvientrasanbong where tientra='{0}'", ls);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalThuesanbong = new DataTable();
            dal.Fill(dalThuesanbong);
            return dalThuesanbong;
        }

        public DataTable getThongtinthuesanbong(long mahoadon)
        {
            string str = string.Format("select mahoadon, tenkhachhang, thuesanbong.soCMND, thuesanbong.masanbong, ngaythuesanbong, ngaytrasanbong, tongtien, hoten, songuoi, tensanbong, khuvuc, loaisanbong, dongia, idnhanvien " +
                "from thuesanbong inner join sanbong on thuesanbong.masanbong = sanbong.maphong " +
                "inner join nhanvien on nhanvien.idnhanvien = thuesanbong.idnhanvienduasanbong or nhanvien.idnhanvien = thuesanbong.idnhanvientrasanbong where mahoadon='{0}'", mahoadon);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalThuesanbong = new DataTable();
            dal.Fill(dalThuesanbong);
            return dalThuesanbong;
        }

        public DataTable timkiemBytensanbong(string tensanbong, int ls)
        {
            string str = string.Format("select mahoadon, tenkhachhang, thuesanbong.soCMND, thuesanbong.masanbong, ngaythuesanbong, hoten, songuoi, tensanbong from thuesanbong inner join sanbong on thuesanbong.masanbong = sanbong.masanbong inner join nhanvien on nhanvien.idnhanvien = thuesanbong.idnhanvienduasanbong or nhanvien.idnhanvien = thuesanbong.idnhanvientrasanbong where tientra = '{1}' and tensanbong like '%{0}%'", tensanbong, ls);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalThuesanbong = new DataTable();
            dal.Fill(dalThuesanbong);
            return dalThuesanbong;
        }

        public DataTable timkiemBytenkhachhang(string tenkhachhang, int ls)
        {
            string str = string.Format("select mahoadon, tenkhachhang, thuesanbong.soCMND, thuesanbong.masanbong, ngaythuesanbong, hoten, songuoi, tensanbong from thuesanbong inner join sanbong on thuesanbong.masanbong = sanbong.masanbong inner join nhanvien on nhanvien.idnhanvien = thuesanbong.idnhanvienduasanbong or nhanvien.idnhanvien = thuesanbong.idnhanvientrasanbong where tientra='{1}' and tenkhachhang like'%{0}%'", tenkhachhang, ls);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalThuesanbong = new DataTable();
            dal.Fill(dalThuesanbong);
            return dalThuesanbong;
        }
        public DataTable timkiem(string tensanbong, string tenkhachhang, int ls)
        {
            string str = string.Format("select mahoadon, tenkhachhang, thuesanbong.soCMND, thuesanbong.masanbong, ngaythuesanbong, hoten, songuoi, tensanbong from thuesanbong inner join sanbong on thuesanbong.masanbong = sanbong.masanbong inner join nhanvien on nhanvien.idnhanvien = thuesanbong.idnhanvienduasanbong or nhanvien.idnhanvien = thuesanbong.idnhanvientrasanbong where tientra='{2}' and (tenkhachhang like'%{0}%' and tensanbong like '%{1}%')", tenkhachhang, tensanbong, ls);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalThuesanbong = new DataTable();
            dal.Fill(dalThuesanbong);
            return dalThuesanbong;
        }


        public bool insertThuesanbong(string tenkhachhang, string soCMND, long masanbong, DateTime ngaythuesanbong, long idnhanvienduasanbong, int songuoi)
        {
            Console.WriteLine(1);
            string str = string.Format("insert into thuesanbong(tenkhachhang, soCMND, masanbong, ngaythuesanbong, tientra, idnhanvienduasanbong, songuoi) values(N'{0}','{1}','{2}','{3}','{4}','{5}','{6}')", tenkhachhang, soCMND, masanbong, ngaythuesanbong, false, idnhanvienduasanbong, songuoi);
            Console.WriteLine(2);
            try
            {
                Console.WriteLine(3);
                DAL_Sanbong dalsanbong = new DAL_Sanbong();
                dalsanbong.updateTinhtrangSanbong(masanbong, 1);
                Console.WriteLine(4);
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine(5);
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool updateThuesanbong(string tenkhachhang, string soCMND, long masanbong, DateTime ngaythuesanbong, int songuoi, long mahoadon)
        {
            DataTable dalthuesanbong = getThongtinthuesanbong(mahoadon);
            long masanbongcu = (long)dalthuesanbong.Rows[0]["masanbong"];
            string str = string.Format("update thuesanbong set tenkhachhang = N'{0}', soCMND= '{1}', masanbong='{2}', ngaythuesanbong='{3}', songuoi='{4}' where mahoadon= '{5}'", tenkhachhang, soCMND, masanbong, ngaythuesanbong, songuoi, mahoadon);
            try
            {
                DAL_Sanbong dalsanbong = new DAL_Sanbong();

                //doisanbong
                if (masanbong != masanbongcu)
                {
                    dalsanbong.updateTinhtrangSanbong(masanbongcu, 2);
                    dalsanbong.updateTinhtrangSanbong(masanbong, 1);
                }
                Console.WriteLine(masanbong);
                Console.WriteLine(masanbongcu);

                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool traSanbong(long mahoadon, long idnhanvientrasanbong)
        {
            DataTable dalthuesanbong = getThongtinthuesanbong(mahoadon);
            long masanbong = (long)dalthuesanbong.Rows[0]["masanbong"];
            string str;
            try
            {
                DAL_Sanbong dalsanbong = new DAL_Sanbong();
                dalsanbong.updateTinhtrangSanbong(masanbong, 2);

                DateTime now = DateTime.Now;
                TimeSpan time = now.Subtract(DateTime.Parse(dalthuesanbong.Rows[0]["ngaythuesanbong"].ToString()));

                int day = time.Days;
                if (day == 0 || time.Hours > 1) day++;

                float tongtien = day * float.Parse(dalthuesanbong.Rows[0]["songuoi"].ToString()) * float.Parse(dalthuesanbong.Rows[0]["dongia"].ToString());
                str = string.Format("update thuesanbong set tongtien='{0}', ngaytrasanbong='{1}', tientra='{2}', idnhanvientrasanbong='{3}' where mahoadon='{4}'", tongtien, DateTime.Now, 1, idnhanvientrasanbong, mahoadon);
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool deleteThuesanbong(long mahoadon)
        {
            string str = string.Format("delete from thuesanbong where mahoadon = '{0}'", mahoadon);
            try
            {
                DAL_Sanbong dalsanbong = new DAL_Sanbong();
                DataTable dalthuesanbong = getThongtinthuesanbong(mahoadon);
                dalsanbong.updateTinhtrangSanbong((long)dalthuesanbong.Rows[0]["masanbong"], 0);
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool taoHoadon(long mahoadon)
        {
            string str = string.Format("delete from hoadon");
            try
            {
                DAL_Nhanvien dalnhanvien = new DAL_Nhanvien();
                DAL_Thuesanbong dalthuephong = new DAL_Thuesanbong();

                // làm trống bảng
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                // lấy thông tin cần
                str = string.Format("select mahoadon, tenkhachhang, thuesanbong.masanbong, tensanbong, loaisanbong, dongia, songuoi, ngaythuesanbong, ngaytrasanbong, idnhanvienduasanbong, idnhanvientrasanbong, tongtien from thuesanbong inner Join sanbong on thuesanbong.masanbong = sanbong.masanbong where mahoadon='{0}'", mahoadon);
                SqlDataAdapter dal = new SqlDataAdapter(str, con);
                DataTable dalhoadon = new DataTable();
                dal.Fill(dalhoadon);
                string tenkhachhang = dalhoadon.Rows[0]["tenkhachhang"].ToString(); Console.WriteLine(tenkhachhang);
                long masanbong = long.Parse(dalhoadon.Rows[0]["masanbong"].ToString()); Console.WriteLine(masanbong);
                string tensanbong = dalhoadon.Rows[0]["tensanbong"].ToString(); Console.WriteLine(tensanbong);
                string loaisanbong = dalhoadon.Rows[0]["loaisanbong"].ToString(); Console.WriteLine(loaisanbong);
                float dongia = float.Parse(dalhoadon.Rows[0]["dongia"].ToString()); Console.WriteLine(dongia);
                int songuoi = int.Parse(dalhoadon.Rows[0]["songuoi"].ToString()); Console.WriteLine(songuoi);
                DateTime ngaythuesanbong = DateTime.Parse(dalhoadon.Rows[0]["ngaythuesanbong"].ToString()); Console.WriteLine(ngaythuesanbong);
                DateTime ngaytrasanbong = DateTime.Parse(dalhoadon.Rows[0]["ngaytrasanbong"].ToString()); Console.WriteLine(ngaytrasanbong);
                float tongtien = float.Parse(dalhoadon.Rows[0]["tongtien"].ToString()); Console.WriteLine(tongtien);

                TimeSpan time = ngaytrasanbong.Subtract(ngaythuesanbong);
                int songay = time.Days;
                if (songay == 0 || time.Hours > 1) songay++;
                string nhanvienduasanbong = dalnhanvien.getNhanvienByID(long.Parse(dalhoadon.Rows[0]["idnhanvienduasanbong"].ToString())).Rows[0]["hoten"].ToString();
                string nhanvientrasanbong = dalnhanvien.getNhanvienByID(long.Parse(dalhoadon.Rows[0]["idnhanvientrasanbong"].ToString())).Rows[0]["hoten"].ToString();

                // điền bảng
                str = string.Format("insert into hoadon(mahoadon,tenkhachhang,  masanbong, tensanbong,loaisanbong, dongia,songuoi,  ngaythuesanbong, ngaytrasanbong, songay, nhanvienduasanbong, nhanvientrasanbong, tongtien) values('{0}', N'{1}', '{2}','{3}','{4}', '{5}','{6}', " +
                    "'{7}', '{8}', '{9}', N'{10}', N'{11}','{12}')", mahoadon, tenkhachhang, masanbong, tensanbong, loaisanbong, dongia, songuoi, ngaythuesanbong, ngaytrasanbong, songay, nhanvienduasanbong, nhanvientrasanbong, tongtien);
                con.Open();
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch
            {
                return false;
            }
            return true;
        }

        public DataTable getHoadon()
        {
            string str = string.Format("select * from hoadon");
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalhoadon = new DataTable();
            dal.Fill(dalhoadon);
            return dalhoadon;
        }

    }
}
