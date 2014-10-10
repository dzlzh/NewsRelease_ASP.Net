using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// B_Item 的摘要说明
/// </summary>
public class B_Item
{
	public B_Item()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static bool InsertItem(M_Item item)
    {
        int count = D_Item.InsertItem(item);
        return count > 0 ? true : false;
    }

    public static List<M_Item> SelectItem()
    {
        return D_Item.SelectItem();
    }

    public static void UpdateItem(M_Item item)
    {
        D_Item.UpdateItem(item);
    }

    public static void DeleteItem(M_Item item)
    {
        D_Item.DeleteItem(item);
    }
}