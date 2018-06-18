namespace QuanLyDoanVien
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.btnTTDoanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnHDPT = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoanPhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhenThuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnSLPH = new DevExpress.XtraBars.BarButtonItem();
            this.btnTinTuc = new DevExpress.XtraBars.BarButtonItem();
            this.btnKyLuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnTTDoanVien,
            this.btnHDPT,
            this.barButtonItem2,
            this.btnDoanPhi,
            this.btnKhenThuong,
            this.btnTaiKhoan,
            this.btnSLPH,
            this.btnTinTuc,
            this.btnKyLuat,
            this.btnChucVu});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(1005, 167);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbonControl1;
            // 
            // btnTTDoanVien
            // 
            this.btnTTDoanVien.Caption = "Thông tin Đoàn viên";
            this.btnTTDoanVien.Id = 1;
            this.btnTTDoanVien.LargeGlyph = global::QuanLyDoanVien.Properties.Resources.Doan_TNCSHCM_Quang_Ngai;
            this.btnTTDoanVien.Name = "btnTTDoanVien";
            this.btnTTDoanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTTDoanVien_ItemClick);
            // 
            // btnHDPT
            // 
            this.btnHDPT.Caption = "Hoạt động phong trào";
            this.btnHDPT.Id = 2;
            this.btnHDPT.Name = "btnHDPT";
            this.btnHDPT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHDPT_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnDoanPhi
            // 
            this.btnDoanPhi.Caption = "Đoàn phí";
            this.btnDoanPhi.Id = 7;
            this.btnDoanPhi.Name = "btnDoanPhi";
            this.btnDoanPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoanPhi_ItemClick);
            // 
            // btnKhenThuong
            // 
            this.btnKhenThuong.Caption = "Khen thưởng";
            this.btnKhenThuong.Id = 8;
            this.btnKhenThuong.Name = "btnKhenThuong";
            this.btnKhenThuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhenThuong_ItemClick);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Caption = "Tài khoản";
            this.btnTaiKhoan.Glyph = global::QuanLyDoanVien.Properties.Resources.icons8_protect_512;
            this.btnTaiKhoan.Id = 9;
            this.btnTaiKhoan.LargeGlyph = global::QuanLyDoanVien.Properties.Resources.icons8_protect_512;
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            // 
            // btnSLPH
            // 
            this.btnSLPH.Caption = "Sao lưu/ Phục hồi";
            this.btnSLPH.Id = 10;
            this.btnSLPH.LargeGlyph = global::QuanLyDoanVien.Properties.Resources.icons8_save_64;
            this.btnSLPH.Name = "btnSLPH";
            // 
            // btnTinTuc
            // 
            this.btnTinTuc.Caption = "Tin Tức";
            this.btnTinTuc.Id = 11;
            this.btnTinTuc.Name = "btnTinTuc";
            this.btnTinTuc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTinTuc_ItemClick);
            // 
            // btnKyLuat
            // 
            this.btnKyLuat.Caption = "Kỷ luật";
            this.btnKyLuat.Id = 13;
            this.btnKyLuat.Name = "btnKyLuat";
            this.btnKyLuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKyLuat_ItemClick);
            // 
            // btnChucVu
            // 
            this.btnChucVu.Caption = "Chức vụ";
            this.btnChucVu.Id = 14;
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChucVu_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Image = global::QuanLyDoanVien.Properties.Resources.icons8_staff_filled_50;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản trị hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Glyph = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.Glyph")));
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaiKhoan);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Tag = true;
            this.ribbonPageGroup1.Text = "*********";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSLPH);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "*********";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup9,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTTDoanVien);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "*********";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnChucVu);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "*********";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnHDPT);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "*********";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDoanPhi);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "*********";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnKhenThuong);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "*********";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnKyLuat);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "*********";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTinTuc);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "*********";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Báo cáo - Tìm kiếm";
            // 
            // frmMain
            // 
            this.ActiveGlowColor = System.Drawing.Color.White;
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::QuanLyDoanVien.Properties.Resources._73585fe55cba3a5;
            this.ClientSize = new System.Drawing.Size(1005, 517);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản Lý Đoàn Viên";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnTTDoanVien;
        private DevExpress.XtraBars.BarButtonItem btnHDPT;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnDoanPhi;
        private DevExpress.XtraBars.BarButtonItem btnKhenThuong;
        private DevExpress.XtraBars.BarButtonItem btnTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnSLPH;
        private DevExpress.XtraBars.BarButtonItem btnTinTuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btnKyLuat;
        private DevExpress.XtraBars.BarButtonItem btnChucVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
    }
}

