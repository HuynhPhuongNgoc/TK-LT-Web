<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bai7_57131345.aspx.cs" Inherits="Bai7_57131345" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 262px;
            margin-left: 320px;
        }
        .auto-style2 {
            width: 100%;
            height: 88px;
        }
        .auto-style3 {
            height: 28px;
        }
        .auto-style4 {
            height: 28px;
            width: 115px;
        }
        .auto-style5 {
            width: 115px;
            height: 26px;
        }
        .auto-style6 {
            height: 28px;
            width: 257px;
        }
        .auto-style7 {
            width: 257px;
            height: 26px;
        }
        .auto-style8 {
            width: 115px;
            height: 30px;
        }
        .auto-style9 {
            width: 257px;
            height: 30px;
        }
        .auto-style10 {
            height: 30px;
        }
        .auto-style11 {
            width: 115px;
            height: 44px;
        }
        .auto-style12 {
            width: 257px;
            height: 44px;
        }
        .auto-style13 {
            height: 44px;
        }
        .auto-style14 {
            height: 28px;
            width: 240px;
        }
        .auto-style15 {
            width: 240px;
            height: 26px;
        }
        .auto-style16 {
            width: 240px;
            height: 30px;
        }
        .auto-style17 {
            width: 240px;
            height: 44px;
        }
        .auto-style18 {
            margin-left: 125px;
        }
        .auto-style19 {
            margin-left: 28px;
        }
        .auto-style20 {
            height: 26px;
        }
        .auto-style21 {
            margin-left: 440px;
            margin-top: 0px;
        }
    </style>
</head>
<body style="height: 294px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" ForeColor="Blue" Text="ĐĂNG KÝ THÔNG TIN CÁ NHÂN"></asp:Label>
    
    </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="Mã sinh viên : "></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtmsv" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label6" runat="server" Text="Họ tên : "></asp:Label>
                    <asp:TextBox ID="txtht" runat="server" CssClass="auto-style19" Width="162px"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label3" runat="server" Text="Ngày sinh : "></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtns" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label7" runat="server" Text="Giới tính : "></asp:Label>
&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rbtnnam" runat="server" Text="Nam" />
&nbsp;&nbsp;
                    <asp:RadioButton ID="rbtnnu" runat="server" Text="Nữ" />
                </td>
                <td class="auto-style20"></td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label4" runat="server" Text="Ngày học : "></asp:Label>
                </td>
                <td class="auto-style16">
                    <asp:DropDownList ID="lstmh" runat="server" Height="20px" Width="212px">
                        <asp:ListItem>Công nghệ thông tin</asp:ListItem>
                        <asp:ListItem>Công nghệ chế biến</asp:ListItem>
                        <asp:ListItem>Công nghệ thực phẩm</asp:ListItem>
                        <asp:ListItem>Kế toán - Tài chính</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style9"></td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <asp:Label ID="Label5" runat="server" Text="Sở thích : "></asp:Label>
                </td>
                <td class="auto-style17">
                    <asp:CheckBox ID="cbtndl" runat="server" Text="Du lịch" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="cbtnan" runat="server" Text="Âm nhạc" />
                </td>
                <td class="auto-style12">
                    <asp:CheckBox ID="cbtntt" runat="server" Text="Thể Thao" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="cbtnlvk" runat="server" Text="Lĩnh vực khác" />
                </td>
                <td class="auto-style13">&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="btnXn" runat="server" CssClass="auto-style18" OnClick="btnXn_Click" Text="Xác nhận" Width="84px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Text="Ảnh "></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" CssClass="auto-style21" Height="72px" Width="117px" ImageUrl="~/hinh-anh-pikachu-de-thuong-kute-nhat-1.jpg" />
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtHThi" runat="server" ForeColor="Red" Height="90px" OnTextChanged="TextBox1_TextChanged" TextMode="MultiLine" Width="400px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
