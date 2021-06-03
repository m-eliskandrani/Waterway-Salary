namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_HR_Employee_Penality
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_HR_Employee_Penality : PO{public X_VAHRUAE_HR_Employee_Penality (Context ctx, int VAHRUAE_HR_Employee_Penality_ID, Trx trxName) : base (ctx, VAHRUAE_HR_Employee_Penality_ID, trxName){/** if (VAHRUAE_HR_Employee_Penality_ID == 0){SetVAHRUAE_HR_Employee_Penality_ID (0);} */
}public X_VAHRUAE_HR_Employee_Penality (Ctx ctx, int VAHRUAE_HR_Employee_Penality_ID, Trx trxName) : base (ctx, VAHRUAE_HR_Employee_Penality_ID, trxName){/** if (VAHRUAE_HR_Employee_Penality_ID == 0){SetVAHRUAE_HR_Employee_Penality_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_Employee_Penality (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_Employee_Penality (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_Employee_Penality (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_HR_Employee_Penality(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27903031033404L;/** Last Updated Timestamp 5/13/2021 1:35:16 PM */
public static long updatedMS = 1620905716615L;/** AD_Table_ID=1000904 */
public static int Table_ID; // =1000904;
/** TableName=VAHRUAE_HR_Employee_Penality */
public static String Table_Name="VAHRUAE_HR_Employee_Penality";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_HR_Employee_Penality[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Business Partner.
@param C_BPartner_ID Identifies a Customer/Prospect */
public void SetC_BPartner_ID (int C_BPartner_ID){if (C_BPartner_ID <= 0) Set_Value ("C_BPartner_ID", null);else
Set_Value ("C_BPartner_ID", C_BPartner_ID);}/** Get Business Partner.
@return Identifies a Customer/Prospect */
public int GetC_BPartner_ID() {Object ii = Get_Value("C_BPartner_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Hours.
@param Hours Hours */
public void SetHours (Decimal? Hours){Set_Value ("Hours", (Decimal?)Hours);}/** Get Hours.
@return Hours */
public Decimal GetHours() {Object bd =Get_Value("Hours");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Absent Days.
@param VAHRUAE_Absent_Days Absent Days */
public void SetVAHRUAE_Absent_Days (Boolean VAHRUAE_Absent_Days){Set_Value ("VAHRUAE_Absent_Days", VAHRUAE_Absent_Days);}/** Get Absent Days.
@return Absent Days */
public Boolean IsVAHRUAE_Absent_Days() {Object oo = Get_Value("VAHRUAE_Absent_Days");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Deduction Amount.
@param VAHRUAE_DeductionAmount Deduction Amount */
public void SetVAHRUAE_DeductionAmount (Decimal? VAHRUAE_DeductionAmount){Set_Value ("VAHRUAE_DeductionAmount", (Decimal?)VAHRUAE_DeductionAmount);}/** Get Deduction Amount.
@return Deduction Amount */
public Decimal GetVAHRUAE_DeductionAmount() {Object bd =Get_Value("VAHRUAE_DeductionAmount");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set VAHRUAE_HR_Employee_Penality_ID.
@param VAHRUAE_HR_Employee_Penality_ID VAHRUAE_HR_Employee_Penality_ID */
public void SetVAHRUAE_HR_Employee_Penality_ID (int VAHRUAE_HR_Employee_Penality_ID){if (VAHRUAE_HR_Employee_Penality_ID < 1) throw new ArgumentException ("VAHRUAE_HR_Employee_Penality_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_HR_Employee_Penality_ID", VAHRUAE_HR_Employee_Penality_ID);}/** Get VAHRUAE_HR_Employee_Penality_ID.
@return VAHRUAE_HR_Employee_Penality_ID */
public int GetVAHRUAE_HR_Employee_Penality_ID() {Object ii = Get_Value("VAHRUAE_HR_Employee_Penality_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Penality Details.
@param VAHRUAE_HR_PenalityDetails_ID Penality Details */
public void SetVAHRUAE_HR_PenalityDetails_ID (int VAHRUAE_HR_PenalityDetails_ID){if (VAHRUAE_HR_PenalityDetails_ID <= 0) Set_Value ("VAHRUAE_HR_PenalityDetails_ID", null);else
Set_Value ("VAHRUAE_HR_PenalityDetails_ID", VAHRUAE_HR_PenalityDetails_ID);}/** Get Penality Details.
@return Penality Details */
public int GetVAHRUAE_HR_PenalityDetails_ID() {Object ii = Get_Value("VAHRUAE_HR_PenalityDetails_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}}
}