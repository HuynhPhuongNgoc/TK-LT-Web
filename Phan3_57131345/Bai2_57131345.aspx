<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bai2_57131345.aspx.cs" Inherits="Bai2_57131345" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 97px">
    
        <asp:Label ID="Label1" runat="server" Text="Giải và biện luận phương trình bậc 1 (ax+b=0)"></asp:Label>
        <br />
        <asp:TextBox ID="txtA" runat="server" style="margin-left: 3px" Width="90px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="x"></asp:Label>
&nbsp;+&nbsp;
        <asp:TextBox ID="txtB" runat="server" Width="97px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="=0"></asp:Label>
        <br />
        <asp:Button ID="btnGiai" runat="server" Height="25px" OnClick="btnGiai_Click" style="margin-left: 112px; margin-top: 0px" Text="Giải" Width="96px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLamLai" runat="server" OnClick="btnLamLai_Click" Text="Làm lại" Width="109px" />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Kết quả:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtKQ" runat="server" Enabled="False" Width="275px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
