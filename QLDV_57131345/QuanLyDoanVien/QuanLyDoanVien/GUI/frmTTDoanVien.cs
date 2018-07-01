using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDoanVien.DAL;
namespace QuanLyDoanVien.GUI
{
    public partial class frmTTDoanVien : Form
    {
        TTDoanVienDAL ttdvDAL = new TTDoanVienDAL();
        public frmTTDoanVien()
        {
            InitializeComponent();
            datagridTTDoanVien.DataSource = ttdvDAL.DoanVienTN_DS();
            datagridTTDoanVien.Columns[0].HeaderText = "Mã Đoàn Viên";
            datagridTTDoanVien.Columns[1].HeaderText = "Họ Đoàn Viên";
            datagridTTDoanVien.Columns[2].HeaderText = "Tên Đoàn Viên";
            datagridTTDoanVien.Columns[3].HeaderText = "Ngày sinh";
            datagridTTDoanVien.Columns[4].HeaderText = "Giới tính";
            datagridTTDoanVien.Columns[5].HeaderText = "Quê quán";
            datagridTTDoanVien.Columns[6].HeaderText = "Email";
            datagridTTDoanVien.Columns[7].HeaderText = "Số điện thoại";
            datagridTTDoanVien.Columns[8].HeaderText = "Dân tộc";
            datagridTTDoanVien.Columns[9].HeaderText = "Tôn giáo";
            datagridTTDoanVien.Columns[10].HeaderText = "Ngày vào Đoàn";
            datagridTTDoanVien.Columns[11].HeaderText = "Chỗ ở hiện nay";
            datagridTTDoanVien.Columns[12].HeaderText = "Mã chi Đoàn";
        }

        private void label14_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            byte GioiTinh= 1;
            if (rdnnam.Checked == true) GioiTinh = 1;
            if (rdnnu.Checked == true) GioiTinh = 0;
            try
            {
                ttdvDAL.themTTDoanVien(txtMDV.Text, txthDV.Text, txttDV.Text,txtns.Text,GioiTinh, txtqq.Text, txtemail.Text, txtsdt.Text, txtdt.Text, txttg.Text, txtnvd.Text, txtcohn.Text, lbltb.Text);
                datagridTTDoanVien.DataSource = ttdvDAL.DoanVienTN_DS();
                lbltbtt.Text = "Thêm thành công";
            }
            catch { lbltbtt.Text = "Thêm không thành công, cần xem lại thông tin"; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ttdvDAL.xoaTTDoanVien(txtMDV.Text);
                datagridTTDoanVien.DataSource = ttdvDAL.DoanVienTN_DS();
                lbltbtt.Text = "Xóa thành công";
            }
            catch { lbltbtt.Text = "Xóa không thành công"; }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            byte GioiTinh = 1;
            if (rdnnam.Checked == true) GioiTinh = 1;
            if (rdnnu.Checked == true) GioiTinh = 0;
            try
            {
                ttdvDAL.suaTTDoanVien(txtMDV.Text, txthDV.Text,txttDV.Text, txtns.Text, GioiTinh, txtqq.Text, txtemail.Text, txtsdt.Text, txtdt.Text, txttg.Text, txtnvd.Text, txtcohn.Text, lbltb.Text);
                datagridTTDoanVien.DataSource = ttdvDAL.DoanVienTN_DS();
                lbltbtt.Text = "Sửa thành công";
            }
            catch { lbltbtt.Text = "Sửa không thàng cônh, cần xem lại thông tin"; }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            txtMDV.Text = "";
            txthDV.Text = "";
            txttDV.Text = "";
            txtns.Text = "";
            //txtgt.Text = "";
            txtqq.Text = "";
            txtemail.Text = "";
            txtsdt.Text = "";
            txtdt.Text = "";
            txttg.Text = "";
            txtnvd.Text = "";
            txtcohn.Text = "";
            lbltb.Text = "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
