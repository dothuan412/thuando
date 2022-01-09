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
    
    public partial class frmDoisanbong : Form
    {
        List<sanbongItem> sanbong;
        BUS_Sanbong bussanbong = new BUS_Sanbong();
        public frmDoisanbong()
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
                if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 0) a.anhsanbong = "sanbongtrong.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 1) a.anhsanbong = "sanbongdathue.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 2) a.anhsanbong = "donsanbong.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 3) a.anhsanbong = "sanbonghong.png";
                sanbong.Add(a);
                a.Cursor = Cursors.Hand;
                a.getanh.Click += (sender, e) => chitietsanbong_Click(this, e, long.Parse(a.masanbong));
            }
            foreach (sanbongItem p in sanbong)
            {
                flp1.Controls.Add(p);
            }

            sanbong.Clear();
            listsanbong = bussanbong.getListSanbongbyKhuvuc(2);
            for (int i = 0; i < listsanbong.Rows.Count; i++)
            {
                sanbongItem a = new sanbongItem();
                a.loaisanbong = listsanbong.Rows[i]["loaisanbong"].ToString();
                a.tensanbong = listsanbong.Rows[i]["tensanbong"].ToString();
                a.masanbong = listsanbong.Rows[i]["masanbong"].ToString();
                if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 0) a.anhsanbong = "phongtrong.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 1) a.anhsanbong = "phongdathue.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 2) a.anhsanbong = "donphong.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 3) a.anhsanbong = "phonghong.png";
                sanbong.Add(a);
                a.Cursor = Cursors.Hand;
                a.getanh.Click += (sender, e) => chitietsanbong_Click(this, e, long.Parse(a.masanbong));
            }
            foreach (sanbongItem p in sanbong)
            {
                flp2.Controls.Add(p);
            }


            sanbong.Clear();
            listsanbong = bussanbong.getListSanbongbyKhuvuc(3);
            for (int i = 0; i < listsanbong.Rows.Count; i++)
            {
                sanbongItem a = new sanbongItem();
                a.loaisanbong = listsanbong.Rows[i]["loaisanbong"].ToString();
                a.tensanbong = listsanbong.Rows[i]["tensanbong"].ToString();
                a.masanbong = listsanbong.Rows[i]["masanbong"].ToString();
                if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 0) a.anhsanbong = "phongtrong.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 1) a.anhsanbong = "phongdathue.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 2) a.anhsanbong = "donphong.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 3) a.anhsanbong = "phonghong.png";
                sanbong.Add(a);
                a.Cursor = Cursors.Hand;
                a.getanh.Click += (sender, e) => chitietsanbong_Click(this, e, long.Parse(a.masanbong));
            }
            foreach (sanbongItem p in sanbong)
            {
                flp3.Controls.Add(p);
            }

            sanbong.Clear();
            listsanbong = bussanbong.getListSanbongbyKhuvuc(4);
            for (int i = 0; i < listsanbong.Rows.Count; i++)
            {
                sanbongItem a = new sanbongItem();
                a.loaisanbong = listsanbong.Rows[i]["loaisanbong"].ToString();
                a.tensanbong = listsanbong.Rows[i]["tensanbong"].ToString();
                a.masanbong = listsanbong.Rows[i]["masanbong"].ToString();
                if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 0) a.anhsanbong = "phongtrong.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 1) a.anhsanbong = "phongdathue.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 2) a.anhsanbong = "donphong.png";
                else if (int.Parse(listsanbong.Rows[i]["tinhtrang"].ToString()) == 3) a.anhsanbong = "phonghong.png";
                sanbong.Add(a);
                a.Cursor = Cursors.Hand;
                a.getanh.Click += (sender, e) => chitietsanbong_Click(this, e, long.Parse(a.masanbong));
            }
            foreach (sanbongItem p in sanbong)
            {
                flp4.Controls.Add(p);
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
        }


        private void flp1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDoisanbong_Load(object sender, EventArgs e)
        {
            LoadSanbong();
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }
        public void chitietsanbong_Click(object sender, EventArgs e, long masanbong)
        {
            masanbongchitiet.MASANBONG = masanbong;
            frmChitietdoisanbong ctp = new frmChitietdoisanbong();
            ctp.Show();
            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
