using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageNews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            M_Admin admin = new M_Admin();
            admin = (M_Admin)Session["name"];
            ddlClass.AppendDataBoundItems = true;
            ddlClass.Items.Add(new ListItem("-- 请选择一个选择项 --", ""));
            ddlClass.DataSource = B_News.SelectClass(admin);
            ddlClass.DataTextField = "Class_Name";
            ddlClass.DataValueField = "Class_ID";
            ddlClass.DataBind();
            gvNews.DataSource = B_News.SelectNews(admin);
            gvNews.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string classid = "0";
        if (ddlClass.SelectedIndex != 0)
        {
           classid = ddlClass.SelectedValue.ToString();
        }

        string key = txtKey.Text.Trim();
        gvNews.DataSource = B_News.jiansuo(classid,key);
        gvNews.DataBind();
    }
}