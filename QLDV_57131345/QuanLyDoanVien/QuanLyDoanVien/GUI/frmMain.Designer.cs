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
            this.btnHD = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimKiem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnChiDoan = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbonControl1.ApplicationIcon = global::QuanLyDoanVien.Properties.Resources.Treetog_Junior_Box_config;
            this.ribbonControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.btnChucVu,
            this.btnHD,
            this.btnTimKiem,
            this.btnChiDoan});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 20;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1005, 194);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
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
            this.btnTTDoanVien.LargeGlyph = global::QuanLyDoanVien.Properties.Resources._10207_man_student_light_skin_tone_icon;
            this.btnTTDoanVien.Name = "btnTTDoanVien";
            this.btnTTDoanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTTDoanVien_ItemClick);
            // 
            // btnHDPT
            // 
            this.btnHDPT.Caption = "Hoạt động phong trào";
            this.btnHDPT.Id = 2;
            this.btnHDPT.LargeGlyph = global::QuanLyDoanVien.Properties.Resources.community_users_icon;
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
            this.btnDoanPhi.LargeGlyph = global::QuanLyDoanVien.Properties.Resources.Money_icon1;
            this.btnDoanPhi.Name = "btnDoanPhi";
            this.btnDoanPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoanPhi_ItemClick);
            // 
            // btnKhenThuong
            // 
            this.btnKhenThuong.Caption = "Khen thưởng";
            this.btnKhenThuong.Id = 8;
            this.btnKhenThuong.LargeGlyph = global::QuanLyDoanVien.Properties.Resources.Star_icon;
            this.btnKhenThuong.Name = "btnKhenThuong";
            this.btnKhenThuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhenThuong_ItemClick);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Caption = "Tài khoản";
            this.btnTaiKhoan.Glyph = global::QuanLyDoanVien.Properties.Resources.reseller_account_template_icon;
            this.btnTaiKhoan.Id = 9;
            this.btnTaiKhoan.LargeGlyph = global::QuanLyDoanVien.Properties.Resources.reseller_account_template_icon1;
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            // 
            // btnSLPH
            // 
            this.btnSLPH.Caption = "Sao lưu/ Phục hồi";
            this.btnSLPH.Id = 10;
            this.btnSLPH.LargeGlyph = global::QuanLyDoanVien.Properties.Resources.floppy_drive_3_12_icon;
            this.btnSLPH.Name = "btnSLPH";
            // 
            // btnTinTuc
            // 
            this.btnTinTuc.Caption = "Tin Tức";
            this.btnTinTuc.Id = 11;
            this.btnTinTuc.LargeGlyph = global::QuanLyDoanVien.Properties.Resources.Tv_icon;
            this.btnTinTuc.Name = "btnTinTuc";
            this.btnTinTuc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTinTuc_ItemClick);
            // 
            // btnKyLuat
            // 
            this.btnKyLuat.Caption = "Kỷ luật";
            this.btnKyLuat.Id = 13;
            this.btnKyLuat.LargeGlyph = global::QuanLyDoanVien.Properties.Resources.prisoner_icon;
            this.btnKyLuat.Name = "btnKyLuat";
            this.btnKyLuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKyLuat_ItemClick);
            // 
            // btnChucVu
            // 
            this.btnChucVu.Caption = "Chức vụ";
            this.btnChucVu.Id = 14;
            this.btnChucVu.LargeGlyph = global::QuanLyDoanVien.Properties.Resources.chair_icon;
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChucVu_ItemClick);
            // 
            // btnHD
            // 
            this.btnHD.Caption = "Hỏi-Đáp";
            this.btnHD.Id = 17;
            this.btnHD.LargeGlyph = global::QuanLyDoanVien.Properties.Resources.App_help_index_icon;
            this.btnHD.Name = "btnHD";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Caption = "Tìm kiếm Đoàn viên";
            this.btnTimKiem.Id = 18;
            this.btnTimKiem.LargeGlyph = global::QuanLyDoanVien.Properties.Resources.search_icon;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTimKiem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup10});
            this.ribbonPage1.Image = global::QuanLyDoanVien.Properties.Resources.App_network_connection_manager_icon;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản trị hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Glyph = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.Glyph")));
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaiKhoan);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Tag = true;
            this.ribbonPageGroup1.Text = "--- *** ---";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSLPH);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "--- *** ---";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnHD);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "---***---";
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
            this.ribbonPageGroup4,
            this.ribbonPageGroup12});
            this.ribbonPage2.Image = global::QuanLyDoanVien.Properties.Resources.Folder_Add_icon;
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTTDoanVien);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "--- *** ---";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnChucVu);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "--- *** ---";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnHDPT);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "--- *** ---";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDoanPhi);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "--- *** ---";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnKhenThuong);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "--- *** ---";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnKyLuat);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "--- *** ---";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTinTuc);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "--- *** ---";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup11});
            this.ribbonPage3.Image = global::QuanLyDoanVien.Properties.Resources.SEO_icon;
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = " Tìm kiếm";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnTimKiem);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "---***---";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Image = global::QuanLyDoanVien.Properties.Resources.Balance_icon;
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Thống kê-Báo cáo";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.xtraTabbedMdiManager.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.xtraTabbedMdiManager.MdiParent = this;
            this.xtraTabbedMdiManager.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Far;
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.btnChiDoan);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.Text = "ribbonPageGroup12";
            // 
            // btnChiDoan
            // 
            this.btnChiDoan.Caption = "Chi Đoàn";
            this.btnChiDoan.Id = 19;
            this.btnChiDoan.Name = "btnChiDoan";
            this.btnChiDoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChiDoan_ItemClick);
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::QuanLyDoanVien.Properties.Resources.jgjjhjh;
            this.ClientSize = new System.Drawing.Size(1005, 595);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1364, 768);
            this.MinimumSize = new System.Drawing.Size(798, 600);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "QUẢN LÝ ĐOÀN VIÊN";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
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
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.BarButtonItem btnHD;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem btnTimKiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.BarButtonItem btnChiDoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
    }
}

