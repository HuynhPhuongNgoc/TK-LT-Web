<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bai8_57131345.aspx.cs" Inherits="Bai8_57131345" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 376px;
        }
        .auto-style2 {
            width: 136px;
        }
        .auto-style3 {
            width: 136px;
            height: 30px;
        }
        .auto-style4 {
            height: 30px;
        }
        .auto-style5 {
            width: 285px;
        }
        .auto-style6 {
            height: 30px;
            width: 285px;
        }
        .auto-style7 {
            width: 136px;
            height: 5px;
        }
        .auto-style8 {
            height: 5px;
            width: 285px;
        }
        .auto-style9 {
            height: 5px;
        }
        .auto-style10 {
            width: 136px;
            height: 45px;
        }
        .auto-style11 {
            width: 285px;
            height: 45px;
        }
        .auto-style12 {
            height: 45px;
        }
        .auto-style13 {
            margin-right: 2px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Text="Khách hàng đăng ký"></asp:Label>
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Họ tên khách hàng"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtht" runat="server" Width="265px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>
                    <asp:RequiredFieldValidator ID="rqkh" runat="server" ErrorMessage="Chưa nhập họ tên khách hàng" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Mật khẩu"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtmk" runat="server" Width="261px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="rqmk" runat="server" ErrorMessage="Chưa nhập mật khẩu" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Mật khẩu xác nhận lại"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtxnmk" runat="server" Width="257px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rqxnmk" runat="server" ErrorMessage="Mật khẩu nhập lại không giống nhau" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label5" runat="server" Text="Thu nhập (triệu đồng)"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txttn" runat="server" Width="256px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rqtn" runat="server" ErrorMessage="Thu nhập từ 1 đến 100 triệu đồng" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="Địa chỉ email"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtdcmail" runat="server" Width="253px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rqmail" runat="server" ErrorMessage="Địa chỉ email không hợp lệ" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="Label7" runat="server" Text="Số chẵn bạn thích"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtsc" runat="server" Width="250px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rqsochan" runat="server" ErrorMessage="Phải nhập số chẵn" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style12">
                    <asp:RequiredFieldValidator ID="rqso" runat="server" ErrorMessage="Phải nhập số" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style6"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="btndk" runat="server" OnClick="btndk_Click" Text="Đăng ký" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <p>
            <asp:TextBox ID="txtHienThi" runat="server" CssClass="auto-style13" Height="89px" Width="686px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
