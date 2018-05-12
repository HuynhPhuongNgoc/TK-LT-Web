<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bai3_57131345.aspx.cs" Inherits="Bai3_57131345" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Giải và biện luận phương trình bậc 2"></asp:Label>
        (ax2+bx+c=0)<br />
        <br />
        <asp:TextBox ID="txtA" runat="server" Width="79px"></asp:TextBox>
&nbsp;<asp:Label ID="Label2" runat="server" Text="x2  +"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtB" runat="server" Height="16px" Width="86px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="x +  "></asp:Label>
&nbsp;
        <asp:TextBox ID="txtC" runat="server" Width="83px"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label4" runat="server" Text="= 0"></asp:Label>
        <br />
        <br />
        <asp:Button ID="txtGiai" runat="server" style="margin-left: 103px" Text="Giải" Width="90px" OnClick="txtGiai_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLamLai" runat="server" style="margin-left: 8px" Text="Làm Lại" Width="100px" OnClick="btnLamLai_Click" />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Kết quả:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtKQ" runat="server" Width="371px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
