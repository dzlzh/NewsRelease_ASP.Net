using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// M_Item 的摘要说明
/// </summary>
public class M_Item
{
    /// <summary>
    /// Item表的实体类
    /// </summary>
	public M_Item()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    private int _item_ID;
    private string _item_Name;
    private string _item_Desc;
    private int _item_Order;

    public int Item_ID
    {
        get { return _item_ID; }
        set { _item_ID = value; }
    }
    public string Item_Name
    {
        get { return _item_Name; }
        set { _item_Name = value; }
    }
    public string Item_Desc
    {
        get { return _item_Desc; }
        set { _item_Desc = value; }
    }
    public int Item_Order
    {
        get { return _item_Order; }
        set { _item_Order = value; }
    }
}