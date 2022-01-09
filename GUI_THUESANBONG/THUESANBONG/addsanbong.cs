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
    public partial class addsanbong : UserControl
    {
        public addsanbong()
        {
            InitializeComponent();
        }
        public string anhplus
        {
            set => anh.Image = new Bitmap(Application.StartupPath + "\\resources\\" + value);
        }

        public PictureBox getanh
        {
            get { return anh; }
        }
        public int khuvuc
        {
            get => int.Parse(lblKhuvuc.Text);
            set => lblKhuvuc.Text = value.ToString();
        }

        
        private void anh_Click(object sender, EventArgs e)
        {

        }
    }
}
