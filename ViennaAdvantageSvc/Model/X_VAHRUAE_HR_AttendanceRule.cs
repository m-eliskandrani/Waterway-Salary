namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_HR_AttendanceRule
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_HR_AttendanceRule : PO{public X_VAHRUAE_HR_AttendanceRule (Context ctx, int VAHRUAE_HR_AttendanceRule_ID, Trx trxName) : base (ctx, VAHRUAE_HR_AttendanceRule_ID, trxName){/** if (VAHRUAE_HR_AttendanceRule_ID == 0){SetVAHRUAE_HR_AttendanceRule_ID (0);SetVAHRUAE_Name (null);} */
}public X_VAHRUAE_HR_AttendanceRule (Ctx ctx, int VAHRUAE_HR_AttendanceRule_ID, Trx trxName) : base (ctx, VAHRUAE_HR_AttendanceRule_ID, trxName){/** if (VAHRUAE_HR_AttendanceRule_ID == 0){SetVAHRUAE_HR_AttendanceRule_ID (0);SetVAHRUAE_Name (null);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_AttendanceRule (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_AttendanceRule (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_AttendanceRule (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_HR_AttendanceRule(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27904141011613L;/** Last Updated Timestamp 5/26/2021 9:54:54 AM */
public static long updatedMS = 1622015694824L;/** AD_Table_ID=1000829 */
public static int Table_ID; // =1000829;
/** TableName=VAHRUAE_HR_AttendanceRule */
public static String Table_Name="VAHRUAE_HR_AttendanceRule";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_HR_AttendanceRule[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set DAYSOFFGENERATE.
@param DAYSOFFGENERATE DAYSOFFGENERATE */
public void SetDAYSOFFGENERATE (String DAYSOFFGENERATE){if (DAYSOFFGENERATE != null && DAYSOFFGENERATE.Length > 20){log.Warning("Length > 20 - truncated");DAYSOFFGENERATE = DAYSOFFGENERATE.Substring(0,20);}Set_Value ("DAYSOFFGENERATE", DAYSOFFGENERATE);}/** Get DAYSOFFGENERATE.
@return DAYSOFFGENERATE */
public String GetDAYSOFFGENERATE() {return (String)Get_Value("DAYSOFFGENERATE");}/** Set DAYSPERMONTH.
@param DAYSPERMONTH DAYSPERMONTH */
public void SetDAYSPERMONTH (int DAYSPERMONTH){Set_Value ("DAYSPERMONTH", DAYSPERMONTH);}/** Get DAYSPERMONTH.
@return DAYSPERMONTH */
public int GetDAYSPERMONTH() {Object ii = Get_Value("DAYSPERMONTH");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set FRIDAYOFF.
@param FRIDAYOFF FRIDAYOFF */
public void SetFRIDAYOFF (Boolean FRIDAYOFF){Set_Value ("FRIDAYOFF", FRIDAYOFF);}/** Get FRIDAYOFF.
@return FRIDAYOFF */
public Boolean IsFRIDAYOFF() {Object oo = Get_Value("FRIDAYOFF");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set HOURSPERDAY.
@param HOURSPERDAY Amount in a defined currency */
public void SetHOURSPERDAY (int HOURSPERDAY){Set_Value ("HOURSPERDAY", HOURSPERDAY);}/** Get HOURSPERDAY.
@return Amount in a defined currency */
public int GetHOURSPERDAY() {Object ii = Get_Value("HOURSPERDAY");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set IsRoundCeiling.
@param IsRoundCeiling IsRoundCeiling */
public void SetIsRoundCeiling (Boolean IsRoundCeiling){Set_Value ("IsRoundCeiling", IsRoundCeiling);}/** Get IsRoundCeiling.
@return IsRoundCeiling */
public Boolean IsRoundCeiling() {Object oo = Get_Value("IsRoundCeiling");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set IsRoundFloor.
@param IsRoundFloor IsRoundFloor */
public void SetIsRoundFloor (Boolean IsRoundFloor){Set_Value ("IsRoundFloor", IsRoundFloor);}/** Get IsRoundFloor.
@return IsRoundFloor */
public Boolean IsRoundFloor() {Object oo = Get_Value("IsRoundFloor");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set MONDAYOFF.
@param MONDAYOFF MONDAYOFF */
public void SetMONDAYOFF (Boolean MONDAYOFF){Set_Value ("MONDAYOFF", MONDAYOFF);}/** Get MONDAYOFF.
@return MONDAYOFF */
public Boolean IsMONDAYOFF() {Object oo = Get_Value("MONDAYOFF");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set RotationalLeeway.
@param RotationalLeeway Amount in a defined currency */
public void SetRotationalLeeway (Decimal? RotationalLeeway){Set_Value ("RotationalLeeway", (Decimal?)RotationalLeeway);}/** Get RotationalLeeway.
@return Amount in a defined currency */
public Decimal GetRotationalLeeway() {Object bd =Get_Value("RotationalLeeway");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set RotationalStartTime.
@param RotationalStartTime RotationalStartTime */
public void SetRotationalStartTime (DateTime? RotationalStartTime){Set_Value ("RotationalStartTime", (DateTime?)RotationalStartTime);}/** Get RotationalStartTime.
@return RotationalStartTime */
public DateTime? GetRotationalStartTime() {return (DateTime?)Get_Value("RotationalStartTime");}/** Set RoundNumber.
@param RoundNumber Numeric Value */
public void SetRoundNumber (int RoundNumber){Set_Value ("RoundNumber", RoundNumber);}/** Get RoundNumber.
@return Numeric Value */
public int GetRoundNumber() {Object ii = Get_Value("RoundNumber");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set SATURDAYOFF.
@param SATURDAYOFF SATURDAYOFF */
public void SetSATURDAYOFF (Boolean SATURDAYOFF){Set_Value ("SATURDAYOFF", SATURDAYOFF);}/** Get SATURDAYOFF.
@return SATURDAYOFF */
public Boolean IsSATURDAYOFF() {Object oo = Get_Value("SATURDAYOFF");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set SHIFT1ACTIVE.
@param SHIFT1ACTIVE SHIFT1ACTIVE */
public void SetSHIFT1ACTIVE (Boolean SHIFT1ACTIVE){Set_Value ("SHIFT1ACTIVE", SHIFT1ACTIVE);}/** Get SHIFT1ACTIVE.
@return SHIFT1ACTIVE */
public Boolean IsSHIFT1ACTIVE() {Object oo = Get_Value("SHIFT1ACTIVE");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set SHIFT2ACTIVE.
@param SHIFT2ACTIVE SHIFT2ACTIVE */
public void SetSHIFT2ACTIVE (Boolean SHIFT2ACTIVE){Set_Value ("SHIFT2ACTIVE", SHIFT2ACTIVE);}/** Get SHIFT2ACTIVE.
@return SHIFT2ACTIVE */
public Boolean IsSHIFT2ACTIVE() {Object oo = Get_Value("SHIFT2ACTIVE");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set SHIFT3ACTIVE.
@param SHIFT3ACTIVE SHIFT3ACTIVE */
public void SetSHIFT3ACTIVE (Boolean SHIFT3ACTIVE){Set_Value ("SHIFT3ACTIVE", SHIFT3ACTIVE);}/** Get SHIFT3ACTIVE.
@return SHIFT3ACTIVE */
public Boolean IsSHIFT3ACTIVE() {Object oo = Get_Value("SHIFT3ACTIVE");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set SUNDAYOFF.
@param SUNDAYOFF SUNDAYOFF */
public void SetSUNDAYOFF (Boolean SUNDAYOFF){Set_Value ("SUNDAYOFF", SUNDAYOFF);}/** Get SUNDAYOFF.
@return SUNDAYOFF */
public Boolean IsSUNDAYOFF() {Object oo = Get_Value("SUNDAYOFF");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set THURSDAYOFF.
@param THURSDAYOFF THURSDAYOFF */
public void SetTHURSDAYOFF (Boolean THURSDAYOFF){Set_Value ("THURSDAYOFF", THURSDAYOFF);}/** Get THURSDAYOFF.
@return THURSDAYOFF */
public Boolean IsTHURSDAYOFF() {Object oo = Get_Value("THURSDAYOFF");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set TUESDAYOFF.
@param TUESDAYOFF TUESDAYOFF */
public void SetTUESDAYOFF (Boolean TUESDAYOFF){Set_Value ("TUESDAYOFF", TUESDAYOFF);}/** Get TUESDAYOFF.
@return TUESDAYOFF */
public Boolean IsTUESDAYOFF() {Object oo = Get_Value("TUESDAYOFF");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Break Hours.
@param VAHRUAE_BreakHours Break Hours */
public void SetVAHRUAE_BreakHours (Decimal? VAHRUAE_BreakHours){Set_Value ("VAHRUAE_BreakHours", (Decimal?)VAHRUAE_BreakHours);}/** Get Break Hours.
@return Break Hours */
public Decimal GetVAHRUAE_BreakHours() {Object bd =Get_Value("VAHRUAE_BreakHours");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Consider Early Before(Half day).
@param VAHRUAE_ConsiderBeforeHalf Consider Early Before(Half day) */
public void SetVAHRUAE_ConsiderBeforeHalf (DateTime? VAHRUAE_ConsiderBeforeHalf){Set_Value ("VAHRUAE_ConsiderBeforeHalf", (DateTime?)VAHRUAE_ConsiderBeforeHalf);}/** Get Consider Early Before(Half day).
@return Consider Early Before(Half day) */
public DateTime? GetVAHRUAE_ConsiderBeforeHalf() {return (DateTime?)Get_Value("VAHRUAE_ConsiderBeforeHalf");}/** Set Consider Early Before.
@param VAHRUAE_ConsiderEarlyBefore Consider Early Before */
public void SetVAHRUAE_ConsiderEarlyBefore (DateTime? VAHRUAE_ConsiderEarlyBefore){Set_Value ("VAHRUAE_ConsiderEarlyBefore", (DateTime?)VAHRUAE_ConsiderEarlyBefore);}/** Get Consider Early Before.
@return Consider Early Before */
public DateTime? GetVAHRUAE_ConsiderEarlyBefore() {return (DateTime?)Get_Value("VAHRUAE_ConsiderEarlyBefore");}/** Set Consider ExtraTime As OT.
@param VAHRUAE_ConsiderExtraTimeAsOT Consider ExtraTime As OT */
public void SetVAHRUAE_ConsiderExtraTimeAsOT (Boolean VAHRUAE_ConsiderExtraTimeAsOT){Set_Value ("VAHRUAE_ConsiderExtraTimeAsOT", VAHRUAE_ConsiderExtraTimeAsOT);}/** Get Consider ExtraTime As OT.
@return Consider ExtraTime As OT */
public Boolean IsVAHRUAE_ConsiderExtraTimeAsOT() {Object oo = Get_Value("VAHRUAE_ConsiderExtraTimeAsOT");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Consider Late After.
@param VAHRUAE_ConsiderLateAfter Consider Late After */
public void SetVAHRUAE_ConsiderLateAfter (DateTime? VAHRUAE_ConsiderLateAfter){Set_Value ("VAHRUAE_ConsiderLateAfter", (DateTime?)VAHRUAE_ConsiderLateAfter);}/** Get Consider Late After.
@return Consider Late After */
public DateTime? GetVAHRUAE_ConsiderLateAfter() {return (DateTime?)Get_Value("VAHRUAE_ConsiderLateAfter");}/** Set Define OT Shift.
@param VAHRUAE_DefineOTShift Define OT Shift */
public void SetVAHRUAE_DefineOTShift (Boolean VAHRUAE_DefineOTShift){Set_Value ("VAHRUAE_DefineOTShift", VAHRUAE_DefineOTShift);}/** Get Define OT Shift.
@return Define OT Shift */
public Boolean IsVAHRUAE_DefineOTShift() {Object oo = Get_Value("VAHRUAE_DefineOTShift");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set General Shift.
@param VAHRUAE_GeneralShift General Shift */
public void SetVAHRUAE_GeneralShift (Boolean VAHRUAE_GeneralShift){Set_Value ("VAHRUAE_GeneralShift", VAHRUAE_GeneralShift);}/** Get General Shift.
@return General Shift */
public Boolean IsVAHRUAE_GeneralShift() {Object oo = Get_Value("VAHRUAE_GeneralShift");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Shift.
@param VAHRUAE_HR_AttendanceRule_ID Shift */
public void SetVAHRUAE_HR_AttendanceRule_ID (int VAHRUAE_HR_AttendanceRule_ID){if (VAHRUAE_HR_AttendanceRule_ID < 1) throw new ArgumentException ("VAHRUAE_HR_AttendanceRule_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_HR_AttendanceRule_ID", VAHRUAE_HR_AttendanceRule_ID);}/** Get Shift.
@return Shift */
public int GetVAHRUAE_HR_AttendanceRule_ID() {Object ii = Get_Value("VAHRUAE_HR_AttendanceRule_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set In Time.
@param VAHRUAE_InTime In Time */
public void SetVAHRUAE_InTime (DateTime? VAHRUAE_InTime){Set_Value ("VAHRUAE_InTime", (DateTime?)VAHRUAE_InTime);}/** Get In Time.
@return In Time */
public DateTime? GetVAHRUAE_InTime() {return (DateTime?)Get_Value("VAHRUAE_InTime");}/** Set In Time (Second).
@param VAHRUAE_InTime2 In Time (Second) */
public void SetVAHRUAE_InTime2 (DateTime? VAHRUAE_InTime2){Set_Value ("VAHRUAE_InTime2", (DateTime?)VAHRUAE_InTime2);}/** Get In Time (Second).
@return In Time (Second) */
public DateTime? GetVAHRUAE_InTime2() {return (DateTime?)Get_Value("VAHRUAE_InTime2");}/** Set VAHRUAE_InTime3.
@param VAHRUAE_InTime3 VAHRUAE_InTime3 */
public void SetVAHRUAE_InTime3 (DateTime? VAHRUAE_InTime3){Set_Value ("VAHRUAE_InTime3", (DateTime?)VAHRUAE_InTime3);}/** Get VAHRUAE_InTime3.
@return VAHRUAE_InTime3 */
public DateTime? GetVAHRUAE_InTime3() {return (DateTime?)Get_Value("VAHRUAE_InTime3");}/** Set Rotational Shift.
@param VAHRUAE_IsRotationalShift Rotational Shift */
public void SetVAHRUAE_IsRotationalShift (Boolean VAHRUAE_IsRotationalShift){Set_Value ("VAHRUAE_IsRotationalShift", VAHRUAE_IsRotationalShift);}/** Get Rotational Shift.
@return Rotational Shift */
public Boolean IsVAHRUAE_IsRotationalShift() {Object oo = Get_Value("VAHRUAE_IsRotationalShift");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}
/** VAHRUAE_MinOTHour AD_Reference_ID=1000298 */
public static int VAHRUAE_MINOTHOUR_AD_Reference_ID=1000298;/** NA = 000 */
public static String VAHRUAE_MINOTHOUR_NA = "000";/** 15 Minutes = 015 */
public static String VAHRUAE_MINOTHOUR_15Minutes = "015";/** 30 Minutes = 030 */
public static String VAHRUAE_MINOTHOUR_30Minutes = "030";/** 45 Minutes = 045 */
public static String VAHRUAE_MINOTHOUR_45Minutes = "045";/** 1 Hour = 100 */
public static String VAHRUAE_MINOTHOUR_1Hour = "100";/** 2 Hours = 200 */
public static String VAHRUAE_MINOTHOUR_2Hours = "200";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_MinOTHourValid (String test){return test == null || test.Equals("000") || test.Equals("015") || test.Equals("030") || test.Equals("045") || test.Equals("100") || test.Equals("200");}/** Set Minimum OT Time.
@param VAHRUAE_MinOTHour Minimum OT Time */
public void SetVAHRUAE_MinOTHour (String VAHRUAE_MinOTHour){if (!IsVAHRUAE_MinOTHourValid(VAHRUAE_MinOTHour))
throw new ArgumentException ("VAHRUAE_MinOTHour Invalid value - " + VAHRUAE_MinOTHour + " - Reference_ID=1000298 - 000 - 015 - 030 - 045 - 100 - 200");if (VAHRUAE_MinOTHour != null && VAHRUAE_MinOTHour.Length > 3){log.Warning("Length > 3 - truncated");VAHRUAE_MinOTHour = VAHRUAE_MinOTHour.Substring(0,3);}Set_Value ("VAHRUAE_MinOTHour", VAHRUAE_MinOTHour);}/** Get Minimum OT Time.
@return Minimum OT Time */
public String GetVAHRUAE_MinOTHour() {return (String)Get_Value("VAHRUAE_MinOTHour");}/** Set Name.
@param VAHRUAE_Name The name of an entity (record) is used as a default search option in addition to the search key. */
public void SetVAHRUAE_Name (String VAHRUAE_Name){if (VAHRUAE_Name == null) throw new ArgumentException ("VAHRUAE_Name is mandatory.");if (VAHRUAE_Name.Length > 50){log.Warning("Length > 50 - truncated");VAHRUAE_Name = VAHRUAE_Name.Substring(0,50);}Set_Value ("VAHRUAE_Name", VAHRUAE_Name);}/** Get Name.
@return The name of an entity (record) is used as a default search option in addition to the search key. */
public String GetVAHRUAE_Name() {return (String)Get_Value("VAHRUAE_Name");}/** Set OT Grace In Min.
@param VAHRUAE_OTGraceInMin OT Grace In Min */
public void SetVAHRUAE_OTGraceInMin (DateTime? VAHRUAE_OTGraceInMin){Set_Value ("VAHRUAE_OTGraceInMin", (DateTime?)VAHRUAE_OTGraceInMin);}/** Get OT Grace In Min.
@return OT Grace In Min */
public DateTime? GetVAHRUAE_OTGraceInMin() {return (DateTime?)Get_Value("VAHRUAE_OTGraceInMin");}/** Set OTGraceOutMin.
@param VAHRUAE_OTGraceOutMin OTGraceOutMin */
public void SetVAHRUAE_OTGraceOutMin (DateTime? VAHRUAE_OTGraceOutMin){Set_Value ("VAHRUAE_OTGraceOutMin", (DateTime?)VAHRUAE_OTGraceOutMin);}/** Get OTGraceOutMin.
@return OTGraceOutMin */
public DateTime? GetVAHRUAE_OTGraceOutMin() {return (DateTime?)Get_Value("VAHRUAE_OTGraceOutMin");}/** Set OT In time .
@param VAHRUAE_OTInTime OT In time  */
public void SetVAHRUAE_OTInTime (DateTime? VAHRUAE_OTInTime){Set_Value ("VAHRUAE_OTInTime", (DateTime?)VAHRUAE_OTInTime);}/** Get OT In time .
@return OT In time  */
public DateTime? GetVAHRUAE_OTInTime() {return (DateTime?)Get_Value("VAHRUAE_OTInTime");}/** Set OT In Time (Second).
@param VAHRUAE_OTInTime2 OT In Time (Second) */
public void SetVAHRUAE_OTInTime2 (DateTime? VAHRUAE_OTInTime2){Set_Value ("VAHRUAE_OTInTime2", (DateTime?)VAHRUAE_OTInTime2);}/** Get OT In Time (Second).
@return OT In Time (Second) */
public DateTime? GetVAHRUAE_OTInTime2() {return (DateTime?)Get_Value("VAHRUAE_OTInTime2");}/** Set VAHRUAE_OTInTime3.
@param VAHRUAE_OTInTime3 VAHRUAE_OTInTime3 */
public void SetVAHRUAE_OTInTime3 (DateTime? VAHRUAE_OTInTime3){Set_Value ("VAHRUAE_OTInTime3", (DateTime?)VAHRUAE_OTInTime3);}/** Get VAHRUAE_OTInTime3.
@return VAHRUAE_OTInTime3 */
public DateTime? GetVAHRUAE_OTInTime3() {return (DateTime?)Get_Value("VAHRUAE_OTInTime3");}/** Set OT OutTime.
@param VAHRUAE_OTOutTime OT OutTime */
public void SetVAHRUAE_OTOutTime (DateTime? VAHRUAE_OTOutTime){Set_Value ("VAHRUAE_OTOutTime", (DateTime?)VAHRUAE_OTOutTime);}/** Get OT OutTime.
@return OT OutTime */
public DateTime? GetVAHRUAE_OTOutTime() {return (DateTime?)Get_Value("VAHRUAE_OTOutTime");}/** Set OT Out Time (Second).
@param VAHRUAE_OTOutTime2 OT Out Time (Second) */
public void SetVAHRUAE_OTOutTime2 (DateTime? VAHRUAE_OTOutTime2){Set_Value ("VAHRUAE_OTOutTime2", (DateTime?)VAHRUAE_OTOutTime2);}/** Get OT Out Time (Second).
@return OT Out Time (Second) */
public DateTime? GetVAHRUAE_OTOutTime2() {return (DateTime?)Get_Value("VAHRUAE_OTOutTime2");}/** Set VAHRUAE_OTOutTime3.
@param VAHRUAE_OTOutTime3 VAHRUAE_OTOutTime3 */
public void SetVAHRUAE_OTOutTime3 (DateTime? VAHRUAE_OTOutTime3){Set_Value ("VAHRUAE_OTOutTime3", (DateTime?)VAHRUAE_OTOutTime3);}/** Get VAHRUAE_OTOutTime3.
@return VAHRUAE_OTOutTime3 */
public DateTime? GetVAHRUAE_OTOutTime3() {return (DateTime?)Get_Value("VAHRUAE_OTOutTime3");}/** Set OT Type.
@param VAHRUAE_OTRule_ID OT Type */
public void SetVAHRUAE_OTRule_ID (int VAHRUAE_OTRule_ID){if (VAHRUAE_OTRule_ID <= 0) Set_Value ("VAHRUAE_OTRule_ID", null);else
Set_Value ("VAHRUAE_OTRule_ID", VAHRUAE_OTRule_ID);}/** Get OT Type.
@return OT Type */
public int GetVAHRUAE_OTRule_ID() {Object ii = Get_Value("VAHRUAE_OTRule_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}
/** VAHRUAE_OTStartAfterTime AD_Reference_ID=1000297 */
public static int VAHRUAE_OTSTARTAFTERTIME_AD_Reference_ID=1000297;/** NA = 00 */
public static String VAHRUAE_OTSTARTAFTERTIME_NA = "00";/** 15 Minutes = 01 */
public static String VAHRUAE_OTSTARTAFTERTIME_15Minutes = "01";/** 30 Minutes = 02 */
public static String VAHRUAE_OTSTARTAFTERTIME_30Minutes = "02";/** 45 Minutes = 03 */
public static String VAHRUAE_OTSTARTAFTERTIME_45Minutes = "03";/** 1 Hour = 04 */
public static String VAHRUAE_OTSTARTAFTERTIME_1Hour = "04";/** 2 Hours = 05 */
public static String VAHRUAE_OTSTARTAFTERTIME_2Hours = "05";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_OTStartAfterTimeValid (String test){return test == null || test.Equals("00") || test.Equals("01") || test.Equals("02") || test.Equals("03") || test.Equals("04") || test.Equals("05");}/** Set OT Start After Time.
@param VAHRUAE_OTStartAfterTime OT Start After Time */
public void SetVAHRUAE_OTStartAfterTime (String VAHRUAE_OTStartAfterTime){if (!IsVAHRUAE_OTStartAfterTimeValid(VAHRUAE_OTStartAfterTime))
throw new ArgumentException ("VAHRUAE_OTStartAfterTime Invalid value - " + VAHRUAE_OTStartAfterTime + " - Reference_ID=1000297 - 00 - 01 - 02 - 03 - 04 - 05");if (VAHRUAE_OTStartAfterTime != null && VAHRUAE_OTStartAfterTime.Length > 2){log.Warning("Length > 2 - truncated");VAHRUAE_OTStartAfterTime = VAHRUAE_OTStartAfterTime.Substring(0,2);}Set_Value ("VAHRUAE_OTStartAfterTime", VAHRUAE_OTStartAfterTime);}/** Get OT Start After Time.
@return OT Start After Time */
public String GetVAHRUAE_OTStartAfterTime() {return (String)Get_Value("VAHRUAE_OTStartAfterTime");}
/** VAHRUAE_OTTimeSlot AD_Reference_ID=1000299 */
public static int VAHRUAE_OTTIMESLOT_AD_Reference_ID=1000299;/** NA = 000 */
public static String VAHRUAE_OTTIMESLOT_NA = "000";/** 05 Minutes = 005 */
public static String VAHRUAE_OTTIMESLOT_05Minutes = "005";/** 10 Minutes = 010 */
public static String VAHRUAE_OTTIMESLOT_10Minutes = "010";/** 15 Minutes = 015 */
public static String VAHRUAE_OTTIMESLOT_15Minutes = "015";/** 20 Minutes = 020 */
public static String VAHRUAE_OTTIMESLOT_20Minutes = "020";/** 25 Minutes = 025 */
public static String VAHRUAE_OTTIMESLOT_25Minutes = "025";/** 30 Minutes = 030 */
public static String VAHRUAE_OTTIMESLOT_30Minutes = "030";/** 35 Minutes = 035 */
public static String VAHRUAE_OTTIMESLOT_35Minutes = "035";/** 40 Minutes = 040 */
public static String VAHRUAE_OTTIMESLOT_40Minutes = "040";/** 45 Minutes = 045 */
public static String VAHRUAE_OTTIMESLOT_45Minutes = "045";/** 50 Minutes = 050 */
public static String VAHRUAE_OTTIMESLOT_50Minutes = "050";/** 55 Minutes = 055 */
public static String VAHRUAE_OTTIMESLOT_55Minutes = "055";/** 1 Hour = 100 */
public static String VAHRUAE_OTTIMESLOT_1Hour = "100";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_OTTimeSlotValid (String test){return test == null || test.Equals("000") || test.Equals("005") || test.Equals("010") || test.Equals("015") || test.Equals("020") || test.Equals("025") || test.Equals("030") || test.Equals("035") || test.Equals("040") || test.Equals("045") || test.Equals("050") || test.Equals("055") || test.Equals("100");}/** Set OT Time Slot.
@param VAHRUAE_OTTimeSlot OT Time Slot */
public void SetVAHRUAE_OTTimeSlot (String VAHRUAE_OTTimeSlot){if (!IsVAHRUAE_OTTimeSlotValid(VAHRUAE_OTTimeSlot))
throw new ArgumentException ("VAHRUAE_OTTimeSlot Invalid value - " + VAHRUAE_OTTimeSlot + " - Reference_ID=1000299 - 000 - 005 - 010 - 015 - 020 - 025 - 030 - 035 - 040 - 045 - 050 - 055 - 100");if (VAHRUAE_OTTimeSlot != null && VAHRUAE_OTTimeSlot.Length > 3){log.Warning("Length > 3 - truncated");VAHRUAE_OTTimeSlot = VAHRUAE_OTTimeSlot.Substring(0,3);}Set_Value ("VAHRUAE_OTTimeSlot", VAHRUAE_OTTimeSlot);}/** Get OT Time Slot.
@return OT Time Slot */
public String GetVAHRUAE_OTTimeSlot() {return (String)Get_Value("VAHRUAE_OTTimeSlot");}/** Set OT Total Working Hours.
@param VAHRUAE_OTTotalWorkingHours OT Total Working Hours */
public void SetVAHRUAE_OTTotalWorkingHours (Decimal? VAHRUAE_OTTotalWorkingHours){Set_Value ("VAHRUAE_OTTotalWorkingHours", (Decimal?)VAHRUAE_OTTotalWorkingHours);}/** Get OT Total Working Hours.
@return OT Total Working Hours */
public Decimal GetVAHRUAE_OTTotalWorkingHours() {Object bd =Get_Value("VAHRUAE_OTTotalWorkingHours");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Out Time.
@param VAHRUAE_OutTime Out Time */
public void SetVAHRUAE_OutTime (DateTime? VAHRUAE_OutTime){Set_Value ("VAHRUAE_OutTime", (DateTime?)VAHRUAE_OutTime);}/** Get Out Time.
@return Out Time */
public DateTime? GetVAHRUAE_OutTime() {return (DateTime?)Get_Value("VAHRUAE_OutTime");}/** Set Out Time (Second).
@param VAHRUAE_OutTime2 Out Time (Second) */
public void SetVAHRUAE_OutTime2 (DateTime? VAHRUAE_OutTime2){Set_Value ("VAHRUAE_OutTime2", (DateTime?)VAHRUAE_OutTime2);}/** Get Out Time (Second).
@return Out Time (Second) */
public DateTime? GetVAHRUAE_OutTime2() {return (DateTime?)Get_Value("VAHRUAE_OutTime2");}/** Set VAHRUAE_OutTime3.
@param VAHRUAE_OutTime3 VAHRUAE_OutTime3 */
public void SetVAHRUAE_OutTime3 (DateTime? VAHRUAE_OutTime3){Set_Value ("VAHRUAE_OutTime3", (DateTime?)VAHRUAE_OutTime3);}/** Get VAHRUAE_OutTime3.
@return VAHRUAE_OutTime3 */
public DateTime? GetVAHRUAE_OutTime3() {return (DateTime?)Get_Value("VAHRUAE_OutTime3");}/** Set OverTimeApplied.
@param VAHRUAE_OverTimeApplied OverTimeApplied */
public void SetVAHRUAE_OverTimeApplied (Boolean VAHRUAE_OverTimeApplied){Set_Value ("VAHRUAE_OverTimeApplied", VAHRUAE_OverTimeApplied);}/** Get OverTimeApplied.
@return OverTimeApplied */
public Boolean IsVAHRUAE_OverTimeApplied() {Object oo = Get_Value("VAHRUAE_OverTimeApplied");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Penalty Amount.
@param VAHRUAE_Penality Penalty Amount */
public void SetVAHRUAE_Penality (Boolean VAHRUAE_Penality){Set_Value ("VAHRUAE_Penality", VAHRUAE_Penality);}/** Get Penalty Amount.
@return Penalty Amount */
public Boolean IsVAHRUAE_Penality() {Object oo = Get_Value("VAHRUAE_Penality");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Rotational Shift Days off Duty.
@param VAHRUAE_ROTATIONALDAYSOFF Rotational Shift Days off Duty */
public void SetVAHRUAE_ROTATIONALDAYSOFF (Decimal? VAHRUAE_ROTATIONALDAYSOFF){Set_Value ("VAHRUAE_ROTATIONALDAYSOFF", (Decimal?)VAHRUAE_ROTATIONALDAYSOFF);}/** Get Rotational Shift Days off Duty.
@return Rotational Shift Days off Duty */
public Decimal GetVAHRUAE_ROTATIONALDAYSOFF() {Object bd =Get_Value("VAHRUAE_ROTATIONALDAYSOFF");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Rotational Shift Days on Duty.
@param VAHRUAE_ROTATIONALDAYSONDUTY Rotational Shift Days on Duty */
public void SetVAHRUAE_ROTATIONALDAYSONDUTY (Decimal? VAHRUAE_ROTATIONALDAYSONDUTY){Set_Value ("VAHRUAE_ROTATIONALDAYSONDUTY", (Decimal?)VAHRUAE_ROTATIONALDAYSONDUTY);}/** Get Rotational Shift Days on Duty.
@return Rotational Shift Days on Duty */
public Decimal GetVAHRUAE_ROTATIONALDAYSONDUTY() {Object bd =Get_Value("VAHRUAE_ROTATIONALDAYSONDUTY");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Rotational Shift Hours (Second).
@param VAHRUAE_RotationalShiftHours2 Rotational Shift Hours (Second) */
public void SetVAHRUAE_RotationalShiftHours2 (Decimal? VAHRUAE_RotationalShiftHours2){Set_Value ("VAHRUAE_RotationalShiftHours2", (Decimal?)VAHRUAE_RotationalShiftHours2);}/** Get Rotational Shift Hours (Second).
@return Rotational Shift Hours (Second) */
public Decimal GetVAHRUAE_RotationalShiftHours2() {Object bd =Get_Value("VAHRUAE_RotationalShiftHours2");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Shift Ends On Next Day.
@param VAHRUAE_ShiftEndsOnNextDay Shift Ends On Next Day */
public void SetVAHRUAE_ShiftEndsOnNextDay (Boolean VAHRUAE_ShiftEndsOnNextDay){Set_Value ("VAHRUAE_ShiftEndsOnNextDay", VAHRUAE_ShiftEndsOnNextDay);}/** Get Shift Ends On Next Day.
@return Shift Ends On Next Day */
public Boolean IsVAHRUAE_ShiftEndsOnNextDay() {Object oo = Get_Value("VAHRUAE_ShiftEndsOnNextDay");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Total Working Hours.
@param VAHRUAE_TotalWorkingHours Total Working Hours */
public void SetVAHRUAE_TotalWorkingHours (Decimal? VAHRUAE_TotalWorkingHours){Set_Value ("VAHRUAE_TotalWorkingHours", (Decimal?)VAHRUAE_TotalWorkingHours);}/** Get Total Working Hours.
@return Total Working Hours */
public Decimal GetVAHRUAE_TotalWorkingHours() {Object bd =Get_Value("VAHRUAE_TotalWorkingHours");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set WEDNESDAYOFF.
@param WEDNESDAYOFF WEDNESDAYOFF */
public void SetWEDNESDAYOFF (Boolean WEDNESDAYOFF){Set_Value ("WEDNESDAYOFF", WEDNESDAYOFF);}/** Get WEDNESDAYOFF.
@return WEDNESDAYOFF */
public Boolean IsWEDNESDAYOFF() {Object oo = Get_Value("WEDNESDAYOFF");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set WORKINGHOURBASED.
@param WORKINGHOURBASED WORKINGHOURBASED */
public void SetWORKINGHOURBASED (Boolean WORKINGHOURBASED){Set_Value ("WORKINGHOURBASED", WORKINGHOURBASED);}/** Get WORKINGHOURBASED.
@return WORKINGHOURBASED */
public Boolean IsWORKINGHOURBASED() {Object oo = Get_Value("WORKINGHOURBASED");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}}
}