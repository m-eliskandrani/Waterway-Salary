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

namespace DGM10.Process
{
    public class GENERATEDAYSOFF : SvrProcess
    {
        protected override string DoIt()
        {
            bool SUN, MON, TUE, WED, THU, FRI, SAT;
            Ctx ctx = GetCtx();
            X_VAHRUAE_HR_AttendanceRule x = new X_VAHRUAE_HR_AttendanceRule(GetCtx(), GetRecord_ID(), null);
            SUN = x.IsSUNDAYOFF();
            MON = x.IsMONDAYOFF();
            TUE = x.IsTUESDAYOFF();
            WED = x.IsWEDNESDAYOFF();
            THU = x.IsTHURSDAYOFF();
            FRI = x.IsFRIDAYOFF();
            SAT = x.IsSATURDAYOFF();
            X_VAHRUAE_HR_SHIFT_DAYSOFF s;
            
            // sqlFormattedDate = sqlFormattedDate.Substring(2, sqlFormattedDate.Length);

            DateTime dt = new DateTime(DateTime.Now.Year, 1 , 1);


            while (dt.Year != DateTime.Now.Year + 1)
            {
                if ((SUN && dt.DayOfWeek == DayOfWeek.Sunday) || (MON && dt.DayOfWeek == DayOfWeek.Monday) || (TUE && dt.DayOfWeek == DayOfWeek.Tuesday) || (WED && dt.DayOfWeek == DayOfWeek.Wednesday) || (THU && dt.DayOfWeek == DayOfWeek.Thursday) || (FRI && dt.DayOfWeek == DayOfWeek.Friday) || (SAT && dt.DayOfWeek == DayOfWeek.Saturday))
                {
                    s = new X_VAHRUAE_HR_SHIFT_DAYSOFF(GetCtx(), 0, Get_TrxName());
                    s.SetAD_Client_ID(x.GetAD_Client_ID());
                    s.SetAD_Org_ID(x.GetAD_Org_ID());
                    s.SetIsActive(true);
                    s.SetDAY(dt);
                    s.SetVAHRUAE_HR_AttendanceRule_ID(x.GetVAHRUAE_HR_AttendanceRule_ID());
                    s.SetVAHRUAE_HR_SHIFT_DAYSOFF_ID(GetRecord_ID());
                    

                }
                dt = dt.AddDays(1);
            }
            return "";
        }
      
        protected override void Prepare()
        {

        }
    }
}
