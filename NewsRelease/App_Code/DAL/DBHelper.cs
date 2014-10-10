using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class DBHelper
{
    /// <summary>
    /// DBHelper 的摘要说明
    /// </summary>
	public DBHelper()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    // Web.config 连接数据库字符串        
    public static string conStr = ConfigurationManager.ConnectionStrings["ApplicationServices"].ToString();

    // 连接数据库
    public static SqlConnection con;
    public static SqlConnection Con
    {
        get
        {
            if (con == null)
            {
                con = new SqlConnection(conStr);
                con.Open();
            }
            else if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else if (con.State == System.Data.ConnectionState.Broken)
            {
                con.Close();
                con.Open();
            }
            return con;
        }
    }


    public static int ExecuteScalarSelect(string strsql)
    {
        SqlCommand com = new SqlCommand(strsql, Con);
        return (int)com.ExecuteScalar();
    }
    public static string ExecuteScalarSelectName(string strsql)
    {
        SqlCommand com = new SqlCommand(strsql, Con);
        return com.ExecuteScalar().ToString();
    }
    public static SqlDataReader ExecuteReaderSelect(string strsql)
    { 
        SqlCommand com = new SqlCommand(strsql,Con ); 
        return com.ExecuteReader();
    }

    public static int IDUTable( string strsql, SqlParameter[] comSql)
    {
        SqlCommand com = new SqlCommand(strsql, Con);
        foreach (SqlParameter parameter in comSql)
        {
            com.Parameters.Add(parameter);
        }
        return com.ExecuteNonQuery();
    }

    public static SqlDataReader SelectTable(string strsql)
    {
        SqlCommand com = new SqlCommand (strsql,Con);
        return com.ExecuteReader();
    }


    public static bool MultitermSQL(string com1,string[] com2)
    {
        bool fla = true;
        SqlCommand com = new SqlCommand();
        SqlTransaction myTran;
        myTran = Con.BeginTransaction();
        com.Connection = Con;
        com.Transaction = myTran;
        try
        {
            com.CommandText = com1;
            
            com.ExecuteNonQuery();
            if (com2.Count() > 0)
            {
                foreach (string strsql in com2)
                {
                    com.CommandText += strsql;
                    
                }
                com.ExecuteNonQuery();
            }
            
            myTran.Commit();
        }
        catch (Exception err)
        {
            myTran.Rollback();
            fla = false;
        }
        return fla;

    }
}