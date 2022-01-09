using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_THUESANBONG;

namespace BUS_THUESANBONG
{

    public class BUS_Nhanvien
    {
        DAL_Nhanvien dalnhanvien = new DAL_Nhanvien();
        public DataTable ktdn(string username, string password)
        {
            return dalnhanvien.ktdn(username, password);
        }

        public DataTable getNhanvienByID(long id)
        {
            return dalnhanvien.getNhanvienByID(id);
        }
    }
}

