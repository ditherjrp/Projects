using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.UI;
using WeatherTest.Type;

namespace WeatherTest
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    calDate.SelectedDate = DateTime.Now;

                    this.getLastForecast(ddlCity.SelectedValue, calDate.SelectedDate);
                }
            }
            catch (Exception excPageLoad)
            {
                lblMessage.Text = excPageLoad.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.getLastForecast(ddlCity.SelectedValue, calDate.SelectedDate);
        }

        private void getLastForecast(string city, DateTime date)
        {
            try
            {
                lblMessage.Text = string.Empty;
                lblMessage.ForeColor = System.Drawing.Color.Black;

                if (date > DateTime.Now)
                    date = DateTime.Now;

                DateTime startDate = date.AddDays(-1);
                DateTime endDate = date;

                List<Datum> D = new List<Datum>();

                WebClient wc = new WebClient();

                for (int x = 15; x > 0; x--)
                {
                    var json = wc.DownloadString("https://api.weatherbit.io/v2.0/history/daily?city=" + city + "&country=Mexico&start_date=" + startDate.ToString("yyyy-MM-dd:HH") + "&end_date=" + endDate.ToString("yyyy-MM-dd:HH") + "&key=3c54ba9f76c94ea997af7e28fd6025cc");

                    var F = JsonConvert.DeserializeObject<Forecast>(json);

                    D.AddRange(F.data);

                    startDate = startDate.AddDays(-1);
                    endDate = endDate.AddDays(-1);
                }
                
                if (D != null && D.Count > 0)
                {
                    ViewState["Data"] = D;

                    if (ddlScale.SelectedValue == "F")
                    {
                        for (int i = 0; i < D.Count; i++)
                        {
                            D[i].temp = ((Convert.ToDouble(D[i].temp) * 9.0 / 5.0) + 32.0).ToString();
                        }
                    }

                    this.fillGridView(D);

                    this.fillGraph(D);
                }
               
            }
            catch (Exception exc)
            {
                lblMessage.Text = exc.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }


        private void fillGridView(List<Datum> D)
        {
            try
            {
                gvwTemperatures.DataSource = D;
                gvwTemperatures.DataBind();
            }
            catch (Exception exc)
            {
                lblMessage.Text = exc.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void fillGraph(List<Datum> D)
        {
            try
            {
                string[] dates = new string[D.Count];
                double[] temps = new double[D.Count];
                int i = 0;
                foreach (Datum d in D)
                {
                    dates[i] = D[i].datetime;
                    temps[i] = Convert.ToDouble(D[i].temp);

                    i++;
                }

                chrtGraph.Series[0].Points.DataBindXY(dates, temps);
                chrtGraph.ChartAreas[0].AxisX.Interval = 1;
            }
            catch (Exception exc)
            {
                lblMessage.Text = exc.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void ddlScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ViewState["Data"] != null)
            {
                List<Datum> D = (List<Datum>)ViewState["Data"];

                if (D != null && D.Count > 0)
                {
                    ViewState["Data"] = D;

                    if (ddlScale.SelectedValue == "F")
                    {
                        for (int i = 0; i < D.Count; i++)
                        {
                            D[i].temp = ((Convert.ToDouble(D[i].temp) * 9.0 / 5.0) + 32.0).ToString();
                        }
                    }

                    this.fillGridView(D);

                    this.fillGraph(D);
                }
            }

        }

        protected void calDate_SelectionChanged(object sender, EventArgs e)
        {
            this.getLastForecast(ddlCity.SelectedValue, calDate.SelectedDate);
        }
    }   
}