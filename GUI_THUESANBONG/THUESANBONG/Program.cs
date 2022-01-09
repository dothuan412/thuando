using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUESANBONG
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI_Menu());
        }

    }
    class mySave
    {
        static Boolean kt = true;
        public static Boolean KT
        {
            get { return kt; }
            set { kt = value; }
        }
    }

    class nhanvien
    {
        static long id;
        static string tennhanvien;
        public static long ID
        {
            get { return id; }
            set { id = value; }
        }

        public static string TEN
        {
            get { return tennhanvien; }
            set { tennhanvien = value; }
        }
    }

    class khuvucthemsanbong
    {
        static int khuvuc;
        public static int KHUVUC
        {
            get { return khuvuc; }
            set { khuvuc = value; }
        }
    }

    class masanbongchitiet
    {
        static long masanbong;
        public static long MASANBONG
        {
            get { return masanbong; }
            set { masanbong = value; }
        }
    }

    class mahoadondoi
    {
        static long mahoadon;
        public static long MAHOADON
        {
            get { return mahoadon; }
            set { mahoadon = value; }
        }
    }
}
