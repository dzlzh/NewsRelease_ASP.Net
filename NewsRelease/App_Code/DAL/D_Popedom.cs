using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Popedom 的摘要说明
/// </summary>
public class D_Popedom
{
	public D_Popedom()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    public static List<M_Class_Item> Select_Class_Item()
    {
        string strsql = "select Class_ID ,Class_Name,Class_Desc,Item.Item_Name from Class,Item where Class.Item_ID=Item.Item_ID";
        List<M_Class_Item> list_Class_Item = new List<M_Class_Item>();
        using (SqlDataReader dr = DBHelper.SelectTable(strsql))
        {
            while (dr.Read())
            {
                list_Class_Item.Add(Get_Class_Item(dr));
            }
        }

        return list_Class_Item;
    }

    public static M_Class_Item Get_Class_Item(SqlDataReader Class_ItemTable)
    {
        M_Class_Item Class_Item = new M_Class_Item();
        Class_Item.Class_ID = (int)Class_ItemTable["Class_ID"];
        Class_Item.Class_Name = Class_ItemTable["Class_Name"].ToString();
        Class_Item.Class_Desc = Class_ItemTable["Class_Desc"].ToString();
        Class_Item.Item_Name = Class_ItemTable["Item_Name"].ToString(); 
        return Class_Item;
    }

    public static int SelectPopedomClassID(string adminid, string classid)
    {
        string strsql = string.Format("select count(*) from Popedom where Admin_ID={0} and Class_ID ={1}", adminid, classid);
        return DBHelper.ExecuteScalarSelect(strsql);
    }

    public static bool InsertPopedom(string adminid,List<M_Popedom> popedom)
    {
        string com1 = string.Format("delete from Popedom where Admin_ID={0}",adminid);
        string[] com2 = new string[popedom.Count];
        if (popedom.Count > 0)
        {
            for (int i = 0; i < popedom.Count; i++)
            {
                com2[i] = string.Format("insert Popedom values({0},{1})", popedom[i].Class_ID.ToString(), popedom[i].Admin_ID.ToString());
            }
            
        }
        return DBHelper.MultitermSQL(com1, com2);
    }

    public static List<M_Popedom> SelectPopedom(string adminid)
    {
        string strsql = string.Format("select * from Popedom where Admin_ID={0}", adminid);
        List<M_Popedom> listPopedom = new List<M_Popedom>();
        using (SqlDataReader dr = DBHelper.SelectTable(strsql))
        {
            while (dr.Read())
            {
                listPopedom.Add(GetPopedom(dr));
            }
        }

        return listPopedom;
    }

    public static M_Popedom GetPopedom(SqlDataReader PopedomTable)
    {
        M_Popedom popedom = new M_Popedom();
        popedom.Popedom_ID = (int)PopedomTable["Popedom_ID"];
        popedom.Class_ID = (int)PopedomTable["Class_ID"];
        popedom.Admin_ID = (int)PopedomTable["Admin_ID"];
        return popedom;
    }
}