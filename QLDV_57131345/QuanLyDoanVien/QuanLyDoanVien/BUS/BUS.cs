using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDoanVien.DTO;
using QuanLyDoanVien.DAL;
namespace QuanLyDoanVien.BUS
{
    public class LoginBUS
    {
        public bool CheckLogin(Login lg)
        {
            LoginDAL lgdal = new LoginDAL();
            return lgdal.CheckLogin(lg);
        }
        public string CheckQuyen(Login lg)
        {
            LoginDAL lgdal = new LoginDAL();
            return lgdal.CheckQuyen(lg);
        }
    }
}
