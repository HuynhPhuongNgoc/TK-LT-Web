using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Bai2_57131345 : System.Web.UI.Page
{
    String conn = "Data Source=(local);Initial Catalog=Bai2_57131345;user=sa;pwd=sa";
    DataTable LoaiSachDS()
    {
        SqlDataAdapter adap = new SqlDataAdapter("LoaiSach_DS", conn);
        DataTable ds = new DataTable();
        adap.Fill(ds);
        return ds;
    }
    //void HienThiGridView
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            d1.DataSource = LoaiSachDS();
            d1.DataTextField = "TenLS";
            d1.DataValueField = "MaLS";
            d1.DataBind();
        }
        g1.DataSource = SachDS();
        g1.DataBind();
    }

    DataTable SachDS()
    {
        SqlDataAdapter adap = new SqlDataAdapter("Sach_DS", conn);
        DataTable ds = new DataTable();
        adap.Fill(ds);
        return ds;
    }
 //---------------------------
    void ThemSach(string masach, string tensach, string anhsach, string tacgia, string nhaxb, string mals)
    {
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand("Sach_Them", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@MaSach", SqlDbType.VarChar).Value = masach;
        cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = tensach;
        cmd.Parameters.Add("@AnhSach", SqlDbType.VarChar).Value = anhsach;
        cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar).Value = tacgia;
        cmd.Parameters.Add("@NhaXB", SqlDbType.NVarChar).Value = nhaxb;
        cmd.Parameters.Add("@MaLS", SqlDbType.VarChar).Value = mals;
        cmd.ExecuteNonQuery();
        con.Close();
    }
    void SuaSach(string masach, string tensach, string anhsach, string tacgia, string nhaxb, string mals)
    {
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand("Sach_Sua", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@MaSach", SqlDbType.VarChar).Value = masach;
        cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = tensach;
        cmd.Parameters.Add("@AnhSach", SqlDbType.VarChar).Value = anhsach;
        cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar).Value = tacgia;
        cmd.Parameters.Add("@NhaXB", SqlDbType.NVarChar).Value = nhaxb;
        cmd.Parameters.Add("@MaLS", SqlDbType.VarChar).Value = mals;
        cmd.ExecuteNonQuery();
        con.Close();
    }
  
    void XoaSach(string masach)
    {
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand("Sach_Xoa", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@MaSach", SqlDbType.VarChar).Value = masach;
        cmd.ExecuteNonQuery();
        con.Close();
    }
    //--------------------kkk
    protected void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            ThemSach(txtms.Text, txtts.Text,f1.FileName, txttg.Text, txtnxb.Text,d1.SelectedValue);
            g1.DataSource = SachDS();
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
                SuaSach(txtms.Text, txtts.Text, f1.FileName, txttg.Text, txtnxb.Text, d1.SelectedValue);
                g1.DataSource = SachDS();
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
        XoaSach(txtms.Text);
        g1.DataSource = SachDS();
        g1.DataBind();
    }


    protected void g1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        GridViewRow row;
        row = g1.Rows[e.NewSelectedIndex];
        txtms.Text = Server.HtmlDecode(row.Cells[1].Text);
        txtts.Text = Server.HtmlDecode(row.Cells[2].Text);
        //txtMaSach.Text = Server.HtmlDecode(row.Cells[3].Text);
        txttg.Text = Server.HtmlDecode(row.Cells[4].Text);
        txtnxb.Text = Server.HtmlDecode(row.Cells[5].Text);
        d1.SelectedValue = Server.HtmlDecode(row.Cells[6].Text);
    }
}