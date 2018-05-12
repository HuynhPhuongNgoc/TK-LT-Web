<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bai4_57131345.aspx.cs" Inherits="Bai4_57131345" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 389px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            width: 326px;
        }
        .auto-style4 {
            height: 26px;
            width: 326px;
        }
        .auto-style5 {
            width: 155px;
        }
        .auto-style6 {
            height: 26px;
            width: 155px;
        }
        .auto-style7 {
            margin-right: 67px;
        }
        .auto-style8 {
            width: 112px;
        }
        .auto-style9 {
            height: 26px;
            width: 112px;
        }
        .auto-style10 {
            width: 155px;
            height: 84px;
        }
        .auto-style11 {
            width: 326px;
            height: 84px;
        }
        .auto-style12 {
            width: 112px;
            height: 84px;
        }
        .auto-style13 {
            height: 84px;
        }
        .auto-style14 {
            width: 100%;
            height: 132px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="THÔNG TIN TIN TỨC "></asp:Label>
        <br />
        <table class="auto-style14">
            <tr>
                <td class="auto-style10">Mã tin tức</td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtmtt" runat="server" Width="181px"></asp:TextBox>
                </td>
                <td class="auto-style12">Tiêu đề</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txttd" runat="server" Height="48px" Width="381px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Ngày đăng</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtnd" runat="server" CssClass="auto-style7" Width="181px"></asp:TextBox>
                </td>
                <td class="auto-style8">Ảnh minh họa</td>
                <td>
                    <asp:FileUpload ID="f1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Loại tin tức</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="d1" runat="server" Height="16px" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style9">
                    <asp:Button ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click1" Width="88px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnSua" runat="server" OnClick="btnSua_Click1" Text="Sửa" Width="83px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnXoa" runat="server" OnClick="btnXoa_Click1" Text="Xóa" Width="107px" />
                </td>
            </tr>
        </table>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="DANH SÁCH TIN TỨC HIỆN CÓ"></asp:Label>
        <br />
        <asp:GridView ID="g1" runat="server" Width="484px">
        </asp:GridView>
        <br />
        <asp:Label ID="lbltb" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
