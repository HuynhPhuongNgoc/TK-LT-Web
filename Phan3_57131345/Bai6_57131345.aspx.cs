using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bai6_57131345 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnTinh_Click(object sender, EventArgs e)
    {
        double msv, dkt, tk, tkt, dt;
        string mh, ht, xl;
        msv = double.Parse(txtMSV.Text);
        dkt = double.Parse(txtDiemKT.Text);
        tkt = double.Parse(txtTyLeKT.Text);
        dt = double.Parse(txtDiemthi.Text);
        mh = txtMonHoc.Text;
        ht = txtHoTen.Text;
        //xl = txtXepLoai.Text;
        tk = ((dkt*tkt)+(dt*(100-tkt)))/100;
        txtDIemTK.Text = tk.ToString();
        XepLoai(tk);
       txtHThi.Text="Mã sinh viên: " + msv.ToString() + "- Họ tên: " + ht.ToString() + "\nMôn Học : " + mh.ToString() +
            "\nTỷ lệ kiểm tra: " + tkt.ToString() + "\nĐiểm kiểm tra: " + dkt.ToString() + "\nĐiểm thi: " + dt.ToString() + "\nĐiểm tổng kết: " + tk.ToString() + "\nXếp loại: " + txtXepLoai.Text;
        
    }
    public void XepLoai(double tk)
    {
        if (tk < 3.5)
            txtXepLoai.Text = "Quá yếu";
        if (tk >= 3.5 && tk < 5)
            txtXepLoai.Text = "Yếu";
        if (tk >= 5 && tk < 6)
            txtXepLoai.Text = "Trung bình";
        if (tk >= 6 && tk < 7)
            txtXepLoai.Text = "Trung bình khá";
        if (tk >= 7 && tk < 8)
            txtXepLoai.Text = "Khá";
        if (tk >= 8 && tk < 9)
            txtXepLoai.Text = "Giỏi";
        if (tk >= 9 && tk <= 10)
            txtXepLoai.Text = "Xuất sắc";
        
    }

    protected void btnLamLai_Click(object sender, EventArgs e)
    {
        txtMSV.Text = "";
        txtMonHoc.Text = "";
        txtDiemKT.Text = "";
        txtDIemTK.Text = "";
        txtHoTen.Text = "";
        txtTyLeKT.Text = "";
        txtDiemthi.Text = "";
        txtXepLoai.Text = "";
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}