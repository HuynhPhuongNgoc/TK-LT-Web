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
            /*string[] lines = new string[2];
            lines = File.ReadAllLines("CurrentUser.txt");
            AccountBLL accBLL = new AccountBLL();
            lblCurrentUser.Text = accBLL.LayTenHT(lines[0], lines[1]);
            SkinHelper.InitSkinPopupMenu(SkinsLink);*/
        }

        private void btnTimKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTimKiemDV));
            if (frm != null)
                frm.Activate();
            else
            {
                frmTimKiemDV f = new frmTimKiemDV();
                f.MdiParent = this;
                f.Show();
            }
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
    }
}
