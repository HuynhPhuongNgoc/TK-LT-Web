<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bai6_57131345.aspx.cs" Inherits="Bai6_57131345" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
        }
        .auto-style3 {
            width: 259px;
        }
        .auto-style4 {
            width: 100%;
            height: 118px;
        }
        .auto-style5 {
            width: 150px;
            height: 24px;
        }
        .auto-style6 {
            width: 259px;
            height: 24px;
        }
        .auto-style8 {
            height: 24px;
            width: 509px;
        }
        .auto-style9 {
            width: 66px;
        }
        .auto-style10 {
            width: 66px;
            height: 24px;
        }
        .auto-style11 {
            margin-left: 20px;
        }
        .auto-style12 {
            width: 509px;
        }
    </style>
</head>
<body style="height: 398px">
    <form id="form1" runat="server">
    <div aria-hidden="False">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="NHẬP THÔNG TIN HỌC TẬP"></asp:Label>
        <br />
        <table class="auto-style4">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Mã sinh viên"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtMSV" runat="server" Width="199px"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="Label5" runat="server" Text="Họ tên"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtHoTen" runat="server" Height="16px" Width="216px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Môn học"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtMonHoc" runat="server" Width="199px"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="Label6" runat="server" Text="Tỷ lệ KT"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtTyLeKT" runat="server" Width="216px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Điểm kiểm tra"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtDiemKT" runat="server" Width="199px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style9">
                    <asp:Label ID="Label7" runat="server" Text="Điểm thi"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtDiemthi" runat="server" Width="216px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnTinh" runat="server" OnClick="btnTinh_Click" Text="Tính" Width="96px" />
                    <asp:Button ID="btnLamLai" runat="server" CssClass="auto-style11" Text="Làm lại" Width="90px" OnClick="btnLamLai_Click" />
                </td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Điểm tổng kết</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtDIemTK" runat="server" Enabled="False" Width="199px"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:Label ID="Label8" runat="server" Text="Xếp Loại"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtXepLoai" runat="server" Enabled="False" Width="216px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
        <p>
            <asp:TextBox ID="txtHThi" runat="server" Height="128px" OnTextChanged="TextBox1_TextChanged" TextMode="MultiLine" Width="488px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
