using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QuanLyDoanVien.DAL;
namespace QuanLyDoanVien.GUI
{
    public partial class frmTimKiemDoanVien : DevExpress.XtraEditors.XtraForm
    {
        TimKiemDAL tkDAL = new TimKiemDAL();
        public frmTimKiemDoanVien()
        {
            InitializeComponent();
            datagridTKDV.DataSource = tkDAL.TK_DS();
            datagridTKDV.Columns[0].HeaderText = "Mã Đoàn Viên";
            datagridTKDV.Columns[1].HeaderText = "Họ Đoàn Viên";
            datagridTKDV.Columns[2].HeaderText = "Tên Đoàn Viên";
            datagridTKDV.Columns[3].HeaderText = "Ngày sinh";
            datagridTKDV.Columns[4].HeaderText = "Giới tính";
            datagridTKDV.Columns[5].HeaderText = "Quê quán";
            datagridTKDV.Columns[6].HeaderText = "Email";
            datagridTKDV.Columns[7].HeaderText = "Số điện thoại";
            datagridTKDV.Columns[8].HeaderText = "Dân tộc";
            datagridTKDV.Columns[9].HeaderText = "Tôn giáo";
            datagridTKDV.Columns[10].HeaderText = "Ngày vào Đoàn";
            datagridTKDV.Columns[11].HeaderText = "Chỗ ở hiện nay";
            datagridTKDV.Columns[12].HeaderText = "Mã chi Đoàn";
        }


        private void btnTKDV_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFindValue.Text))
            {
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.Text = "Nhập tên nhân viên cần tìm";
            }
            else
            {
                tkDAL.TimDV(txtFindValue.Text);
                datagridTKDV.DataSource = tkDAL.TK_DS();
            }
        }
    }
}