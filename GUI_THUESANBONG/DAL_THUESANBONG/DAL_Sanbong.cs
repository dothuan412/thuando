using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_THUESANBONG
{
    public class DAL_Sanbong : DAL_THUESANBONG.DBConnection
    {
        public DataTable getListSanbongbykhuvuc(int khuvuc)
        {
            string str = string.Format("select * from sanbong where khuvuc='{0}'", khuvuc);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSanbong = new DataTable();
            dal.Fill(dalSanbong);
            return dalSanbong;
        }

        public DataTable getListSanbongtrong()
        {
            string str = string.Format("select * from sanbong where tinhtrang='{0}'", 0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSanbong = new DataTable();
            dal.Fill(dalSanbong);
            return dalSanbong;
        }

        public DataTable getSanbongByma(long masanbong)
        {
            string str = string.Format("select * from sanbong where masanbong='{0}'", masanbong);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSanbong = new DataTable();
            dal.Fill(dalSanbong);
            return dalSanbong;
        }

        public DataTable timkiemSanbongtrongBykhuvuc(string khuvuc)
        {
            string str = string.Format("select * from sanbong where khuvuc='{0}' and tinhtrang='{1}'", khuvuc, 0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSanbong = new DataTable();
            dal.Fill(dalSanbong);
            return dalSanbong;
        }

        public DataTable timkiemSanbongtrongByloaisanbong(string loaisanbong)
        {
            string str = string.Format("select * from sanbong where loaisanbong = '{0}' and tinhtrang='{1}'", loaisanbong, 0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSanbong = new DataTable();
            dal.Fill(dalSanbong);
            return dalSanbong;
        }

        public DataTable timkiemSanbongtrongBysonguoitoida(string songuoitoida)
        {
            string str = string.Format("select * from sanbong where songuoitoida ='{0}' and tinhtrang='{1}'", songuoitoida, 0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSanbong = new DataTable();
            dal.Fill(dalSanbong);
            return dalSanbong;
        }

        public DataTable timkiemSanbongtrongBykhuvucvaloaisanbong(string khuvuc, string loaisanbong)
        {
            string str = string.Format("select * from sanbong where khuvuc='{0}' and loaisanbong = '{1}' and tinhtrang='{2}'", khuvuc, loaisanbong, 0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSanbong = new DataTable();
            dal.Fill(dalSanbong);
            return dalSanbong;
        }

        public DataTable timkiemSanbongtrongByvasonguoitoida(string khuvuc, string songuoitoida)
        {
            string str = string.Format("select * from Sanbong where khuvuc='{0}' and songuoitoida ='{1}' and tinhtrang='{2}'", khuvuc, songuoitoida, 0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSanbong = new DataTable();
            dal.Fill(dalSanbong);
            return dalSanbong;
        }

        public DataTable timkiemSanbongtrongByloaisanbongvasonguoitoida(string loaisanbong, string songuoitoida)
        {
            string str = string.Format("select * from sanbong where loaisanbong = '{0}' and songuoitoida ='{1}' and tinhtrang='{2}'", loaisanbong, songuoitoida, 0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSanbong = new DataTable();
            dal.Fill(dalSanbong);
            return dalSanbong;
        }

        public DataTable timkiemSanbongtrong(string khuvuc, string loaisanbong, string songuoitoida)
        {
            string str = string.Format("select * from sanbong where khuvuc='{0}' and loaisanbong = '{1}' and songuoitoida ='{2}' and tinhtrang='{3}'", khuvuc, loaisanbong, songuoitoida, 0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSanbong = new DataTable();
            dal.Fill(dalSanbong);
            return dalSanbong;
        }

        public bool insertSanbong(string tensanbong, int khuvuc, string loaisanbong, int songuoitoida, string mota, float dongia, int tinhtrang)
        {
            string str = string.Format("insert into sanbong(tensanbong, khuvuc, loaisanbong, songuoitoida,  mota, dongia,tinhtrang) values('N{0}','{1}','{2}','{3}','{4}',N'{5}','{6}')", tensanbong, khuvuc, loaisanbong, songuoitoida, mota, dongia, tinhtrang);
            try
            {
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

        public bool updateSanbong(long masanbong, string tensanbong, int khuvuc, string loaisanbong, int songuoitoida,  string mota, float dongia, int tinhtrang)
        {
            string str = string.Format("update sanbong set tensanbong = N'{0}', khuvuc = '{1}', loaisanbong = '{2}', songuoitoida = '{3}',  mota = N'{4}', dongia = '{5}', tinhtrang = '{6}' where masanbong = '{7}'", tensanbong, khuvuc, loaisanbong, songuoitoida, mota, dongia, tinhtrang, masanbong);
            try
            {
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

        public bool updateTinhtrangSanbong(long masanbong, int tinhtrang)
        {
            string str = string.Format("update sanbong set tinhtrang = '{0}' where masanbong = '{1}'", tinhtrang, masanbong);
            try
            {
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

        public bool deleteSanbong(long masanbong)
        {
            string str = string.Format("delete from sanbong where maphong = '{0}'", masanbong);
            try
            {
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
    }
}
