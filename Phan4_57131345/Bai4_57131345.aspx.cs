using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bai4_57131345 : System.Web.UI.Page
{
    String conn = "Data Source=(local);Initial Catalog=Bai4_57131345;user=sa;pwd=sa";
    DataTable LoaiTTDS()
    {
        SqlDataAdapter adap = new SqlDataAdapter("LoaiTT_DS", conn);
        DataTable ds = new DataTable();
        adap.Fill(ds);
        return ds;
    }
   
    protected void Page_Load(object sender, EventArgs e)
    {
        d1.DataSource = LoaiTTDS();
        d1.DataTextField = "TenLTT";
        d1.DataValueField = "MaLTT";
        d1.DataBind();
        g1.DataSource = TinTucDS();
        g1.DataBind();
    }
    DataTable TinTucDS()
    {
        SqlDataAdapter adap = new SqlDataAdapter("TinTuc_DS", conn);
        DataTable ds = new DataTable();
        adap.Fill(ds);
        return ds;
    }
    //---------------------------
    void ThemTT(string matt, string tieude, string ngaydang, string anhmh, string maltt)
    {
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand("TinTuc_Them", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@MaTT", SqlDbType.VarChar).Value = matt;
        cmd.Parameters.Add("@TieuDe", SqlDbType.NVarChar).Value = tieude;
        cmd.Parameters.Add("@NgayDang", SqlDbType.DateTime).Value = ngaydang;
        cmd.Parameters.Add("@AnhMH", SqlDbType.VarChar).Value = anhmh;
        cmd.Parameters.Add("@MaLTT", SqlDbType.VarChar).Value = maltt;
       
        cmd.ExecuteNonQuery();
        con.Close();
    }
    void SuaTT(string matt, string tieude, string ngaydang, string anhmh, string maltt)
    {
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand("TinTuc_Sua", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@MaTT", SqlDbType.VarChar).Value = matt;
        cmd.Parameters.Add("@TieuDe", SqlDbType.NVarChar).Value = tieude;
        cmd.Parameters.Add("@NgayDang", SqlDbType.DateTime).Value = ngaydang;
        cmd.Parameters.Add("@AnhMH", SqlDbType.VarChar).Value = anhmh;
        cmd.Parameters.Add("@MaLTT", SqlDbType.VarChar).Value = maltt;
        cmd.ExecuteNonQuery();
        con.Close();
    }

    void XoaTT(string matt)
    {
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand("TinTuc_Xoa", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@MaTT", SqlDbType.VarChar).Value = matt;
        cmd.ExecuteNonQuery();
        con.Close();
    }

    
       protected void btnThem_Click1(object sender, EventArgs e)
    {
        try
        {
            ThemTT(txtmtt.Text, txttd.Text, txtnd.Text, f1.FileName, d1.SelectedValue);
            g1.DataSource = TinTucDS();
            g1.DataBind();
            lbltb.Text = "Thêm vào thành công";
        }
        catch
        {
            lbltb.Text = "Thông tin không hợp lệ, vui lòng kiểm tra lại";
        }
    }

    protected void btnSua_Click1(object sender, EventArgs e)
    {
        {
            try
            {
                SuaTT(txtmtt.Text, txttd.Text, txtnd.Text, f1.FileName, d1.SelectedValue);
                g1.DataSource = TinTucDS();
                g1.DataBind();
                lbltb.Text = "Sửa thành công";
            }
            catch
            {
                lbltb.Text = "Thông tin không hợp lệ, vui lòng kiểm tra lại";
            }
        }
    }

    protected void btnXoa_Click1(object sender, EventArgs e)
    {
        XoaTT(txtmtt.Text);
        g1.DataSource = TinTucDS();
        g1.DataBind();
    }
}