namespace QuanLyDoanVien.GUI
{
    partial class frmLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoad));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttb = new System.Windows.Forms.TextBox();
            this.progressChay = new System.Windows.Forms.ProgressBar();
            this.TimerProgress = new System.Windows.Forms.Timer(this.components);
            this.TimerDot = new System.Windows.Forms.Timer(this.components);
            this.lbdot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ ĐOÀN VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "LOADING";
            // 
            // txttb
            // 
            this.txttb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txttb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttb.Location = new System.Drawing.Point(615, 238);
            this.txttb.Name = "txttb";
            this.txttb.Size = new System.Drawing.Size(45, 29);
            this.txttb.TabIndex = 2;
            // 
            // progressChay
            // 
            this.progressChay.Location = new System.Drawing.Point(495, 287);
            this.progressChay.Name = "progressChay";
            this.progressChay.Size = new System.Drawing.Size(498, 45);
            this.progressChay.TabIndex = 5;
            this.progressChay.Click += new System.EventHandler(this.progressChay_Click);
            // 
            // TimerProgress
            // 
            this.TimerProgress.Interval = 10;
            this.TimerProgress.Tick += new System.EventHandler(this.TimeProgress_Tick);
            // 
            // TimerDot
            // 
            this.TimerDot.Interval = 300;
            this.TimerDot.Tick += new System.EventHandler(this.TimerDot_Tick);
            // 
            // lbdot
            // 
            this.lbdot.AutoSize = true;
            this.lbdot.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdot.Location = new System.Drawing.Point(734, 253);
            this.lbdot.Name = "lbdot";
            this.lbdot.Size = new System.Drawing.Size(21, 31);
            this.lbdot.TabIndex = 4;
            this.lbdot.Text = ".";
            // 
            // frmLoad
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.None;
            this.BackgroundImageStore = global::QuanLyDoanVien.Properties.Resources.chibi3;
            this.ClientSize = new System.Drawing.Size(1005, 469);
            this.Controls.Add(this.lbdot);
            this.Controls.Add(this.progressChay);
            this.Controls.Add(this.txttb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoad";
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.frmLoad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttb;
        private System.Windows.Forms.ProgressBar progressChay;
        private System.Windows.Forms.Timer TimerProgress;
        private System.Windows.Forms.Timer TimerDot;
        private System.Windows.Forms.Label lbdot;
    }
}