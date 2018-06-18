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
    public partial class frmHDPT : Form
    {
        HoatDongPTDAL hdptDAL = new HoatDongPTDAL();
        public frmHDPT()
        {
            InitializeComponent();
            datagridHDPT.DataSource = hdptDAL.HoatDongPT_DS();
            datagridHDPT.Columns[0].HeaderText = "Mã hoạt động phong trào";
            datagridHDPT.Columns[1].HeaderText = "Ngày bắt đầu";
            datagridHDPT.Columns[2].HeaderText = "Ngày kết thúc";
            datagridHDPT.Columns[3].HeaderText = "Nội dung hoạt động";
            datagridHDPT.Columns[4].HeaderText = "Địa điểm";
            datagridHDPT.Columns[5].HeaderText = "Mã Đoàn viên";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                hdptDAL.themHDPT(txtmahdpt.Text, txtnbd.Text, txtnkt.Text, txtndhd.Text, txtdd.Text, txtMDVhd.Text);
                datagridHDPT.DataSource = hdptDAL.HoatDongPT_DS();
                lbltb.Text = "Thêm thành công";
            }
            catch { lbltb.Text = "Thêm không thành công, cần xem lại thông tin"; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                hdptDAL.xoaHDPT(txtmahdpt.Text);
                datagridHDPT.DataSource = hdptDAL.HoatDongPT_DS();
                lbltb.Text = "Xóa thành công";
            }
            catch { lbltb.Text = "Xóa không thành công"; }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                hdptDAL.suaHDPT(txtmahdpt.Text, txtnbd.Text, txtnkt.Text, txtndhd.Text, txtdd.Text, txtMDVhd.Text);
                datagridHDPT.DataSource = hdptDAL.HoatDongPT_DS();
                lbltb.Text = "Sửa thành công";
            }
            catch { lbltb.Text = "Sửa không thành công, cần xem lại thông tin"; }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            txtmahdpt.Text = "";
            txtnbd.Text = "";
            txtnkt.Text = "";
            txtndhd.Text = "";
            txtdd.Text = "";
            txtMDVhd.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
