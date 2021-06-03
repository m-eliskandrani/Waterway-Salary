using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VAdvantage.DataBase;
using VAdvantage.Utility;

namespace VAT.Controllers
{
    public class CalloutController : Controller
    {
        //
        // GET: /VAT/Callout/
        public ActionResult Index()
        {
            return View();
        }

        public ContentResult GetDepartmentCode(int depID)
        {
            string sql = "SELECT VAT_DepartmentCode From VAT_Department Where VAT_Department_ID=" + depID;
            return Content(Util.GetValueOfString(DB.ExecuteScalar(sql)));
        }


    }
}