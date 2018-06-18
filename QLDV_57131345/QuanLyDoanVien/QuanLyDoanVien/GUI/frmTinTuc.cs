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
    public partial class frmTinTuc : Form
    {
        TinTucDAL ttDAL = new TinTucDAL();
        public frmTinTuc()
        {
          
            InitializeComponent();
            datagridTinTuc.DataSource = ttDAL.TinTuc_DS();
            datagridTinTuc.Columns[0].HeaderText = "Mã tin tức";
            datagridTinTuc.Columns[1].HeaderText = "Tên tin tức";
            datagridTinTuc.Columns[2].HeaderText = "Nội dung tin tức";
            datagridTinTuc.Columns[3].HeaderText = "Thời gian đăng";
            datagridTinTuc.Columns[4].HeaderText = "Người đăng";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ttDAL.themTinTuc(txtmtt.Text, txtttt.Text, txtndtt.Text, Convert.ToDateTime(txttgd.Text),txtnd.Text);
                datagridTinTuc.DataSource = ttDAL.TinTuc_DS();
                lbltb.Text = "Thêm thành công";
            }
            catch { lbltb.Text = "Thêm không thành công, cần xem lại thông tin"; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ttDAL.xoaTinTuc(txtmtt.Text);
                datagridTinTuc.DataSource = ttDAL.TinTuc_DS();
                lbltb.Text = "Xóa thành công";
            }
            catch { lbltb.Text = "Xóa không thành công"; }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ttDAL.suaTinTuc(txtmtt.Text, txtttt.Text, txtndtt.Text, Convert.ToDateTime(txttgd.Text), txtnd.Text);
                datagridTinTuc.DataSource = ttDAL.TinTuc_DS();
                lbltb.Text = "Sửa thành công";
            }
            catch { lbltb.Text = "Sửa không thành công, cần xem lại thông tin"; }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            txtmtt.Text = "";
            txtttt.Text = "";
            txtndtt.Text = "";
            txttgd.Text = "";
            txtnd.Text = "";
        }
    }
}
