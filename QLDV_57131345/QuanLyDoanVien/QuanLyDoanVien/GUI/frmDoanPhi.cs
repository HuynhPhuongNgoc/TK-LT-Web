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
    public partial class frmDoanPhi : Form
        
    {
        DoanPhiDAL dpDAL = new DoanPhiDAL();
        public frmDoanPhi()
        {
            InitializeComponent();
            datagridDoanPhi.DataSource = dpDAL.DoanPhi_DS();
            datagridDoanPhi.Columns[0].HeaderText = "Mã đoàn phí";
            datagridDoanPhi.Columns[1].HeaderText = "Ngày";
            datagridDoanPhi.Columns[2].HeaderText = "Số tiền";
            datagridDoanPhi.Columns[3].HeaderText = "Nội dung đoàn phí";
            datagridDoanPhi.Columns[4].HeaderText = "Mã đoàn viên";
         
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dpDAL.themDoanPhi(txtmdp.Text, txtngay.Text, Convert.ToDecimal(txtsotien.Text), txtnd.Text, txtMDVdp.Text);
                datagridDoanPhi.DataSource = dpDAL.DoanPhi_DS();
                lbltb.Text = "Thêm thành công";
            }
            catch { lbltb.Text = "Thêm không thàng công, cần xem lại thông tin"; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dpDAL.xoaDoanPhi(txtmdp.Text);
                datagridDoanPhi.DataSource = dpDAL.DoanPhi_DS();
                lbltb.Text = "Xóa thành công";
            }
            catch { lbltb.Text = "Xóa không thàng công"; }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                dpDAL.suaDoanPhi(txtmdp.Text, txtngay.Text, Convert.ToDecimal(txtsotien.Text), txtnd.Text, txtMDVdp.Text);
                datagridDoanPhi.DataSource = dpDAL.DoanPhi_DS();
                lbltb.Text = "Sửa thành công";
            }
            catch { lbltb.Text = "Sửa không thàng công, cần xem lại thông tin"; }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            txtmdp.Text = "";
            txtngay.Text = "";
            txtsotien.Text = "";
            txtnd.Text = "";
            txtMDVdp.Text = "";
        }
    }
}
