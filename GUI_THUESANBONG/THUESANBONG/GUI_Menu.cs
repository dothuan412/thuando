using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUESANBONG
{
    public partial class GUI_Menu : Form
    {
        public GUI_Menu()
        {
            InitializeComponent();
            Lock_Unlock(mySave.KT);
        }
        void Lock_Unlock(Boolean kt)
        {
            mnuDangxuat.Enabled = mnuSodosanbong.Enabled = mnuQuanlithuesanbong.Enabled = mnuLichsuthuesanbong.Enabled = !kt;
            mnuDangnhap.Enabled = mnuThoat.Enabled = kt;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mnuDangnhap_Click(object sender, EventArgs e)
        {
            frmDangnhap dn = new frmDangnhap();
            dn.Show();

        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuDangxuat_Click(object sender, EventArgs e)
        {
            mySave.KT = !mySave.KT;
            Lock_Unlock(mySave.KT);
        }

        private void GUI_Menu_Load(object sender, EventArgs e)
        {
            Lock_Unlock(mySave.KT);
        }

        private void mnuThuesanbong_Click(object sender, EventArgs e)
        {

            frmThuesanbong ts = new frmThuesanbong();
            ts.Show();
        }

        

        private void mnuTrasan_Click(object sender, EventArgs e)
        {
            frmDanhsachthuesanbong ts = new frmDanhsachthuesanbong();
            ts.Show();
        }

        private void mnuLichsuthuesanbong_Click(object sender, EventArgs e)
        {
            frmLichsuthue ls = new frmLichsuthue();
            ls.Show();
        }

        private void mnuSodosanbong_Click(object sender, EventArgs e)
        {
            frmSodosanbong sdsb = new frmSodosanbong();
            sdsb.Show();
        }

        private void mnuSystem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void GUI_Menu_Activated(object sender, EventArgs e)
        {
            Lock_Unlock(mySave.KT);
        }
    }
}
