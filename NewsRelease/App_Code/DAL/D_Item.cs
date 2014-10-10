using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// D_Item 的摘要说明
/// </summary>
public class D_Item
{
	public D_Item()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static  int  InsertItem(M_Item item)
    {
        string strsql = "insert Item values(@Item_Name,@Item_Desc,@Item_Order)";
        SqlParameter[] comSql = new SqlParameter[]{
            new SqlParameter("@Item_Name",item.Item_Name),
            new SqlParameter("@Item_Desc",item.Item_Desc),
            new SqlParameter("@Item_Order",item.Item_Order)
        };
        return DBHelper.IDUTable(strsql, comSql);
    }

    public static List<M_Item> SelectItem()
    {
        string strsql = "select * from Item";
        List<M_Item> listItem= new List<M_Item>();
        using (SqlDataReader dr = DBHelper.SelectTable(strsql))
        {
          while (dr.Read())
          {
              listItem.Add(GetItem(dr));
          }
        }
        
        return listItem;
    }

    public static int UpdateItem(M_Item item)
    {
        string strsql = "update Item set Item_Name=@Item_Name,Item_Desc= @Item_Desc,Item_Order=@Item_Order where Item_ID=@Item_ID ";
        SqlParameter[] comSql = new SqlParameter[]{
            new SqlParameter("@Item_ID",item.Item_ID),
            new SqlParameter("@Item_Name",item.Item_Name),
            new SqlParameter("@Item_Desc",item.Item_Desc),
            new SqlParameter("@Item_Order",item.Item_Order)
        };
        return DBHelper.IDUTable(strsql, comSql);
    }

    public static int DeleteItem(M_Item item)
    {
        int count = D_Class.GetItemcount(item.Item_ID);
        if (count > 0)
        {
            HttpContext.Current.Response.Write("<script>alert('删除失败！所属栏目下有记录！')</script>");
            return -1;
        }
        else
        {
            string strsql = "delete Item where Item_ID=@Item_ID ";
            SqlParameter[] comSql = new SqlParameter[]
            {
               new SqlParameter("@Item_ID",item.Item_ID),
            };
            return DBHelper.IDUTable(strsql, comSql);
        }

    }

    public static M_Item GetItem(SqlDataReader ItemTable)
    {
        M_Item item = new M_Item();
        item.Item_ID = (int)ItemTable["Item_ID"];
        item.Item_Name = ItemTable["Item_Name"].ToString();
        item.Item_Desc = ItemTable["Item_Desc"].ToString();
        item.Item_Order = (int)ItemTable["Item_Order"];
        return item;
    }
}