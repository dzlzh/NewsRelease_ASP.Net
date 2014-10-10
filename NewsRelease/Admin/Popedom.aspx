<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Popedom.aspx.cs" Inherits="Admin_Popedom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gvPopedom" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="Class_ID" OnRowDataBound="gvPopedom_RowDataBound" >
            <Columns>
                <asp:BoundField DataField="Class_ID" HeaderText="类别编号" SortExpression="Class_ID" />
                <asp:BoundField DataField="Class_Name" HeaderText="类别名称" SortExpression="Class_Name" />
                <asp:BoundField DataField="Class_Desc" HeaderText="类别描述" SortExpression="Class_Desc" />
                <asp:BoundField DataField="Item_Name" HeaderText="所属栏目" SortExpression="Item_Name" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="Popedom" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Select_Class_Item" TypeName="B_Popedom"></asp:ObjectDataSource>
        <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click" />
        <input id="Button2" type="button" value="返回上页" onclick="javascript: window.location.href = 'ManageAdmin.aspx'";/>
    </div>
    </form>
</body>
</html>
