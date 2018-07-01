using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using QuanLyDoanVien.DTO;
namespace QuanLyDoanVien.DAL
{
    public class DBConnect
    {
        public static string strConn = "Data Source=NGOCNGOCKUTE;Initial Catalog=QuanLyDoanVien;user=sa;pwd=sa";
        public static SqlConnection conn = new SqlConnection(strConn);
        /*public static SqlDataAdapter adapter;*/
        /*public static SqlCommandBuilder builder;
        public static Thread threadHelper;*/
       
       
        /*public DBConnect()
        {
            Connect();
        }*/
       public static SqlConnection getConnection()
        {
            conn = new SqlConnection(strConn);
            return conn;
        }
        /*public void Connect()
        {
            try
            {
                getConnection().Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.ToString());
            }
        }*/
        public DataTable GetData(string strSQL)
        {
            DataTable ds = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(strSQL, strConn);
            adap.Fill(ds);
            return ds;
        }
       /*public static DataTable FillData(string command)
        {
            if (command.Trim().Length < 0)
                throw new Exception("Command text is empty");
            SqlDataAdapter _ad = new SqlDataAdapter(command, getConnection());
            DataTable dt = new DataTable();
            if (getConnection().State == ConnectionState.Closed)
                getConnection().Open();
            _ad.Fill(dt);

            adapter = _ad;
            if (threadHelper != null && threadHelper.IsAlive)
            {
                threadHelper.Abort();
            }
            threadHelper = new Thread(new ThreadStart(Do_Work));
            threadHelper.Start();
            return dt;
        }*/

       /* public static void Do_Work()
        {
            builder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
        }*/

        /*public static int UpdateData(DataTable dt)
        {
            if (adapter == null)
                throw new Exception("Parameter adapter is null");
            return adapter.Update(dt);
        }*/
    }

    /*public class ChiDoanDAL : DBConnect
    {
        public static DataTable FillData()
        {
            return FillData("SELECT * ChiDoan");
        }

        public static int UpdateData(DataTable dt)
        {
            return DBConnect.UpdateData(dt);
        }
    }*/
    public class TTDoanVienDAL : DBConnect
    {
        public DataTable DoanVienTN_DS()
        {
            return GetData("DoanVienTN_DS");
        }
        public void themTTDoanVien(string MaDV, string HoDV, string TenDV,string NgaySinh, byte GioiTinh, string QueQuan, string Email, string SDT, string DanToc, string TonGiao, string NgayVaoDOoan, string ChooHienNay, string MaChiDoan)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DoanVienTN_Them", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MaDV;
            cmd.Parameters.Add("@HoDV", SqlDbType.NVarChar).Value = HoDV;
            cmd.Parameters.Add("@TenDV", SqlDbType.NVarChar).Value = TenDV;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = NgaySinh;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = GioiTinh;
            cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar).Value = QueQuan;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
            cmd.Parameters.Add("@DanToc", SqlDbType.NVarChar).Value = DanToc;
            cmd.Parameters.Add("@TonGiao", SqlDbType.NVarChar).Value = TonGiao;
            cmd.Parameters.Add("@NgayVaoDoan", SqlDbType.Date).Value = NgayVaoDOoan;
            cmd.Parameters.Add("@ChooHienNay", SqlDbType.NVarChar).Value = ChooHienNay;
            cmd.Parameters.Add("@MaChiDoan", SqlDbType.VarChar).Value = MaChiDoan;

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void xoaTTDoanVien(string MaDV)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("DoanVienTN_Xoa", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MaDV;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void suaTTDoanVien(string MaDV, string HoDV,string TenDV, string NgaySinh, byte GioiTinh, string QueQuan, string Email, string SDT, string DanToc, string TonGiao, string NgayVaoDOoan, string ChooHienNay, string MaChiDoan)
        
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DoanVienTN_Sua", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MaDV;
            cmd.Parameters.Add("@HoDV", SqlDbType.NVarChar).Value = HoDV;
            cmd.Parameters.Add("@TenDV", SqlDbType.NVarChar).Value = TenDV;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = NgaySinh;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = GioiTinh;
            cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar).Value = QueQuan;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
            cmd.Parameters.Add("@DanToc", SqlDbType.NVarChar).Value = DanToc;
            cmd.Parameters.Add("@TonGiao", SqlDbType.NVarChar).Value = TonGiao;
            cmd.Parameters.Add("@NgayVaoDoan", SqlDbType.Date).Value = NgayVaoDOoan;
            cmd.Parameters.Add("@ChooHienNay", SqlDbType.NVarChar).Value = ChooHienNay;
            cmd.Parameters.Add("@MaChiDoan", SqlDbType.VarChar).Value = MaChiDoan;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
       /* public static DataTable DanhSachTimKiem(TTDoanVienDTO TT)
        {
            SqlConnection Conn = DBConnect.getConnection();
            Conn.Open();
            SqlCommand cmd = new SqlCommand("Tim_DV", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenDV", SqlDbType.NVarChar).Value = TT.TenDV;
            cmd.Parameters.Add("@MaChiDoan", SqlDbType.Decimal).Value = TT.MaChiDoan;
       
            DataTable ds = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = cmd;
            adap.Fill(ds);
            return ds;
        }*/
    }
    public class HoatDongPTDAL : DBConnect
    {
        public DataTable HoatDongPT_DS()
        {
            return GetData("HoatDongPT_DS");
        }
        public void themHDPT(string MaHDPT, string NgayBD, string NgayKT, string NDHD, string DiaDiem, string MDV)
        {
          
            conn.Open();
            SqlCommand cmd = new SqlCommand("HoatDongPT_Them", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHDPT", SqlDbType.VarChar).Value = MaHDPT;
            cmd.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = NgayBD;
            cmd.Parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = NgayKT;
            cmd.Parameters.Add("@NoiDungHD", SqlDbType.NVarChar).Value = NDHD;
            cmd.Parameters.Add("@DiaDiem", SqlDbType.NVarChar).Value = DiaDiem;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MDV;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void xoaHDPT(string MaHDPT)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("HoatDongPT_Xoa", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHDPT", SqlDbType.VarChar).Value = MaHDPT;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void suaHDPT(string MaHDPT, string NgayBD, string NgayKT, string NDHD, string DiaDiem, string MDV)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("HoatDongPT_Sua", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHDPT", SqlDbType.VarChar).Value = MaHDPT;
            cmd.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = NgayBD;
            cmd.Parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = NgayKT;
            cmd.Parameters.Add("@NoiDungHD", SqlDbType.NVarChar).Value = NDHD;
            cmd.Parameters.Add("@DiaDiem", SqlDbType.NVarChar).Value = DiaDiem;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MDV;
            cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

    public class DoanPhiDAL : DBConnect
    {
        public DataTable DoanPhi_DS()
        {
            return GetData("DoanPhi_DS");
        }
        public void themDoanPhi(string Madp, string Ngay, decimal SoTien, string ndDP, string MDV)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("DoanPhi_Them", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDoanPhi", SqlDbType.VarChar).Value = Madp;
            cmd.Parameters.Add("@Ngay", SqlDbType.Date).Value = Ngay;
            cmd.Parameters.Add("@SoTien", SqlDbType.Decimal).Value = SoTien;
            cmd.Parameters.Add("@NoiDungDP", SqlDbType.NVarChar).Value = ndDP;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MDV;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void xoaDoanPhi(string madp)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("DoanPhi_Xoa", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDoanPhi", SqlDbType.VarChar).Value = madp;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void suaDoanPhi(string Madp, string Ngay, decimal SoTien, string ndDP, string MDV)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DoanPhi_Sua", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDoanPhi", SqlDbType.VarChar).Value = Madp;
            cmd.Parameters.Add("@Ngay", SqlDbType.Date).Value = Ngay;
            cmd.Parameters.Add("@SoTien", SqlDbType.Decimal).Value = SoTien;
            cmd.Parameters.Add("@NoiDungDP", SqlDbType.NVarChar).Value = ndDP;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MDV;
            cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
        public class KhenThuongDAL : DBConnect
        {
            public DataTable KhenThuong_DS()
            {
                return GetData("KhenThuong_DS");
            }
            public void themKT(string Makt, string Ngaykt, string ndKT, string MDV)
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("KhenThuong_Them", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKhenThuong", SqlDbType.VarChar).Value = Makt;
                cmd.Parameters.Add("@NgayKhenThuong", SqlDbType.Date).Value = Ngaykt;
                cmd.Parameters.Add("@NoiDungKT", SqlDbType.NVarChar).Value = ndKT;
                cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MDV;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            public void xoaKT(string makt)
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("KhenThuong_Xoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKhenThuong", SqlDbType.VarChar).Value = makt;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            public void suaKT(string Makt, string Ngaykt, string ndKT, string MDV)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("KhenThuong_Sua", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKhenThuong", SqlDbType.VarChar).Value = Makt;
                cmd.Parameters.Add("@NgayKhenThuong", SqlDbType.Date).Value = Ngaykt;
                cmd.Parameters.Add("@NoiDungKT", SqlDbType.NVarChar).Value = ndKT;
                cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MDV;

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    public class KyLuatDAL : DBConnect
    {
        public DataTable KyLuat_DS()
        {
            return GetData("KyLuat_DS");
        }
        public void themKL(string Makl, string Ngaykl, string ndKl, string MDV)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("KyLuat_Them", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaKyLuat", SqlDbType.VarChar).Value = Makl;
            cmd.Parameters.Add("@NgayKyLuat", SqlDbType.Date).Value = Ngaykl;
            cmd.Parameters.Add("@NoiDungKL", SqlDbType.NVarChar).Value = ndKl;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MDV;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void xoaKL(string makl)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("KyLuat_Xoa", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaKyLuat", SqlDbType.VarChar).Value = makl;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void suaKL(string Makl, string Ngaykl, string ndKl, string MDV)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("KyLuat_Sua", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaKyLuat", SqlDbType.VarChar).Value = Makl;
            cmd.Parameters.Add("@NgayKyLuat", SqlDbType.Date).Value = Ngaykl;
            cmd.Parameters.Add("@NoiDungKL", SqlDbType.NVarChar).Value = ndKl;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MDV;

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    public class TinTucDAL : DBConnect
    {
        public DataTable TinTuc_DS()
        {
            return GetData("TinTuc_DS");
        }
        public void themTinTuc(string matt, string tentt, string ndtt, DateTime tgd, string nd)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("Tintuc_Them", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaTinTuc", SqlDbType.VarChar).Value = matt;
            cmd.Parameters.Add("@TenTinTuc", SqlDbType.NVarChar).Value = tentt;
            cmd.Parameters.Add("@NoiDungTT", SqlDbType.NVarChar).Value = ndtt;
            cmd.Parameters.Add("@ThoiGianDang", SqlDbType.DateTime).Value = tgd;
            cmd.Parameters.Add("@NguoiDang", SqlDbType.NVarChar).Value = nd;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void xoaTinTuc(string matt)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("TinTuc_Xoa", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaTinTuc", SqlDbType.VarChar).Value = matt;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void suaTinTuc(string matt, string tentt, string ndtt, DateTime tgd, string nd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("TinTuc_Sua", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaTinTuc", SqlDbType.VarChar).Value = matt;
            cmd.Parameters.Add("@TenTinTuc", SqlDbType.NVarChar).Value = tentt;
            cmd.Parameters.Add("@NoiDungTT", SqlDbType.NVarChar).Value = ndtt;
            cmd.Parameters.Add("@ThoiGianDang", SqlDbType.DateTime).Value = tgd;
            cmd.Parameters.Add("@NguoiDang", SqlDbType.NVarChar).Value = nd;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    public class  ChucVuDAL : DBConnect
    {
        public DataTable ChucVu_DS()
        {
            return GetData("ChucVu_DS");
        }
        public void themChucVu(string macv, string tencv, string nnc, string nhnk,string mdv)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("ChucVu_Them", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaChucVu", SqlDbType.VarChar).Value = macv;
            cmd.Parameters.Add("@TenChucVu", SqlDbType.NVarChar).Value = tencv;
            cmd.Parameters.Add("@NgayNhamChuc", SqlDbType.Date).Value = nnc;
            cmd.Parameters.Add("@NgayHetNhiemKy", SqlDbType.Date).Value = nhnk;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = mdv;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void xoaChucVu(string macv)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("ChucVu_Xoa", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaChucVu", SqlDbType.VarChar).Value = macv;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void suaChucVu(string macv, string tencv, string nnc, string nhnk, string mdv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("ChucVu_Sua", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaChucVu", SqlDbType.VarChar).Value = macv;
            cmd.Parameters.Add("@TenChucVu", SqlDbType.NVarChar).Value = tencv;
            cmd.Parameters.Add("@NgayNhamChuc", SqlDbType.Date).Value = nnc;
            cmd.Parameters.Add("@NgayHetNhiemKy", SqlDbType.Date).Value = nhnk;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = mdv;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    /*public class TimKiemDAL : DBConnect
    {
        public DataTable TK_DS()
        {
            return GetData("DoanVienTN_DS");
        }
        /*public void TimDV(string tdv,string mcd)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("Tim_DV", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenDV", SqlDbType.VarChar).Value = tdv;
            //cmd.Parameters.Add("@MaChiDoan", SqlDbType.NVarChar).Value = mcd;
          
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }*/
     public class LoginDAL:DBConnect
    {
        public bool CheckLogin(Login lg)
        {
            SqlConnection Conn = DBConnect.getConnection();
            conn.Open();
           
                string sql = "select * from DangNhap where TaiKhoan='" + lg.taiKhoan + "'and MatKhau ='" + lg.matKhau + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
     
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return true;
                else
                    return false;
            
            conn.Close(); 

        }
        public string CheckQuyen(Login lg)
        {

            SqlConnection Conn = DBConnect.getConnection();
            conn.Open();
            string sql = "select quyen from DangNhap where taikhoan='" + lg.taiKhoan + "'and matkhau ='" + lg.matKhau + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string quyen = (string)cmd.ExecuteScalar();
            conn.Close();
            return quyen;

        }
    }
}
