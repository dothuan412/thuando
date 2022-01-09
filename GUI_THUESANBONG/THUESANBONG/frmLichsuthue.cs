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
    public partial class frmLichsuthue : Form
    {
        BUS_Thuesanbong busThuesanbong = new BUS_Thuesanbong();
        BUS_Sanbong bussanbong = new BUS_Sanbong();
        public frmLichsuthue()
        {
            InitializeComponent();
            dgvThuesanbong.DataSource = busThuesanbong.getListThuesanbong(1);
            tkTensanbong.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvThuephong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (tkTensanbong.Text.Equals("") && tkTenkhachhang.Text.Equals("")) dgvThuesanbong.DataSource = busThuesanbong.getListThuesanbong(1);
            else if (!tkTensanbong.Text.Equals("") && tkTenkhachhang.Text.Equals("")) dgvThuesanbong.DataSource = busThuesanbong.timkiemBytensanbong(tkTensanbong.Text, 1);
            else if (tkTensanbong.Text.Equals("") && !tkTenkhachhang.Text.Equals("")) dgvThuesanbong.DataSource = busThuesanbong.timkiemBytenkhachhang(tkTenkhachhang.Text, 1);
            else if (!tkTensanbong.Text.Equals("") && !tkTenkhachhang.Text.Equals("")) dgvThuesanbong.DataSource = busThuesanbong.timkiem(tkTensanbong.Text, tkTenkhachhang.Text, 1);
        }

        private void frmLichsuthue_Load(object sender, EventArgs e)
        {

        }

        private void txtHotenkhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvThuesanbong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvThuesanbong.CurrentRow.Index;
            if ((i <= dgvThuesanbong.Rows.Count - 2) && dgvThuesanbong.Rows.Count > 1)
            {
                DataTable tt = busThuesanbong.getThongtinthuesanbong((long)dgvThuesanbong[0, i].Value);
                txtMasanbong.Text = tt.Rows[0]["masanbong"].ToString();
                txtTensanbong.Text = tt.Rows[0]["tensanbong"].ToString();
                txtKhuvuc.Text = tt.Rows[0]["khuvuc"].ToString();
                txtLoaisanbong.Text = tt.Rows[0]["loaisanbong"].ToString();
                txtGiathuesanbong.Text = tt.Rows[0]["dongia"].ToString();
                txtHotenkhachhang.Text = tt.Rows[0]["tenkhachhang"].ToString();
                txtSoCMND.Text = tt.Rows[0]["soCMND"].ToString();
                txtSoluonguoi.Text = tt.Rows[0]["songuoi"].ToString();
                txtThuesanbong.Text = tt.Rows[0]["ngaythue"].ToString();
                txtManhanvien.Text = tt.Rows[0]["idnhanvien"].ToString();
                txtTennhanvien.Text = tt.Rows[0]["hoten"].ToString();
                txtMahoadon.Text = tt.Rows[0]["mahoadon"].ToString();
                txtTrasanbong.Text = tt.Rows[0]["ngaytra"].ToString();
                lblTongtien.Text = tt.Rows[0]["tongtien"].ToString() + "đ";
            }
        }

        private void tkTensanbong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
