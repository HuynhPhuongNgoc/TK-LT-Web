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
    public partial class frmKT : Form
    {
       KhenThuongDAL ktDAL = new KhenThuongDAL();
        public frmKT()
        {
            InitializeComponent();
            datagridKhenThuong.DataSource = ktDAL.KhenThuong_DS();
            datagridKhenThuong.Columns[0].HeaderText = "Mã khen thưởng";
            datagridKhenThuong.Columns[1].HeaderText = "Ngày khen thưởng";
            datagridKhenThuong.Columns[2].HeaderText = "Nội dung khen thưởng";
            datagridKhenThuong.Columns[3].HeaderText = "Mã Đoàn viên";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ktDAL.themKT(txtmkt.Text, txtnkt.Text, txtndkt.Text, txtMDVkt.Text);
                datagridKhenThuong.DataSource = ktDAL.KhenThuong_DS();
                lbltb.Text = "Thêm thành công";
            }
            catch { lbltb.Text = "Thêm không thàng công, cần xem lại thông tin"; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ktDAL.xoaKT(txtmkt.Text);
                datagridKhenThuong.DataSource = ktDAL.KhenThuong_DS();
                lbltb.Text = "Xóa thành công";
            }
            catch { lbltb.Text = "Xóa không thàng công"; }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ktDAL.suaKT(txtmkt.Text, txtnkt.Text, txtndkt.Text, txtMDVkt.Text);
                datagridKhenThuong.DataSource = ktDAL.KhenThuong_DS();
                lbltb.Text = "Sửa thành công";
            }
            catch { lbltb.Text = "Sửa không thàng công, cần xem lại thông tin"; }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            txtmkt.Text = "";
            txtnkt.Text = "";
            txtndkt.Text = "";
            txtMDVkt.Text = "";
        }
    }
}
