using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddClass : System.Web.UI.Page
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        M_Class newsclass = new M_Class();
        newsclass.Class_Name = txtClassName.Text.Trim();
        newsclass.Class_Desc = txtClassDesc.Text.Trim();
        newsclass.Class_Order =Convert.ToInt32(txtClassOrder.Text.Trim());
        newsclass.Item_ID = Convert.ToInt32(ddlItemID.SelectedValue);
        if (B_Class.InsertClass(newsclass))
        {
            Response.Write("<script>alert('添加成功！')</script>");
        }
        else
        {
            Response.Write("<script>alert('添加失败！')</script>");
        }
    }
}