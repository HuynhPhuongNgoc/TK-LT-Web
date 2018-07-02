using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using QuanLyDoanVien.GUI;
namespace QuanLyDoanVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string quyen;
        public string Quyen { get { return quyen; } set { quyen = value; } }

        public frmMain()
        {
            InitializeComponent();
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
        }
        public frmMain(string quyen)
        {
            InitializeComponent();
            this.quyen = quyen;
        }

        private Form KiemTraTonTai(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)    // Neu Form duoc truyen vao da duoc mo
                {
                    return f;
                }
            }
            return null;
        }

        private void closeallforms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != Parent)
                {
                    frm.Close();
                }
            }
        }

        private void btnTTDoanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTTDoanVien));
            if (frm != null)
                frm.Activate();
            else
            {
                frmTTDoanVien f = new frmTTDoanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmChucVu));
            if (frm != null)
                frm.Activate();
            else
            {
                frmChucVu f = new frmChucVu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHDPT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmHDPT));
            if (frm != null)
                frm.Activate();
            else
            {
                frmHDPT f = new frmHDPT();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDoanPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmDoanPhi));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDoanPhi f = new frmDoanPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKhenThuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmKT));
            if (frm != null)
                frm.Activate();
            else
            {
                frmKT f = new frmKT();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKyLuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmKyLuat));
            if (frm != null)
                frm.Activate();
            else
            {
                frmKyLuat f = new frmKyLuat();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTinTuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTinTuc));
            if (frm != null)
                frm.Activate();
            else
            {
                frmTinTuc f = new frmTinTuc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            //tabForm.TabPages.Clear();
        }


        private void btnChiDoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmChiDoan));
            if (frm != null)
                frm.Activate();
            else
            {
                frmChiDoan f = new frmChiDoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void btnDX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnThoat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
        public void PhanQuyenCNAdmin()
        {
            frmLogin frm1 = new frmLogin();
            frm1.Hide();
            frmMain fm = new frmMain();
            ribDN.Visible = false;
            fm.ShowDialog();

        }
        public void PhanQuyenCNMember()
        {

            //if (MessageBox.Show("RẤT TIẾC!TÀI KHOẢN CỦA BẠN KHÔNG PHẢI ADMIN. VUI LÒNG KHÔNG XÂM NHẬP HỆ THỐNG!!", "PROBLEM!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           // {
                //this.Close();
                frmLogin frm = new frmLogin();
            frm.Hide();
            frmMain fm = new frmMain();
            ribDN.Visible = false;
            ribbonPageQL.Visible = false;
            ribbonPageTK.Visible = false;
            ribbonPageTKBC.Visible = false;
            ribBKRS.Visible = false;
            fm.ShowDialog();
           // }
        }
        public void PhanQuyen()
        {
            if (Quyen == "admin")
                PhanQuyenCNAdmin();
            else if (Quyen == "member")
                PhanQuyenCNMember();
           
        }

        private void btnTKDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTimKiemDoanVien));
            if (frm != null)
                frm.Activate();
            else
            {
                frmTimKiemDoanVien f = new frmTimKiemDoanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://tintuc.tinhdoankhanhhoa.org.vn/");
        }

        private void btnHelp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/DoanKhoaCNTT.DHNT/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = "Date: " + System.DateTime.Now.ToShortDateString();
            lblTime.Text = "Time: " + System.DateTime.Now.ToLongTimeString();
        }

    }
}
