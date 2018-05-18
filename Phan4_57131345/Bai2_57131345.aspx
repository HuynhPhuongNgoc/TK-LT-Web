<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bai2_57131345.aspx.cs" Inherits="Bai2_57131345" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 478px;
        }
        .auto-style2 {
            width: 100%;
            height: 101px;
        }
        .auto-style3 {
            width: 174px;
            height: 26px;
        }
        .auto-style4 {
            width: 174px;
            height: 33px;
        }
        .auto-style5 {
            height: 33px;
        }
        .auto-style6 {
            width: 429px;
            height: 26px;
        }
        .auto-style7 {
            height: 33px;
            width: 429px;
        }
        .auto-style8 {
            width: 174px;
            height: 23px;
        }
        .auto-style9 {
            width: 429px;
            height: 23px;
        }
        .auto-style10 {
            height: 23px;
        }
        .auto-style11 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" ForeColor="Blue" Text="CÁC SÁCH HIỆN CÓ"></asp:Label>
        <br />
        <asp:GridView ID="g1" runat="server" Width="573px" AutoGenerateSelectButton="True" OnSelectedIndexChanging="g1_SelectedIndexChanging">
        </asp:GridView>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" ForeColor="Blue" Text="CẬP NHẬT THÔNG TIN SÁCH"></asp:Label>
        <br />
        <table class="auto-style2">
            <tr>
                <td class="auto-style8">Mã&nbsp; sách</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtms" runat="server" Width="155px"></asp:TextBox>
                </td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style3">Tên sách</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtts" runat="server" Width="381px"></asp:TextBox>
                </td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style4">Ảnh sách</td>
                <td class="auto-style7">
                    <asp:FileUpload ID="f1" runat="server" Width="231px" />
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style4">Tác giả</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txttg" runat="server" Width="380px"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Nhà xuất bản</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtnxb" runat="server" Height="16px" Width="382px"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Loại sách</td>
                <td class="auto-style7">
                    <asp:DropDownList ID="d1" runat="server" Width="183px" DataTextField="TenLS" DataValueField="MaLS">
                    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnThem" runat="server" OnClick="btnThem_Click" Text="Thêm" Width="90px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSua" runat="server" Text="Sửa" Width="85px" OnClick="btnSua_Click" />
                </td>
                <td class="auto-style5">&nbsp;&nbsp;<asp:Button ID="btnXoa" runat="server" Text="Xóa" Width="83px" OnClick="btnXoa_Click" />
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lbltb" runat="server"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
