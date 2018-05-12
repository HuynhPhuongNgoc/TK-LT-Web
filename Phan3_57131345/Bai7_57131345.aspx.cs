using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bai7_57131345 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnXn_Click(object sender, EventArgs e)
    {
        string msv, ht, ns;
        msv = txtmsv.Text;
        ht = txtht.Text;
        ns = txtns.Text;
        txtHThi.Text = "Mã sinh viên : " + msv.ToString() + "\nHọ tên: " + ht.ToString() + "\nNgày sinh: " + ns.ToString();
        if (rbtnnam.Checked == true)
        {
            txtHThi.Text += "\nGiới tính: " + rbtnnam.Text;
         }
        if (rbtnnu.Checked == true)
        {
            txtHThi.Text += "\nGiới tính: " + rbtnnu.Text;
        }
        txtHThi.Text += "\nNgành học: " + lstmh.SelectedValue.ToString() + "\nSở thích: ";
        if(cbtndl.Checked==true)
        {
            txtHThi.Text += "-" + cbtndl.Text;
        }
        if(cbtnan.Checked==true)
        {
            txtHThi.Text += "-" + cbtnan.Text;
        }
        if(cbtntt.Checked==true)
        {
            txtHThi.Text += "-" + cbtntt.Text;
        }
        if(cbtnlvk.Checked==true)
        {
            txtHThi.Text += '-' + cbtnlvk.Text;
        }
    }
}