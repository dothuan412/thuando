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
    public partial class frmThuesanbong : Form
    {
        BUS_Thuesanbong busthuesanbong = new BUS_Thuesanbong();
        BUS_Sanbong bussanbong = new BUS_Sanbong();
        public frmThuesanbong()
        {
            InitializeComponent();
            InitializeComponent();
            dgvSanbong.DataSource = bussanbong.getListSanbongtrong();
            for (int i = 1; i <= 5; i++) cbbKhuvuc.Items.Add(i.ToString());
            cbbLoaisanbong.Items.Add("VIP");
            cbbLoaisanbong.Items.Add("Superior");
            cbbLoaisanbong.Items.Add("Standard");
            cbbSonguoitoida.Items.Add(2);
            cbbSonguoitoida.Items.Add(4);
            cbbKhuvuc.Focus();
            txtTennhanvien.Text = nhanvien.TEN;
            txtManhanvien.Text = nhanvien.ID.ToString();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void frmThuesanbong_Load(object sender, EventArgs e)
        {

        }

        private void btnThuesanbong_Click(object sender, EventArgs e)
        {
            bool kt = true;
            foreach (char c in txtSoCMND.Text)
            {
                if ((byte)c < 48 || (byte)c > 57)
                {
                    kt = false;
                    break;
                }
            }

            bool kt1 = true;
            foreach (char c in txtSoluonguoi.Text)
            {
                if ((byte)c < 48 || (byte)c > 57)
                {
                    kt1 = false;
                    break;
                }
            }
            bool kt2 = true;
            foreach (char c in txtHotenkhachhang.Text)
            {
                if ((byte)c < 65 || (byte)c > 90 && (byte)c < 97 || (byte)c > 122)
                {
                    kt2 = false;
                    break;
                }
            }

            if (txtMasanbong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải chọn sân bóng", "Thông báo");
            }
            else if (txtHotenkhachhang.Text.Trim() == "")
            {
                txtHotenkhachhang.Focus();
                MessageBox.Show("Không được bỏ trống tên khách hàng", "Thông báo");
            }
            else if (txtSoCMND.Text.Trim() == "")
            {
                txtSoCMND.Focus();
                MessageBox.Show("Không được bỏ trống Số chứng minh nhân dân của khách hàng", "Thông báo");
            }
            else if (txtSoluonguoi.Text.Trim() == "")
            {
                txtSoluonguoi.Focus();
                MessageBox.Show("Không được bỏ trống số lượng người", "Thông báo");
            }
            else if (dtThuesanbong.Text.Trim() == "")
            {
                dtThuesanbong.Focus();
                MessageBox.Show("Không được bỏ trống ngày thuê sân bóng", "Thông báo");
            }
            else if (!kt)
            {
                txtSoCMND.Focus();
                MessageBox.Show("Số CMND chỉ được chứa ký tự số", "Thông báo");
            }
            else if (!kt1)
            {
                txtSoluonguoi.Focus();
                MessageBox.Show("Số người chỉ được chứa ký tự số", "Thông báo");
            }
            else if (!kt2)
            {
                txtHotenkhachhang.Focus();
                MessageBox.Show("Họ tên khách chỉ được chứa ký tự chữ", "Thông báo");
            }
            else if (int.Parse(txtSoluonguoi.Text.Trim()) > (int)dgvSanbong[4, dgvSanbong.CurrentRow.Index].Value)
            {

                txtSoluonguoi.Focus();
                MessageBox.Show("Số người không được lớn hơn số người tối đa của sân bóng", "Thông báo");
            }
            else
            {
                bool tp = busthuesanbong.insertThuesanbong(txtHotenkhachhang.Text, txtSoCMND.Text, long.Parse(txtMasanbong.Text), DateTime.Parse(dtThuesanbong.Text), long.Parse(txtManhanvien.Text), int.Parse(txtSoluonguoi.Text));
                if (tp) MessageBox.Show("Thuê sân bóng thành công", "Thông báo");
                else MessageBox.Show("Thuê sân bóng thất bại", "Thông báo");
                dgvSanbong.DataSource = bussanbong.getListSanbongtrong();
                cbbKhuvuc.Focus();
                cbbKhuvuc.Text = "";
                cbbLoaisanbong.Text = "";
                cbbSonguoitoida.Text = "";
                txtMasanbong.Text = "";
                txtTensanbong.Text = "";
                txtKhuvuc.Text = "";
                txtLoaisanbong.Text = "";
                txtGiathuesanbong.Text = "";
                txtHotenkhachhang.Text = "";
                txtSoCMND.Text = "";
                txtSoluonguoi.Text = "";
                dtThuesanbong.Text = "";

            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cbbKhuvuc.SelectedItem == null && cbbLoaisanbong.SelectedItem == null && cbbSonguoitoida.SelectedItem == null)
                dgvSanbong.DataSource = bussanbong.getListSanbongtrong();
            else if (cbbKhuvuc.SelectedItem != null && cbbLoaisanbong.SelectedItem == null && cbbSonguoitoida.SelectedItem == null)
                dgvSanbong.DataSource = bussanbong.timkiemSanbongtrongBykhuvuc(cbbKhuvuc.SelectedItem.ToString());
            else if (cbbKhuvuc.SelectedItem == null && cbbLoaisanbong.SelectedItem != null && cbbSonguoitoida.SelectedItem == null)
                dgvSanbong.DataSource = bussanbong.timkiemSanbongtrongByloaisanbong(cbbLoaisanbong.SelectedItem.ToString());
            else if (cbbKhuvuc.SelectedItem == null && cbbLoaisanbong.SelectedItem == null && cbbSonguoitoida.SelectedItem != null)
                dgvSanbong.DataSource = bussanbong.timkiemSanbongtrongBysonguoitoida(cbbSonguoitoida.SelectedItem.ToString());
            else if (cbbKhuvuc.SelectedItem != null && cbbLoaisanbong.SelectedItem != null && cbbSonguoitoida.SelectedItem == null)
                dgvSanbong.DataSource = bussanbong.timkiemSanbongtrongBykhuvucvaloaisanbong(cbbKhuvuc.SelectedItem.ToString(), cbbLoaisanbong.SelectedItem.ToString());
            else if (cbbKhuvuc.SelectedItem == null && cbbLoaisanbong.SelectedItem != null && cbbSonguoitoida.SelectedItem != null)
                dgvSanbong.DataSource = bussanbong.timkiemSanbongtrongByloaisanbongvasonguoitoida(cbbLoaisanbong.SelectedItem.ToString(), cbbSonguoitoida.SelectedItem.ToString());
            else if (cbbKhuvuc.SelectedItem != null && cbbLoaisanbong.SelectedItem == null && cbbSonguoitoida.SelectedItem != null)
                dgvSanbong.DataSource = bussanbong.timkiemSanbongtrongBykhuvucvasonguoitoida(cbbKhuvuc.SelectedItem.ToString(), cbbSonguoitoida.SelectedItem.ToString());
            else if (cbbKhuvuc.SelectedItem != null && cbbLoaisanbong.SelectedItem != null && cbbSonguoitoida.SelectedItem != null)
                dgvSanbong.DataSource = bussanbong.timkiemSanbongtrong(cbbKhuvuc.SelectedItem.ToString(), cbbLoaisanbong.SelectedItem.ToString(), cbbSonguoitoida.SelectedItem.ToString());
        }

        private void dgvSanbong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSanbong.CurrentRow.Index;
            txtMasanbong.Text = dgvSanbong[0, i].Value.ToString();
            txtTensanbong.Text = dgvSanbong[1, i].Value.ToString();
            txtKhuvuc.Text = dgvSanbong[2, i].Value.ToString();
            txtGiathuesanbong.Text = dgvSanbong[5, i].Value.ToString();
            txtLoaisanbong.Text = dgvSanbong[3, i].Value.ToString();
            txtHotenkhachhang.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbKhuvuc.Focus();
            cbbKhuvuc.Text = "";
            cbbLoaisanbong.Text = "";
            cbbSonguoitoida.Text = "";
            txtMasanbong.Text = "";
            txtTensanbong.Text = "";
            txtKhuvuc.Text = "";
            txtLoaisanbong.Text = "";
            txtGiathuesanbong.Text = "";
            txtHotenkhachhang.Text = "";
            txtSoCMND.Text = "";
            txtSoluonguoi.Text = "";
            dtThuesanbong.Text = "";
        }

        private void txtMasanbong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
