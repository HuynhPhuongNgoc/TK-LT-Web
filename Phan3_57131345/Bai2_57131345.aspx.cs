using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bai2_57131345 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGiai_Click(object sender, EventArgs e)
    {
        double a, b, kq;
        a = double.Parse(txtA.Text);
        b = Convert.ToDouble(txtB.Text);
        if (a == 0)
            if (b == 0)
                txtKQ.Text = "Phương trình có vô số nghiệm";
            else
                txtKQ.Text = "Phương trình vô nghiệm";
        else
        {
            kq = -b / a;
            txtKQ.Text = "Phương trình có  nghiệm là x=" + kq.ToString();
        }
    }

    protected void btnLamLai_Click(object sender, EventArgs e)
    {
        txtA.Text = "";
        txtB.Text = "";
        txtKQ.Text = "";
    }
}