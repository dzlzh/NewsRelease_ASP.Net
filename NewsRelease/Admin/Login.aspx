<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Admin_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>新闻发布系统登录</title>    
    <link href="../Style/Style1.css" rel="stylesheet" type="text/css" />
        <style type="text/css">
        .style4
        {
            height: 30px;
            width: 100px;
        }
        .style5
        {
            height: 30px; width:140px;
        }
    </style>
</head>
<body bgcolor="#9999CC" text="#000000" leftmargin="0" topmargin="48" marginwidth="0" marginheight="0" background="images/bj.gif">
    <form id="form1" runat="server">
        <div>
        <br />
        <br />
        <br />
        <br />
            <table width="97%" border="0" cellpadding="0" cellspacing="0" align="center">
              <tr> 
                <td height="28" background="images/bian.gif">　</td>
              </tr>
              <tr>
                <td height="270" bgcolor="#FFFFFF" align="center" valign="middle"> 
                <table style="width: 100%; height: 100%" cellpadding="0" cellspacing="0" border="0">
                  <tr>
                    <td width="600" align="left"><img alt="" src="Images/AdminLogo.gif" style="width: 600px; height: 270px" /></td>
                    <td align="center">
                      <table border="0" cellpadding="0" cellspacing="0" style="width:74%; text-align:center;">
                      <tr>
                        <td class="style4" align="right"><div class="bodytext">用户名称：</div></td>
                        <td class="style5" align="left"><asp:TextBox ID="Name" runat="server"></asp:TextBox></td>
                      </tr>
                      <tr>
                        <td class="style4" align="right"><div class="bodytext">用户密码：</div></td>
                        <td class="style5" align="left"><asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox></td>
                      </tr>
                      <tr>
                        <td colspan="2" style=" height:30px;" align="center"><asp:Button ID="Button1" runat="server"  Text="登录" OnClick="Button1_Click" />&nbsp;<input id="btnReset" type="reset" value="重置" /></td>
                      </tr>
                     </table>
                   </td>
                 </tr>
               </table>
               </td>
             </tr>
             <tr>
               <td height="29" background="images/bian.gif">　</td>
             </tr>
          </table>
        </div>
    </form>
</body>
</html>
