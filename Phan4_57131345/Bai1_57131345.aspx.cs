using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bai1_57131345 : System.Web.UI.Page
{
    String conn = "Data Source=(local);Initial Catalog=Bai1_57131345;user=sa;pwd=sa";
    DataTable DienThoaiDS()
    {
        SqlDataAdapter adap = new SqlDataAdapter("DienThoai_DS", conn);
        DataTable ds = new DataTable();
        adap.Fill(ds);
        return ds;
    }
    void XoaDT(string maDT)
    {
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand("DienThoai_Xoa", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@MaDT", SqlDbType.VarChar).Value = maDT;
        cmd.ExecuteNonQuery();
        con.Close();
    }
    void ThemDT(string maDT, string tenDT, string dongia, string phukienkemtheo, string loaidienthoai)
    {
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand("DienThoai_Them", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@MaDT", SqlDbType.VarChar).Value = maDT;
        cmd.Parameters.Add("@TenDT", SqlDbType.VarChar).Value = tenDT;
        cmd.Parameters.Add("@Dongia", SqlDbType.Money).Value = dongia;
        cmd.Parameters.Add("@Phukienkemtheo", SqlDbType.NVarChar).Value = phukienkemtheo;
        cmd.Parameters.Add("@Loaidienthoai", SqlDbType.NVarChar).Value = loaidienthoai;
        cmd.ExecuteNonQuery();
        con.Close();
    }
    void SuaDT(string maDT, string tenDT, string dongia, string phukienkemtheo, string loaidienthoai)
    {
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand("DienThoai_Sua", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@MaDT", SqlDbType.VarChar).Value = maDT;
        cmd.Parameters.Add("@TenDT", SqlDbType.VarChar).Value = tenDT;
        cmd.Parameters.Add("@Dongia", SqlDbType.Money).Value = dongia;
        cmd.Parameters.Add("@Phukienkemtheo", SqlDbType.NVarChar).Value = phukienkemtheo;
        cmd.Parameters.Add("@Loaidienthoai", SqlDbType.NVarChar).Value = loaidienthoai;
        cmd.ExecuteNonQuery();
        con.Close();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        g1.DataSource = DienThoaiDS();
        g1.DataBind();
    }

  


    protected void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            ThemDT(txtmdt.Text, txttdt.Text, txtdg.Text, txtpkkt.Text, txtldt.Text);
            g1.DataSource = DienThoaiDS();
            g1.DataBind();
            lbltb.Text = "Thêm vào thành công";
        }
        catch
        {
            lbltb.Text = "Thông tin không hợp lệ, vui lòng kiểm tra lại";
        }
    }

    protected void btnSua_Click(object sender, EventArgs e)
    {
        try
        {
            SuaDT(txtmdt.Text, txttdt.Text, txtdg.Text, txtpkkt.Text, txtldt.Text);
            g1.DataSource = DienThoaiDS();
            g1.DataBind();
            lbltb.Text = "Sửa thành công";
        }
        catch
        {
            lbltb.Text = "Thông tin không hợp lệ, vui lòng kiểm tra lại";
        }
    }

    protected void btnXoa_Click(object sender, EventArgs e)
    {
        XoaDT(txtmdt.Text);
        g1.DataSource = DienThoaiDS();
        g1.DataBind();
    }
}