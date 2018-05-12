using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bai5_57131345 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnHienThi_Click(object sender, EventArgs e)
    {
        int n, i;
        string kq;
        n = int.Parse(txtN.Text);
        if (n>0)
        {
            txtKQ.Text = "1";
        }
        for (i = 2; i < n; i++)
        
            if (SoNguyenTo(i)==1)
            {
                txtKQ.Text += " -> " + i.ToString();
            }
          
        
    }
    public int SoNguyenTo(int n)
    {
        int kt = 1;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) kt = 0;
        if (kt == 1) return 1;
        else return 0;
    }

    protected void btnLamLai_Click(object sender, EventArgs e)
    {
        txtN.Text = "";
        txtKQ.Text = "";
    }
}