<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddAdmin.aspx.cs" Inherits="Admin_AddAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        用户名称：<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户名称不能为空！" ControlToValidate="txtName" ForeColor="Red"></asp:RequiredFieldValidator><br />
        密&nbsp;&nbsp;&nbsp;&nbsp;码：<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能为空！" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator><br />
        确认密码：<asp:TextBox ID="txtQrPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="两次密码不一致！" ForeColor="Red"  ControlToCompare ="txtQrPassword" ControlToValidate ="txtPassword"></asp:CompareValidator><br />
        <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click" />
        <input id="Button2" type="button" value="返回上页" onclick="javascript: window.location.href = 'ManageAdmin.aspx'";/>
    </div>
    </form>
</body>
</html>
