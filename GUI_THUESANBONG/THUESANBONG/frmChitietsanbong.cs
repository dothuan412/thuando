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
    public partial class frmChitietsanbong : Form
    {
        BUS_Sanbong bussanbong = new BUS_Sanbong();
        public frmChitietsanbong()
        {
            InitializeComponent();
            LoadChitietsanbong();
        }

      
        public void LoadChitietsanbong()
        {
            cbbLoaisanbong.Items.Add("VIP");
            cbbLoaisanbong.Items.Add("Superior");
            cbbLoaisanbong.Items.Add("Standard");
            cbbSonguoitoida.Items.Add(2);
            cbbSonguoitoida.Items.Add(4);
            cbbTinhtrang.Items.Add("Sân bóng trống");
            cbbTinhtrang.Items.Add("Sân bóng đã cho thuê");
            cbbTinhtrang.Items.Add("Sân bóng đang dọn dẹp");
            cbbTinhtrang.Items.Add("Sân bóng hỏng");
            cbbKhuvuc.Items.Add("1");
            cbbKhuvuc.Items.Add("2");
            cbbKhuvuc.Items.Add("3");
            cbbKhuvuc.Items.Add("4");
            cbbKhuvuc.Items.Add("5");
            DataTable sanbong = bussanbong.getSanbongByma(masanbongchitiet.MASANBONG);
            if (sanbong.Rows.Count > 0)
            {
                txtMasanbong.Text = sanbong.Rows[0]["masanbong"].ToString();
                txtTensanbong.Text = sanbong.Rows[0]["tensanbong"].ToString();
                cbbKhuvuc.Text = sanbong.Rows[0]["khuvuc"].ToString();
                cbbLoaisanbong.Text = sanbong.Rows[0]["loaisanbong"].ToString();
                cbbSonguoitoida.Text = sanbong.Rows[0]["songuoitoida"].ToString();
                txtDongia.Text = sanbong.Rows[0]["dongia"].ToString();
                txtMota.Text = sanbong.Rows[0]["mota"].ToString();
                int tt = int.Parse(sanbong.Rows[0]["tinhtrang"].ToString());
                if (tt == 0) cbbTinhtrang.Text = "Sân bóng trống";
                else if (tt == 1) cbbTinhtrang.Text = "Sân bóng đã cho thuê";
                else if (tt == 2) cbbTinhtrang.Text = "Sân bóng đang dọn dẹp";
                else cbbTinhtrang.Text = "Sân bóng hỏng";
            }
        }
            private void btnSua_Click(object sender, EventArgs e)
        {
            bool kt = true;
            foreach (char c in txtDongia.Text)
            {
                if ((byte)c < 48 || (byte)c > 57)
                {
                    kt = false;
                    break;
                }
            }
            if (kt)
            {
                int tinhtrang;
                if (cbbTinhtrang.Text.Equals("Sân bóng trống")) tinhtrang = 0;
                else if (cbbTinhtrang.Text.Equals("Sân bóng đã cho thuê")) tinhtrang = 1;
                else if (cbbTinhtrang.Text.Equals("Sân bóng đang dọn dẹp")) tinhtrang = 2;
                else tinhtrang = 3;

                bussanbong.updateSanbong(long.Parse(txtMasanbong.Text), txtTensanbong.Text, int.Parse(cbbKhuvuc.Text), cbbLoaisanbong.Text, int.Parse(cbbSonguoitoida.Text),  txtMota.Text, float.Parse(txtDongia.Text), tinhtrang);
                MessageBox.Show("Sửa sân bóng thành công", "Thông báo");
                Close();
                LoadChitietsanbong();
            }
            else
            {
                MessageBox.Show("Đơn giá chỉ được chứa ký tự số", "Thông báo");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bussanbong.deleteSanbong(masanbongchitiet.MASANBONG);
            MessageBox.Show("Xoá sân bóng thành công", "Thông báo");
            Close();
            LoadChitietsanbong();
        }
    }
}
