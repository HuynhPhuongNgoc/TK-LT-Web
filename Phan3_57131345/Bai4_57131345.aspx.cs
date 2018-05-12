using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bai4_57131345 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btndw_Click(object sender, EventArgs e)
    {
        int n, i, kq;
        n=int.Parse(txtN.Text);
        i = 0;
        kq = 0;
        do
        {
            i++;
            kq = kq + i;

        } while (i < n);
        txtKQ.Text = kq.ToString();
    }

    protected void btnw_Click(object sender, EventArgs e)
    {
        int n, i, kq;
        n = int.Parse(txtN.Text);
        i = 0;
        kq = 0;
        while (i < n)
        {
            i++;
            kq = kq + i;
        }
        txtKQ.Text = kq.ToString();
    }

    protected void btnFor_Click(object sender, EventArgs e)
    {
        int n, i, kq;
        n = int.Parse(txtN.Text);
        kq = 0;
        for(i=1;i<=n;i++)
        {
            kq = kq + i;
        }
        txtKQ.Text = kq.ToString();
    }

    protected void btnLamLai_Click(object sender, EventArgs e)
    {
        txtN.Text = "";
        txtKQ.Text = "";
    }
}