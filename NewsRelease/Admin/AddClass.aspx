<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddClass.aspx.cs" Inherits="Admin_AddClass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div> 
        分类名称：<asp:TextBox ID="txtClassName" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="分类名称不能为空！" ControlToValidate="txtClassName" ForeColor="Red"></asp:RequiredFieldValidator><br />
        所属栏目：<asp:DropDownList ID="ddlItemID" runat="server" DataSourceID="objItem" DataTextField="Item_Name" DataValueField="Item_ID" Width="146px" ></asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="请选择所属栏目！" ControlToValidate="ddlItemID" ForeColor="Red"></asp:RequiredFieldValidator><br />
        分类描述：<asp:TextBox ID="txtClassDesc" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="分类描述不能为空！" ControlToValidate="txtClassDesc" ForeColor="Red"></asp:RequiredFieldValidator><br />
        分类顺序：<asp:TextBox ID="txtClassOrder" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="分类顺序不能为空！" ControlToValidate="txtClassOrder" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="必须为1-4位数字！"  ValidationExpression ="\d{1,4}" ControlToValidate="txtClassOrder"  ForeColor="Red" ></asp:RegularExpressionValidator><br />
        <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click"  /><input id="Button2" type="button" value="返回上页" onclick="javascript: window.location.href = 'ManageClass.aspx'";/>
        <asp:ObjectDataSource ID="objItem" runat="server" SelectMethod="SelectItem" TypeName="B_Item"></asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
