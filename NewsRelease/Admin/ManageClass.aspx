<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageClass.aspx.cs" Inherits="Admin_ManageClass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Class_ID" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="Class_Name" HeaderText="类别名称" SortExpression="Class_Name" />
                <asp:BoundField DataField="Class_Desc" HeaderText="类别描述" SortExpression="Class_Desc" />
                <asp:BoundField DataField="Class_Order" HeaderText="类别顺序" SortExpression="Class_Order" />
                <asp:TemplateField HeaderText="所属栏目" SortExpression="Item_ID">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="Item_Name" DataValueField="Item_ID" SelectedValue='<%# Bind("Item_ID") %>'>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="Item_Name" DataValueField="Item_ID" SelectedValue='<%# Bind("Item_ID") %>' Enabled="False">
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" />
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="删除" OnClientClick="return confirm('确认要删除吗？');"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="M_Class" DeleteMethod="DeleteClass" SelectMethod="SelectClass" TypeName="B_Class" UpdateMethod="UpdateClass"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectItem" TypeName="B_Item"></asp:ObjectDataSource>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/AddClass.aspx">添加类型</asp:HyperLink>
    </div>
    </form>
</body>
</html>
