using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// M_Popedom 的摘要说明
/// </summary>
public class M_Popedom
{
	public M_Popedom()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    private int _popedom_ID;
    public int Popedom_ID
    {
        get { return _popedom_ID; }
        set { _popedom_ID = value; }
    }
    private int _class_ID;
    public int Class_ID
    {
        get { return _class_ID; }
        set { _class_ID = value; }
    }
    private int _admin_ID;
    public int Admin_ID
    {
        get { return _admin_ID; }
        set { _admin_ID = value; }
    }
}