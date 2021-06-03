using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VAdvantage.DataBase;
using VAdvantage.Model;
using VAdvantage.Utility;

namespace VAT.Models
{
    public class Department
    {
        Ctx _ctx;
        public Department(Ctx ctx)
        {
            _ctx = ctx;
        }

        public List<VAT_KeyVal> GetDepartmentData()
        {
            List<VAT_KeyVal> departments = new List<VAT_KeyVal>();
            string sql = "SELECT vat_department_id,vat_departmentname FROM VAT_Department WHERE isactive='Y'";
            sql = MRole.GetDefault(_ctx).AddAccessSQL(sql, "VAT_Department", true, true);
            var dr = DB.ExecuteReader(sql);
            if (dr != null)
            {
                while (dr.Read())
                {
                    VAT_KeyVal dep = new VAT_KeyVal();
                    dep.ID = Util.GetValueOfString(dr["vat_department_id"]);
                    dep.Value = Util.GetValueOfString(dr["vat_departmentname"]);
                    departments.Add(dep);
                }
                dr.Close();
                dr = null;
            }
            return departments;
        }


        public List<VAT_KeyVal> GetEmployeeGrade()
        {
            List<VAT_KeyVal> grades = new List<VAT_KeyVal>();
            string sql = "SELECT value,name FROM ad_ref_list WHERE ad_reference_id=(SELECT ad_reference_id FROM ad_reference WHERE name='VAT_EmployeeGrade')";
            var dr = DB.ExecuteReader(sql);
            if (dr != null)
            {
                while (dr.Read())
                {
                    VAT_KeyVal grade = new VAT_KeyVal();
                    grade.ID = Util.GetValueOfString(dr["value"]);
                    grade.Value = Util.GetValueOfString(dr["name"]);
                    grades.Add(grade);
                }
                dr.Close();
                dr = null;
            }

            return grades;
        }

    }

    public class VAT_KeyVal
    {
        public string Value { get; set; }
        public string ID { get; set; }
    }

}