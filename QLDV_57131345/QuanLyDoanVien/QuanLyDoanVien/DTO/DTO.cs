using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoanVien.DTO
{

    /*public class TTDoanVienDTO
    {
         private string dMaDV, dHoDV, dTenDV, dNgaySinh, dGioiTinh, dQueQuan, dEmail, dSDT,dDanToc,dTonGiao,dNgayVaoDoan,dChooHienNay,dMaChiDoan;

         public string MaDV
         {
             get { return dMaDV; }
             set { dMaDV = value; }
         }
         public string HoDV
         {
             get { return dHoDV; }
             set { dHoDV = value; }
         }

         public string TenDV
         {
             get { return dTenDV; }
             set { dTenDV = value; }
         }

         public string NgaySinh
         {
             get { return dNgaySinh; }
             set { dNgaySinh= value; }
         }

         public string GioiTinh
         {
             get { return dGioiTinh; }
             set { dGioiTinh = value; }
         }

         public string QueQuan
         {
             get { return dQueQuan; }
             set { dQueQuan = value; }
         }

         public string Email
         {
             get { return dEmail; }
             set { dEmail = value; }
         }

         public string SDT
         {
             get { return dSDT; }
             set { dSDT = value; }
         }
         public string DanToc
         {
             get { return dDanToc; }
             set { dDanToc = value; }
         }
         public string TonGiao
         {
             get { return dTonGiao; }
             set { dTonGiao = value; }
         }
         public string NgayVaoDoan
         {
             get { return dNgayVaoDoan; }
             set { dChooHienNay = value; }
         }
         public string ChooHienNay
         { 
             get { return dChooHienNay; }
             set { dChooHienNay = value; }
         }
         public string MaChiDoan
         {
             get { return dMaChiDoan; }
             set { dMaChiDoan = value; }
         }
     }*/
        public class Login
        {
            private string TaiKhoan, MatKhau, Quyen;
            public string taiKhoan
            {
                get { return TaiKhoan; }
                set { TaiKhoan = value; }
            }
            public string matKhau
            {
                get { return MatKhau; }
                set { MatKhau = value; }
            }
            public string quyen
            {
                get { return Quyen; }
                set { Quyen = value; }
            }
            public Login() { TaiKhoan = ""; MatKhau = ""; Quyen = ""; }
        }
    }
