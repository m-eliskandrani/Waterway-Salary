namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_HR_PenalityDetails
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_HR_PenalityDetails : PO{public X_VAHRUAE_HR_PenalityDetails (Context ctx, int VAHRUAE_HR_PenalityDetails_ID, Trx trxName) : base (ctx, VAHRUAE_HR_PenalityDetails_ID, trxName){/** if (VAHRUAE_HR_PenalityDetails_ID == 0){SetVAHRUAE_HR_PenalityDetails_ID (0);SetVAHRUAE_HR_Penality_ID (0);} */
}public X_VAHRUAE_HR_PenalityDetails (Ctx ctx, int VAHRUAE_HR_PenalityDetails_ID, Trx trxName) : base (ctx, VAHRUAE_HR_PenalityDetails_ID, trxName){/** if (VAHRUAE_HR_PenalityDetails_ID == 0){SetVAHRUAE_HR_PenalityDetails_ID (0);SetVAHRUAE_HR_Penality_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_PenalityDetails (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_PenalityDetails (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_PenalityDetails (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_HR_PenalityDetails(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27903031142851L;/** Last Updated Timestamp 5/13/2021 1:37:06 PM */
public static long updatedMS = 1620905826062L;/** AD_Table_ID=1000846 */
public static int Table_ID; // =1000846;
/** TableName=VAHRUAE_HR_PenalityDetails */
public static String Table_Name="VAHRUAE_HR_PenalityDetails";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_HR_PenalityDetails[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Business Partner.
@param C_BPartner_ID Identifies a Customer/Prospect */
public void SetC_BPartner_ID (int C_BPartner_ID){if (C_BPartner_ID <= 0) Set_Value ("C_BPartner_ID", null);else
Set_Value ("C_BPartner_ID", C_BPartner_ID);}/** Get Business Partner.
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
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Compensation Name.
@param VAHRUAE_CompensationMaster_ID Compensation Name */
public void SetVAHRUAE_CompensationMaster_ID (int VAHRUAE_CompensationMaster_ID){if (VAHRUAE_CompensationMaster_ID <= 0) Set_Value ("VAHRUAE_CompensationMaster_ID", null);else
Set_Value ("VAHRUAE_CompensationMaster_ID", VAHRUAE_CompensationMaster_ID);}/** Get Compensation Name.
@return Compensation Name */
public int GetVAHRUAE_CompensationMaster_ID() {Object ii = Get_Value("VAHRUAE_CompensationMaster_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Days.
@param VAHRUAE_Days Days */
public void SetVAHRUAE_Days (Decimal? VAHRUAE_Days){Set_Value ("VAHRUAE_Days", (Decimal?)VAHRUAE_Days);}/** Get Days.
@return Days */
public Decimal GetVAHRUAE_Days() {Object bd =Get_Value("VAHRUAE_Days");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Deduction Amount.
@param VAHRUAE_DeductionAmount Deduction Amount */
public void SetVAHRUAE_DeductionAmount (Decimal? VAHRUAE_DeductionAmount){Set_Value ("VAHRUAE_DeductionAmount", (Decimal?)VAHRUAE_DeductionAmount);}/** Get Deduction Amount.
@return Deduction Amount */
public Decimal GetVAHRUAE_DeductionAmount() {Object bd =Get_Value("VAHRUAE_DeductionAmount");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Deduction Percentage.
@param VAHRUAE_DeductionPercentage Deduction Percentage */
public void SetVAHRUAE_DeductionPercentage (Decimal? VAHRUAE_DeductionPercentage){Set_Value ("VAHRUAE_DeductionPercentage", (Decimal?)VAHRUAE_DeductionPercentage);}/** Get Deduction Percentage.
@return Deduction Percentage */
public Decimal GetVAHRUAE_DeductionPercentage() {Object bd =Get_Value("VAHRUAE_DeductionPercentage");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Penality Details.
@param VAHRUAE_HR_PenalityDetails_ID Penality Details */
public void SetVAHRUAE_HR_PenalityDetails_ID (int VAHRUAE_HR_PenalityDetails_ID){if (VAHRUAE_HR_PenalityDetails_ID < 1) throw new ArgumentException ("VAHRUAE_HR_PenalityDetails_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_HR_PenalityDetails_ID", VAHRUAE_HR_PenalityDetails_ID);}/** Get Penality Details.
@return Penality Details */
public int GetVAHRUAE_HR_PenalityDetails_ID() {Object ii = Get_Value("VAHRUAE_HR_PenalityDetails_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Penalty.
@param VAHRUAE_HR_Penality_ID Penalty */
public void SetVAHRUAE_HR_Penality_ID (int VAHRUAE_HR_Penality_ID){if (VAHRUAE_HR_Penality_ID < 1) throw new ArgumentException ("VAHRUAE_HR_Penality_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_HR_Penality_ID", VAHRUAE_HR_Penality_ID);}/** Get Penalty.
@return Penalty */
public int GetVAHRUAE_HR_Penality_ID() {Object ii = Get_Value("VAHRUAE_HR_Penality_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Line No.
@param VAHRUAE_Line Line No */
public void SetVAHRUAE_Line (Decimal? VAHRUAE_Line){Set_Value ("VAHRUAE_Line", (Decimal?)VAHRUAE_Line);}/** Get Line No.
@return Line No */
public Decimal GetVAHRUAE_Line() {Object bd =Get_Value("VAHRUAE_Line");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set VAHRUAE_Missing_Punch.
@param VAHRUAE_Missing_Punch VAHRUAE_Missing_Punch */
public void SetVAHRUAE_Missing_Punch (Boolean VAHRUAE_Missing_Punch){Set_Value ("VAHRUAE_Missing_Punch", VAHRUAE_Missing_Punch);}/** Get VAHRUAE_Missing_Punch.
@return VAHRUAE_Missing_Punch */
public Boolean IsVAHRUAE_Missing_Punch() {Object oo = Get_Value("VAHRUAE_Missing_Punch");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}}
}