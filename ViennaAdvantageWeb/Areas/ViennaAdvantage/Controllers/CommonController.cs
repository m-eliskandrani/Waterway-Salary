using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VAdvantage.Utility;
using VAT.Models;

namespace VAT.Controllers
{
    //[Authorize]
    public class CommonController : Controller
    {
        //
        // GET: /VAT/Common/
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Save employee
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="name"></param>
        /// <param name="departmentId"></param>
        /// <param name="empGrade"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public JsonResult Save(int employeeId, string name, string departmentId, string empGrade, string date)
        {
            if (Session["Ctx"] != null)
            {
                var ctx = Session["ctx"] as Ctx;
                Employee obj = new Employee();
                var value = obj.Save(ctx, Convert.ToInt32(employeeId), name, Convert.ToInt32(departmentId), empGrade, date);
                return Json(new { result = value }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { result = "ok" }, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Delete employee record
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public JsonResult Delete(int employeeId)
        {
            if (Session["Ctx"] != null)
            {
                var ctx = Session["ctx"] as Ctx;
                Employee obj = new Employee();
                var value = obj.Delete(ctx, employeeId);
                return Json(new { result = value }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { result = "ok" }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDepartmentData()
        {
            Department department = new Department(Session["Ctx"] as Ctx);
            List<VAT_KeyVal> value = department.GetDepartmentData();
            return Json(JsonConvert.SerializeObject(value), JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetEmployeeGrade()
        {
            Department department = new Department(Session["Ctx"] as Ctx);
            List<VAT_KeyVal> value = department.GetEmployeeGrade();
            return Json(JsonConvert.SerializeObject(value), JsonRequestBehavior.AllowGet);
        }

        public JsonResult LoadEmployeeData(int AD_Client_ID)
        {
            Employee employee = new Employee();
            List<VAT_EmployeeData> value = employee.LoadEmployeeData(Session["Ctx"] as Ctx, AD_Client_ID);
            return Json(JsonConvert.SerializeObject(value), JsonRequestBehavior.AllowGet);
        }

    }
}