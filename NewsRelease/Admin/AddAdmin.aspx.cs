using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
public partial class Admin_AddAdmin : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            M_Admin admin = new M_Admin();
            admin = (M_Admin)Session["name"];
            if (admin.Power==0)
            {
                Response.Write("<script>alert('用户权限不够！')</script>");
                Response.Write("<script>window.location.href = 'index.aspx'</script>");
                //Response.Redirect("index.aspx");
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        M_Admin admin = new M_Admin();
        string name = txtName.Text.Trim();
        string password = txtPassword.Text.Trim();
        admin.Admin_Name = name;
        admin.Admin_Password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");
        if (B_Admin.InsertAdmin(admin))
        {
            Response.Write("<script>alert('添加成功！')</script>");
        }
        else
        {
            Response.Write("<script>alert('添加失败！')</script>");
        }
    }

}