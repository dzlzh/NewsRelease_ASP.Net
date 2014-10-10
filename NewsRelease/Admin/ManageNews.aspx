<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageNews.aspx.cs" Inherits="Admin_ManageNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        检索关键字：<asp:TextBox ID="txtKey" runat="server"></asp:TextBox><asp:DropDownList ID="ddlClass" runat="server"></asp:DropDownList><asp:Button ID="Button1" runat="server" Text="检索新闻" OnClick="Button1_Click" />
        <asp:GridView ID="gvNews" runat="server" AutoGenerateColumns="False" DataKeyNames="News_ID">
            <Columns>
                <asp:BoundField DataField="News_ID" HeaderText="编号" />
                <asp:BoundField DataField="News_Title" HeaderText="新闻标题" />
                <asp:TemplateField HeaderText="所属类别">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Class_ID") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# B_News.Getclassname(Eval("Class_ID").ToString()) %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="News_Date" HeaderText="发布时间" />
                <asp:BoundField DataField="Hits" HeaderText="点击" />
                <asp:HyperLinkField DataNavigateUrlFields="News_ID" DataNavigateUrlFormatString="AddNews.aspx?NewsID={0}" Text="编辑" />
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="删除"  OnClientClick="return confirm('确认要删除吗？');" ></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/AddNews.aspx">添加新闻</asp:HyperLink>
    </div>
    </form>
</body>
</html>
