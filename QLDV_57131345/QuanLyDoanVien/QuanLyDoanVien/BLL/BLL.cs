using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDoanVien.DAL;
using QuanLyDoanVien.DTO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace QuanLyDoanVien.BLL
{
    /*public class BasicBLL
    {
        public DBConnect DataAccess = new DBConnect();
    }
    public class ChiDoanBLL : BasicBLL
    {
    
        public void UpdateData(DataTable dt)
        {
            try
            {
                int i = ChiDoanDAL.UpdateData(dt);
                MessageBox.Show(i + " : bản ghi cập nhật thành công");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        public DataTable FillData()
        {
            return ChiDoanDAL.FillData();
        }

    }
    public class TTDoanVienBLL : BasicBLL
    {
        public DataTable TTDoanVien_DS()
        {
            return DataAccess.GetData("DoanVienTN_DS");
        }
        public DataTable DanhSachKetQua(TTDoanVienDTO TT)
        {
          
        
             return TTDoanVienDAL.DanhSachTimKiem(TT);
        }

    }*/
}
    