using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VAT.Controllers
{
    //restrict access by callers to an action method.
    [Authorize]
    public class EmployeeByViewController : Controller
    {
        //
        // GET: /VAT/EmployeeByView/
        public ActionResult Index(int windowno)
        {
            ViewBag.WindowNumber = windowno;
            return PartialView();
        }
    }
}