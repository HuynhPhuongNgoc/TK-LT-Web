using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bai8_57131345 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btndk_Click(object sender, EventArgs e)
    {

        if (!IsValid)
            return;
        else
           lblthongtin.Text = "Họ tên khách hàng: " + txtht.Text + "<br>" +
                          "Mật khẩu: " + txtmk.Text + "<br>" +
                          "Thu nhập (triệu đồng): " + txttn.Text;
    }
   

    protected void KiemTraSo_ServerValidate1(object source, ServerValidateEventArgs args)
    {
        int so;
        try
        {
            so = int.Parse(txtsc.Text);
            if ((so % 2) == 0)
                args.IsValid = true; // xác nhận đúng
            else
                args.IsValid = false; // chưa xác nhận
        }
        catch
        {
            lblloi.Text = "Dữ liệu không là kiểu số. Vui lòng kiểm tra lại!";
        }
    }
}