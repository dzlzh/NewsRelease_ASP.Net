using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// M_News 的摘要说明
/// </summary>
public class M_News
{
	public M_News()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    private int _news_ID;
    private string _news_Title;
    private int _class_ID;
    private DateTime _news_Date;
    private string _news_Key;
    private string _news_Ource;
    private string _news_Content;
    private int _admin_ID;
    private int? _hits=0;
    private int? _monthhits=0;

    public int News_ID
    {
        get { return _news_ID; }
        set { _news_ID = value; }
    }

    public string News_Title
    {
        get { return _news_Title; }
        set { _news_Title = value; }
    }

    public int Class_ID
    {
        get { return _class_ID; }
        set { _class_ID = value; }
    }

    public DateTime News_Date
    {
        get { return _news_Date; }
        set { _news_Date = value; }
    }

    public string News_Key
    {
        get { return _news_Key; }
        set { _news_Key = value; }
    }

    public string News_Ource
    {
        get { return _news_Ource; }
        set { _news_Ource = value; }
    }

    public string News_Content
    {
        get { return _news_Content; }
        set { _news_Content = value; }
    }

    public int Admin_ID
    {
        get { return _admin_ID; }
        set { _admin_ID = value; }
    }

    public int? Hits
    {
        get { return _hits; }
        set { _hits = value; }
    }

    public int? Monthhits
    {
        get { return _monthhits; }
        set { _monthhits = value; }
    }
}