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
    public class BUS_Thuesanbong
    {
        DAL_Thuesanbong dalthuesanbong = new DAL_Thuesanbong();
        public DataTable getListThuesanbong(int ls)
        {
            return dalthuesanbong.getListThuesanbong(ls);
        }

        public DataTable getThongtinthuesanbong(long mahoadon)
        {
            return dalthuesanbong.getThongtinthuesanbong(mahoadon);
        }

        public DataTable timkiemBytensanbong(string tensanbong, int ls)
        {
            return dalthuesanbong.timkiemBytensanbong(tensanbong, ls);
        }

        public DataTable timkiemBytenkhachhang(string tenkhachhang, int ls)
        {
            return dalthuesanbong.timkiemBytenkhachhang(tenkhachhang, ls);
        }

        public DataTable timkiem(string tensanbong, string tenkhachhang, int ls)
        {
            return dalthuesanbong.timkiem(tensanbong, tenkhachhang, ls);
        }

        public bool insertThuesanbong(string tenkhachhang, string soCMND, long masanbong, DateTime ngaythuesanbong, long idnhanvienduasanbong, int songuoi)
        {
            return dalthuesanbong.insertThuesanbong(tenkhachhang, soCMND, masanbong, ngaythuesanbong, idnhanvienduasanbong, songuoi);
        }

        public bool updateThuesanbong(string tenkhachhang, string soCMND, long masanbong, DateTime ngaythuesanbong, int songuoi, long mahoadon)
        {
            return dalthuesanbong.updateThuesanbong(tenkhachhang, soCMND, masanbong, ngaythuesanbong, songuoi, mahoadon);
        }

        public bool traSanbong(long mahoadon, long idnhanvientrasanbong)
        {
            return dalthuesanbong.traSanbong(mahoadon, idnhanvientrasanbong);
        }
        public bool deleteThuesanbong(long mahoadon)
        {
            return dalthuesanbong.deleteThuesanbong(mahoadon);
        }

        public bool taoHoadon(long mahoadon)
        {
            return dalthuesanbong.taoHoadon(mahoadon);
        }

        public DataTable getHoadon()
        {
            return dalthuesanbong.getHoadon();
        }
    }
}

