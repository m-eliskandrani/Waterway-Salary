namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_MonthlyAttendance
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_MonthlyAttendance : PO{public X_VAHRUAE_MonthlyAttendance (Context ctx, int VAHRUAE_MonthlyAttendance_ID, Trx trxName) : base (ctx, VAHRUAE_MonthlyAttendance_ID, trxName){/** if (VAHRUAE_MonthlyAttendance_ID == 0){SetVAHRUAE_MonthlyAttendance_ID (0);} */
}public X_VAHRUAE_MonthlyAttendance (Ctx ctx, int VAHRUAE_MonthlyAttendance_ID, Trx trxName) : base (ctx, VAHRUAE_MonthlyAttendance_ID, trxName){/** if (VAHRUAE_MonthlyAttendance_ID == 0){SetVAHRUAE_MonthlyAttendance_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_MonthlyAttendance (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_MonthlyAttendance (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_MonthlyAttendance (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_MonthlyAttendance(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27899993460415L;/** Last Updated Timestamp 4/8/2021 9:49:03 AM */
public static long updatedMS = 1617868143626L;/** AD_Table_ID=1000810 */
public static int Table_ID; // =1000810;
/** TableName=VAHRUAE_MonthlyAttendance */
public static String Table_Name="VAHRUAE_MonthlyAttendance";
protected static KeyNamePair model;protected Decimal accessLevel = new Decimal(3);/** AccessLevel
@return 3 - Client - Org 
*/
protected override int Get_AccessLevel(){return Convert.ToInt32(accessLevel.ToString());}/** Load Meta Data
@param ctx context
@return PO Info
*/
protected override POInfo InitPO (Context ctx){POInfo poi = POInfo.GetPOInfo (ctx, Table_ID);return poi;}/** Load Meta Data
@param ctx context
@return PO Info
*/
protected override POInfo InitPO (Ctx ctx){POInfo poi = POInfo.GetPOInfo (ctx, Table_ID);return poi;}/** Info
@return info
*/
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_MonthlyAttendance[").Append(Get_ID()).Append("]");return sb.ToString();}
/** C_Period_ID AD_Reference_ID=1000237 */
public static int C_PERIOD_ID_AD_Reference_ID=1000237;/** Set Period.
@param C_Period_ID Period of the Calendar */
public void SetC_Period_ID (int C_Period_ID){if (C_Period_ID <= 0) Set_Value ("C_Period_ID", null);else
Set_Value ("C_Period_ID", C_Period_ID);}/** Get Period.
@return Period of the Calendar */
public int GetC_Period_ID() {Object ii = Get_Value("C_Period_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Year.
@param C_Year_ID Calendar Year */
public void SetC_Year_ID (int C_Year_ID){if (C_Year_ID <= 0) Set_Value ("C_Year_ID", null);else
Set_Value ("C_Year_ID", C_Year_ID);}/** Get Year.
@return Calendar Year */
public int GetC_Year_ID() {Object ii = Get_Value("C_Year_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Processed.
@param Processed The document has been processed */
public void SetProcessed (Boolean Processed){Set_Value ("Processed", Processed);}/** Get Processed.
@return The document has been processed */
public Boolean IsProcessed() {Object oo = Get_Value("Processed");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Comments.
@param VAHRUAE_Comments Comments */
public void SetVAHRUAE_Comments (String VAHRUAE_Comments){if (VAHRUAE_Comments != null && VAHRUAE_Comments.Length > 500){log.Warning("Length > 500 - truncated");VAHRUAE_Comments = VAHRUAE_Comments.Substring(0,500);}Set_Value ("VAHRUAE_Comments", VAHRUAE_Comments);}/** Get Comments.
@return Comments */
public String GetVAHRUAE_Comments() {return (String)Get_Value("VAHRUAE_Comments");}/** Set From Date.
@param VAHRUAE_FromDate From Date */
public void SetVAHRUAE_FromDate (DateTime? VAHRUAE_FromDate){Set_Value ("VAHRUAE_FromDate", (DateTime?)VAHRUAE_FromDate);}/** Get From Date.
@return From Date */
public DateTime? GetVAHRUAE_FromDate() {return (DateTime?)Get_Value("VAHRUAE_FromDate");}/** Set Generate Attendance.
@param VAHRUAE_GenerateAttendence Generate Attendance */
public void SetVAHRUAE_GenerateAttendence (String VAHRUAE_GenerateAttendence){if (VAHRUAE_GenerateAttendence != null && VAHRUAE_GenerateAttendence.Length > 50){log.Warning("Length > 50 - truncated");VAHRUAE_GenerateAttendence = VAHRUAE_GenerateAttendence.Substring(0,50);}Set_Value ("VAHRUAE_GenerateAttendence", VAHRUAE_GenerateAttendence);}/** Get Generate Attendance.
@return Generate Attendance */
public String GetVAHRUAE_GenerateAttendence() {return (String)Get_Value("VAHRUAE_GenerateAttendence");}/** Set Attendance.
@param VAHRUAE_MonthlyAttendance_ID Attendance */
public void SetVAHRUAE_MonthlyAttendance_ID (int VAHRUAE_MonthlyAttendance_ID){if (VAHRUAE_MonthlyAttendance_ID < 1) throw new ArgumentException ("VAHRUAE_MonthlyAttendance_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_MonthlyAttendance_ID", VAHRUAE_MonthlyAttendance_ID);}/** Get Attendance.
@return Attendance */
public int GetVAHRUAE_MonthlyAttendance_ID() {Object ii = Get_Value("VAHRUAE_MonthlyAttendance_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Process Now.
@param VAHRUAE_Processing Process Now */
public void SetVAHRUAE_Processing (String VAHRUAE_Processing){if (VAHRUAE_Processing != null && VAHRUAE_Processing.Length > 1){log.Warning("Length > 1 - truncated");VAHRUAE_Processing = VAHRUAE_Processing.Substring(0,1);}Set_Value ("VAHRUAE_Processing", VAHRUAE_Processing);}/** Get Process Now.
@return Process Now */
public String GetVAHRUAE_Processing() {return (String)Get_Value("VAHRUAE_Processing");}/** Set ReOpen Attendance.
@param VAHRUAE_ReOpen_Attend ReOpen Attendance */
public void SetVAHRUAE_ReOpen_Attend (String VAHRUAE_ReOpen_Attend){if (VAHRUAE_ReOpen_Attend != null && VAHRUAE_ReOpen_Attend.Length > 1){log.Warning("Length > 1 - truncated");VAHRUAE_ReOpen_Attend = VAHRUAE_ReOpen_Attend.Substring(0,1);}Set_Value ("VAHRUAE_ReOpen_Attend", VAHRUAE_ReOpen_Attend);}/** Get ReOpen Attendance.
@return ReOpen Attendance */
public String GetVAHRUAE_ReOpen_Attend() {return (String)Get_Value("VAHRUAE_ReOpen_Attend");}
/** VAHRUAE_SalaryType AD_Reference_ID=1000242 */
public static int VAHRUAE_SALARYTYPE_AD_Reference_ID=1000242;/** Daily = DA */
public static String VAHRUAE_SALARYTYPE_Daily = "DA";/** Fort Night = FN */
public static String VAHRUAE_SALARYTYPE_FortNight = "FN";/** Monthly = MO */
public static String VAHRUAE_SALARYTYPE_Monthly = "MO";/** Weekly = WE */
public static String VAHRUAE_SALARYTYPE_Weekly = "WE";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_SalaryTypeValid (String test){return test == null || test.Equals("DA") || test.Equals("FN") || test.Equals("MO") || test.Equals("WE");}/** Set Salary Type.
@param VAHRUAE_SalaryType Salary Type */
public void SetVAHRUAE_SalaryType (String VAHRUAE_SalaryType){if (!IsVAHRUAE_SalaryTypeValid(VAHRUAE_SalaryType))
throw new ArgumentException ("VAHRUAE_SalaryType Invalid value - " + VAHRUAE_SalaryType + " - Reference_ID=1000242 - DA - FN - MO - WE");if (VAHRUAE_SalaryType != null && VAHRUAE_SalaryType.Length > 2){log.Warning("Length > 2 - truncated");VAHRUAE_SalaryType = VAHRUAE_SalaryType.Substring(0,2);}Set_Value ("VAHRUAE_SalaryType", VAHRUAE_SalaryType);}/** Get Salary Type.
@return Salary Type */
public String GetVAHRUAE_SalaryType() {return (String)Get_Value("VAHRUAE_SalaryType");}/** Set To Date.
@param VAHRUAE_ToDate To Date */
public void SetVAHRUAE_ToDate (DateTime? VAHRUAE_ToDate){Set_Value ("VAHRUAE_ToDate", (DateTime?)VAHRUAE_ToDate);}/** Get To Date.
@return To Date */
public DateTime? GetVAHRUAE_ToDate() {return (DateTime?)Get_Value("VAHRUAE_ToDate");}}
}