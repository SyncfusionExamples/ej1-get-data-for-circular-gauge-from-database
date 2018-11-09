#region Copyright
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml;



public class ScheduleAppointmentsObjDatum
{

    [DataObjectMethod(DataObjectMethodType.Select)]
    public List<ScheduleAppointmentsObjData> GetRecords()
    {

        List<ScheduleAppointmentsObjData> list = new List<ScheduleAppointmentsObjData>();
        list.Add(new ScheduleAppointmentsObjData("100", "Bering Sea Gold", "chn", "5/2/2014 9:00:00 AM", "5/2/2014 10:30:00 AM", "", "1", "", "1", "", "", "", "", false, "", "", "FREQ=DAILY;INTERVAL=2;COUNT=10"));
        list.Add(new ScheduleAppointmentsObjData("101", "Bering Sea Gold", "mum", "5/2/2014 4:00:00 AM", "5/2/2014 5:00:00 AM", "", "1", "", "0", "", "", "", "", false, "", "", ""));
        list.Add(new ScheduleAppointmentsObjData("102", "Bering Sea Gold", "trcy", "5/2/2014 4:00:00 PM", "5/2/2014 5:30:00 PM", "", "1", "", "0", "", "", "", "", false, "", "", ""));
        list.Add(new ScheduleAppointmentsObjData("103", "What Happened Next?", "chn", "5/4/2014 3:00:00 AM", "5/4/2014 4:30:00 AM", "", "1", "", "0", "", "", "", "", false, "", "", ""));
        list.Add(new ScheduleAppointmentsObjData("104", "Bering Sea Gold", "trcy", "5/4/2014 5:00:00 AM", "5/4/2014 5:40:00 AM", "", "1", "", "0", "", "", "", "", false, "", "", ""));
        list.Add(new ScheduleAppointmentsObjData("105", "Daily Planet", "chn", "5/3/2014 1:00:00 AM", "5/3/2014 2:00:00 AM", "", "1", "", "0", "", "", "", "", false, "", "", ""));
        list.Add(new ScheduleAppointmentsObjData("106", "Alaska: The Last Frontier", "chn", "5/3/2014 4:00:00 AM", "5/3/2014 5:00:00 AM", "", "1", "", "0", "", "", "", "", false, "", "", ""));
        list.Add(new ScheduleAppointmentsObjData("107", "How It's Made", "chn", "5/1/2014 6:00:00 AM", "5/1/2014 6:30:00 AM", "", "1", "", "1", "", "", "", "", false, "", "", "FREQ=WEEKLY;BYDAY=MO,TU;INTERVAL=1;COUNT=15"));
        list.Add(new ScheduleAppointmentsObjData("108", "Deadest Catch", "chn", "5/3/2014 4:00:00 PM", "5/3/2014 5:00:00 PM", "", "1", "", "0", "", "", "", "", false, "", "", ""));
        list.Add(new ScheduleAppointmentsObjData("109", "MayDay", "chn", "4/30/2014 6:30:00 AM", "4/30/2014 7:30:00 AM", "", "1", "", "0", "", "", "", "", false, "", "", ""));
        list.Add(new ScheduleAppointmentsObjData("110", "MoonShiners", "chn", "5/2/2014 2:00:00 AM", "5/2/2014 2:30:00 AM", "", "1", "", "1", "", "", "", "", false, "", "", "FREQ=DAILY;INTERVAL=1;COUNT=5"));
        list.Add(new ScheduleAppointmentsObjData("111", "Close Encounters", "chn", "4/30/2014 2:00:00 PM", "4/30/2014 3:00:00 PM", "", "1", "", "1", "", "", "", "", false, "", "", "FREQ=WEEKLY;BYDAY=MO,TH;INTERVAL=1;COUNT=5"));
        list.Add(new ScheduleAppointmentsObjData("112", "Close Encounters", "mum", "4/30/2014 3:00:00 AM", "4/30/2014 3:30:00 AM", "", "1", "", "1", "", "", "", "", false, "", "", "FREQ=WEEKLY;BYDAY=WE;INTERVAL=1;COUNT=3"));
        list.Add(new ScheduleAppointmentsObjData("113", "Highway Thru Hell", "chn", "5/1/2014 3:00:00 AM", "5/1/2014 7:00:00 AM", "", "1", "", "1", "", "", "", "", false, "", "", "FREQ=DAILY;INTERVAL=2;COUNT=10"));
        list.Add(new ScheduleAppointmentsObjData("114", "Moon Shiners", "chn", "5/2/2014 4:20:00 AM", "5/2/2014 5:50:00 AM", "", "1", "", "0", "", "", "", "", false, "", "", ""));
        list.Add(new ScheduleAppointmentsObjData("115", "Cash Cab", "chn", "4/30/2014 3:00:00 PM", "4/30/2014 4:30:00 PM", "", "1", "", "1", "", "", "", "", false, "", "", "FREQ=DAILY;INTERVAL=1;COUNT=5"));
        return list;

    }

}

[Serializable]
public class ScheduleAppointmentsObjData
{
    public String _id;
    public String _subject;
    public String _location;
    public String _startTime;
    public String _endTime;
    public String _description;
    public String _owner;
    public String _priority;
    public String _recurrence;
    public String _recurrenceType;
    public String _recurrenceTypeCount;
    public String _remainderCategorize;
    public String _customStyle;
    public Boolean _allDay;
    public String _recurrenceStartDate;
    public String _recurrenceEndDate;
    public String _recurrenceRule;


    public ScheduleAppointmentsObjData(string _id, string _subject, string _location, string _startTime, string _endTime, string _description, string _owner, string _priority, string _recurrence, string _recurrenceType, string _recurrenceTypeCount, string _remainderCategorize, string _customStyle, bool _allDay, string _recurrenceStartDate, string _recurrenceEndDate, string _recurrenceRule)
    {
        this._id=_id;
        this._subject=_subject;
        this._location=_location;
        this._startTime=_startTime;
        this._endTime=_endTime;
        this._description=_description;
        this._owner=_owner;
        this._priority=_priority;
        this._recurrence=_recurrence;;
        this._recurrenceType=_recurrenceType;
        this._recurrenceTypeCount=_recurrenceTypeCount;
        this._remainderCategorize=_remainderCategorize;
        this._customStyle=_customStyle;
        this._allDay=_allDay;
        this._recurrenceStartDate=_recurrenceStartDate;
        this._recurrenceEndDate=_recurrenceEndDate;
        this._recurrenceRule = _recurrenceRule;
    }

    public string ID
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }

    public string Subject
    {
        get
        {
            return _subject;
        }
        set
        {
            _subject = value;
        }
    }
    public string Location
    {
        get
        {
            return _location;
        }
        set
        {
            _location = value;
        }
    }
    public string StartTime
    {
        get
        {
            return _startTime;
        }
        set
        {
            _startTime = value;
        }
    }
    public string EndTime
    {
        get
        {
            return _endTime;
        }
        set
        {
            _endTime = value;
        }
    }
    public string Description
    {
        get
        {
            return _description;
        }
        set
        {
            _description = value;
        }
    }
    public string Owner
    {
        get
        {
            return _owner;
        }
        set
        {
            _owner = value;
        }
    }
    public string Priority
    {
        get
        {
            return _priority;
        }
        set
        {
            _priority = value;
        }
    }
    public string Recurrence
    {
        get
        {
            return _recurrence;
        }
        set
        {
            _recurrence = value;
        }
    }
    public string RecurrenceType
    {
        get
        {
            return _recurrenceType;
        }
        set
        {
            _recurrenceType = value;
        }
    }
    public string RecurrenceTypeCount
    {
        get
        {
            return _recurrenceTypeCount;
        }
        set
        {
            _recurrenceTypeCount = value;
        }
    }
    public string RemainderCategorize
    {
        get
        {
            return _remainderCategorize;
        }
        set
        {
            _remainderCategorize = value;
        }
    }
    public string CustomStyle
    {
        get
        {
            return _customStyle;
        }
        set
        {
            _customStyle = value;
        }
    }
    public Boolean AllDay
    {
        get
        {
            return _allDay;
        }
        set
        {
            _allDay = value;
        }
    }
    public string RecurrenceStartDate
    {
        get
        {
            return _recurrenceStartDate;
        }
        set
        {
            _recurrenceStartDate = value;
        }
    }
    public string RecurrenceEndDate
    {
        get
        {
            return _recurrenceEndDate;
        }
        set
        {
            _recurrenceEndDate = value;
        }
    }
    public string RecurrenceRule
    {
        get
        {
            return _recurrenceRule;
        }
        set
        {
            _recurrenceRule = value;
        }
    }
    
}