using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Web.Script.Serialization;
using Syncfusion.JavaScript.DataVisualization.Maps;

/// <summary>
/// Summary description for Data
/// </summary>
public class Data
{
    public SqlConnection odc;
    public Data()
	{
        
        odc = new SqlConnection();
        
        odc.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True";
    }
    public DataSet GetRecords()
    {

        DataSet ds = new DataSet();

        //try
        {
            odc.Open();
            SqlDataAdapter odda = new SqlDataAdapter("select * from [DataSource]", odc);
            odda.Fill(ds, "DataSource");
        }
        //catch (Exception e)
        //{
        //    throw new Exception(e.Message);

        //}
        return ds;
    }
}

[Serializable]
public class TabData
{

    public TabData(int _id, int _parentid, string _text)
    {
        this.ID = _id;
        this.ParentID = _parentid;
        this.Text = _text;
    }
    public TabData()
    {

    }

    [Browsable(true)]
    public int ID
    {
        get;
        set;
    }

    [Browsable(true)]
    public int ParentID
    {
        get;
        set;
    }

    [Browsable(true)]
    public string Text
    {
        get;
        set;
    }


    public List<TabData> GetTabItems()
    {
        List<TabData> data = new List<TabData>();
        data.Add(new TabData(1, 0, "Railways"));
        data.Add(new TabData(2, 0, "Roadways"));
        data.Add(new TabData(3, 0, "Airways"));
        data.Add(new TabData(4, 0, "Waterways"));
        data.Add(new TabData(5, 1, "Electric Trains"));
        data.Add(new TabData(6, 1, "Diesel Trains"));
        data.Add(new TabData(7, 2, "Heavy Motor Vehicles"));
        data.Add(new TabData(8, 2, "Light Motor Vehicles"));
        data.Add(new TabData(9, 3, "Aeroplanes"));
        data.Add(new TabData(10, 3, "Helicopters"));
        data.Add(new TabData(11, 4, "Ships"));
        data.Add(new TabData(12, 4, "Submarines"));

        return data;
    }
}

[Serializable]
public class ToolData
{

    public ToolData(string _id, string _css, string _tip)
    {
        this.ID = _id;
        this.Tooltip = _tip;
        this.Css = _css;
    }
    public ToolData()
    {

    }

    [Browsable(true)]
    public string ID
    {
        get;
        set;
    }

    [Browsable(true)]
    public string Css
    {
        get;
        set;
    }

    [Browsable(true)]
    public string Tooltip
    {
        get;
        set;
    }



    public List<ToolData> GetToolItems()
    {
        List<ToolData> data = new List<ToolData>();
        data.Add(new ToolData("1", "mailtools movetofolder", "Mail"));
        data.Add(new ToolData("2", "mailtools categorize", "Scheduler"));
        data.Add(new ToolData("3", "mailtools flag", "Calculator"));
        data.Add(new ToolData("4", "mailtools forward", "Sticky Notes"));
        data.Add(new ToolData("5", "mailtools newmail", "Calendar"));
        data.Add(new ToolData("6", "mailtools reply", "Notes"));
        data.Add(new ToolData("7", "mailtools done", "Delete"));
        return data;
    }
}


[Serializable]
public class AutoData
{

    public AutoData(string _text, string _spriteCss)
    {

        this.text = _text;
        this.sprite = _spriteCss;
    }
    public AutoData()
    {

    }

    [Browsable(true)]
    public string text
    {
        get;
        set;
    }

    [Browsable(true)]
    public string sprite
    {
        get;
        set;
    }


    public List<AutoData> GetAutoDataItems()
    {
        List<AutoData> data = new List<AutoData>();

        data.Add(new AutoData("Algeria", "flag-dz"));
        data.Add(new AutoData("Argentina", "flag-ar"));
        data.Add(new AutoData("Armenia", "flag-am"));
        data.Add(new AutoData("Brazil", "flag-br"));
        data.Add(new AutoData("Bangladesh", "flag-bd"));
        data.Add(new AutoData("Canada", "flag-ca"));
        data.Add(new AutoData("Cuba", "flag-cu"));
        data.Add(new AutoData("China", "flag-cn"));
        data.Add(new AutoData("Denmark", "flag-dk"));
        data.Add(new AutoData("Estonia", "flag-ee"));
        data.Add(new AutoData("Egypt", "flag-eg"));
        data.Add(new AutoData("France", "flag-fr"));
        data.Add(new AutoData("Finland", "flag-fi"));
        data.Add(new AutoData("Greenland", "flag-gl"));
        data.Add(new AutoData("India", "flag-in"));
        data.Add(new AutoData("Indonesia", "flag-id"));
        data.Add(new AutoData("Malaysia", "flag-my"));
        data.Add(new AutoData("Mexico", "flag-mx"));
        data.Add(new AutoData("New Zealand", "flag-nz"));
        data.Add(new AutoData("Netherlands", "flag-nl"));
        data.Add(new AutoData("Norway", "flag-no"));
        data.Add(new AutoData("Portugal", "flag-pt"));
        data.Add(new AutoData("Poland", "flag-pl"));
        data.Add(new AutoData("Qatar", "flag-qa"));
        return data;
    }
}

[Serializable]
public class RotatorData
{

    public RotatorData(string _caption, string _url)
    {
        this.Caption = _caption;
        this.Url = _url;
        
    }
    public RotatorData()
    {

    }

    [Browsable(true)]
    public string Caption
    {
        get;
        set;
    }

    [Browsable(true)]
    public string Url
    {
        get;
        set;
    }


    public List<RotatorData> GetRotatorItems()
    {
        List<RotatorData> data = new List<RotatorData>();
        data.Add(new RotatorData("Beautiful Bird", "../Content/images/rotator/bird.jpg"));
        data.Add(new RotatorData("Colorful Night", "../Content/images/rotator/night.jpg"));
        data.Add(new RotatorData("Technology", "../Content/images/rotator/tablet.jpg"));
        data.Add(new RotatorData("Nature", "../Content/images/rotator/nature.jpg"));
        data.Add(new RotatorData("Snow Fall", "../Content/images/rotator/snowfall.jpg"));
        data.Add(new RotatorData("Credit Card", "../Content/images/rotator/card.jpg"));
        return data;
    }
}
[Serializable]
public class TagCloudData
{

    public TagCloudData(string _text, string _url, int _frequency)
    {
        this.text = _text;
        this.url = _url;
        this.frequency = _frequency;

    }
    public TagCloudData()
    {

    }


    public string text
    {
        get;
        set;
    }


    public string url
    {
        get;
        set;
    }

    public int frequency
    {
        get;
        set;
    }


    public List<TagCloudData> GetTagCloudItems()
    {
        List<TagCloudData> data = new List<TagCloudData>();
        data.Add(new TagCloudData("Hindustan Motors", "http://www.zigwheels.com/newcars/Hindustan-Motors", 10));
        data.Add(new TagCloudData("Bentley Continental ", "http://www.zigwheels.com/newcars/Bentley/Continental", 3));
        data.Add(new TagCloudData("BMW 7", "http://www.zigwheels.com/newcars/BMW/7-Series", 4));
        data.Add(new TagCloudData("Bugatti Veyron", "http://www.zigwheels.com/newcars/Bugatti/Veyron", 2));
        data.Add(new TagCloudData("Honda", "http://www.zigwheels.com/newcars/Honda", 3));
        data.Add(new TagCloudData("Chevrolet Beat", "http://www.zigwheels.com/newcars/Chevrolet/Beat", 7));
        return data;
    }
    public List<TagCloudData> GetRtlTagCloudItems()
    {
        List<TagCloudData> data = new List<TagCloudData>();
        data.Add(new TagCloudData("جوجل", "http://www.google.com", 12));
        data.Add(new TagCloudData("كل الأشياء الرقمية",  "http://allthingsd.com/", 3));
        data.Add(new TagCloudData("الفنون تكنيكا", "http://arstechnica.com/", 8));
        data.Add(new TagCloudData("بيزنس ويك", "http://www.businessweek.com/", 2));
        data.Add(new TagCloudData("ياهو",  "http://in.yahoo.com/", 12));
        data.Add(new TagCloudData("مركز الشبكات",  "http://www.centernetworks.com/", 5));
        return data;
    }
}
