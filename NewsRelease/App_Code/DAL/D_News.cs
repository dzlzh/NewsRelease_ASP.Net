using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
/// <summary>
/// D_News 的摘要说明
/// </summary>
public class D_News
{
	public D_News()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    public static List<M_Class> SelectClass(M_Admin admin)
    {
        if (admin.Power == 0)
        {
            string strsql = string.Format("select Class.* from Class,Popedom where Class.Class_ID=Popedom.Class_ID and Popedom.Admin_ID={0}", admin.Admin_ID);
            List<M_Class> listClass = new List<M_Class>();
            using (SqlDataReader dr = DBHelper.SelectTable(strsql))
            {
                while (dr.Read())
                {
                    listClass.Add(D_Class.GetClass(dr));
                }
            }

            return listClass;
        }
        else
        {
           return D_Class.SelectClass();
        }
    }

    public static List<M_News> SelectNewsID(string newsid)
    {
        string strsql = string.Format("select * from News where News_ID={0}", newsid);
        List<M_News> listnews = new List<M_News>();
        using (SqlDataReader dr = DBHelper.SelectTable(strsql))
        {
            while (dr.Read())
            {
                listnews.Add(GetNews(dr));
            }
        }

        return listnews;
    }
    public static List<M_News> SelectNews(M_Admin admin)
    {
        //M_Admin admin = new M_Admin();
        //admin = (M_Admin)Objadmin;
        if (admin.Power == 0)
        {
            string strsql = string.Format("select * from News where Admin_ID={0}", admin.Admin_ID);
            List<M_News> listnews = new List<M_News>();
            using (SqlDataReader dr = DBHelper.SelectTable(strsql))
            {
                while (dr.Read())
                {
                    listnews.Add(GetNews(dr));
                }
            }

            return listnews;
        }
        else
        {
            string strsql = "select * from News";
            List<M_News> listnews = new List<M_News>();
            using (SqlDataReader dr = DBHelper.SelectTable(strsql))
            {
                while (dr.Read())
                {
                    listnews.Add(GetNews(dr));
                }
            }

            return listnews;
        }
    }


    public static int InsertNews(M_News news)
    {
        string strsql = "insert news values(@News_Title,@Class_ID,@News_Date,@News_Key,@News_Ource,@News_Content,@Admin_ID,@Hits,@Monthhits)";
        SqlParameter[] comSql = new SqlParameter[]{
            new SqlParameter("@News_Title",news.News_Title),
            new SqlParameter("@Class_ID",news.Class_ID),
            new SqlParameter("@News_Date",news.News_Date),
            new SqlParameter("@News_Key",news.News_Key),
            new SqlParameter("@News_Ource",news.News_Ource),
            new SqlParameter("@News_Content",news.News_Content),
            new SqlParameter("@Admin_ID",news.Admin_ID),
            new SqlParameter("@Hits",news.Hits),
            new SqlParameter("@Monthhits",news.Monthhits)

        };
        return DBHelper.IDUTable(strsql, comSql);
    }

    public static M_News GetNews(SqlDataReader NewsTable)
    {
        M_News news = new M_News();
        news.News_ID = (int)NewsTable["News_ID"];
        news.News_Title = NewsTable["News_Title"].ToString();
        news.News_Ource = NewsTable["News_Ource"].ToString();
        news.News_Key = NewsTable["News_Key"].ToString();
        news.News_Content = NewsTable["News_Content"].ToString();
        news.News_Date =Convert.ToDateTime( NewsTable["News_Date"]);
        news.Admin_ID = (int)NewsTable["Admin_ID"];
        news.Class_ID = (int)NewsTable["Class_ID"];
        news.Hits = (int)NewsTable["Hits"];
        news.Monthhits = (int)NewsTable["Monthhits"];
        return news;
    }
    public static int UpdateNews(M_News news)
    {
        string strsql = "update News set News_Title=@News_Title,Class_ID= @Class_ID,News_Key=@News_Key, News_Content=@News_Content , Hits=@Hits ,Monthhits=@Monthhits where News_ID=@News_ID ";
        SqlParameter[] comSql = new SqlParameter[]{
            new SqlParameter("@News_ID",news.News_ID),
            new SqlParameter("@News_Title",news.News_Title),
            new SqlParameter("@Class_ID",news.Class_ID),
            new SqlParameter("@News_Date",news.News_Date),
            new SqlParameter("@News_Key",news.News_Key),
            
            new SqlParameter("@News_Content",news.News_Content),
            
            new SqlParameter("@Hits",news.Hits),
            new SqlParameter("@Monthhits",news.Monthhits)
        };
        return DBHelper.IDUTable(strsql, comSql);
    }

    public static string Getclassname(string classid)
    {
        string strsql= string.Format("select Class_Name from Class where Class_ID={0}",classid);
        return DBHelper.ExecuteScalarSelectName(strsql);
    }

    public static List<M_News> jiansuo(string classid , string key)
    {
        string strsql = string.Format("select * from News where Class_ID={0} or News_Key  like '%{1}%'", classid, key);
        List<M_News> listnews = new List<M_News>();
        using (SqlDataReader dr = DBHelper.SelectTable(strsql))
        {
            while (dr.Read())
            {
                listnews.Add(GetNews(dr));
            }
        }

        return listnews;
    }
}