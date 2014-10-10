using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// M_Class 的摘要说明
/// </summary>
public class M_Class
{
    /// <summary>
    /// Class表的实体类
    /// </summary>
	public M_Class()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    private int _class_ID;
    private string _class_Name;
    private string _class_Desc;
    private int _class_Order;
    private int _item_ID;

    public int Class_ID
    {
        get { return _class_ID; }
        set { _class_ID = value; }
    }
    public string Class_Name
    {
        get { return _class_Name; }
        set { _class_Name = value; }
    }

    public string Class_Desc
    {
        get { return _class_Desc; }
        set { _class_Desc = value; }
    }
    public int Class_Order
    {
        get { return _class_Order; }
        set { _class_Order = value; }
    }
    public int Item_ID
    {
        get { return _item_ID; }
        set { _item_ID = value; }
    }
}