<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageItem.aspx.cs" Inherits="Admin_ManageItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:gridview runat="server" AutoGenerateColumns="False" DataKeyNames="Item_ID" DataSourceID="ObjectDataSource1">
          <Columns>
              <asp:BoundField DataField="Item_Name" HeaderText="栏目名称" />
              <asp:BoundField DataField="Item_Desc" HeaderText="栏目描述" />
              <asp:BoundField DataField="Item_Order" HeaderText="栏目顺序" />
              <asp:CommandField ShowEditButton="True" />
              <asp:TemplateField ShowHeader="False">
                  <ItemTemplate>
                      <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="删除" OnClientClick="return confirm('确认要删除吗？');" ></asp:LinkButton>
                  </ItemTemplate>
              </asp:TemplateField>
          </Columns>
        </asp:gridview>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectItem" TypeName="B_Item" DataObjectTypeName="M_Item" DeleteMethod="DeleteItem" UpdateMethod="UpdateItem">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
        </asp:ObjectDataSource>
        <asp:HyperLink ID="HyperLink1" runat="server" Text ="添加栏目"  NavigateUrl="~/Admin/AddItem.aspx"></asp:HyperLink>
    </div>
    </form>
</body>
</html>
