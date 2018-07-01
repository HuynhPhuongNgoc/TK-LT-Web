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
using QuanLyDoanVien.BLL;
namespace QuanLyDoanVien.GUI
{
    public partial class frmChiDoan : DevExpress.XtraEditors.XtraForm
    {
      /*  DataTable dt;
        ChiDoanBLL cd;
        public frmChiDoan()
        {
            InitializeComponent();
            cd = new ChiDoanBLL();
        }

        private void gridChiDoan_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < gridChiDoan.Rows.Count - 1; i++)
            {
                gridChiDoan.Rows[i].Cells[0].Value = (i + 1).ToString();
               
            }
        }

        private void gridChiDoan_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
            for (int i = 0; i < gridChiDoan.Rows.Count - 1; i++)
            {
                gridChiDoan.Rows[i].Cells[0].Value = (i + 1).ToString();
                
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            cd.UpdateData(dt);
        }

        private void frmChiDoan_Load(object sender, EventArgs e)
        {
            dt = cd.FillData();
            gridChiDoan.DataSource = dt;
        }*/
    }
}