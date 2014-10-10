<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageAdmin.aspx.cs" Inherits="Admin_ManageAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Admin_ID" DataSourceID="ObjectDataSource1" >
            <Columns>
                <asp:BoundField DataField="Admin_Name" HeaderText="用户名称" SortExpression="Admin_Name" />
                <asp:HyperLinkField HeaderText="权限" Text="权限" DataNavigateUrlFormatString="Popedom.aspx?AdminID={0}" DataNavigateUrlFields="Admin_ID" />
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="删除" OnClientClick="return confirm('确认要删除吗？');" ></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/AddAdmin.aspx">添加用户</asp:HyperLink>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAdmin" TypeName="B_Admin" DataObjectTypeName="M_Admin" DeleteMethod="DeleteAdmin"></asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
