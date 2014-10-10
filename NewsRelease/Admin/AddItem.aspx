<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddItem.aspx.cs" Inherits="Admin_AddItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        栏目名称：<asp:TextBox ID="txtItemName" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="栏目名称不能为空！" ControlToValidate="txtItemName" ForeColor="Red"></asp:RequiredFieldValidator><br />
        栏目描述：<asp:TextBox ID="txtItemDesc" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="栏目描述不能为空！" ControlToValidate="txtItemDesc" ForeColor="Red"></asp:RequiredFieldValidator><br />
        栏目顺序：<asp:TextBox ID="txtItemOrder" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="栏目顺序不能为空！" ControlToValidate="txtItemOrder" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="必须为1-4位数字！" ValidationExpression ="\d{1,4}" ControlToValidate="txtItemOrder" ForeColor="Red"></asp:RegularExpressionValidator><br />
        <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click" /><input id="Button2" type="button" value="返回上页" onclick="javascript: window.location.href = 'ManageItem.aspx'";/>
    </div>
    </form>
</body>
</html>
