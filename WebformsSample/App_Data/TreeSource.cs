using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Web.Script.Serialization;
using Syncfusion.JavaScript;

/// <summary>
/// Summary description for Data
/// </summary>
public class TreeSource
{
    public SqlConnection odc;
    public TreeSource()
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
public class TreeIconsDataSource
{
    public TreeIconsDataSource()
    {}
    public TreeIconsDataSource(int _id, int _parentid, string _text, string _hasChild, string _expanded, string _spriteCssClass)
    {
        this.ID = _id;
        this.ParentID = _parentid;
        this.Text = _text;
        this.HasChild = _hasChild;
        this.Expanded = _expanded;
        this.SpriteCssClass = _spriteCssClass;
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
    [Browsable(true)]
    public string HasChild
    {
        get;
        set;
    }
    [Browsable(true)]
    public string Expanded
    {
        get;
        set;
    }
    [Browsable(true)]
    public string SpriteCssClass
    {
        get;
        set;
    }

    public List<TreeIconsDataSource> GetTreeIconItems()
    {
        List<TreeIconsDataSource> data = new List<TreeIconsDataSource>();
        data.Add(new TreeIconsDataSource(1, 0, "Mail", "true", "true", "mailicon sprite-root"));
        data.Add(new TreeIconsDataSource(2, 1, "Inbox ", "true", "", "mailicon sprite-inbox"));
        data.Add(new TreeIconsDataSource(3, 2, "Development ", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(4, 2, "Supports", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(5, 2, "HR Team ", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(20, 2, "Management", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(21, 2, "Team Meeting", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(6, 1, "Drafts", "true", "", "mailicon sprite-drafts"));
        data.Add(new TreeIconsDataSource(7, 6, "Support template ", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(8, 6, "Personal ", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(9, 1, "Sent items ", "true", "", "mailicon sprite-sentitems"));
        data.Add(new TreeIconsDataSource(10, 9, "Support ", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(22, 9, "HTML JS ", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(23, 9, "Others ", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(24, 1, "Deleted ", "", "", "mailicon sprite-deleted"));
        data.Add(new TreeIconsDataSource(25, 1, "Junk Mails ", "", "", "mailicon sprite-junk"));
        data.Add(new TreeIconsDataSource(26, 1, "Peronal ", "true", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(27, 26, "HR Team ", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(28, 26, "My Works ", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(29, 26, "Login details ", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(11, 0, "Calendar", "true", "", "mailicon sprite-calendar"));
        data.Add(new TreeIconsDataSource(12, 11, "My Calendar ", "", "", "mailicon sprite-calendar"));
        data.Add(new TreeIconsDataSource(13, 11, "Team", "", "", "mailicon sprite-calendar"));
        data.Add(new TreeIconsDataSource(14, 11, "Others", "", "", "mailicon sprite-calendar"));
        data.Add(new TreeIconsDataSource(15, 0, "Notes", "true", "", "mailicon sprite-notes"));
        data.Add(new TreeIconsDataSource(16, 15, "My Reference ", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(17, 15, "Team Meeting", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(18, 15, "Others", "", "", "mailicon sprite-folder"));
        data.Add(new TreeIconsDataSource(30, 0, "Contacts", "true", "", "mailicon sprite-contacts"));
        data.Add(new TreeIconsDataSource(31, 30, "Suggested", "", "", "mailicon sprite-contacts"));
        data.Add(new TreeIconsDataSource(32, 30, "MY Team", "", "", "mailicon sprite-contacts"));
        data.Add(new TreeIconsDataSource(33, 30, "Others", "", "", "mailicon sprite-contacts"));        

        return data;
    }
}
[Serializable]
public class TreeLocalDataSource
    {
       
    public TreeLocalDataSource()
    { }
    public TreeLocalDataSource(int _id, int _parentid, string _text, string _hasChild, string _expanded)
    {
        this.ID = _id;
        this.ParentID = _parentid;
        this.Text = _text;
        this.HasChild = _hasChild;
        this.Expanded = _expanded;
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
    [Browsable(true)]
    public string HasChild
    {
        get;
        set;
    }
    [Browsable(true)]
    public string Expanded
    {
        get;
        set;
    }    
    public List<TreeLocalDataSource> GetTreeDataItems()
    {
        List<TreeLocalDataSource> data = new List<TreeLocalDataSource>();

        data.Add(new TreeLocalDataSource(1, 0, "Discover Music", "true", "true"));
        data.Add(new TreeLocalDataSource(2, 1, "Hot Singles", "", ""));
        data.Add(new TreeLocalDataSource(3, 1, "Rising Artists", "", ""));
        data.Add(new TreeLocalDataSource(4, 1, "Live Music", "", ""));
        data.Add(new TreeLocalDataSource(6, 1, "Best of 2013 So Far", "", ""));
        data.Add(new TreeLocalDataSource(7, 0, "Sales and Events", "true", "true"));
        data.Add(new TreeLocalDataSource(8, 7, "100 Albums - $5 Each", "", ""));
        data.Add(new TreeLocalDataSource(9, 7, "Hip-Hop and R&B Sale", "", ""));
        data.Add(new TreeLocalDataSource(10, 7, "CD Deals", "", ""));
        data.Add(new TreeLocalDataSource(11, 0, "Categories", "true", ""));
        data.Add(new TreeLocalDataSource(12, 11, "Songs", "", ""));
        data.Add(new TreeLocalDataSource(13, 11, "Bestselling Albums", "", ""));
        data.Add(new TreeLocalDataSource(14, 11, "New Releases", "", ""));
        data.Add(new TreeLocalDataSource(15, 11, "Bestselling Songs", "", ""));
        data.Add(new TreeLocalDataSource(16, 0, "MP3 Albums", "true", ""));
        data.Add(new TreeLocalDataSource(17, 16, "Rock", "", ""));
        data.Add(new TreeLocalDataSource(18, 16, "Gospel", "", ""));
        data.Add(new TreeLocalDataSource(19, 16, "Latin Music", "", ""));
        data.Add(new TreeLocalDataSource(20, 16, "Jazz", "", ""));
        data.Add(new TreeLocalDataSource(21, 0, "More in Music", "true", ""));
        data.Add(new TreeLocalDataSource(22, 21, "Music Trade-In", "", ""));
        data.Add(new TreeLocalDataSource(23, 21, "Redeem a Gift Card", "", ""));
        data.Add(new TreeLocalDataSource(24, 21, "Band T-Shirts", "", ""));
        data.Add(new TreeLocalDataSource(25, 21, "Mobile MVC", "", ""));

        return data;
    }
}
[Serializable]
public class TreeOnDemandDataSource
{

    public TreeOnDemandDataSource(int _id, int _parentid, string _text, string _hasChild)
    {
        this.ID = _id;
        this.ParentID = _parentid;
        this.Text = _text;
        this.HasChild = _hasChild;
    }
    public TreeOnDemandDataSource()
    { }
    
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
    [Browsable(true)]
    public string HasChild
    {
        get;
        set;
    }

    public List<TreeOnDemandDataSource> GetTreeItems()
    {
        List<TreeOnDemandDataSource> data = new List<TreeOnDemandDataSource>();
        data.Add(new TreeOnDemandDataSource(1, 0, "Local Disk(C:)", "true"));
        data.Add(new TreeOnDemandDataSource(2, 1, "Folder 1", ""));
        data.Add(new TreeOnDemandDataSource(3, 1, "Folder 2", ""));
        data.Add(new TreeOnDemandDataSource(4, 1, "Folder 3", "true"));
        data.Add(new TreeOnDemandDataSource(5, 4, "File 1", ""));
        data.Add(new TreeOnDemandDataSource(6, 4, "File 2", "true"));
        data.Add(new TreeOnDemandDataSource(7, 6, "File 3", ""));
        data.Add(new TreeOnDemandDataSource(9, 0, "Local Disk(D:)", "true"));
        data.Add(new TreeOnDemandDataSource(10, 9, "Folder 4", "true"));
        data.Add(new TreeOnDemandDataSource(11, 10, "File 4", ""));
        data.Add(new TreeOnDemandDataSource(12, 10, "File 5", ""));
        data.Add(new TreeOnDemandDataSource(13, 10, "File 6", ""));
        data.Add(new TreeOnDemandDataSource(14, 9, "Folder 5", ""));
        data.Add(new TreeOnDemandDataSource(15, 9, "Folder 6", ""));
        data.Add(new TreeOnDemandDataSource(16, 0, "Local Disk(E:)", "true"));
        data.Add(new TreeOnDemandDataSource(17, 16, "Folder 7", "true"));
        data.Add(new TreeOnDemandDataSource(18, 17, "File 7", ""));
        data.Add(new TreeOnDemandDataSource(19, 17, "File 8", ""));
        data.Add(new TreeOnDemandDataSource(20, 17, "File 9", ""));
        data.Add(new TreeOnDemandDataSource(21, 16, "Folder 8", ""));
        data.Add(new TreeOnDemandDataSource(22, 16, "Folder 9", ""));
        return data;
    }    
}
