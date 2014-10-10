using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddNews : System.Web.UI.Page
{
    M_News news = new M_News();
    M_Admin admin = new M_Admin();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Request.QueryString["NewsID"]!=null)
            {
                admin = (M_Admin)Session["name"];
                string newsid = Request.QueryString["NewsID"].ToString();
                List<M_News> news= new List<M_News>();
                news=B_News.SelectNewsID(newsid);
                txtTitle.Text = news[0].News_Title.ToString();
                ddlClass.DataSource = B_News.SelectClass(admin);
                ddlClass.DataTextField = "Class_Name";
                ddlClass.DataValueField = "Class_ID";
                ddlClass.DataBind();
                ddlClass.SelectedValue = news[0].Class_ID.ToString() ;
                lblDate.Text = news[0].News_Date.ToString();
                txtKey.Text = news[0].News_Key.ToString();
                txtFrom.Text = admin.Admin_Name;
                ckContet.Text = news[0].News_Content.ToString();
            }
            else
            {
                admin = (M_Admin)Session["name"];
                ddlClass.AppendDataBoundItems = true;
                ddlClass.Items.Add(new ListItem("-- 请选择一个选择项 --", ""));
                ddlClass.DataSource = B_News.SelectClass(admin);
                ddlClass.DataTextField = "Class_Name";
                ddlClass.DataValueField = "Class_ID";
                ddlClass.DataBind();
                lblDate.Text = DateTime.Now.ToString();
                txtFrom.Text = admin.Admin_Name;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["NewsID"] != null)
        {
            admin = (M_Admin)Session["name"];
            news.News_ID = Convert.ToInt32( Request.QueryString["NewsID"]);
            news.News_Title = txtTitle.Text.Trim();
            news.Class_ID = Convert.ToInt32(ddlClass.SelectedValue);
            news.Admin_ID = admin.Admin_ID;
            news.News_Key = txtKey.Text.Trim();
            news.News_Ource = txtFrom.Text;
            news.News_Content = ckContet.Text;
            news.News_Date = DateTime.Now;
            if (B_News.UpdateNews(news))
            {
                Response.Write("<script>alert('修改成功！')</script>");
            }
            else
            {
                Response.Write("<script>alert('修改失败！')</script>");
            }
        }
        else
        {
            admin = (M_Admin)Session["name"];
            news.News_Title = txtTitle.Text.Trim();
            news.Class_ID = Convert.ToInt32(ddlClass.SelectedValue);
            news.Admin_ID = admin.Admin_ID;
            news.News_Key = txtKey.Text.Trim();
            news.News_Ource = txtFrom.Text;
            news.News_Content = ckContet.Text;
            news.News_Date = DateTime.Now;
            if (B_News.InsertNews(news))
            {
                Response.Write("<script>alert('添加成功！')</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败！')</script>");
            }
        }
    }
}