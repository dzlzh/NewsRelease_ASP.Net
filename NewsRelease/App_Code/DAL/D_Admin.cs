using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// D_Admin 的摘要说明
/// </summary>
public class D_Admin
{
	public D_Admin()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static int GetExecuteScalar(M_Admin admin)
    {
        string strsql = string.Format("select count(*) from Admin where Admin_Name='{0}' and Admin_Password='{1}'", admin.Admin_Name, admin.Admin_Password);
        return DBHelper.ExecuteScalarSelect(strsql);
    }

    public static M_Admin GetNamePassword(M_Admin admin)
    {
        string strsql = string.Format("select * from Admin where Admin_Name='{0}' and Admin_Password='{1}'", admin.Admin_Name, admin.Admin_Password);
        return GetAdminName(DBHelper.ExecuteReaderSelect(strsql));
    }

    public static M_Admin GetAdminName( SqlDataReader AdminTable)
    {
        M_Admin admin = new M_Admin();
        if (AdminTable.Read())
        {
            admin.Admin_ID = (int)AdminTable["Admin_ID"];
            admin.Admin_Name = AdminTable["Admin_Name"].ToString();
            admin.Admin_Password = AdminTable["Admin_Password"].ToString();
            admin.Power = Convert.ToInt32((bool)AdminTable["Power"] ? 1 : 0);
        }
        else
        {
            admin = null;
        }
      
        AdminTable.Close();
        return admin;
    }

    public static int InsertAdmin(M_Admin admin)
    {
        string strsql = "Insert Admin values(@Admin_Name,@Admin_Password,@Power)";
        SqlParameter[] comSql = new SqlParameter[]{
            new SqlParameter("@Admin_Name",admin.Admin_Name),
            new SqlParameter("@Admin_Password",admin.Admin_Password),
            new SqlParameter("@Power",admin.Power)
        };
        return DBHelper.IDUTable(strsql, comSql);
    }

    public static List<M_Admin> SelectAdmin()
    {
        string strsql = "select * from Admin where Power='False'";
        List<M_Admin> listAdmin = new List<M_Admin>();
        using (SqlDataReader dr = DBHelper.SelectTable(strsql))
         {
            while (dr.Read())
            {
                listAdmin.Add(GetAdmin(dr));
            }
        }

        return listAdmin;
    }
    public static bool GetPassword(string Password)
    {
        string strsql = string.Format("select * from Admin where  Admin_Password='{0}'",Password);
        if (DBHelper.ExecuteScalarSelect(strsql) > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static int UpdateAdmin(M_Admin admin,string Password)
    {
        if (GetPassword(Password))
        {
            string strsql = "update Admin set Admin_Password=@Admin_Password  where Admin_ID=@Admin_ID";
            SqlParameter[] comSql = new SqlParameter[]
            {
              new SqlParameter("@Admin_Password",admin.Admin_Password),
              new SqlParameter("@Admin_ID",admin.Admin_ID)
            };
            return DBHelper.IDUTable(strsql, comSql);
        }
        else
        {
            return 0;
        }
    }
    public static int DeleteAdmin(M_Admin admin)
    {
        string strsql = "delete from Admin  where Admin_ID=@Admin_ID";
        SqlParameter[] comSql = new SqlParameter[]{
            new SqlParameter("@Admin_ID",admin.Admin_ID),
        };
        return DBHelper.IDUTable(strsql, comSql);
    }

    public static M_Admin GetAdmin(SqlDataReader AdminTable)
    {
        M_Admin admin = new M_Admin();
        admin.Admin_ID = (int)AdminTable["Admin_ID"];
        admin.Admin_Name = AdminTable["Admin_Name"].ToString();
        admin.Admin_Password = AdminTable["Admin_Password"].ToString();
        admin.Power = Convert.ToInt32((bool)AdminTable["Power"] ? 1 : 0);
        return admin;
    }
}