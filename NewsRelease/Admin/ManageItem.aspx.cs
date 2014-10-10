using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageItem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            M_Admin admin = new M_Admin();
            admin = (M_Admin)Session["name"];
            if (admin.Power == 0)
            {
                Response.Write("<script>alert('用户权限不够！')</script>");
                Response.Write("<script>window.location.href = 'index.aspx'</script>");
                //Response.Redirect("index.aspx");
            }
        }
    }
}