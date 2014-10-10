<%@ Page Language="C#" AutoEventWireup="true" CodeFile="middle.aspx.cs" Inherits="Admin_middle" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
      <base target="middleFrame">
    <link rel="stylesheet" href="../Style/Style2.css" type="text/css"/>
    <script>

        function main_back() {
            history.back(-1);
        }
        function main_forward() {
            history.go(1);
        }
        function main_refresh() {
            parent.mainFrame.location.reload();
        }
        function main_print() {
            window.parent.mainFrame.focus();
            window.print();
        }
    </script>
</head>
<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
    <form id="form1" runat="server">
        <table width="100%" height="40" border="0" cellpadding="0" cellspacing="0">
            <tr> 
              <td width="48%" align="center" background="images/path_1.gif"><table width="412" height="27" border="0" cellpadding="0" cellspacing="0">
                  <tr> 
                    <td width="37">&nbsp;&nbsp;<img src="images/path_3.gif" width="25" height="23"></td>
                    <td width="375">欢迎您：<asp:Label ID="lblCurrentUser" runat="server"></asp:Label>
                                </td>
                  </tr>
                </table>          </td>
                <td background="images/path_2.gif" width="46%" nowrap="nowrap" align="right">
	                <a href="####" onClick="main_back();" title="后退"><img src="images/icon/001.gif" border="0"/>后退</a>
	                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	                <a href="####" onClick="main_forward();" title="前进"><img src="images/icon/002.gif" border="0"/>前进</a>
	                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	                <a href="####" onClick="main_refresh();" title="刷新工作区"><img src="images/icon/003.gif" border="0"/>刷新</a>
	                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	                <a href="####" onClick="main_print();" title="打印"><img src="images/icon/print.gif" height="16" width="16" border="0"/>打印</a> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;      </td>
            </tr>
          </table>
    </form>
</body>
</html>
