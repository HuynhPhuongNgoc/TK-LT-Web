<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bai8_57131345.aspx.cs" Inherits="Bai8_57131345" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 376px;
        }
        .auto-style2 {
            width: 179px;
        }
        .auto-style3 {
            width: 179px;
            height: 30px;
        }
        .auto-style4 {
            height: 30px;
        }
        .auto-style6 {
            height: 30px;
            width: 293px;
        }
        .auto-style7 {
            width: 179px;
            height: 5px;
        }
        .auto-style8 {
            height: 5px;
            width: 293px;
        }
        .auto-style9 {
            height: 5px;
        }
        .auto-style14 {
            width: 179px;
            height: 26px;
        }
        .auto-style15 {
            width: 293px;
            height: 26px;
        }
        .auto-style16 {
            height: 26px;
        }
        .auto-style17 {
            width: 100%;
            height: 455px;
        }
        .auto-style18 {
            width: 179px;
            height: 64px;
        }
        .auto-style19 {
            height: 64px;
            width: 293px;
        }
        .auto-style20 {
            height: 64px;
        }
        .auto-style24 {
            margin-left: 6px;
            margin-top: 0px;
            margin-bottom: 0px;
        }
        .auto-style25 {
            width: 179px;
            height: 100px;
        }
        .auto-style26 {
            width: 293px;
            height: 100px;
        }
        .auto-style27 {
            height: 100px;
        }
        .auto-style31 {
            width: 293px;
        }
        .auto-style32 {
            width: 179px;
            height: 56px;
        }
        .auto-style33 {
            height: 56px;
            width: 293px;
        }
        .auto-style34 {
            height: 56px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Text="Khách hàng đăng ký"></asp:Label>
        <br />
        <table class="auto-style17">
            <tr>
                <td class="auto-style18">
                    <asp:Label ID="Label2" runat="server" Text="Họ tên khách hàng"></asp:Label>
                </td>
                <td class="auto-style19">
                    <asp:TextBox ID="txtht" runat="server" Width="265px" Height="22px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style20">
                    <asp:RequiredFieldValidator ID="rqkh" runat="server" ErrorMessage="Chưa nhập họ tên khách hàng" ForeColor="Red" ControlToValidate="txtht"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Mật khẩu"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtmk" runat="server" Width="264px" Height="21px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="rqmk" runat="server" ErrorMessage="Chưa nhập mật khẩu" ForeColor="Red" ControlToValidate="txtmk"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:Label ID="Label4" runat="server" Text="Mật khẩu xác nhận lại"></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtxnmk" runat="server" Width="266px" Height="20px"></asp:TextBox>
                    <br />
                </td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label5" runat="server" Text="Thu nhập (triệu đồng)"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtmk" ControlToValidate="txtxnmk" ErrorMessage="Mật khẩu nhập lại không giống nhau" ForeColor="Red"></asp:CompareValidator>
                    <asp:TextBox ID="txttn" runat="server" Width="267px" Height="19px"></asp:TextBox>
                    <br />
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txttn" ErrorMessage="Thu nhập từ 1 đến 100 triệu đồng" ForeColor="Red" MaximumValue="100" MinimumValue="1" Type="Double"></asp:RangeValidator>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:Label ID="Label6" runat="server" Text="Địa chỉ email"></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtdcmail" runat="server" Width="265px" Height="21px"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtdcmail" ErrorMessage="Địa chỉ email không hợp lệ" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style32">
                    <asp:Label ID="Label7" runat="server" Text="Số chẵn bạn thích"></asp:Label>
                </td>
                <td class="auto-style33">
                    <asp:TextBox ID="txtsc" runat="server" Width="263px" Height="18px"></asp:TextBox>
                    <br />
                    <asp:CustomValidator ID="KiemTraSo" runat="server" ErrorMessage="Phải nhập số chẵn" ForeColor="Red" ControlToValidate="txtsc" OnServerValidate="KiemTraSo_ServerValidate1"></asp:CustomValidator>
                    <br />
                </td>
                <td class="auto-style34">
                    <asp:RequiredFieldValidator ID="rqso" runat="server" ErrorMessage="Phải nhập số" ForeColor="Red" ControlToValidate="txtsc"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style25">
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
                <td class="auto-style26">
                    <asp:Button ID="btndk" runat="server" OnClick="btndk_Click" Text="Đăng ký" CssClass="auto-style24" Height="26px" Width="94px" />
                    <br />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="Danh sách các lỗi" Width="237px" />
                </td>
                <td class="auto-style27"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblthongtin" runat="server" ForeColor="Red"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblloi" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style31">&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <p>
        </p>
    </form>
</body>
</html>
