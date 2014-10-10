using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
public partial class Admin_ModifyPassword : System.Web.UI.Page
{
    M_Admin admin = new M_Admin();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string yPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(txtyPassword.Text.Trim(), "MD5");
        String Password = txtPassword.Text.Trim();
        admin.Admin_Password = FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "MD5");
        admin.Admin_ID = ((M_Admin)Session["name"]).Admin_ID;
        if (B_Admin.UpdateAdmin(admin,yPassword))
        {
            Response.Write("<script>alert('修改成功！')</script>");
        }
        else
        {
            Response.Write("<script>alert('修改失败！')</script>");
        }
        
    }
}