namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_LeaveSalaryRuleLine
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_LeaveSalaryRuleLine : PO{public X_VAHRUAE_LeaveSalaryRuleLine (Context ctx, int VAHRUAE_LeaveSalaryRuleLine_ID, Trx trxName) : base (ctx, VAHRUAE_LeaveSalaryRuleLine_ID, trxName){/** if (VAHRUAE_LeaveSalaryRuleLine_ID == 0){SetVAHRUAE_LeaveSalaryRuleLine_ID (0);SetVAHRUAE_LeaveType (null);// @VAHRUAE_LeaveType@
SetVAHRUAE_LeaveType_ID (0);} */
}public X_VAHRUAE_LeaveSalaryRuleLine (Ctx ctx, int VAHRUAE_LeaveSalaryRuleLine_ID, Trx trxName) : base (ctx, VAHRUAE_LeaveSalaryRuleLine_ID, trxName){/** if (VAHRUAE_LeaveSalaryRuleLine_ID == 0){SetVAHRUAE_LeaveSalaryRuleLine_ID (0);SetVAHRUAE_LeaveType (null);// @VAHRUAE_LeaveType@
SetVAHRUAE_LeaveType_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_LeaveSalaryRuleLine (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_LeaveSalaryRuleLine (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_LeaveSalaryRuleLine (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_LeaveSalaryRuleLine(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27902420095917L;/** Last Updated Timestamp 5/6/2021 11:52:59 AM */
public static long updatedMS = 1620294779128L;/** AD_Table_ID=1000853 */
public static int Table_ID; // =1000853;
/** TableName=VAHRUAE_LeaveSalaryRuleLine */
public static String Table_Name="VAHRUAE_LeaveSalaryRuleLine";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_LeaveSalaryRuleLine[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Leave Days.
@param VAHRUAE_LeaveDays Leave Days */
public void SetVAHRUAE_LeaveDays (Decimal? VAHRUAE_LeaveDays){Set_Value ("VAHRUAE_LeaveDays", (Decimal?)VAHRUAE_LeaveDays);}/** Get Leave Days.
@return Leave Days */
public Decimal GetVAHRUAE_LeaveDays() {Object bd =Get_Value("VAHRUAE_LeaveDays");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Leave Salary Rule Line.
@param VAHRUAE_LeaveSalaryRuleLine_ID Leave Salary Rule Line */
public void SetVAHRUAE_LeaveSalaryRuleLine_ID (int VAHRUAE_LeaveSalaryRuleLine_ID){if (VAHRUAE_LeaveSalaryRuleLine_ID < 1) throw new ArgumentException ("VAHRUAE_LeaveSalaryRuleLine_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_LeaveSalaryRuleLine_ID", VAHRUAE_LeaveSalaryRuleLine_ID);}/** Get Leave Salary Rule Line.
@return Leave Salary Rule Line */
public int GetVAHRUAE_LeaveSalaryRuleLine_ID() {Object ii = Get_Value("VAHRUAE_LeaveSalaryRuleLine_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}
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
public bool IsVAHRUAE_LeaveTypeValid (String test){return test.Equals("AL") || test.Equals("BL") || test.Equals("MA") || test.Equals("MT") || test.Equals("OL") || test.Equals("SL");}/** Set Leave Type.
@param VAHRUAE_LeaveType Leave Type */
public void SetVAHRUAE_LeaveType (String VAHRUAE_LeaveType){if (VAHRUAE_LeaveType == null) throw new ArgumentException ("VAHRUAE_LeaveType is mandatory");if (!IsVAHRUAE_LeaveTypeValid(VAHRUAE_LeaveType))
throw new ArgumentException ("VAHRUAE_LeaveType Invalid value - " + VAHRUAE_LeaveType + " - Reference_ID=1000286 - AL - BL - MA - MT - OL - SL");if (VAHRUAE_LeaveType.Length > 2){log.Warning("Length > 2 - truncated");VAHRUAE_LeaveType = VAHRUAE_LeaveType.Substring(0,2);}Set_ValueNoCheck ("VAHRUAE_LeaveType", VAHRUAE_LeaveType);}/** Get Leave Type.
@return Leave Type */
public String GetVAHRUAE_LeaveType() {return (String)Get_Value("VAHRUAE_LeaveType");}/** Set Leave Type.
@param VAHRUAE_LeaveType_ID Leave Type */
public void SetVAHRUAE_LeaveType_ID (int VAHRUAE_LeaveType_ID){if (VAHRUAE_LeaveType_ID < 1) throw new ArgumentException ("VAHRUAE_LeaveType_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_LeaveType_ID", VAHRUAE_LeaveType_ID);}/** Get Leave Type.
@return Leave Type */
public int GetVAHRUAE_LeaveType_ID() {Object ii = Get_Value("VAHRUAE_LeaveType_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Remarks.
@param VAHRUAE_Remarks Remarks */
public void SetVAHRUAE_Remarks (String VAHRUAE_Remarks){if (VAHRUAE_Remarks != null && VAHRUAE_Remarks.Length > 255){log.Warning("Length > 255 - truncated");VAHRUAE_Remarks = VAHRUAE_Remarks.Substring(0,255);}Set_Value ("VAHRUAE_Remarks", VAHRUAE_Remarks);}/** Get Remarks.
@return Remarks */
public String GetVAHRUAE_Remarks() {return (String)Get_Value("VAHRUAE_Remarks");}/** Set Salary Percent.
@param VAHRUAE_SalaryPercent Salary Percent */
public void SetVAHRUAE_SalaryPercent (Decimal? VAHRUAE_SalaryPercent){Set_Value ("VAHRUAE_SalaryPercent", (Decimal?)VAHRUAE_SalaryPercent);}/** Get Salary Percent.
@return Salary Percent */
public Decimal GetVAHRUAE_SalaryPercent() {Object bd =Get_Value("VAHRUAE_SalaryPercent");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}}
}