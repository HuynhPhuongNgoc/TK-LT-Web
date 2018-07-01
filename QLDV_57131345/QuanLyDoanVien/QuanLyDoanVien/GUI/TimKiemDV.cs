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
using QuanLyDoanVien.DTO;
using QuanLyDoanVien.BLL;
namespace QuanLyDoanVien.GUI
{
    public partial class frmTimKiemDV : DevExpress.XtraEditors.XtraForm
    {
        
       /* ChiDoanBLL cd = new ChiDoanBLL();
        TTDoanVienBLL tt = new TTDoanVienBLL();
        TTDoanVienDTO TTDoanVien = new TTDoanVienDTO();
        public frmTimKiemDV()
        {
            InitializeComponent();
        }

        private void gridKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmdv.Text = gridKetQua.CurrentRow.Cells[1].Value.ToString();
            Clipboard.SetText(txtmdv.Text.Trim());
        }

        private void gridKetQua_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < gridKetQua.Rows.Count; i++)
            {
                gridKetQua.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void gridKetQua_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < gridKetQua.Rows.Count; i++)
            {
                gridKetQua.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void txttdv_TextChanged(object sender, EventArgs e)
        {
            HienThiKQ();
        }
        private void HienThiKQ()
        {
            TTDoanVien.TenDV = txttdv.Text;
           
            TTDoanVien.MaChiDoan = combomcd.SelectedValue.ToString();
   
            gridKetQua.DataSource = tt.DanhSachKetQua(TTDoanVien);
        }

        private void frmTimKiemDV_Load(object sender, EventArgs e)
        {
            combomcd.DataSource = cd.FillData();
            combomcd.ValueMember = "MaChiDoan";
            combomcd.DisplayMember = "TenChiDoan";
            combomcd.AutoCompleteSource = AutoCompleteSource.ListItems;
            combomcd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            gridKetQua.DataSource = tt.TTDoanVien_DS();
        }

        private void combomcd_Click(object sender, EventArgs e)
        {
            HienThiKQ();
        }*/
    }
}