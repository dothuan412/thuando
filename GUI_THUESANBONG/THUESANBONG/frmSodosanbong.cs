using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_THUESANBONG;

namespace THUESANBONG
{
    public partial class frmSodosanbong : Form
    {

        List<sanbongItem> sanbong;
        BUS_Sanbong bussanbong = new BUS_Sanbong();
        public frmSodosanbong()
        {
            InitializeComponent();
            LoadSanbong();
        }
        private void LoadSanbong()
        {
            flp1.Controls.Clear();
            flp2.Controls.Clear();
            flp3.Controls.Clear();
            flp4.Controls.Clear();
            flp5.Controls.Clear();
            sanbong = new List<sanbongItem>();
            DataTable listsanbong = bussanbong.getListSanbongbyKhuvuc(1);


            for (int i = 0; i < listsanbong.Rows.Count; i++)
            {
                sanbongItem a = new sanbongItem();
                a.loaisanbong = listsanbong.Rows[i]["loaisanbong"].ToString();
                a.tensanbong = listsanbong.Rows[i]["tensanbong"].ToString();
                a.masanbong = listsanbong.Rows[i]["masanbong"].ToString();
                if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 0) a.anhsanbong = "santrong.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 1) a.anhsanbong = "dathue.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 2) a.anhsanbong = "sandangdon.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 3) a.anhsanbong = "dongcua.png";
                sanbong.Add(a);
                a.Cursor = Cursors.Hand;
                a.getanh.Click += (sender, e) => chitietsanbong_Click(this, e, long.Parse(a.masanbong));
            }
            foreach (sanbongItem p in sanbong)
            {
                flp1.Controls.Add(p);
            }
            if (flp1.Controls.Count < 10)
            {
                addsanbong a1 = new addsanbong();
                a1.anhplus = "plus.png";
                a1.khuvuc = 1;
                flp1.Controls.Add(a1);
                a1.Cursor = Cursors.Hand;
                a1.getanh.Click += (sender, e) => addsanbong_Click(this, e, 1);

            }

            sanbong.Clear();
            listsanbong = bussanbong.getListSanbongbyKhuvuc(2);
            for (int i = 0; i < listsanbong.Rows.Count; i++)
            {
                sanbongItem a = new sanbongItem();
                a.loaisanbong = listsanbong.Rows[i]["loaisanbong"].ToString();
                a.tensanbong = listsanbong.Rows[i]["tensanbong"].ToString();
                a.masanbong = listsanbong.Rows[i]["masanbong"].ToString();
                if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 0) a.anhsanbong = "santrong.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 1) a.anhsanbong = "dathue.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 2) a.anhsanbong = "sandangdon.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 3) a.anhsanbong = "dongcua.png";
                sanbong.Add(a);
                a.Cursor = Cursors.Hand;
                a.getanh.Click += (sender, e) => chitietsanbong_Click(this, e, long.Parse(a.masanbong));
            }
            foreach (sanbongItem p in sanbong)
            {
                flp2.Controls.Add(p);
            }
            if (flp2.Controls.Count < 10)
            {
                addsanbong a1 = new addsanbong();
                a1.anhplus = "plus.png";
                a1.khuvuc = 2;
                flp2.Controls.Add(a1);
                a1.Cursor = Cursors.Hand;
                a1.getanh.Click += (sender, e) => addsanbong_Click(this, e, 2);
            }


            sanbong.Clear();
            listsanbong = bussanbong.getListSanbongbyKhuvuc(3);
            for (int i = 0; i < listsanbong.Rows.Count; i++)
            {
                sanbongItem a = new sanbongItem();
                a.loaisanbong = listsanbong.Rows[i]["loaisanbong"].ToString();
                a.tensanbong = listsanbong.Rows[i]["tensanbong"].ToString();
                a.masanbong = listsanbong.Rows[i]["masanbong"].ToString();
                if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 0) a.anhsanbong = "santrong.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 1) a.anhsanbong = "dathue.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 2) a.anhsanbong = "sandangdon.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 3) a.anhsanbong = "dongcua.png";
                sanbong.Add(a);
                a.Cursor = Cursors.Hand;
                a.getanh.Click += (sender, e) => chitietsanbong_Click(this, e, long.Parse(a.masanbong));
            }
            foreach (sanbongItem p in sanbong)
            {
                flp3.Controls.Add(p);
            }
            if (flp3.Controls.Count < 10)
            {
                addsanbong a1 = new addsanbong();
                a1.anhplus = "plus.png";
                a1.khuvuc = 3;
                flp3.Controls.Add(a1);
                a1.Cursor = Cursors.Hand;
                a1.getanh.Click += (sender, e) => addsanbong_Click(this, e, 3);
            }

            sanbong.Clear();
            listsanbong = bussanbong.getListSanbongbyKhuvuc(4);
            for (int i = 0; i < listsanbong.Rows.Count; i++)
            {
                sanbongItem a = new sanbongItem();
                a.loaisanbong = listsanbong.Rows[i]["loaisanbong"].ToString();
                a.tensanbong = listsanbong.Rows[i]["tensanbong"].ToString();
                a.masanbong = listsanbong.Rows[i]["masanbong"].ToString();
                if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 0) a.anhsanbong = "santrong.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 1) a.anhsanbong = "dathue.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 2) a.anhsanbong = "sandangdon.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 3) a.anhsanbong = "dongcua.png";
                sanbong.Add(a);
                a.Cursor = Cursors.Hand;
                a.getanh.Click += (sender, e) => chitietsanbong_Click(this, e, long.Parse(a.masanbong));
            }
            foreach (sanbongItem p in sanbong)
            {
                flp4.Controls.Add(p);
            }
            if (flp4.Controls.Count < 10)
            {
                addsanbong a1 = new addsanbong();
                a1.anhplus = "plus.png";
                a1.khuvuc = 4;
                flp4.Controls.Add(a1);
                a1.Cursor = Cursors.Hand;
                a1.getanh.Click += (sender, e) => addsanbong_Click(this, e, 4);
            }

            sanbong.Clear();
            listsanbong = bussanbong.getListSanbongbyKhuvuc(5);
            for (int i = 0; i < listsanbong.Rows.Count; i++)
            {
                sanbongItem a = new sanbongItem();
                a.loaisanbong = listsanbong.Rows[i]["loaisanbong"].ToString();
                a.tensanbong = listsanbong.Rows[i]["tensanbong"].ToString();
                a.masanbong = listsanbong.Rows[i]["masanbong"].ToString();
                if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 0) a.anhsanbong = "santrong.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 1) a.anhsanbong = "dathue.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 2) a.anhsanbong = "sandangdon.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 3) a.anhsanbong = "dongcua.png";
                sanbong.Add(a);
                a.Cursor = Cursors.Hand;
                a.getanh.Click += (sender, e) => chitietsanbong_Click(this, e, long.Parse(a.masanbong));
            }
            foreach (sanbongItem p in sanbong)
            {
                flp5.Controls.Add(p);
            }
            if (flp5.Controls.Count < 10)
            {
                addsanbong a1 = new addsanbong();
                a1.anhplus = "plus.png";
                a1.khuvuc = 5;
                flp5.Controls.Add(a1);
                a1.Cursor = Cursors.Hand;
                a1.getanh.Click += (sender, e) => addsanbong_Click(this, e, 5);
            }
        }
        public void addsanbong_Click(object sender, EventArgs e, int khuvuc)
        {
            khuvucthemsanbong.KHUVUC = khuvuc;
            frmThemsanbong tp = new frmThemsanbong();
            tp.Show();
            LoadSanbong();
        }

        public void chitietsanbong_Click(object sender, EventArgs e, long masanbong)
        {
            masanbongchitiet.MASANBONG = masanbong;
            frmChitietsanbong ctp = new frmChitietsanbong();
            ctp.Show();
        }

        private void frmSodophong_Load(object sender, EventArgs e)
        {
            LoadSanbong();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void flp1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
