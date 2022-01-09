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
    public class BUS_Sanbong
    {
        DAL_Sanbong dalSanbong = new DAL_Sanbong();
        public DataTable getListSanbongbyKhuvuc(int khuvuc)
        {
            return dalSanbong.getListSanbongbykhuvuc(khuvuc);
        }

        public DataTable getListSanbongtrong()
        {
            return dalSanbong.getListSanbongtrong();
        }

        public DataTable getSanbongByma(long masanbong)
        {
            return dalSanbong.getSanbongByma(masanbong);
        }

        public DataTable timkiemSanbongtrong(string khuvuc, string loaisanbong, string songuoitoida)
        {
            return dalSanbong.timkiemSanbongtrong(khuvuc, loaisanbong, songuoitoida);
        }

        public DataTable timkiemSanbongtrongBykhuvuc(string khuvuc)
        {
            return dalSanbong.timkiemSanbongtrongBykhuvuc(khuvuc);
        }

        public DataTable timkiemSanbongtrongByloaisanbong(string loaisanbong)
        {
            return dalSanbong.timkiemSanbongtrongByloaisanbong(loaisanbong);
        }

        public DataTable timkiemSanbongtrongBysonguoitoida(string songuoitoida)
        {
            return dalSanbong.timkiemSanbongtrongBysonguoitoida(songuoitoida);
        }

        public DataTable timkiemSanbongtrongBykhuvucvaloaisanbong(string khuvuc, string loaisanbong)
        {
            return dalSanbong.timkiemSanbongtrongBykhuvucvaloaisanbong(khuvuc, loaisanbong);
        }

        public DataTable timkiemSanbongtrongBykhuvucvasonguoitoida(string khuvuc, string songuoitoida)
        {
            return dalSanbong.timkiemSanbongtrongBykhuvucvaloaisanbong(khuvuc, songuoitoida);
        }

        public DataTable timkiemSanbongtrongByloaisanbongvasonguoitoida(string loaisanbong, string songuoitoida)
        {

            return dalSanbong.timkiemSanbongtrongBykhuvucvaloaisanbong(loaisanbong, songuoitoida);
        }



        public bool insertSanbong(string tensanbong, int khuvuc, string loaisanbong, int songuoitoida,  string mota, float dongia, int tinhtrang)
        {
            return dalSanbong.insertSanbong(tensanbong, khuvuc, loaisanbong, songuoitoida,  mota, dongia,  tinhtrang);
        }

        public bool updateSanbong(long masanbong, string tensanbong, int khuvuc, string loaisanbong, int songuoitoida,  string mota, float dongia, int tinhtrang)
        {
            return dalSanbong.updateSanbong(masanbong, tensanbong, khuvuc, loaisanbong, songuoitoida, mota, dongia, tinhtrang);
        }

        public bool updateTinhtrangSanbong(long masanbong, int tinhtrang)
        {
            return dalSanbong.updateTinhtrangSanbong(masanbong, tinhtrang);
        }

        public bool deleteSanbong(long masanbong)
        {
            return dalSanbong.deleteSanbong(masanbong);
        }
    }
}
