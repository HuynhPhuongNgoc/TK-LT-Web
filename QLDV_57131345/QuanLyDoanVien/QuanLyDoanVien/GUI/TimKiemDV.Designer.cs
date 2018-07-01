namespace QuanLyDoanVien.GUI
{
    /*partial class frmTimKiemDV
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
            this.groupTSTK = new DevExpress.XtraEditors.GroupControl();
            this.combomcd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttdv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmdv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gridKetQua = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupTSTK)).BeginInit();
            this.groupTSTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // groupTSTK
            // 
            this.groupTSTK.Controls.Add(this.combomcd);
            this.groupTSTK.Controls.Add(this.label3);
            this.groupTSTK.Controls.Add(this.txttdv);
            this.groupTSTK.Controls.Add(this.label2);
            this.groupTSTK.Controls.Add(this.label1);
            this.groupTSTK.Controls.Add(this.txtmdv);
            this.groupTSTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTSTK.Location = new System.Drawing.Point(0, 0);
            this.groupTSTK.Name = "groupTSTK";
            this.groupTSTK.Size = new System.Drawing.Size(923, 91);
            this.groupTSTK.TabIndex = 0;
            this.groupTSTK.Text = "THAM SỐ TÌM KIẾM";
            // 
            // combomcd
            // 
            this.combomcd.FormattingEnabled = true;
            this.combomcd.Location = new System.Drawing.Point(655, 30);
            this.combomcd.Name = "combomcd";
            this.combomcd.Size = new System.Drawing.Size(121, 21);
            this.combomcd.TabIndex = 5;
            this.combomcd.Click += new System.EventHandler(this.combomcd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Chi đoàn";
            // 
            // txttdv
            // 
            this.txttdv.Location = new System.Drawing.Point(353, 28);
            this.txttdv.Name = "txttdv";
            this.txttdv.Size = new System.Drawing.Size(127, 21);
            this.txttdv.TabIndex = 3;
            this.txttdv.TextChanged += new System.EventHandler(this.txttdv_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Đoàn viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Đoàn viên";
            // 
            // txtmdv
            // 
            this.txtmdv.Location = new System.Drawing.Point(98, 28);
            this.txtmdv.Name = "txtmdv";
            this.txtmdv.Size = new System.Drawing.Size(124, 21);
            this.txtmdv.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "DANH SÁCH ĐOÀN VIÊN TÌM ĐƯỢC";
            // 
            // gridKetQua
            // 
            this.gridKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKetQua.Location = new System.Drawing.Point(45, 132);
            this.gridKetQua.Name = "gridKetQua";
            this.gridKetQua.Size = new System.Drawing.Size(803, 171);
            this.gridKetQua.TabIndex = 2;
            this.gridKetQua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridKetQua_CellClick);
            this.gridKetQua.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridKetQua_RowsAdded);
            this.gridKetQua.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gridKetQua_RowsRemoved);
            // 
            // frmTimKiemDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 348);
            this.Controls.Add(this.gridKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupTSTK);
            this.Name = "frmTimKiemDV";
            this.Text = "Tìm kiếm Đoàn viên";
            this.Load += new System.EventHandler(this.frmTimKiemDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupTSTK)).EndInit();
            this.groupTSTK.ResumeLayout(false);
            this.groupTSTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupTSTK;
        private System.Windows.Forms.ComboBox combomcd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttdv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmdv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridKetQua;
    }*/
}