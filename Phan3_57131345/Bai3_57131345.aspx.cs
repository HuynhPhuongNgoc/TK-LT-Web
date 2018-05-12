using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bai3_57131345 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void txtGiai_Click(object sender, EventArgs e)
    {
        double a, b, c, kq;
        a = double.Parse(txtA.Text);
        b = Convert.ToDouble(txtB.Text);
        c = Convert.ToDouble(txtC.Text);
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    txtKQ.Text = ("Phương trình vô số nghiệm");
                }
                else
                {
                    txtKQ.Text = ("Phương trình vô nghiệm");
                }
            }
            else
            {
                double x = -c / b;
                txtKQ.Text = x.ToString();
            }
        }
        else
        {
            double delta = (double)(Math.Pow(b, 2) - 4 * a * c);
            if (delta > 0)
            {
                double x1 = (-b + (Math.Sqrt(delta)) / (2 * a));
                double x2 = (-b - (Math.Sqrt(delta)) / (2 * a));
                String h = ("Phương trình có 2 nghiệm x1=" + x1 + " và x2=" + x2);
                txtKQ.Text = h.ToString();
            }
            if (delta < 0)
                txtKQ.Text = ("Phương trình vô nghiệm");
            if(delta==0)
            {
                double x3=-b/(2*a);
                txtKQ.Text = x3.ToString();
            }

        }
    }

    protected void btnLamLai_Click(object sender, EventArgs e)
    {
        txtA.Text = "";
        txtB.Text = "";
        txtKQ.Text = "";
    }
}