using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// M_Admin 的摘要说明
/// </summary>
public class M_Admin
{
    /// <summary>
    ///  Admin表的实体类
    /// </summary>
	public M_Admin()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    private int _admin_ID;
    private string _admin_Name;
    private string _admin_Password;
    private int? _power = 0;

    public int Admin_ID
    {
        get { return _admin_ID; }
        set { _admin_ID = value; }
    }
    public string Admin_Name
    {
        get { return _admin_Name; }
        set { _admin_Name = value; }
    }
    public string Admin_Password
    {
        get { return _admin_Password; }
        set { _admin_Password = value; }
    }
    public int? Power
    {
        get { return _power; }
        set { _power = value; }
    }
}