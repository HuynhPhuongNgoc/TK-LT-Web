using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bai3_57131345 : System.Web.UI.Page
{
    String conn = "Data Source=(local);Initial Catalog=Bai3_57131345;user=sa;pwd=sa";
    DataTable LoaiDTDS()
    {
        SqlDataAdapter adap = new SqlDataAdapter("LoaiDT_DS", conn);
        DataTable ds = new DataTable();
        adap.Fill(ds);
        return ds;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            d1.DataSource = LoaiDTDS();
            d1.DataTextField = "TenLDT";
            d1.DataValueField = "MaLDT";
            d1.DataBind();
        }
        g1.DataSource = DienThoaiDS();
        g1.DataBind();
    }
    DataTable DienThoaiDS()
    {
        SqlDataAdapter adap = new SqlDataAdapter("DienThoai_DS", conn);
        DataTable ds = new DataTable();
        adap.Fill(ds);
        return ds;
    }
    //---------------------------
    void ThemDT(string madt, string tendt, string anhdt, string phukien, string dongia, string maldt)
    {
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand("DienThoai_Them", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@MaDT", SqlDbType.VarChar).Value = madt;
        cmd.Parameters.Add("@TenDT", SqlDbType.NVarChar).Value = tendt;
        cmd.Parameters.Add("@AnhDT", SqlDbType.VarChar).Value = anhdt;
        cmd.Parameters.Add("@PhuKien", SqlDbType.NVarChar).Value = phukien;
        cmd.Parameters.Add("@DonGia", SqlDbType.Money).Value = dongia;
        cmd.Parameters.Add("@MaLDT", SqlDbType.VarChar).Value = maldt;
        cmd.ExecuteNonQuery();
        con.Close();
    }
    void SuaDT(string madt, string tendt, string anhdt, string phukien, string dongia, string maldt)
    {
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand("DienThoai_Sua", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@MaDT", SqlDbType.VarChar).Value = madt;
        cmd.Parameters.Add("@TenDT", SqlDbType.NVarChar).Value = tendt;
        cmd.Parameters.Add("@AnhDT", SqlDbType.VarChar).Value = anhdt;
        cmd.Parameters.Add("@PhuKien", SqlDbType.NVarChar).Value = phukien;
        cmd.Parameters.Add("@DonGia", SqlDbType.Money).Value = dongia;
        cmd.Parameters.Add("@MaLDT", SqlDbType.VarChar).Value = maldt;
        cmd.ExecuteNonQuery();
        con.Close();
    }

    void XoaDT(string madt)
    {
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand("DienThoai_Xoa", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@MaDT", SqlDbType.VarChar).Value = madt;
        cmd.ExecuteNonQuery();
        con.Close();
    }


    protected void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            ThemDT(txtmdt.Text, txttdt.Text,f1.FileName, txtpkkt.Text, txtdg.Text, d1.SelectedValue);
            g1.DataSource = DienThoaiDS();
            g1.DataBind();
            lbltb.Text = "Thêm vào thành công";
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

    protected void btnSua_Click(object sender, EventArgs e)
    {
        try
        {
            SuaDT(txtmdt.Text, txttdt.Text,f1.FileName, txtpkkt.Text, txtdg.Text,  d1.SelectedValue);
            g1.DataSource = DienThoaiDS();
            g1.DataBind();
            lbltb.Text = "Sửa thành công";
        }
        catch
        {
            lbltb.Text = "Thông tin không hợp lệ, vui lòng kiểm tra lại";
        }
    }

    protected void g1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        GridViewRow row;
        row = g1.Rows[e.NewSelectedIndex];
        txtmdt.Text = Server.HtmlDecode(row.Cells[1].Text);
        txttdt.Text = Server.HtmlDecode(row.Cells[2].Text);
        //txtMaSach.Text = Server.HtmlDecode(row.Cells[3].Text);
        txtpkkt.Text = Server.HtmlDecode(row.Cells[4].Text);
        txtdg.Text = Server.HtmlDecode(row.Cells[5].Text);
        d1.SelectedValue = Server.HtmlDecode(row.Cells[6].Text);
    }
}
