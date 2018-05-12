<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bai1_57131345.aspx.cs" Inherits="Bai1_57131345" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 481px;
            width: 1021px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 224px;
        }
        .auto-style4 {
            width: 224px;
        }
        .auto-style5 {
            width: 90%;
        }
        .auto-style6 {
            margin-left: 0px;
        }
        .auto-style7 {
            height: 23px;
            width: 248px;
        }
        .auto-style8 {
            width: 248px;
        }
        .auto-style9 {
            margin-left: 231px;
        }
        .auto-style10 {
            margin-left: 44px;
        }
        .auto-style11 {
            margin-left: 19px;
        }
    </style>
</head>
<body style="height: 454px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" ForeColor="#3333FF" Text="DANH SÁCH ĐIỆN THOẠI HIỆN CÓ"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="g1" runat="server" Width="501px">
        </asp:GridView>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" ForeColor="Blue" Text="CẬP NHẬT THÔNG TIN ĐIỆN THOẠI"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <table class="auto-style5">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Mã điện thoại"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtmdt" runat="server" Width="251px"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="Tên điện thoại"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txttdt" runat="server" CssClass="auto-style6" Width="252px"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Text="Đơn giá"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtdg" runat="server" Width="252px"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label6" runat="server" Text="Phụ kiện kèm theo"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtpkkt" runat="server" Width="252px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Loại điện thoại</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtldt" runat="server" Width="251px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnThem" runat="server" CssClass="auto-style9" OnClick="btnThem_Click" Text="Thêm" Width="75px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSua" runat="server" CssClass="auto-style11" OnClick="btnSua_Click" Text="Sửa" Width="76px" />
&nbsp;&nbsp;
        <asp:Button ID="btnXoa" runat="server" CssClass="auto-style10" OnClick="btnXoa_Click" Text="Xóa" Width="83px" />
        <br />
        <br />
        <br />
        <asp:Label ID="lbltb" runat="server"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
