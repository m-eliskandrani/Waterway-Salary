using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using VAdvantage.DataBase;
using VAdvantage.Utility;
using ViennaAdvantageSvc.Model;
//using ViennaAdvantageSvc.Model;

namespace VAT.Models
{
    public class Employee
    {
        /// <summary>
        /// Save records from ajaxe request
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="employeeId"></param>
        /// <param name="name"></param>
        /// <param name="departmentId"></param>
        /// <param name="empGrade"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool Save(Ctx ctx, int employeeId, string name, int departmentId, string empGrade, string date)
        {
            //you can user context parameter but iam not using here.

            //we have two way to update record .You can use any one of them.

            // Method  using Mclass but take care of Your Before save logic here it update record with amount on before save it change

            MVATEmployee obj = new MVATEmployee(ctx, employeeId, null);
            obj.SetName(name);
            obj.SetVAT_Department_ID(departmentId);
            obj.SetVAT_EmployeeGrade(empGrade);
            if (date != "")
            {
                obj.SetV_Date(Convert.ToDateTime(date));
            }
            if (!obj.Save())
            {
                return false;
            }

            //Or
            //Trx trx = Trx.Get(Trx.CreateTrxName("emp"), true);
            //try
            //{
            //    // Method  using sql query
            //    string sql = "update VAT_Employee set Name=@param1,VAT_Department_ID=@param2,VAT_EmployeeGrade= @param3,V_Date=@param4 where VAT_Employee_ID=@param5";
            //    SqlParameter[] param = new SqlParameter[5];
            //    param[0] = new SqlParameter("@param1", name);
            //    param[1] = new SqlParameter("@param2", departmentId);
            //    param[2] = new SqlParameter("@param3", empGrade);
            //    param[3] = new SqlParameter("@param4", date);
            //    param[4] = new SqlParameter("@param5", employeeId);

            //    if (VAdvantage.DataBase.DB.ExecuteQuery(sql, param, trx.GetTrxName()) < 0)
            //    {
            //        trx.Rollback();
            //        trx.Close();
            //        trx = null;
            //        return false;
            //    }
            //    trx.Commit();
            //    trx.Close();
            //    trx = null;
            //    return true;
            //}
            //catch
            //{
            //    if (trx != null)
            //    {
            //        trx.Rollback();
            //    }
            //}

            return true;
        }

        /// <summary>
        /// Delete records from from
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public bool Delete(Ctx ctx, int employeeId)
        {
            MVATEmployee obj = new MVATEmployee(ctx, employeeId, null);
            if (!obj.Delete(true))
            {
                return false;
            }
            return true;
        }

        public List<VAT_EmployeeData> LoadEmployeeData(Ctx ctx, int AD_Client_ID)
        {
            List<VAT_EmployeeData> empData = new List<VAT_EmployeeData>();
            string sql = "SELECT e.VAT_Employee_ID,e.name,d.vat_departmentname,e.vat_employeegrade,e.v_date,e.vat_department_id  FROM vat_employee e" +
                      " LEFT OUTER JOIN vat_department d ON d.vat_department_id=e.vat_department_id  WHERE e.ad_client_id=" + AD_Client_ID;
            var dr = DB.ExecuteReader(sql);
            if (dr != null)
            {
                while (dr.Read())
                {
                    VAT_EmployeeData eData = new VAT_EmployeeData();
                    eData.EmpID = Util.GetValueOfInt(dr["VAT_Employee_ID"]);
                    eData.Name = Util.GetValueOfString(dr["Name"]);
                    eData.DepName = Util.GetValueOfString(dr["VAT_DepartmentName"]);
                    eData.Grade = Util.GetValueOfString(dr["VAT_EmployeeGrade"]);
                    eData.Date = Util.GetValueOfDateTime(dr["v_date"]);
                    eData.DepID = Util.GetValueOfInt(dr["VAT_department_ID"]);
                    empData.Add(eData);
                }
                dr.Close();
                dr = null;
            }
            return empData;
        }
    }

    public class VAT_EmployeeData
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string DepName { get; set; }
        public string Grade { get; set; }
        public DateTime? Date { get; set; }
        public int DepID { get; set; }
    }

}