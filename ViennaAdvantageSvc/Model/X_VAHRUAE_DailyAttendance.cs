namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_DailyAttendance
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_DailyAttendance : PO{public X_VAHRUAE_DailyAttendance (Context ctx, int VAHRUAE_DailyAttendance_ID, Trx trxName) : base (ctx, VAHRUAE_DailyAttendance_ID, trxName){/** if (VAHRUAE_DailyAttendance_ID == 0){SetVAHRUAE_AttendanceHeader_ID (0);SetVAHRUAE_DailyAttendance_ID (0);} */
}public X_VAHRUAE_DailyAttendance (Ctx ctx, int VAHRUAE_DailyAttendance_ID, Trx trxName) : base (ctx, VAHRUAE_DailyAttendance_ID, trxName){/** if (VAHRUAE_DailyAttendance_ID == 0){SetVAHRUAE_AttendanceHeader_ID (0);SetVAHRUAE_DailyAttendance_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_DailyAttendance (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_DailyAttendance (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_DailyAttendance (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_DailyAttendance(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27900001750728L;/** Last Updated Timestamp 4/8/2021 12:07:13 PM */
public static long updatedMS = 1617876433939L;/** AD_Table_ID=1000870 */
public static int Table_ID; // =1000870;
/** TableName=VAHRUAE_DailyAttendance */
public static String Table_Name="VAHRUAE_DailyAttendance";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_DailyAttendance[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Processed.
@param Processed The document has been processed */
public void SetProcessed (Boolean Processed){Set_Value ("Processed", Processed);}/** Get Processed.
@return The document has been processed */
public Boolean IsProcessed() {Object oo = Get_Value("Processed");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Actual In Time.
@param VAHRUAE_ActualInTime Actual In Time */
public void SetVAHRUAE_ActualInTime (DateTime? VAHRUAE_ActualInTime){Set_Value ("VAHRUAE_ActualInTime", (DateTime?)VAHRUAE_ActualInTime);}/** Get Actual In Time.
@return Actual In Time */
public DateTime? GetVAHRUAE_ActualInTime() {return (DateTime?)Get_Value("VAHRUAE_ActualInTime");}/** Set Actual Out Time.
@param VAHRUAE_ActualOutTime Actual Out Time */
public void SetVAHRUAE_ActualOutTime (DateTime? VAHRUAE_ActualOutTime){Set_Value ("VAHRUAE_ActualOutTime", (DateTime?)VAHRUAE_ActualOutTime);}/** Get Actual Out Time.
@return Actual Out Time */
public DateTime? GetVAHRUAE_ActualOutTime() {return (DateTime?)Get_Value("VAHRUAE_ActualOutTime");}/** Set Attendance Marked.
@param VAHRUAE_AttMarked Attendance Marked */
public void SetVAHRUAE_AttMarked (Boolean VAHRUAE_AttMarked){Set_Value ("VAHRUAE_AttMarked", VAHRUAE_AttMarked);}/** Get Attendance Marked.
@return Attendance Marked */
public Boolean IsVAHRUAE_AttMarked() {Object oo = Get_Value("VAHRUAE_AttMarked");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Attendance Header.
@param VAHRUAE_AttendanceHeader_ID Attendance Header */
public void SetVAHRUAE_AttendanceHeader_ID (int VAHRUAE_AttendanceHeader_ID){if (VAHRUAE_AttendanceHeader_ID < 1) throw new ArgumentException ("VAHRUAE_AttendanceHeader_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_AttendanceHeader_ID", VAHRUAE_AttendanceHeader_ID);}/** Get Attendance Header.
@return Attendance Header */
public int GetVAHRUAE_AttendanceHeader_ID() {Object ii = Get_Value("VAHRUAE_AttendanceHeader_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Check In Time.
@param VAHRUAE_CheckInTime Check In Time */
public void SetVAHRUAE_CheckInTime (String VAHRUAE_CheckInTime){if (VAHRUAE_CheckInTime != null && VAHRUAE_CheckInTime.Length > 10){log.Warning("Length > 10 - truncated");VAHRUAE_CheckInTime = VAHRUAE_CheckInTime.Substring(0,10);}Set_Value ("VAHRUAE_CheckInTime", VAHRUAE_CheckInTime);}/** Get Check In Time.
@return Check In Time */
public String GetVAHRUAE_CheckInTime() {return (String)Get_Value("VAHRUAE_CheckInTime");}/** Set Check Out Time.
@param VAHRUAE_CheckOutTime Check Out Time */
public void SetVAHRUAE_CheckOutTime (String VAHRUAE_CheckOutTime){if (VAHRUAE_CheckOutTime != null && VAHRUAE_CheckOutTime.Length > 10){log.Warning("Length > 10 - truncated");VAHRUAE_CheckOutTime = VAHRUAE_CheckOutTime.Substring(0,10);}Set_Value ("VAHRUAE_CheckOutTime", VAHRUAE_CheckOutTime);}/** Get Check Out Time.
@return Check Out Time */
public String GetVAHRUAE_CheckOutTime() {return (String)Get_Value("VAHRUAE_CheckOutTime");}/** Set Consider Early Before.
@param VAHRUAE_ConsiderEarlyBefore Consider Early Before */
public void SetVAHRUAE_ConsiderEarlyBefore (DateTime? VAHRUAE_ConsiderEarlyBefore){Set_Value ("VAHRUAE_ConsiderEarlyBefore", (DateTime?)VAHRUAE_ConsiderEarlyBefore);}/** Get Consider Early Before.
@return Consider Early Before */
public DateTime? GetVAHRUAE_ConsiderEarlyBefore() {return (DateTime?)Get_Value("VAHRUAE_ConsiderEarlyBefore");}/** Set Consider Late After.
@param VAHRUAE_ConsiderLateAfter Consider Late After */
public void SetVAHRUAE_ConsiderLateAfter (DateTime? VAHRUAE_ConsiderLateAfter){Set_Value ("VAHRUAE_ConsiderLateAfter", (DateTime?)VAHRUAE_ConsiderLateAfter);}/** Get Consider Late After.
@return Consider Late After */
public DateTime? GetVAHRUAE_ConsiderLateAfter() {return (DateTime?)Get_Value("VAHRUAE_ConsiderLateAfter");}/** Set Daily Attendance .
@param VAHRUAE_DailyAttendance_ID Daily Attendance  */
public void SetVAHRUAE_DailyAttendance_ID (int VAHRUAE_DailyAttendance_ID){if (VAHRUAE_DailyAttendance_ID < 1) throw new ArgumentException ("VAHRUAE_DailyAttendance_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_DailyAttendance_ID", VAHRUAE_DailyAttendance_ID);}/** Get Daily Attendance .
@return Daily Attendance  */
public int GetVAHRUAE_DailyAttendance_ID() {Object ii = Get_Value("VAHRUAE_DailyAttendance_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Date.
@param VAHRUAE_Date1 Date */
public void SetVAHRUAE_Date1 (DateTime? VAHRUAE_Date1){Set_Value ("VAHRUAE_Date1", (DateTime?)VAHRUAE_Date1);}/** Get Date.
@return Date */
public DateTime? GetVAHRUAE_Date1() {return (DateTime?)Get_Value("VAHRUAE_Date1");}/** Set Early Out Count.
@param VAHRUAE_EarlyOutCount Early Out Count */
public void SetVAHRUAE_EarlyOutCount (Decimal? VAHRUAE_EarlyOutCount){Set_Value ("VAHRUAE_EarlyOutCount", (Decimal?)VAHRUAE_EarlyOutCount);}/** Get Early Out Count.
@return Early Out Count */
public Decimal GetVAHRUAE_EarlyOutCount() {Object bd =Get_Value("VAHRUAE_EarlyOutCount");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Enroll ID.
@param VAHRUAE_Enroll_ID Enroll ID */
public void SetVAHRUAE_Enroll_ID (int VAHRUAE_Enroll_ID){if (VAHRUAE_Enroll_ID <= 0) Set_Value ("VAHRUAE_Enroll_ID", null);else
Set_Value ("VAHRUAE_Enroll_ID", VAHRUAE_Enroll_ID);}/** Get Enroll ID.
@return Enroll ID */
public int GetVAHRUAE_Enroll_ID() {Object ii = Get_Value("VAHRUAE_Enroll_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set HR Employee.
@param VAHRUAE_HR_Employee_ID HR Employee */
public void SetVAHRUAE_HR_Employee_ID (int VAHRUAE_HR_Employee_ID){if (VAHRUAE_HR_Employee_ID <= 0) Set_Value ("VAHRUAE_HR_Employee_ID", null);else
Set_Value ("VAHRUAE_HR_Employee_ID", VAHRUAE_HR_Employee_ID);}/** Get HR Employee.
@return HR Employee */
public int GetVAHRUAE_HR_Employee_ID() {Object ii = Get_Value("VAHRUAE_HR_Employee_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set HR Leave Detail.
@param VAHRUAE_HR_LeaveDetail_ID HR Leave Detail */
public void SetVAHRUAE_HR_LeaveDetail_ID (int VAHRUAE_HR_LeaveDetail_ID){if (VAHRUAE_HR_LeaveDetail_ID <= 0) Set_Value ("VAHRUAE_HR_LeaveDetail_ID", null);else
Set_Value ("VAHRUAE_HR_LeaveDetail_ID", VAHRUAE_HR_LeaveDetail_ID);}/** Get HR Leave Detail.
@return HR Leave Detail */
public int GetVAHRUAE_HR_LeaveDetail_ID() {Object ii = Get_Value("VAHRUAE_HR_LeaveDetail_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Holiday Overtime.
@param VAHRUAE_HolidayOvertime Holiday Overtime */
public void SetVAHRUAE_HolidayOvertime (Boolean VAHRUAE_HolidayOvertime){Set_Value ("VAHRUAE_HolidayOvertime", VAHRUAE_HolidayOvertime);}/** Get Holiday Overtime.
@return Holiday Overtime */
public Boolean IsVAHRUAE_HolidayOvertime() {Object oo = Get_Value("VAHRUAE_HolidayOvertime");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Hours Worked.
@param VAHRUAE_HoursWorked Hours Worked */
public void SetVAHRUAE_HoursWorked (Decimal? VAHRUAE_HoursWorked){Set_Value ("VAHRUAE_HoursWorked", (Decimal?)VAHRUAE_HoursWorked);}/** Get Hours Worked.
@return Hours Worked */
public Decimal GetVAHRUAE_HoursWorked() {Object bd =Get_Value("VAHRUAE_HoursWorked");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set In Time.
@param VAHRUAE_InTime In Time */
public void SetVAHRUAE_InTime (DateTime? VAHRUAE_InTime){Set_Value ("VAHRUAE_InTime", (DateTime?)VAHRUAE_InTime);}/** Get In Time.
@return In Time */
public DateTime? GetVAHRUAE_InTime() {return (DateTime?)Get_Value("VAHRUAE_InTime");}/** Set Late In Count.
@param VAHRUAE_LateInCount Late In Count */
public void SetVAHRUAE_LateInCount (Decimal? VAHRUAE_LateInCount){Set_Value ("VAHRUAE_LateInCount", (Decimal?)VAHRUAE_LateInCount);}/** Get Late In Count.
@return Late In Count */
public Decimal GetVAHRUAE_LateInCount() {Object bd =Get_Value("VAHRUAE_LateInCount");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Attendance.
@param VAHRUAE_MonthlyAttendance_ID Attendance */
public void SetVAHRUAE_MonthlyAttendance_ID (int VAHRUAE_MonthlyAttendance_ID){if (VAHRUAE_MonthlyAttendance_ID <= 0) Set_Value ("VAHRUAE_MonthlyAttendance_ID", null);else
Set_Value ("VAHRUAE_MonthlyAttendance_ID", VAHRUAE_MonthlyAttendance_ID);}/** Get Attendance.
@return Attendance */
public int GetVAHRUAE_MonthlyAttendance_ID() {Object ii = Get_Value("VAHRUAE_MonthlyAttendance_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set OT Amount.
@param VAHRUAE_OTAmount OT Amount */
public void SetVAHRUAE_OTAmount (Decimal? VAHRUAE_OTAmount){Set_Value ("VAHRUAE_OTAmount", (Decimal?)VAHRUAE_OTAmount);}/** Get OT Amount.
@return OT Amount */
public Decimal GetVAHRUAE_OTAmount() {Object bd =Get_Value("VAHRUAE_OTAmount");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set OT Grace In Min.
@param VAHRUAE_OTGraceInMin OT Grace In Min */
public void SetVAHRUAE_OTGraceInMin (DateTime? VAHRUAE_OTGraceInMin){Set_Value ("VAHRUAE_OTGraceInMin", (DateTime?)VAHRUAE_OTGraceInMin);}/** Get OT Grace In Min.
@return OT Grace In Min */
public DateTime? GetVAHRUAE_OTGraceInMin() {return (DateTime?)Get_Value("VAHRUAE_OTGraceInMin");}/** Set OTGraceOutMin.
@param VAHRUAE_OTGraceOutMin OTGraceOutMin */
public void SetVAHRUAE_OTGraceOutMin (DateTime? VAHRUAE_OTGraceOutMin){Set_Value ("VAHRUAE_OTGraceOutMin", (DateTime?)VAHRUAE_OTGraceOutMin);}/** Get OTGraceOutMin.
@return OTGraceOutMin */
public DateTime? GetVAHRUAE_OTGraceOutMin() {return (DateTime?)Get_Value("VAHRUAE_OTGraceOutMin");}/** Set OT Hour.
@param VAHRUAE_OTHour OT Hour */
public void SetVAHRUAE_OTHour (String VAHRUAE_OTHour){if (VAHRUAE_OTHour != null && VAHRUAE_OTHour.Length > 10){log.Warning("Length > 10 - truncated");VAHRUAE_OTHour = VAHRUAE_OTHour.Substring(0,10);}Set_Value ("VAHRUAE_OTHour", VAHRUAE_OTHour);}/** Get OT Hour.
@return OT Hour */
public String GetVAHRUAE_OTHour() {return (String)Get_Value("VAHRUAE_OTHour");}/** Set OT Normal1.
@param VAHRUAE_OT_Normal1 OT Normal1 */
public void SetVAHRUAE_OT_Normal1 (Decimal? VAHRUAE_OT_Normal1){Set_Value ("VAHRUAE_OT_Normal1", (Decimal?)VAHRUAE_OT_Normal1);}/** Get OT Normal1.
@return OT Normal1 */
public Decimal GetVAHRUAE_OT_Normal1() {Object bd =Get_Value("VAHRUAE_OT_Normal1");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set OT Normal2.
@param VAHRUAE_OT_Normal2 OT Normal2 */
public void SetVAHRUAE_OT_Normal2 (Decimal? VAHRUAE_OT_Normal2){Set_Value ("VAHRUAE_OT_Normal2", (Decimal?)VAHRUAE_OT_Normal2);}/** Get OT Normal2.
@return OT Normal2 */
public Decimal GetVAHRUAE_OT_Normal2() {Object bd =Get_Value("VAHRUAE_OT_Normal2");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set OT Premium.
@param VAHRUAE_OT_Premium OT Premium */
public void SetVAHRUAE_OT_Premium (Decimal? VAHRUAE_OT_Premium){Set_Value ("VAHRUAE_OT_Premium", (Decimal?)VAHRUAE_OT_Premium);}/** Get OT Premium.
@return OT Premium */
public Decimal GetVAHRUAE_OT_Premium() {Object bd =Get_Value("VAHRUAE_OT_Premium");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}
/** VAHRUAE_OT_Type AD_Reference_ID=1000331 */
public static int VAHRUAE_OT_TYPE_AD_Reference_ID=1000331;/** 25% = A */
public static String VAHRUAE_OT_TYPE_25 = "A";/** 50% = B */
public static String VAHRUAE_OT_TYPE_50 = "B";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_OT_TypeValid (String test){return test == null || test.Equals("A") || test.Equals("B");}/** Set Overtime Type.
@param VAHRUAE_OT_Type Overtime Type */
public void SetVAHRUAE_OT_Type (String VAHRUAE_OT_Type){if (!IsVAHRUAE_OT_TypeValid(VAHRUAE_OT_Type))
throw new ArgumentException ("VAHRUAE_OT_Type Invalid value - " + VAHRUAE_OT_Type + " - Reference_ID=1000331 - A - B");if (VAHRUAE_OT_Type != null && VAHRUAE_OT_Type.Length > 1){log.Warning("Length > 1 - truncated");VAHRUAE_OT_Type = VAHRUAE_OT_Type.Substring(0,1);}Set_Value ("VAHRUAE_OT_Type", VAHRUAE_OT_Type);}/** Get Overtime Type.
@return Overtime Type */
public String GetVAHRUAE_OT_Type() {return (String)Get_Value("VAHRUAE_OT_Type");}/** Set Out Time.
@param VAHRUAE_OutTime Out Time */
public void SetVAHRUAE_OutTime (DateTime? VAHRUAE_OutTime){Set_Value ("VAHRUAE_OutTime", (DateTime?)VAHRUAE_OutTime);}/** Get Out Time.
@return Out Time */
public DateTime? GetVAHRUAE_OutTime() {return (DateTime?)Get_Value("VAHRUAE_OutTime");}/** Set OverTimeApplied.
@param VAHRUAE_OverTimeApplied OverTimeApplied */
public void SetVAHRUAE_OverTimeApplied (Boolean VAHRUAE_OverTimeApplied){Set_Value ("VAHRUAE_OverTimeApplied", VAHRUAE_OverTimeApplied);}/** Get OverTimeApplied.
@return OverTimeApplied */
public Boolean IsVAHRUAE_OverTimeApplied() {Object oo = Get_Value("VAHRUAE_OverTimeApplied");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Total Working Hours.
@param VAHRUAE_TotalWorkingHours Total Working Hours */
public void SetVAHRUAE_TotalWorkingHours (Decimal? VAHRUAE_TotalWorkingHours){Set_Value ("VAHRUAE_TotalWorkingHours", (Decimal?)VAHRUAE_TotalWorkingHours);}/** Get Total Working Hours.
@return Total Working Hours */
public Decimal GetVAHRUAE_TotalWorkingHours() {Object bd =Get_Value("VAHRUAE_TotalWorkingHours");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}}
}