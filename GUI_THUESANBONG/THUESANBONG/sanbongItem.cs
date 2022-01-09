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
    public partial class sanbongItem : UserControl
    {
        public sanbongItem()
        {
            InitializeComponent();
        }

        public string loaisanbong
        {
            get => lblloaisanbong.Text;
            set => lblloaisanbong.Text = value;
        }

        public string tensanbong
        {
            get => lblTensanbong.Text;
            set => lblTensanbong.Text = value;
        }

        public string masanbong
        {
            get => lblMasanbong.Text;
            set => lblMasanbong.Text = value;
        }

        public string anhsanbong
        {
            set => anh.Image = new Bitmap(Application.StartupPath + "\\resources\\" + value);
        }

        public PictureBox getanh
        {
            get { return anh; }
        }

        private void lblloaisanbong_Click(object sender, EventArgs e)
        {

        }

        private void lblloaisanbong_Click_1(object sender, EventArgs e)
        {

        }
    }
}
