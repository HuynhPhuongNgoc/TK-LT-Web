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
using QuanLyDoanVien.GUI;
namespace QuanLyDoanVien.GUI
{
    public partial class frmLoad : DevExpress.XtraEditors.XtraForm
    {
        public frmLoad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLoad_Load(object sender, EventArgs e)
        {
            progressChay.Minimum = 0;
            progressChay.Maximum = 100;
            progressChay.Value = 1;
            progressChay.Step = 1;
            TimerProgress.Start();
            TimerDot.Start();
            
        }

        private void progressChay_Click(object sender, EventArgs e)
        {

        }

        private void TimeProgress_Tick(object sender, EventArgs e)
        {
            progressChay.PerformStep();
            txttb.Text = progressChay.Value.ToString() + "%";
            if (progressChay.Value == 100)
            {
                TimerProgress.Stop();
                TimerDot.Stop();
                if (progressChay.Value == 100)
                {
                    this.Hide();
                    frmLogin frm = new frmLogin();
                    frm.ShowDialog();
                    this.Close();
                }
            }
        }

        private void TimerDot_Tick(object sender, EventArgs e)
        {
            if (lbdot.Text == "")
                lbdot.Text = ".";
            else if (lbdot.Text == ".")
                lbdot.Text = "..";
            else if (lbdot.Text == "..")
                lbdot.Text = "...";
            else
                lbdot.Text = ".";
        }
    }
    }
