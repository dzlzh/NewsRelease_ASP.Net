using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// D_Class 的摘要说明
/// </summary>
public class D_Class
{
	public D_Class()
	{ 
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static int GetItemcount(int id)
    {
        string strsql = string.Format( "select count(*) from Class where Item_ID={0}",id);
        return DBHelper.ExecuteScalarSelect(strsql); 
    }

    public static  int  InsertClass(M_Class newsclass)
    {
        string strsql = "insert Class values(@Class_Name,@Class_Desc,@Class_Order,@Item_ID)";
        SqlParameter[] comSql = new SqlParameter[]{
            new SqlParameter("@Class_Name",newsclass.Class_Name),
            new SqlParameter("@Class_Desc",newsclass.Class_Desc),
            new SqlParameter("@Class_Order",newsclass.Class_Order),
            new SqlParameter("@Item_ID",newsclass.Item_ID)
        };
        return DBHelper.IDUTable(strsql, comSql);
    }

    public static List<M_Class> SelectClass()
    {
        string strsql = "select * from Class";
        List<M_Class> listClass= new List<M_Class>();
        using (SqlDataReader dr = DBHelper.SelectTable(strsql))
        {
          while (dr.Read())
          {
              listClass.Add(GetClass(dr));
          }
        }
        
        return listClass;
    }

    public static int UpdateClass(M_Class newsclass)
    {
        string strsql = "update Class set Class_Name=@Class_Name,Class_Desc= @Class_Desc,Class_Order=@Class_Order,Item_ID=@Item_ID where Class_ID=@Class_ID ";
        SqlParameter[] comSql = new SqlParameter[]{
            new SqlParameter("@Class_ID",newsclass.Class_ID),
            new SqlParameter("@Class_Name",newsclass.Class_Name),
            new SqlParameter("@Class_Desc",newsclass.Class_Desc),
            new SqlParameter("@Class_Order",newsclass.Class_Order),
            new SqlParameter("@Item_ID",newsclass.Item_ID)
        };
        return DBHelper.IDUTable(strsql, comSql);
    }

    public static int DeleteClass(M_Class newsclass)
    {
        string strsql = "delete Class where Class_ID=@Class_ID ";
        SqlParameter[] comSql = new SqlParameter[]{
            new SqlParameter("@Class_ID",newsclass.Class_ID),
        };
        return DBHelper.IDUTable(strsql, comSql);
    }

     public static M_Class GetClass(SqlDataReader ClassTable)
    {
        M_Class newsclass = new M_Class();
        newsclass.Class_ID = (int)ClassTable["Class_ID"];
        newsclass.Class_Name = ClassTable["Class_Name"].ToString();
        newsclass.Class_Desc = ClassTable["Class_Desc"].ToString();
        newsclass.Class_Order = (int)ClassTable["Class_Order"];
        newsclass.Item_ID=(int)ClassTable["Item_ID"];
        return newsclass;
    }
}