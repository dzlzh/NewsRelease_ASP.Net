using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// B_Class 的摘要说明
/// </summary>
public class B_Class
{
	public B_Class()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    public static bool InsertClass(M_Class newsclass)
    {
        int count = D_Class.InsertClass(newsclass);
        return count > 0 ? true : false;
    }

    public static List<M_Class> SelectClass()
    {
        return D_Class.SelectClass();
    }

    public static void UpdateClass(M_Class newsclass)
    {
        D_Class.UpdateClass(newsclass);
    }

    public static void DeleteClass(M_Class newsclass)
    {
        D_Class.DeleteClass(newsclass);
    }
}