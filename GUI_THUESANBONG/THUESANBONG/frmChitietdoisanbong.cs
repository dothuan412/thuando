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
    public partial class frmChitietdoisanbong : Form
    {
        BUS_Sanbong bussanbong = new BUS_Sanbong();
        BUS_Thuesanbong busthuesanbong = new BUS_Thuesanbong();
        
        public frmChitietdoisanbong()
        {
            InitializeComponent();
            LoadChitietdoisanbong();
        }
        public void LoadChitietdoisanbong()
        {
            DataTable sanbong = bussanbong.getSanbongByma(masanbongchitiet.MASANBONG);
            if (sanbong.Rows.Count > 0)
            {
                txtMasanbong.Text = sanbong.Rows[0]["masanbong"].ToString();
                txtTensanbong.Text = sanbong.Rows[0]["tensanbong"].ToString();
                txtKhuvuc.Text = sanbong.Rows[0]["khuvuc"].ToString();
                txtLoaisanbong.Text = sanbong.Rows[0]["loaisanbong"].ToString();
                txtSonguoitoida.Text = sanbong.Rows[0]["songuoitoida"].ToString();
                txtMota.Text = sanbong.Rows[0]["mota"].ToString();
                txtDongia.Text = sanbong.Rows[0]["dongia"].ToString();
                int tt = int.Parse(sanbong.Rows[0]["tinhtrang"].ToString());
                btnDoisanbong.Enabled = false;
                if (tt == 0)
                {
                    txtTinhtrang.Text = "Sân bóng trống";
                    btnDoisanbong.Enabled = true;
                }
                else if (tt == 1) txtTinhtrang.Text = "Sân bóng đã cho thuê";
                else if (tt == 2) txtTinhtrang.Text = "Sân bóng đang dọn dẹp";
                else txtTinhtrang.Text = "Sân bóng hỏng";
            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnDoisanbong_Click(object sender, EventArgs e)
        {
            DataTable dt = busthuesanbong.getThongtinthuesanbong(mahoadondoi.MAHOADON);
            busthuesanbong.updateThuesanbong(dt.Rows[0]["tenkhachhang"].ToString(), dt.Rows[0]["soCMND"].ToString(), masanbongchitiet.MASANBONG, DateTime.Parse(dt.Rows[0]["ngaythue"].ToString()), int.Parse(dt.Rows[0]["songuoi"].ToString()), mahoadondoi.MAHOADON);
            MessageBox.Show("Đổi sân bóng thành công", "Thông báo");
            Close();

        }
    }
}
