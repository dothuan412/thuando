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
    public partial class frmThemsanbong : Form
    {
        BUS_Sanbong bussanbong = new BUS_Sanbong();
        public frmThemsanbong()
        {
            InitializeComponent();
            txtTensanbong.Focus();
            cbbLoaisanbong.Items.Add("VIP");
            cbbLoaisanbong.Items.Add("Superior");
            cbbLoaisanbong.Items.Add("Standard");
            cbbLoaisanbong.SelectedIndex = 0;
            cbbSonguoitoida.Items.Add(2);
            cbbSonguoitoida.Items.Add(4);
            cbbSonguoitoida.SelectedIndex = 0;
            txtKhuvuc.Text = khuvucthemsanbong.KHUVUC.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
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
            if (txtTensanbong.Text.Trim().Equals("") || txtTensanbong == null || cbbLoaisanbong.SelectedItem.ToString().Trim().Equals("") || cbbLoaisanbong == null || cbbSonguoitoida.SelectedItem.ToString().Trim().Equals("") || cbbSonguoitoida == null || txtDongia.Text.Trim().Equals("") || txtDongia == null || txtMota.Text.Trim().Equals("") || txtMota == null)
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo");
            else if (!kt)
            {
                MessageBox.Show("Đơn giá chỉ được chứa ký tự số", "Thông báo");
            }
            else
            {
                bussanbong.insertSanbong(txtTensanbong.Text, int.Parse(txtKhuvuc.Text), cbbLoaisanbong.SelectedItem.ToString(), int.Parse(cbbSonguoitoida.SelectedItem.ToString()),  txtMota.Text, float.Parse(txtDongia.Text), 0);
                MessageBox.Show("Thêm sân bóng thành công", "Thông báo");
                Close();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
