using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bai1_57131345 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCong_Click(object sender, EventArgs e)
    {
        double a, b, kq;
        a = double.Parse(txtA.Text);
        b = Convert.ToDouble(txtB.Text);
        kq = a + b;
        txtKetQua.Text = kq.ToString();
    }

    protected void btnTru_Click(object sender, EventArgs e)
    {
        double a, b, kq;
        a = double.Parse(txtA.Text);
        b = Convert.ToDouble(txtB.Text);
        kq = a - b;
       txtKetQua.Text = kq.ToString();
    }


    protected void btnNhan_Click(object sender, EventArgs e)
    {
        double a, b, kq;
        a = double.Parse(txtA.Text);
        b = Convert.ToDouble(txtB.Text);
        kq = a * b;
        txtKetQua.Text = kq.ToString();
    }


    protected void btnChia_Click(object sender, EventArgs e)
    {
        double a, b, kq;
        a = double.Parse(txtA.Text);
        b = Convert.ToDouble(txtB.Text);
        kq = a / b;
       txtKetQua.Text = kq.ToString();
    }


    protected void btnLamLai_Click(object sender, EventArgs e)
    {

        txtA.Text = "";
        txtB.Text = "";
        txtKetQua.Text = "";
    }
}