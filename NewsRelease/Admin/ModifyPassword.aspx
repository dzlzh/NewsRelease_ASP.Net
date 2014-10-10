<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModifyPassword.aspx.cs" Inherits="Admin_ModifyPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        原密码：<asp:TextBox ID="txtyPassword" runat="server"  TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户名称不能为空！" ControlToValidate="txtyPassword" ForeColor="Red"></asp:RequiredFieldValidator><br />
        新密码：<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="用户名称不能为空！" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator><br />
        确&nbsp;&nbsp;认：<asp:TextBox ID="txtQrPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="两次密码不一致！" ForeColor="Red"  ControlToCompare ="txtQrPassword" ControlToValidate ="txtPassword"></asp:CompareValidator><br />
        <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
