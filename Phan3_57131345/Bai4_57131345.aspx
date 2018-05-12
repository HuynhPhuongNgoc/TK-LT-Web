<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bai4_57131345.aspx.cs" Inherits="Bai4_57131345" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 198px;
            margin-left: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Size="Medium" Font-Strikeout="False" Text="VÍ DỤ VÒNG LẶP"></asp:Label>
    
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nhập vào một số nguyên n:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtN" runat="server" Width="144px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btndw" runat="server" style="margin-left: 94px" Text="Do... While" Width="82px" OnClick="btndw_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnw" runat="server" Height="25px" style="margin-left: 29px" Text="While" Width="78px" OnClick="btnw_Click" />
        <asp:Button ID="btnFor" runat="server" style="margin-left: 55px" Text="For" Width="76px" OnClick="btnFor_Click" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Kết quả tính tổng số nguyên từ 1 đến n; "></asp:Label>
        <asp:TextBox ID="txtKQ" runat="server" style="margin-left: 45px" Width="146px" ReadOnly="True"></asp:TextBox>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLamLai" runat="server" OnClick="btnLamLai_Click" Text="Làm lại" Width="81px" />
    
    </div>
    </form>
    <p>
        1</p>
</body>
</html>
