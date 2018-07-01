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
    public partial class frmChucVu : Form
    {
        ChucVuDAL cvDAL = new ChucVuDAL();
        public frmChucVu()
        {
       
            InitializeComponent();
            datagridChucVu.DataSource = cvDAL.ChucVu_DS();
            datagridChucVu.Columns[0].HeaderText = "Mã chức vụ";
            datagridChucVu.Columns[1].HeaderText = "Tên chức vụ";
            datagridChucVu.Columns[2].HeaderText = "Ngày nhậm chức";
            datagridChucVu.Columns[3].HeaderText = "Ngày hết nhiệm kì";
            datagridChucVu.Columns[4].HeaderText = "Mã đoàn viên";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                cvDAL.themChucVu(txtmcv.Text, txttcv.Text, txtnnc.Text, txtnhnk.Text, txtMDVcv.Text);
                datagridChucVu.DataSource = cvDAL.ChucVu_DS();
                lbltb.Text = "Thêm thành công";
            }
            catch { lbltb.Text = "Thêm không thàng công, cần xem lại thông tin"; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cvDAL.xoaChucVu(txtmcv.Text);
                datagridChucVu.DataSource = cvDAL.ChucVu_DS();
                lbltb.Text = "Xóa thành công";
            }
            catch { lbltb.Text = "Xóa không thàng công"; }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                cvDAL.suaChucVu(txtmcv.Text, txttcv.Text, txtnnc.Text, txtnhnk.Text, txtMDVcv.Text);
                datagridChucVu.DataSource = cvDAL.ChucVu_DS();
                lbltb.Text = "Sửa thành công";
            }
            catch { lbltb.Text = "Sửa không thành công, cần xem lại thông tin"; }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            txtmcv.Text = "";
            txttcv.Text = "";
            txtnnc.Text = "";
            txtnhnk.Text = "";
            txtMDVcv.Text = "";
        }
    }
}
