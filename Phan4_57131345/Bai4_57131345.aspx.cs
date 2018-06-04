using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Bai4_57131345 : System.Web.UI.Page
{
    String conn = "Data Source=(local);Initial Catalog=Bai4_57131345;user=sa;pwd=sa";
    string TenFile = "";
    string DuongDan = "";
        

DataTable LoaiTTDS()
    {
        SqlDataAdapter adap = new SqlDataAdapter("LoaiTT_DS", conn);
        DataTable ds = new DataTable();
        adap.Fill(ds);
        return ds;
    }
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            d1.DataSource = LoaiTTDS();
            d1.DataTextField = "TenLTT";
            d1.DataValueField = "MaLTT";
            d1.DataBind();
        }
            
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
    void ThemTT(string matt, string tieude, DateTime ngaydang, string anhmh, string maltt)
    {
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand("TinTuc_Them", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@MaTT", SqlDbType.VarChar).Value = matt;
        cmd.Parameters.Add("@TieuDe", SqlDbType.NVarChar).Value = tieude;
        cmd.Parameters.Add("@NgayDang", SqlDbType.DateTime).Value = ngaydang;
        cmd.Parameters.Add("@AnhMH", SqlDbType.NVarChar).Value = anhmh;
        cmd.Parameters.Add("@MaLTT", SqlDbType.VarChar).Value = maltt;
       
        cmd.ExecuteNonQuery();
        con.Close();
    }
    void SuaTT(string matt, string tieude, DateTime ngaydang, string anhmh, string maltt)
    {
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand("TinTuc_Sua", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@MaTT", SqlDbType.VarChar).Value = matt;
        cmd.Parameters.Add("@TieuDe", SqlDbType.NVarChar).Value = tieude;
        cmd.Parameters.Add("@NgayDang", SqlDbType.DateTime).Value = ngaydang;
        cmd.Parameters.Add("@AnhMH", SqlDbType.NVarChar).Value = anhmh;
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
            ThemTT(txtmtt.Text, txttd.Text, Convert.ToDateTime(txtnd.Text), f1.FileName, d1.SelectedValue);
            if (f1.HasFile)
            {
                TenFile = f1.FileName;
                DuongDan = Server.MapPath("~/Images/");
                f1.SaveAs(DuongDan + TenFile);
            }
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
                SuaTT(txtmtt.Text, txttd.Text, Convert.ToDateTime(txtnd.Text), f1.FileName, d1.SelectedValue);
                g1.DataSource = TinTucDS();
                g1.DataBind();
                lbltb.Text = "Sửa thành công";
                // xOA File hien tai
                DuongDan = Server.MapPath("~/Images/");
                DuongDan = DuongDan + LayTenFile(txtmtt.Text);
                if (File.Exists(DuongDan) == true)
                    File.Delete(DuongDan);
                // Them file moi vao
                if (f1.HasFile)
                {
                    TenFile = f1.FileName;
                    DuongDan = Server.MapPath("~/Images/");
                    f1.SaveAs(DuongDan + TenFile);
                }
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
        DuongDan = Server.MapPath("~/Images/");
        DuongDan = DuongDan + LayTenFile(txtmtt.Text);
        if (File.Exists(DuongDan) == true)
            File.Delete(DuongDan);
        g1.DataSource = TinTucDS();
        g1.DataBind();
        lbltb.Text = "Xóa thành công";
    }

    protected void g1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        GridViewRow row;
        row = g1.Rows[e.NewSelectedIndex];
        txtmtt.Text = Server.HtmlDecode(row.Cells[1].Text);
        txttd.Text = Server.HtmlDecode(row.Cells[2].Text);
        txtnd.Text = Server.HtmlDecode(row.Cells[3].Text);
        //txtnd.Text = Server.HtmlDecode(row.Cells[3].Text);
        //txtdg.Text = Server.HtmlDecode(row.Cells[5].Text);
        d1.SelectedValue = Server.HtmlDecode(row.Cells[5].Text);
    }

    protected void g1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
       g1.PageIndex = e.NewPageIndex;
        g1.DataBind();
        //hienThiGridView();
    }

    private string LayTenFile(String ma)
    {
        for (int i = 0; i < g1.Rows.Count; i++)
        {
            if (ma.Equals(g1.Rows[i].Cells[1].Text))
            {
                return g1.Rows[i].Cells[4].Text;
            }
        }
        return "";
    }
}