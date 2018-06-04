<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bai1_57131345.aspx.cs" Inherits="Bai1_57131345" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
        .auto-style2 {
            height: 35px;
        }
        .auto-style3 {
            margin-left: 51px;
        }
        .auto-style4 {
            margin-left: 98px;
        }
        .auto-style5 {
            margin-left: 53px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1"><asp:Label runat="server" Font-Bold="False" Text="Nhập giá trị A:"></asp:Label>
                    <asp:TextBox ID="txtA" runat="server" Width="209px" CssClass="auto-style5"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Nhập giá trị B:"></asp:Label>
                    &nbsp;<asp:TextBox ID="txtB" runat="server" Height="16px" Width="208px" CssClass="auto-style3"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnCong" runat="server" OnClick="btnCong_Click" Text="Cộng" Width="96px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnTru" runat="server" OnClick="btnTru_Click" Text="Trừ" Width="109px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnNhan" runat="server" OnClick="btnNhan_Click" Text="Nhân" Width="97px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnChia" runat="server" OnClick="btnChia_Click" Text="Chia" Width="93px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnLamLai" runat="server" OnClick="btnLamLai_Click" Text="Làm lại" Width="106px" />
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
        </table>
        <asp:Label ID="Label3" runat="server" Text="Kết quả"></asp:Label>
        <asp:TextBox ID="txtKetQua" runat="server" Width="206px" Enabled="False" CssClass="auto-style4" Height="22px"></asp:TextBox>
        <br />
    
    </div>
    </form>
</body>
</html>
