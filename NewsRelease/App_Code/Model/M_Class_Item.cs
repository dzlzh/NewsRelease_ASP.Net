﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// M_Class_Item 的摘要说明
/// </summary>
public class M_Class_Item
{
	public M_Class_Item()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    private int _class_ID;
    private string _class_Name;
    private string _class_Desc;
    //private int _item_ID;
    private string _item_Name;

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

    //public int Item_ID
    //{
    //    get { return _item_ID; }
    //    set { _item_ID = value; }
    //}
    public string Item_Name
    {
        get { return _item_Name; }
        set { _item_Name = value; }
    }
}