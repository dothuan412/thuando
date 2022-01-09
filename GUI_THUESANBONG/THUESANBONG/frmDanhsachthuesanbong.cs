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
    public partial class frmDanhsachthuesanbong : Form
    {
        BUS_Thuesanbong busThuesanbong = new BUS_Thuesanbong();
        BUS_Sanbong bussanbong = new BUS_Sanbong();
        public frmDanhsachthuesanbong()
        {
            InitializeComponent();
            dgvThuesanbong.DataSource = busThuesanbong.getListThuesanbong(0);
            tkTensanbong.Focus();
            btnHuythuesan.Enabled = btnDoisan.Enabled = btnTrasan.Enabled = false;

        }


        private void btnHuythuesan_Click(object sender, EventArgs e)
        {
            busThuesanbong.deleteThuesanbong(long.Parse(txtMahoadon.Text));
            dgvThuesanbong.DataSource = busThuesanbong.getListThuesanbong(0);
            tkTensanbong.Focus();
            btnHuythuesan.Enabled = btnDoisan.Enabled = btnTrasan.Enabled = false;
            txtMasanbong.Text = "";
            txtTensanbong.Text = "";
            txtKhuvuc.Text = "";
            txtLoaisanbong.Text = "";
            txtGiathuesanbong.Text = "";
            txtHotenkhachhang.Text = "";
            txtSoCMND.Text = "";
            txtSoluonguoi.Text = "";
            dtThuesanbong.Text = "";
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            txtMahoadon.Text = "";
            dtTrasanbong.Text = "";
            lblTongtien.Text = "";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (tkTensanbong.Text == null && tkTenkhachhang.Text == null) dgvThuesanbong.DataSource = busThuesanbong.getListThuesanbong(0);
            else if (tkTensanbong.Text != null && tkTenkhachhang.Text == null) dgvThuesanbong.DataSource = busThuesanbong.timkiemBytensanbong(tkTensanbong.Text, 0);
            else if (tkTensanbong.Text == null && tkTenkhachhang.Text != null) dgvThuesanbong.DataSource = busThuesanbong.timkiemBytenkhachhang(tkTenkhachhang.Text, 0);
            else if (tkTensanbong.Text != null && tkTenkhachhang.Text != null) dgvThuesanbong.DataSource = busThuesanbong.timkiem(tkTensanbong.Text, tkTenkhachhang.Text, 0);
        }

        private void dgvThuesanbong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvThuesanbong.CurrentRow.Index;
            if ((i <= dgvThuesanbong.Rows.Count - 2) && dgvThuesanbong.Rows.Count > 1)
            {
                DataTable tt = busThuesanbong.getThongtinthuesanbong((long)dgvThuesanbong[0, i].Value);
                txtMasanbong.Text = tt.Rows[0]["masanbong"].ToString();
                txtTensanbong.Text = tt.Rows[0]["tenphong"].ToString();
                txtKhuvuc.Text = tt.Rows[0]["khuvuc"].ToString();
                txtLoaisanbong.Text = tt.Rows[0]["loaisanbong"].ToString();
                txtGiathuesanbong.Text = tt.Rows[0]["dongia"].ToString();
                txtHotenkhachhang.Text = tt.Rows[0]["tenkhachhang"].ToString();
                txtSoCMND.Text = tt.Rows[0]["soCMND"].ToString();
                txtSoluonguoi.Text = tt.Rows[0]["songuoi"].ToString();
                dtThuesanbong.Text = tt.Rows[0]["ngaythuesanbong"].ToString();
                txtManhanvien.Text = tt.Rows[0]["idnhanvien"].ToString();
                txtTennhanvien.Text = tt.Rows[0]["hoten"].ToString();
                txtMahoadon.Text = tt.Rows[0]["mahoadon"].ToString();
                dtTrasanbong.Text = DateTime.Now.ToString();
                int day = DateTime.Now.Subtract(DateTime.Parse(dtThuesanbong.Text)).Days;
                if (DateTime.Now.Subtract(DateTime.Parse(dtThuesanbong.Text)).Hours > 1) day++;
                lblTongtien.Text = (day * int.Parse(txtSoluonguoi.Text) * float.Parse(txtGiathuesanbong.Text)).ToString() + "đ";
                btnHuythuesan.Enabled = btnDoisan.Enabled = btnTrasan.Enabled = true;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvThuesanbong.DataSource = busThuesanbong.getListThuesanbong(0);
            tkTensanbong.Focus();
            btnHuythuesan.Enabled = btnDoisan.Enabled = btnTrasan.Enabled = false;
            txtMasanbong.Text = "";
            txtTensanbong.Text = "";
            txtKhuvuc.Text = "";
            txtLoaisanbong.Text = "";
            txtGiathuesanbong.Text = "";
            txtHotenkhachhang.Text = "";
            txtSoCMND.Text = "";
            txtSoluonguoi.Text = "";
            dtThuesanbong.Text = "";
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            txtMahoadon.Text = "";
            dtTrasanbong.Text = "";
            lblTongtien.Text = "";
        }

        private void btnDoisan_Click(object sender, EventArgs e)
        {
            mahoadondoi.MAHOADON = long.Parse(txtMahoadon.Text);
            frmDoisanbong dp = new frmDoisanbong();
            dp.Show();
        }

        private void btnTrasan_Click(object sender, EventArgs e)
        {
            bussanbong.updateTinhtrangSanbong(long.Parse(txtMasanbong.Text), 2);
            busThuesanbong.traSanbong(long.Parse(txtMahoadon.Text), nhanvien.ID);
            busThuesanbong.taoHoadon(long.Parse(txtMahoadon.Text));
            frmInhoadon inhd = new frmInhoadon();
            inhd.Show();

            dgvThuesanbong.DataSource = busThuesanbong.getListThuesanbong(0);
            tkTensanbong.Focus();
            btnHuythuesan.Enabled = btnDoisan.Enabled = btnTrasan.Enabled = false;
            txtMasanbong.Text = "";
            txtTensanbong.Text = "";
            txtKhuvuc.Text = "";
            txtLoaisanbong.Text = "";
            txtGiathuesanbong.Text = "";
            txtHotenkhachhang.Text = "";
            txtSoCMND.Text = "";
            txtSoluonguoi.Text = "";
            dtThuesanbong.Text = "";
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            txtMahoadon.Text = "";
            dtTrasanbong.Text = "";
            lblTongtien.Text = "";
        }

        private void frmDanhsachthuesanbong_Load(object sender, EventArgs e)
        {
            dgvThuesanbong.DataSource = busThuesanbong.getListThuesanbong(0);
            tkTensanbong.Focus();
            btnHuythuesan.Enabled = btnDoisan.Enabled = btnTrasan.Enabled = false;
            txtMasanbong.Text = "";
            txtTensanbong.Text = "";
            txtKhuvuc.Text = "";
            txtLoaisanbong.Text = "";
            txtGiathuesanbong.Text = "";
            txtHotenkhachhang.Text = "";
            txtSoCMND.Text = "";
            txtSoluonguoi.Text = "";
            dtThuesanbong.Text = "";
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            txtMahoadon.Text = "";
            dtTrasanbong.Text = "";
            lblTongtien.Text = "";
        }
    }
}
