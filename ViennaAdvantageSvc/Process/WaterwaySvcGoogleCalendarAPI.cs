using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAdvantage.DataBase;
using VAdvantage.Logging;
using VAdvantage.Model;
using VAdvantage.ProcessEngine;
using VAdvantage.Utility;
using DGM10.Model;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAdvantage.DataBase;
using VAdvantage.Logging;
using VAdvantage.Model;
using VAdvantage.ProcessEngine;
using VAdvantage.Utility;
using DGM10.Model;
using System.IO;
using System.Threading;
using VAdvantage.Classes;
using DGM10.Model;
using ViennaAdvantage.Model;
namespace DGM10.Process
{
    public class WaterwaySvcGoogleCalendarAPI : SvrProcess
    {
       
        const string ApiKey = "AIzaSyDdOTnahaZgFWPBNQGUO-Rtz_neWDty_4s";
        const string CalendarId = "en.eg#holiday@group.v.calendar.google.com";
        protected override string DoIt()
        {

            {

                var service = new CalendarService(new BaseClientService.Initializer()
                {
                    ApiKey = ApiKey,
                    ApplicationName = "Mori"
                });
                X_VAHRUAE_HR_Holidays holi;
                var request = service.Events.List(CalendarId);
                request.Fields = "items(summary,start)";
                request.TimeMin = new DateTime(DateTime.Now.Year, 1, 1);
                request.TimeMax = new DateTime(DateTime.Now.Year, 12, 31);
                var response = request.Execute();
                //throw new Exception(request.ToString());
                string sql;
                WaterwaySvcGoogleCalendarAPI GA = new WaterwaySvcGoogleCalendarAPI();

                var ADCID = GA.GetCtx().GetAD_Client_ID();
                var ADOID = GA.GetCtx().GetAD_Org_ID();
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
                int count = 0;
                string[] monthNames = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN",
                "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"
            };
                int mn = int.Parse(sqlFormattedDate.Substring(5, 2));
                sqlFormattedDate = sqlFormattedDate.Remove(5, 2);
                sqlFormattedDate = sqlFormattedDate.Insert(5, monthNames[mn - 1]);
                // sqlFormattedDate = sqlFormattedDate.Substring(2, sqlFormattedDate.Length);
                sqlFormattedDate = sqlFormattedDate.Substring(9, 2) + "-" + sqlFormattedDate.Substring(5, 3) + "-" + sqlFormattedDate.Substring(0, 4);
                while (count < response.Items.Count())
                {
                    string holdate = response.Items.ElementAt(count).Start.Date.Substring(0, 10);
                    mn = int.Parse(holdate.Substring(5, 2));
                    holdate = holdate.Remove(5, 2);
                    holdate = holdate.Insert(5, monthNames[mn]);
                    holdate = holdate.Substring(9, 2) + "-" + holdate.Substring(5, 3) + "-" + holdate.Substring(0, 4);
                    holi = new X_VAHRUAE_HR_Holidays(GetCtx(), 0, null) ;
                    holi.SetVAHRUAE_Date1(DateTime.Parse(response.Items.ElementAt(count).Start.Date));
                    holi.SetVAHRUAE_HolidayName(response.Items[count].Summary);
                    holi.SetVAHRUAE_PublicHoliday(true);
                    holi.SetAD_Client_ID(GetAD_Client_ID());
                    holi.SetAD_Org_ID(GetAD_Org_ID());
                    if (!holi.Save())
                        throw new Exception("WHY");
                    //sql = "INSERT INTO VAHRUAE_HR_Holidays (AD_CLIENT_ID, AD_ORG_ID, CREATED, CREATEDBY, ISACTIVE, UPDATED, UPDATEDBY, VAHRUAE_DATE1, VAHRUAE_HOLIDAYNAME, VAHRUAE_HR_HOLIDAYMASTER_ID) VALUES (" + ADCID + ", " + ADOID + ", '" + sqlFormattedDate + "', " + ADCID + ", 'Y', '" + sqlFormattedDate + "', " + ADCID + ", '" + holdate + "', '" + response.Items[count].Summary + "', 0 )";
                    // throw new Exception(sql);
                    //DB.ExecuteScalar(sql);
                    //Console.WriteLine($"Holiday: {item.Summary} start: {item.Start} end: {item.End}");
                    count++;
                }
            }
            return "";
        }
        protected override void Prepare()
        {

        }
    }
}
