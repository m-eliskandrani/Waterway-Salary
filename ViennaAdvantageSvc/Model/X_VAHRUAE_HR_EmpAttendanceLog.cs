namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_HR_EmpAttendanceLog
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_HR_EmpAttendanceLog : PO{public X_VAHRUAE_HR_EmpAttendanceLog (Context ctx, int VAHRUAE_HR_EmpAttendanceLog_ID, Trx trxName) : base (ctx, VAHRUAE_HR_EmpAttendanceLog_ID, trxName){/** if (VAHRUAE_HR_EmpAttendanceLog_ID == 0){SetVAHRUAE_HR_EmpAttendanceLog_ID (0);} */
}public X_VAHRUAE_HR_EmpAttendanceLog (Ctx ctx, int VAHRUAE_HR_EmpAttendanceLog_ID, Trx trxName) : base (ctx, VAHRUAE_HR_EmpAttendanceLog_ID, trxName){/** if (VAHRUAE_HR_EmpAttendanceLog_ID == 0){SetVAHRUAE_HR_EmpAttendanceLog_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_EmpAttendanceLog (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_EmpAttendanceLog (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_EmpAttendanceLog (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_HR_EmpAttendanceLog(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27900509062266L;/** Last Updated Timestamp 4/14/2021 9:02:25 AM */
public static long updatedMS = 1618383745477L;/** AD_Table_ID=1000848 */
public static int Table_ID; // =1000848;
/** TableName=VAHRUAE_HR_EmpAttendanceLog */
public static String Table_Name="VAHRUAE_HR_EmpAttendanceLog";
protected static KeyNamePair model;protected Decimal accessLevel = new Decimal(7);/** AccessLevel
@return 7 - System - Client - Org 
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_HR_EmpAttendanceLog[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Attendance Marked.
@param VAHRUAE_AttMarked Attendance Marked */
public void SetVAHRUAE_AttMarked (Boolean VAHRUAE_AttMarked){Set_Value ("VAHRUAE_AttMarked", VAHRUAE_AttMarked);}/** Get Attendance Marked.
@return Attendance Marked */
public Boolean IsVAHRUAE_AttMarked() {Object oo = Get_Value("VAHRUAE_AttMarked");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Date.
@param VAHRUAE_Date Date */
public void SetVAHRUAE_Date (DateTime? VAHRUAE_Date){Set_Value ("VAHRUAE_Date", (DateTime?)VAHRUAE_Date);}/** Get Date.
@return Date */
public DateTime? GetVAHRUAE_Date() {return (DateTime?)Get_Value("VAHRUAE_Date");}/** Set Enroll ID.
@param VAHRUAE_Enroll_ID Enroll ID */
public void SetVAHRUAE_Enroll_ID (int VAHRUAE_Enroll_ID){if (VAHRUAE_Enroll_ID <= 0) Set_Value ("VAHRUAE_Enroll_ID", null);else
Set_Value ("VAHRUAE_Enroll_ID", VAHRUAE_Enroll_ID);}/** Get Enroll ID.
@return Enroll ID */
public int GetVAHRUAE_Enroll_ID() {Object ii = Get_Value("VAHRUAE_Enroll_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set First Attendance.
@param VAHRUAE_FirstAttendance First Attendance */
public void SetVAHRUAE_FirstAttendance (Boolean VAHRUAE_FirstAttendance){Set_Value ("VAHRUAE_FirstAttendance", VAHRUAE_FirstAttendance);}/** Get First Attendance.
@return First Attendance */
public Boolean IsVAHRUAE_FirstAttendance() {Object oo = Get_Value("VAHRUAE_FirstAttendance");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Shift.
@param VAHRUAE_HR_AttendanceRule_ID Shift */
public void SetVAHRUAE_HR_AttendanceRule_ID (int VAHRUAE_HR_AttendanceRule_ID){if (VAHRUAE_HR_AttendanceRule_ID <= 0) Set_Value ("VAHRUAE_HR_AttendanceRule_ID", null);else
Set_Value ("VAHRUAE_HR_AttendanceRule_ID", VAHRUAE_HR_AttendanceRule_ID);}/** Get Shift.
@return Shift */
public int GetVAHRUAE_HR_AttendanceRule_ID() {Object ii = Get_Value("VAHRUAE_HR_AttendanceRule_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set HR Emp Attendance Log.
@param VAHRUAE_HR_EmpAttendanceLog_ID HR Emp Attendance Log */
public void SetVAHRUAE_HR_EmpAttendanceLog_ID (int VAHRUAE_HR_EmpAttendanceLog_ID){if (VAHRUAE_HR_EmpAttendanceLog_ID < 1) throw new ArgumentException ("VAHRUAE_HR_EmpAttendanceLog_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_HR_EmpAttendanceLog_ID", VAHRUAE_HR_EmpAttendanceLog_ID);}/** Get HR Emp Attendance Log.
@return HR Emp Attendance Log */
public int GetVAHRUAE_HR_EmpAttendanceLog_ID() {Object ii = Get_Value("VAHRUAE_HR_EmpAttendanceLog_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set IP Address.
@param VAHRUAE_IPAddress IP Address */
public void SetVAHRUAE_IPAddress (String VAHRUAE_IPAddress){if (VAHRUAE_IPAddress != null && VAHRUAE_IPAddress.Length > 30){log.Warning("Length > 30 - truncated");VAHRUAE_IPAddress = VAHRUAE_IPAddress.Substring(0,30);}Set_Value ("VAHRUAE_IPAddress", VAHRUAE_IPAddress);}/** Get IP Address.
@return IP Address */
public String GetVAHRUAE_IPAddress() {return (String)Get_Value("VAHRUAE_IPAddress");}/** Set In Out Mode.
@param VAHRUAE_InOutMode In Out Mode */
public void SetVAHRUAE_InOutMode (int VAHRUAE_InOutMode){Set_Value ("VAHRUAE_InOutMode", VAHRUAE_InOutMode);}/** Get In Out Mode.
@return In Out Mode */
public int GetVAHRUAE_InOutMode() {Object ii = Get_Value("VAHRUAE_InOutMode");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Last Attendance.
@param VAHRUAE_LastAttendance Last Attendance */
public void SetVAHRUAE_LastAttendance (Boolean VAHRUAE_LastAttendance){Set_Value ("VAHRUAE_LastAttendance", VAHRUAE_LastAttendance);}/** Get Last Attendance.
@return Last Attendance */
public Boolean IsVAHRUAE_LastAttendance() {Object oo = Get_Value("VAHRUAE_LastAttendance");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Machine Number.
@param VAHRUAE_MachineNumber Machine Number */
public void SetVAHRUAE_MachineNumber (int VAHRUAE_MachineNumber){Set_Value ("VAHRUAE_MachineNumber", VAHRUAE_MachineNumber);}/** Get Machine Number.
@return Machine Number */
public int GetVAHRUAE_MachineNumber() {Object ii = Get_Value("VAHRUAE_MachineNumber");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Marked.
@param VAHRUAE_Marked Marked */
public void SetVAHRUAE_Marked (Boolean VAHRUAE_Marked){Set_Value ("VAHRUAE_Marked", VAHRUAE_Marked);}/** Get Marked.
@return Marked */
public Boolean IsVAHRUAE_Marked() {Object oo = Get_Value("VAHRUAE_Marked");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Time Of Attendance.
@param VAHRUAE_TimeOfAttendance Time Of Attendance */
public void SetVAHRUAE_TimeOfAttendance (DateTime? VAHRUAE_TimeOfAttendance){Set_Value ("VAHRUAE_TimeOfAttendance", (DateTime?)VAHRUAE_TimeOfAttendance);}/** Get Time Of Attendance.
@return Time Of Attendance */
public DateTime? GetVAHRUAE_TimeOfAttendance() {return (DateTime?)Get_Value("VAHRUAE_TimeOfAttendance");}/** Set Verify Mode.
@param VAHRUAE_VerifyMode Verify Mode */
public void SetVAHRUAE_VerifyMode (int VAHRUAE_VerifyMode){Set_Value ("VAHRUAE_VerifyMode", VAHRUAE_VerifyMode);}/** Get Verify Mode.
@return Verify Mode */
public int GetVAHRUAE_VerifyMode() {Object ii = Get_Value("VAHRUAE_VerifyMode");if (ii == null) return 0;return Convert.ToInt32(ii);}}
}