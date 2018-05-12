<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bai1_57131345.aspx.cs" Inherits="Bai1_57131345" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;<asp:Label runat="server" Font-Bold="False" Text="Nhập giá trị A:"></asp:Label>
                    <asp:TextBox ID="txtA" runat="server" style="margin-left: 49px" Width="116px"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Nhập giá trị B:"></asp:Label>
                    <asp:TextBox ID="txtB" runat="server" Height="16px" style="margin-left: 48px" Width="116px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnCong" runat="server" OnClick="btnCong_Click" Text="Cộng" />
&nbsp;&nbsp;
                    <asp:Button ID="btnTru" runat="server" OnClick="btnTru_Click" Text="Trừ" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnNhan" runat="server" OnClick="btnNhan_Click" Text="Nhân" />
&nbsp;&nbsp;
                    <asp:Button ID="btnChia" runat="server" OnClick="btnChia_Click" Text="Chia" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnLamLai" runat="server" OnClick="btnLamLai_Click" Text="Làm lại" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Label ID="Label3" runat="server" Text="Kết quả"></asp:Label>
        <asp:TextBox ID="txtKetQua" runat="server" style="margin-left: 90px" Width="114px" Enabled="False"></asp:TextBox>
        <br />
    
    </div>
    </form>
</body>
</html>
