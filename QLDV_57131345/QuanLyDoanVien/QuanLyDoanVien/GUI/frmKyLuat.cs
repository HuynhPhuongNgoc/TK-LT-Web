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
    public partial class frmKyLuat : Form
    {
        KyLuatDAL klDAL = new KyLuatDAL();
        public frmKyLuat()
        {
            InitializeComponent();
            datagridKyLuat.DataSource = klDAL.KyLuat_DS();
            datagridKyLuat.Columns[0].HeaderText = "Mã kỷ luật";
            datagridKyLuat.Columns[1].HeaderText = "Ngày kỷ luật";
            datagridKyLuat.Columns[2].HeaderText = "Nội dung kỷ luật";
            datagridKyLuat.Columns[3].HeaderText = "Mã Đoàn viên";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                klDAL.themKL(txtmkl.Text, txtnkl.Text, txtndkl.Text, txtMDVkl.Text);
                datagridKyLuat.DataSource = klDAL.KyLuat_DS();
                lbltb.Text = "Thêm thành công";
            }
            catch { lbltb.Text = "Thêm không thành công, cần xem lại thông tin"; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                klDAL.xoaKL(txtmkl.Text);
                datagridKyLuat.DataSource = klDAL.KyLuat_DS();
                lbltb.Text = "Xóa thành công";
            }
            catch { lbltb.Text = "Xóa không thành công"; }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                klDAL.suaKL(txtmkl.Text, txtnkl.Text, txtndkl.Text, txtMDVkl.Text);
                datagridKyLuat.DataSource = klDAL.KyLuat_DS();
                lbltb.Text = "Sửa thành công";
            }
            catch { lbltb.Text = "Sửa không thành công, cần xem lại thông tin"; }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            txtmkl.Text = "";
            txtnkl.Text = "";
            txtndkl.Text = "";
            txtMDVkl.Text = "";
        }
    }
}
