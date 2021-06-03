namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_MthAttendDetail
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_MthAttendDetail : PO{public X_VAHRUAE_MthAttendDetail (Context ctx, int VAHRUAE_MthAttendDetail_ID, Trx trxName) : base (ctx, VAHRUAE_MthAttendDetail_ID, trxName){/** if (VAHRUAE_MthAttendDetail_ID == 0){SetC_BPartner_ID (0);SetVAHRUAE_MonthlyAttendance_ID (0);SetVAHRUAE_MthAttendDetail_ID (0);} */
}public X_VAHRUAE_MthAttendDetail (Ctx ctx, int VAHRUAE_MthAttendDetail_ID, Trx trxName) : base (ctx, VAHRUAE_MthAttendDetail_ID, trxName){/** if (VAHRUAE_MthAttendDetail_ID == 0){SetC_BPartner_ID (0);SetVAHRUAE_MonthlyAttendance_ID (0);SetVAHRUAE_MthAttendDetail_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_MthAttendDetail (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_MthAttendDetail (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_MthAttendDetail (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_MthAttendDetail(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27901028072465L;/** Last Updated Timestamp 4/20/2021 9:12:35 AM */
public static long updatedMS = 1618902755676L;/** AD_Table_ID=1000809 */
public static int Table_ID; // =1000809;
/** TableName=VAHRUAE_MthAttendDetail */
public static String Table_Name="VAHRUAE_MthAttendDetail";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_MthAttendDetail[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Business Partner.
@param C_BPartner_ID Identifies a Customer/Prospect */
public void SetC_BPartner_ID (int C_BPartner_ID){if (C_BPartner_ID < 1) throw new ArgumentException ("C_BPartner_ID is mandatory.");Set_Value ("C_BPartner_ID", C_BPartner_ID);}/** Get Business Partner.
@return Identifies a Customer/Prospect */
public int GetC_BPartner_ID() {Object ii = Get_Value("C_BPartner_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Period.
@param C_Period_ID Period of the Calendar */
public void SetC_Period_ID (int C_Period_ID){if (C_Period_ID <= 0) Set_Value ("C_Period_ID", null);else
Set_Value ("C_Period_ID", C_Period_ID);}/** Get Period.
@return Period of the Calendar */
public int GetC_Period_ID() {Object ii = Get_Value("C_Period_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Processed.
@param Processed The document has been processed */
public void SetProcessed (Boolean Processed){Set_Value ("Processed", Processed);}/** Get Processed.
@return The document has been processed */
public Boolean IsProcessed() {Object oo = Get_Value("Processed");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set AVL Approved.
@param VAHRUAE_AVLApproved AVL Approved */
public void SetVAHRUAE_AVLApproved (Decimal? VAHRUAE_AVLApproved){Set_Value ("VAHRUAE_AVLApproved", (Decimal?)VAHRUAE_AVLApproved);}/** Get AVL Approved.
@return AVL Approved */
public Decimal GetVAHRUAE_AVLApproved() {Object bd =Get_Value("VAHRUAE_AVLApproved");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Annual Vacation Leave.
@param VAHRUAE_AVLDays Annual Vacation Leave */
public void SetVAHRUAE_AVLDays (Decimal? VAHRUAE_AVLDays){Set_Value ("VAHRUAE_AVLDays", (Decimal?)VAHRUAE_AVLDays);}/** Get Annual Vacation Leave.
@return Annual Vacation Leave */
public Decimal GetVAHRUAE_AVLDays() {Object bd =Get_Value("VAHRUAE_AVLDays");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set AVL Days U.
@param VAHRUAE_AVLDaysU AVL Days U */
public void SetVAHRUAE_AVLDaysU (Decimal? VAHRUAE_AVLDaysU){Set_Value ("VAHRUAE_AVLDaysU", (Decimal?)VAHRUAE_AVLDaysU);}/** Get AVL Days U.
@return AVL Days U */
public Decimal GetVAHRUAE_AVLDaysU() {Object bd =Get_Value("VAHRUAE_AVLDaysU");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set AVL Days U Approved.
@param VAHRUAE_AVLUApproved AVL Days U Approved */
public void SetVAHRUAE_AVLUApproved (Decimal? VAHRUAE_AVLUApproved){Set_Value ("VAHRUAE_AVLUApproved", (Decimal?)VAHRUAE_AVLUApproved);}/** Get AVL Days U Approved.
@return AVL Days U Approved */
public Decimal GetVAHRUAE_AVLUApproved() {Object bd =Get_Value("VAHRUAE_AVLUApproved");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Absent Days.
@param VAHRUAE_Absent_Days Absent Days */
public void SetVAHRUAE_Absent_Days (Decimal? VAHRUAE_Absent_Days){Set_Value ("VAHRUAE_Absent_Days", (Decimal?)VAHRUAE_Absent_Days);}/** Get Absent Days.
@return Absent Days */
public Decimal GetVAHRUAE_Absent_Days() {Object bd =Get_Value("VAHRUAE_Absent_Days");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Present Days.
@param VAHRUAE_Actual_Days_Present Present Days */
public void SetVAHRUAE_Actual_Days_Present (Decimal? VAHRUAE_Actual_Days_Present){Set_Value ("VAHRUAE_Actual_Days_Present", (Decimal?)VAHRUAE_Actual_Days_Present);}/** Get Present Days.
@return Present Days */
public Decimal GetVAHRUAE_Actual_Days_Present() {Object bd =Get_Value("VAHRUAE_Actual_Days_Present");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Bereavement Leave.
@param VAHRUAE_BL Bereavement Leave */
public void SetVAHRUAE_BL (Decimal? VAHRUAE_BL){Set_Value ("VAHRUAE_BL", (Decimal?)VAHRUAE_BL);}/** Get Bereavement Leave.
@return Bereavement Leave */
public Decimal GetVAHRUAE_BL() {Object bd =Get_Value("VAHRUAE_BL");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set BL Approved.
@param VAHRUAE_BLApproved BL Approved */
public void SetVAHRUAE_BLApproved (Decimal? VAHRUAE_BLApproved){Set_Value ("VAHRUAE_BLApproved", (Decimal?)VAHRUAE_BLApproved);}/** Get BL Approved.
@return BL Approved */
public Decimal GetVAHRUAE_BLApproved() {Object bd =Get_Value("VAHRUAE_BLApproved");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Early Out Count.
@param VAHRUAE_EarlyOutCount Early Out Count */
public void SetVAHRUAE_EarlyOutCount (Decimal? VAHRUAE_EarlyOutCount){Set_Value ("VAHRUAE_EarlyOutCount", (Decimal?)VAHRUAE_EarlyOutCount);}/** Get Early Out Count.
@return Early Out Count */
public Decimal GetVAHRUAE_EarlyOutCount() {Object bd =Get_Value("VAHRUAE_EarlyOutCount");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Penalty Days.
@param VAHRUAE_FN_PENALITYDAYS Penalty Days */
public void SetVAHRUAE_FN_PENALITYDAYS (Decimal? VAHRUAE_FN_PENALITYDAYS){Set_Value ("VAHRUAE_FN_PENALITYDAYS", (Decimal?)VAHRUAE_FN_PENALITYDAYS);}/** Get Penalty Days.
@return Penalty Days */
public Decimal GetVAHRUAE_FN_PENALITYDAYS() {Object bd =Get_Value("VAHRUAE_FN_PENALITYDAYS");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Holidays.
@param VAHRUAE_HOL_Days Holidays */
public void SetVAHRUAE_HOL_Days (Decimal? VAHRUAE_HOL_Days){Set_Value ("VAHRUAE_HOL_Days", (Decimal?)VAHRUAE_HOL_Days);}/** Get Holidays.
@return Holidays */
public Decimal GetVAHRUAE_HOL_Days() {Object bd =Get_Value("VAHRUAE_HOL_Days");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Holiday OT Amount.
@param VAHRUAE_HolOtAmount Holiday OT Amount */
public void SetVAHRUAE_HolOtAmount (Decimal? VAHRUAE_HolOtAmount){Set_Value ("VAHRUAE_HolOtAmount", (Decimal?)VAHRUAE_HolOtAmount);}/** Get Holiday OT Amount.
@return Holiday OT Amount */
public Decimal GetVAHRUAE_HolOtAmount() {Object bd =Get_Value("VAHRUAE_HolOtAmount");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Holiday OT Hour.
@param VAHRUAE_HolOtHour Holiday OT Hour */
public void SetVAHRUAE_HolOtHour (Decimal? VAHRUAE_HolOtHour){Set_Value ("VAHRUAE_HolOtHour", (Decimal?)VAHRUAE_HolOtHour);}/** Get Holiday OT Hour.
@return Holiday OT Hour */
public Decimal GetVAHRUAE_HolOtHour() {Object bd =Get_Value("VAHRUAE_HolOtHour");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set ML Approved.
@param VAHRUAE_MLApproved ML Approved */
public void SetVAHRUAE_MLApproved (Decimal? VAHRUAE_MLApproved){Set_Value ("VAHRUAE_MLApproved", (Decimal?)VAHRUAE_MLApproved);}/** Get ML Approved.
@return ML Approved */
public Decimal GetVAHRUAE_MLApproved() {Object bd =Get_Value("VAHRUAE_MLApproved");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set MR Approved.
@param VAHRUAE_MRApproved MR Approved */
public void SetVAHRUAE_MRApproved (Decimal? VAHRUAE_MRApproved){Set_Value ("VAHRUAE_MRApproved", (Decimal?)VAHRUAE_MRApproved);}/** Get MR Approved.
@return MR Approved */
public Decimal GetVAHRUAE_MRApproved() {Object bd =Get_Value("VAHRUAE_MRApproved");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Marriage Leave.
@param VAHRUAE_MarriageLeave Marriage Leave */
public void SetVAHRUAE_MarriageLeave (Decimal? VAHRUAE_MarriageLeave){Set_Value ("VAHRUAE_MarriageLeave", (Decimal?)VAHRUAE_MarriageLeave);}/** Get Marriage Leave.
@return Marriage Leave */
public Decimal GetVAHRUAE_MarriageLeave() {Object bd =Get_Value("VAHRUAE_MarriageLeave");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Maternity Leave.
@param VAHRUAE_MaternityLeave Maternity Leave */
public void SetVAHRUAE_MaternityLeave (Decimal? VAHRUAE_MaternityLeave){Set_Value ("VAHRUAE_MaternityLeave", (Decimal?)VAHRUAE_MaternityLeave);}/** Get Maternity Leave.
@return Maternity Leave */
public Decimal GetVAHRUAE_MaternityLeave() {Object bd =Get_Value("VAHRUAE_MaternityLeave");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Attendance.
@param VAHRUAE_MonthlyAttendance_ID Attendance */
public void SetVAHRUAE_MonthlyAttendance_ID (int VAHRUAE_MonthlyAttendance_ID){if (VAHRUAE_MonthlyAttendance_ID < 1) throw new ArgumentException ("VAHRUAE_MonthlyAttendance_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_MonthlyAttendance_ID", VAHRUAE_MonthlyAttendance_ID);}/** Get Attendance.
@return Attendance */
public int GetVAHRUAE_MonthlyAttendance_ID() {Object ii = Get_Value("VAHRUAE_MonthlyAttendance_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Monthly Attendance Detail.
@param VAHRUAE_MthAttendDetail_ID Monthly Attendance Detail */
public void SetVAHRUAE_MthAttendDetail_ID (int VAHRUAE_MthAttendDetail_ID){if (VAHRUAE_MthAttendDetail_ID < 1) throw new ArgumentException ("VAHRUAE_MthAttendDetail_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_MthAttendDetail_ID", VAHRUAE_MthAttendDetail_ID);}/** Get Monthly Attendance Detail.
@return Monthly Attendance Detail */
public int GetVAHRUAE_MthAttendDetail_ID() {Object ii = Get_Value("VAHRUAE_MthAttendDetail_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set No Of Days Present .
@param VAHRUAE_No_Of_Days_Present No Of Days Present  */
public void SetVAHRUAE_No_Of_Days_Present (Decimal? VAHRUAE_No_Of_Days_Present){Set_Value ("VAHRUAE_No_Of_Days_Present", (Decimal?)VAHRUAE_No_Of_Days_Present);}/** Get No Of Days Present .
@return No Of Days Present  */
public Decimal GetVAHRUAE_No_Of_Days_Present() {Object bd =Get_Value("VAHRUAE_No_Of_Days_Present");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Late In Count.
@param VAHRUAE_NotOnTimeDays Late In Count */
public void SetVAHRUAE_NotOnTimeDays (Decimal? VAHRUAE_NotOnTimeDays){Set_Value ("VAHRUAE_NotOnTimeDays", (Decimal?)VAHRUAE_NotOnTimeDays);}/** Get Late In Count.
@return Late In Count */
public Decimal GetVAHRUAE_NotOnTimeDays() {Object bd =Get_Value("VAHRUAE_NotOnTimeDays");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set OL Approved.
@param VAHRUAE_OLApproved OL Approved */
public void SetVAHRUAE_OLApproved (Decimal? VAHRUAE_OLApproved){Set_Value ("VAHRUAE_OLApproved", (Decimal?)VAHRUAE_OLApproved);}/** Get OL Approved.
@return OL Approved */
public Decimal GetVAHRUAE_OLApproved() {Object bd =Get_Value("VAHRUAE_OLApproved");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set OL Days.
@param VAHRUAE_OLDays Other Leave */
public void SetVAHRUAE_OLDays (Decimal? VAHRUAE_OLDays){Set_Value ("VAHRUAE_OLDays", (Decimal?)VAHRUAE_OLDays);}/** Get OL Days.
@return Other Leave */
public Decimal GetVAHRUAE_OLDays() {Object bd =Get_Value("VAHRUAE_OLDays");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set OT Amount.
@param VAHRUAE_OTAmount OT Amount */
public void SetVAHRUAE_OTAmount (Decimal? VAHRUAE_OTAmount){Set_Value ("VAHRUAE_OTAmount", (Decimal?)VAHRUAE_OTAmount);}/** Get OT Amount.
@return OT Amount */
public Decimal GetVAHRUAE_OTAmount() {Object bd =Get_Value("VAHRUAE_OTAmount");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set OT Hour.
@param VAHRUAE_OTHour OT Hour */
public void SetVAHRUAE_OTHour (Decimal? VAHRUAE_OTHour){Set_Value ("VAHRUAE_OTHour", (Decimal?)VAHRUAE_OTHour);}/** Get OT Hour.
@return OT Hour */
public Decimal GetVAHRUAE_OTHour() {Object bd =Get_Value("VAHRUAE_OTHour");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set OT Normal1.
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
public Decimal GetVAHRUAE_OT_Premium() {Object bd =Get_Value("VAHRUAE_OT_Premium");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set On Time Days.
@param VAHRUAE_OnTimeDays On Time Days */
public void SetVAHRUAE_OnTimeDays (Decimal? VAHRUAE_OnTimeDays){Set_Value ("VAHRUAE_OnTimeDays", (Decimal?)VAHRUAE_OnTimeDays);}/** Get On Time Days.
@return On Time Days */
public Decimal GetVAHRUAE_OnTimeDays() {Object bd =Get_Value("VAHRUAE_OnTimeDays");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Over Time.
@param VAHRUAE_OverTime Over Time */
public void SetVAHRUAE_OverTime (DateTime? VAHRUAE_OverTime){Set_Value ("VAHRUAE_OverTime", (DateTime?)VAHRUAE_OverTime);}/** Get Over Time.
@return Over Time */
public DateTime? GetVAHRUAE_OverTime() {return (DateTime?)Get_Value("VAHRUAE_OverTime");}/** Set Process Now.
@param VAHRUAE_Processing Process Now */
public void SetVAHRUAE_Processing (Boolean VAHRUAE_Processing){Set_Value ("VAHRUAE_Processing", VAHRUAE_Processing);}/** Get Process Now.
@return Process Now */
public Boolean IsVAHRUAE_Processing() {Object oo = Get_Value("VAHRUAE_Processing");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set SL Approved.
@param VAHRUAE_SLApproved SL Approved */
public void SetVAHRUAE_SLApproved (Decimal? VAHRUAE_SLApproved){Set_Value ("VAHRUAE_SLApproved", (Decimal?)VAHRUAE_SLApproved);}/** Get SL Approved.
@return SL Approved */
public Decimal GetVAHRUAE_SLApproved() {Object bd =Get_Value("VAHRUAE_SLApproved");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Sick Leave.
@param VAHRUAE_SL_Days Sick Leave */
public void SetVAHRUAE_SL_Days (Decimal? VAHRUAE_SL_Days){Set_Value ("VAHRUAE_SL_Days", (Decimal?)VAHRUAE_SL_Days);}/** Get Sick Leave.
@return Sick Leave */
public Decimal GetVAHRUAE_SL_Days() {Object bd =Get_Value("VAHRUAE_SL_Days");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}}
}