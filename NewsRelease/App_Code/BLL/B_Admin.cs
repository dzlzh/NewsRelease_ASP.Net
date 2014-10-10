using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// B_Admin 的摘要说明
/// </summary>
public class B_Admin
{
	public B_Admin()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static M_Admin Verify( M_Admin admin)
    {
       return D_Admin.GetNamePassword(admin);
    }

    public static bool InsertAdmin(M_Admin admin)
    {
        int count = D_Admin.InsertAdmin(admin);
        return count > 0 ? true : false;
    }

    public static List<M_Admin> SelectAdmin()
    {
        return D_Admin.SelectAdmin();
    }

    public static void DeleteAdmin(M_Admin admin)
    {
        D_Admin.DeleteAdmin(admin);
    }

    public static bool UpdateAdmin(M_Admin admin, string Password)
    {
        int count=D_Admin.UpdateAdmin(admin, Password);
        return count > 0 ? true : false;
    }
}