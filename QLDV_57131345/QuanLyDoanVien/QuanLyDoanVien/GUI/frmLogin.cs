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
using QuanLyDoanVien.BUS;
using QuanLyDoanVien.DTO;
using QuanLyDoanVien.GUI;
namespace QuanLyDoanVien.GUI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        LoginBUS lgbus = new LoginBUS();
      
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.taiKhoan = txttk.Text;
            lg.matKhau = txtmk.Text;
            if (txttk.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttk.Focus();
            }
            else if (txtmk.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmk.Focus();
            }
            else
            {
                if (lgbus.CheckLogin(lg))
                {
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.Quyen = lgbus.CheckQuyen(lg);
                    //fm.lblUser.Text = lg.Taikhoan;
                    fm.ShowDialog();
                }
                else
                    MessageBox.Show("Xin vui lòng kiểm tra lại tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
      
    }
}