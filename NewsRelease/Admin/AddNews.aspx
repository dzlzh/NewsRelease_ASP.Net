<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNews.aspx.cs" Inherits="Admin_AddNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        新闻标题：<asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="新闻标题不可以为空！" ControlToValidate="txtTitle" ForeColor="Red"></asp:RequiredFieldValidator><br />
        所属类型：<asp:DropDownList ID="ddlClass" runat="server" ></asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请选择所属类型！" ControlToValidate="ddlClass" ForeColor="Red"></asp:RequiredFieldValidator><br />
        发布时间：<asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label><br />
       &nbsp;&nbsp;关键字：<asp:TextBox ID="txtKey" runat="server"></asp:TextBox><br />
        新闻来源：<asp:TextBox ID="txtFrom" runat="server"></asp:TextBox><br />
        新闻内容：<CKEditor:CKEditorControl ID="ckContet" runat="server" ></CKEditor:CKEditorControl>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="新闻内容不可以为空！" ControlToValidate="ckContet" ForeColor="Red"></asp:RequiredFieldValidator><br />
        <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click" />
        <input id="Button2" type="button" value="返回上页" onclick="javascript: window.location.href = 'ManageNews.aspx'";/>
    </div>
 </form>
</body>

</html>
