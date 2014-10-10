using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Popedom : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {

        }
    }
     protected void gvPopedom_RowDataBound(object sender, GridViewRowEventArgs e)
    {
            string adminid =Request.QueryString["AdminID"];
            List<M_Popedom> listpopedom = new List<M_Popedom>();
            listpopedom=B_Popedom.SelectPopedom(adminid);
            foreach (GridViewRow gvr in gvPopedom.Rows)
            {
                int classid =Convert.ToInt32( gvr.Cells[0].Text);
                foreach(M_Popedom popedom in listpopedom)
                {
                    if(classid==popedom.Class_ID)
                    {
                        ((CheckBox)(gvr.FindControl("Popedom"))).Checked=true;
                    }
                }
            //    string classid = gvr.Cells[0].Text.ToString();
            //    if (B_Popedom.SelectPopedomClassID(adminid, classid))
            //    {
            //        ((CheckBox)(gvr.FindControl("Popedom"))).Checked=true;
            //    }

            } 
    }


     protected void Button1_Click(object sender, EventArgs e)
     {
         string adminid = Request.QueryString["AdminID"];
         List<M_Popedom> listpopedom= new List<M_Popedom>();
         
         foreach (GridViewRow gvr in gvPopedom.Rows)
         {
             if (((CheckBox)(gvr.FindControl("Popedom"))).Checked)
             {
                 M_Popedom popedom = new M_Popedom();
                 popedom.Admin_ID =Convert.ToInt32(adminid);
                 popedom.Class_ID=Convert.ToInt32 (gvr.Cells[0].Text);
                 listpopedom.Add(popedom);
             }

         }
         if (B_Popedom.InsertPopedom(adminid,listpopedom))
         {
             Response.Write("<script>alert('修改成功！')</script>");
         }
         else
         {
             Response.Write("<script>alert('修改失败！')</script>");
         }
     }
}