using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// B_News 的摘要说明
/// </summary>
public class B_News
{
	public B_News()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static bool InsertNews(M_News news)
    {
        int count = D_News.InsertNews(news);
        return count > 0 ? true : false;
    }
    public static List<M_Class> SelectClass(M_Admin admin)
    {
        return  D_News.SelectClass(admin);
    }

    public static List<M_News> SelectNews(M_Admin admin)
    {
        return D_News.SelectNews(admin);
    }
    public static List<M_News> SelectNewsID(string newsid)
    {
        return D_News.SelectNewsID(newsid);
    }

    public static bool UpdateNews(M_News news)
    {
        int count = D_News.UpdateNews(news);
        return count > 0 ? true : false;
    }
    public static string Getclassname(string classid)
    {
        return D_News.Getclassname(classid);
    }
    public static List<M_News> jiansuo(string classid, string key)
    {
        return D_News.jiansuo(classid, key);
    }
}