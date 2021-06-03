namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_HR_LeaveDetail
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_HR_LeaveDetail : PO{public X_VAHRUAE_HR_LeaveDetail (Context ctx, int VAHRUAE_HR_LeaveDetail_ID, Trx trxName) : base (ctx, VAHRUAE_HR_LeaveDetail_ID, trxName){/** if (VAHRUAE_HR_LeaveDetail_ID == 0){SetC_BPartner_ID (0);// @C_BPartner_ID@
SetVAHRUAE_HR_LeaveDetail_ID (0);SetVAHRUAE_Vss_Holiday_ID (0);} */
}public X_VAHRUAE_HR_LeaveDetail (Ctx ctx, int VAHRUAE_HR_LeaveDetail_ID, Trx trxName) : base (ctx, VAHRUAE_HR_LeaveDetail_ID, trxName){/** if (VAHRUAE_HR_LeaveDetail_ID == 0){SetC_BPartner_ID (0);// @C_BPartner_ID@
SetVAHRUAE_HR_LeaveDetail_ID (0);SetVAHRUAE_Vss_Holiday_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_LeaveDetail (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_LeaveDetail (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_LeaveDetail (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_HR_LeaveDetail(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27900871189781L;/** Last Updated Timestamp 4/18/2021 1:37:53 PM */
public static long updatedMS = 1618745872992L;/** AD_Table_ID=1000803 */
public static int Table_ID; // =1000803;
/** TableName=VAHRUAE_HR_LeaveDetail */
public static String Table_Name="VAHRUAE_HR_LeaveDetail";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_HR_LeaveDetail[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Business Partner.
@param C_BPartner_ID Identifies a Customer/Prospect */
public void SetC_BPartner_ID (int C_BPartner_ID){if (C_BPartner_ID < 1) throw new ArgumentException ("C_BPartner_ID is mandatory.");Set_ValueNoCheck ("C_BPartner_ID", C_BPartner_ID);}/** Get Business Partner.
@return Identifies a Customer/Prospect */
public int GetC_BPartner_ID() {Object ii = Get_Value("C_BPartner_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Processed.
@param Processed The document has been processed */
public void SetProcessed (Boolean Processed){Set_Value ("Processed", Processed);}/** Get Processed.
@return The document has been processed */
public Boolean IsProcessed() {Object oo = Get_Value("Processed");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Approve .
@param VAHRUAE_Approve Approve  */
public void SetVAHRUAE_Approve (String VAHRUAE_Approve){if (VAHRUAE_Approve != null && VAHRUAE_Approve.Length > 10){log.Warning("Length > 10 - truncated");VAHRUAE_Approve = VAHRUAE_Approve.Substring(0,10);}Set_Value ("VAHRUAE_Approve", VAHRUAE_Approve);}/** Get Approve .
@return Approve  */
public String GetVAHRUAE_Approve() {return (String)Get_Value("VAHRUAE_Approve");}/** Set Cancel.
@param VAHRUAE_CancelApprove Denotes if the applied leave is cancelled or not.  */
public void SetVAHRUAE_CancelApprove (Boolean VAHRUAE_CancelApprove){Set_Value ("VAHRUAE_CancelApprove", VAHRUAE_CancelApprove);}/** Get Cancel.
@return Denotes if the applied leave is cancelled or not.  */
public Boolean IsVAHRUAE_CancelApprove() {Object oo = Get_Value("VAHRUAE_CancelApprove");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Cancel Leave.
@param VAHRUAE_CancelLeave Cancel Leave */
public void SetVAHRUAE_CancelLeave (String VAHRUAE_CancelLeave){if (VAHRUAE_CancelLeave != null && VAHRUAE_CancelLeave.Length > 50){log.Warning("Length > 50 - truncated");VAHRUAE_CancelLeave = VAHRUAE_CancelLeave.Substring(0,50);}Set_Value ("VAHRUAE_CancelLeave", VAHRUAE_CancelLeave);}/** Get Cancel Leave.
@return Cancel Leave */
public String GetVAHRUAE_CancelLeave() {return (String)Get_Value("VAHRUAE_CancelLeave");}/** Set Date.
@param VAHRUAE_Date1 Date */
public void SetVAHRUAE_Date1 (DateTime? VAHRUAE_Date1){Set_Value ("VAHRUAE_Date1", (DateTime?)VAHRUAE_Date1);}/** Get Date.
@return Date */
public DateTime? GetVAHRUAE_Date1() {return (DateTime?)Get_Value("VAHRUAE_Date1");}/** Set HR Leave Detail.
@param VAHRUAE_HR_LeaveDetail_ID HR Leave Detail */
public void SetVAHRUAE_HR_LeaveDetail_ID (int VAHRUAE_HR_LeaveDetail_ID){if (VAHRUAE_HR_LeaveDetail_ID < 1) throw new ArgumentException ("VAHRUAE_HR_LeaveDetail_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_HR_LeaveDetail_ID", VAHRUAE_HR_LeaveDetail_ID);}/** Get HR Leave Detail.
@return HR Leave Detail */
public int GetVAHRUAE_HR_LeaveDetail_ID() {Object ii = Get_Value("VAHRUAE_HR_LeaveDetail_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Leave Type ID.
@param VAHRUAE_HR_LeaveType_ID Leave Type ID */
public void SetVAHRUAE_HR_LeaveType_ID (int VAHRUAE_HR_LeaveType_ID){if (VAHRUAE_HR_LeaveType_ID <= 0) Set_Value ("VAHRUAE_HR_LeaveType_ID", null);else
Set_Value ("VAHRUAE_HR_LeaveType_ID", VAHRUAE_HR_LeaveType_ID);}/** Get Leave Type ID.
@return Leave Type ID */
public int GetVAHRUAE_HR_LeaveType_ID() {Object ii = Get_Value("VAHRUAE_HR_LeaveType_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Hours.
@param VAHRUAE_Hours Hours */
public void SetVAHRUAE_Hours (String VAHRUAE_Hours){if (VAHRUAE_Hours != null && VAHRUAE_Hours.Length > 10){log.Warning("Length > 10 - truncated");VAHRUAE_Hours = VAHRUAE_Hours.Substring(0,10);}Set_Value ("VAHRUAE_Hours", VAHRUAE_Hours);}/** Get Hours.
@return Hours */
public String GetVAHRUAE_Hours() {return (String)Get_Value("VAHRUAE_Hours");}/** Set Approved.
@param VAHRUAE_IsApproved Indicates if this document requires approval */
public void SetVAHRUAE_IsApproved (Boolean VAHRUAE_IsApproved){Set_Value ("VAHRUAE_IsApproved", VAHRUAE_IsApproved);}/** Get Approved.
@return Indicates if this document requires approval */
public Boolean IsVAHRUAE_IsApproved() {Object oo = Get_Value("VAHRUAE_IsApproved");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Half Day.
@param VAHRUAE_IsHalfDay Half Day */
public void SetVAHRUAE_IsHalfDay (Boolean VAHRUAE_IsHalfDay){Set_Value ("VAHRUAE_IsHalfDay", VAHRUAE_IsHalfDay);}/** Get Half Day.
@return Half Day */
public Boolean IsVAHRUAE_IsHalfDay() {Object oo = Get_Value("VAHRUAE_IsHalfDay");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Holiday.
@param VAHRUAE_IsHoliday Holiday */
public void SetVAHRUAE_IsHoliday (Boolean VAHRUAE_IsHoliday){Set_Value ("VAHRUAE_IsHoliday", VAHRUAE_IsHoliday);}/** Get Holiday.
@return Holiday */
public Boolean IsVAHRUAE_IsHoliday() {Object oo = Get_Value("VAHRUAE_IsHoliday");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}
/** VAHRUAE_LeaveType AD_Reference_ID=1000286 */
public static int VAHRUAE_LEAVETYPE_AD_Reference_ID=1000286;/** Annual Vacation Leave = AL */
public static String VAHRUAE_LEAVETYPE_AnnualVacationLeave = "AL";/** Bereavement Leave = BL */
public static String VAHRUAE_LEAVETYPE_BereavementLeave = "BL";/** Marriage Leave = MA */
public static String VAHRUAE_LEAVETYPE_MarriageLeave = "MA";/** Maternity Leave = MT */
public static String VAHRUAE_LEAVETYPE_MaternityLeave = "MT";/** Other Leave = OL */
public static String VAHRUAE_LEAVETYPE_OtherLeave = "OL";/** Sick Leave = SL */
public static String VAHRUAE_LEAVETYPE_SickLeave = "SL";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_LeaveTypeValid (String test){return test == null || test.Equals("AL") || test.Equals("BL") || test.Equals("MA") || test.Equals("MT") || test.Equals("OL") || test.Equals("SL");}/** Set Leave Type.
@param VAHRUAE_LeaveType Leave Type */
public void SetVAHRUAE_LeaveType (String VAHRUAE_LeaveType){if (!IsVAHRUAE_LeaveTypeValid(VAHRUAE_LeaveType))
throw new ArgumentException ("VAHRUAE_LeaveType Invalid value - " + VAHRUAE_LeaveType + " - Reference_ID=1000286 - AL - BL - MA - MT - OL - SL");if (VAHRUAE_LeaveType != null && VAHRUAE_LeaveType.Length > 2){log.Warning("Length > 2 - truncated");VAHRUAE_LeaveType = VAHRUAE_LeaveType.Substring(0,2);}Set_Value ("VAHRUAE_LeaveType", VAHRUAE_LeaveType);}/** Get Leave Type.
@return Leave Type */
public String GetVAHRUAE_LeaveType() {return (String)Get_Value("VAHRUAE_LeaveType");}/** Set Holiday.
@param VAHRUAE_Vss_Holiday_ID Holiday */
public void SetVAHRUAE_Vss_Holiday_ID (int VAHRUAE_Vss_Holiday_ID){if (VAHRUAE_Vss_Holiday_ID < 1) throw new ArgumentException ("VAHRUAE_Vss_Holiday_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_Vss_Holiday_ID", VAHRUAE_Vss_Holiday_ID);}/** Get Holiday.
@return Holiday */
public int GetVAHRUAE_Vss_Holiday_ID() {Object ii = Get_Value("VAHRUAE_Vss_Holiday_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}}
}