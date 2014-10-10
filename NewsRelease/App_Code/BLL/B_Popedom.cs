using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// D_Popedom 的摘要说明
/// </summary>
public class B_Popedom
{
	public B_Popedom()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static List<M_Class_Item> Select_Class_Item()
    {
        return D_Popedom.Select_Class_Item();
    }
    public static bool SelectPopedomClassID(string adminid, string classid)
    {
        int count=D_Popedom.SelectPopedomClassID(adminid, classid);
        return count > 0 ? true : false;
    }

    public static bool InsertPopedom(string adminid,List<M_Popedom> popedom)
    {
        return D_Popedom.InsertPopedom(adminid,popedom);
    }
    public static List<M_Popedom> SelectPopedom(string adminid)
    {
        return D_Popedom.SelectPopedom(adminid);
    }
}