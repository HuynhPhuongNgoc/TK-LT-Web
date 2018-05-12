<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bai5_57131345.aspx.cs" Inherits="Bai5_57131345" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="TÌM CÁC SỐ NGUYÊN TỐ TỪ 1 ĐẾN N "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nhập vào 1 số nguyên dương n:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtN" runat="server" Width="171px"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnHienThi" runat="server" style="margin-left: 0px" Text="Hiển thị" Width="95px" OnClick="btnHienThi_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLamLai" runat="server" Text="Làm lại" Width="93px" OnClick="btnLamLai_Click" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Kết quả: "></asp:Label>
&nbsp;
        <asp:TextBox ID="txtKQ" runat="server" Enabled="False" Width="303px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
