using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Syncfusion.JavaScript.DataVisualization;
using Syncfusion.JavaScript.DataVisualization.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace WebFormsSample
{
    public partial class CircularGaugeFeatures : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CircularScales scale1 = new CircularScales();
            List<Pointers> pointers = new List<Pointers>();
            Pointers pointer1 = new Pointers();
            pointer1.Value = 0;
            pointer1.Length = 80;
            scale1.Pointers.Add(pointer1);
            scale1.ShowRanges = true;
            scale1.ShowScaleBar = true;
            scale1.Size = 1;
            scale1.Radius = 150;
            
            CircularRanges range1 = new CircularRanges();
            range1.DistanceFromScale = -30;
            range1.StartValue = 0;
            range1.EndValue = 30;

            CircularRanges range2 = new CircularRanges();
            range2.DistanceFromScale = -30;
            range2.StartValue = 30;
            range2.EndValue = 60;
            range2.BackgroundColor = "#fc0606";
            range2.Border.Color = "#fc0606";

            CircularRanges range3 = new CircularRanges();
            range3.DistanceFromScale = -30;
            range3.StartValue = 60;
            range3.EndValue = 100;
            range3.BackgroundColor = "#f5b43f";
            range3.Border.Color = "#f5b43f";

            scale1.Ranges.Add(range1);
            scale1.Ranges.Add(range2);
            scale1.Ranges.Add(range3);

            this.CircularGauge.Scales.Add(scale1);
            this.CircularGauge.BackgroundColor = "transparent";
            this.CircularGauge.EnableAnimation = true;

            String strConnString = ConfigurationManager.ConnectionStrings["DefaultConnection1"].ConnectionString;
            SqlDataReader rt;
            SqlConnection con;
            SqlCommand cmd = new SqlCommand();
            con = new SqlConnection(strConnString);

            cmd.CommandType = CommandType.StoredProcedure;
            //stored procedure command execution
            cmd.CommandText = "GetPointerDetails";
            cmd.Connection = con;
            con.Open();

            // read the returned result form the procedure
            rt = cmd.ExecuteReader();
            if (rt.Read())
            {
                this.CircularGauge.Scales[0].Pointers[0].Value = Convert.ToDouble(rt.GetValue(0));
            }        
            con.Close();
            con.Dispose();          
        }
    }
}
