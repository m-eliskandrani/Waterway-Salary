namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_HR_Penality
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_HR_Penality : PO{public X_VAHRUAE_HR_Penality (Context ctx, int VAHRUAE_HR_Penality_ID, Trx trxName) : base (ctx, VAHRUAE_HR_Penality_ID, trxName){/** if (VAHRUAE_HR_Penality_ID == 0){SetVAHRUAE_HR_Penality_ID (0);} */
}public X_VAHRUAE_HR_Penality (Ctx ctx, int VAHRUAE_HR_Penality_ID, Trx trxName) : base (ctx, VAHRUAE_HR_Penality_ID, trxName){/** if (VAHRUAE_HR_Penality_ID == 0){SetVAHRUAE_HR_Penality_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_Penality (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_Penality (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_Penality (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_HR_Penality(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27903031138564L;/** Last Updated Timestamp 5/13/2021 1:37:01 PM */
public static long updatedMS = 1620905821775L;/** AD_Table_ID=1000847 */
public static int Table_ID; // =1000847;
/** TableName=VAHRUAE_HR_Penality */
public static String Table_Name="VAHRUAE_HR_Penality";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_HR_Penality[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Description.
@param VAHRUAE_Description Description */
public void SetVAHRUAE_Description (String VAHRUAE_Description){if (VAHRUAE_Description != null && VAHRUAE_Description.Length > 255){log.Warning("Length > 255 - truncated");VAHRUAE_Description = VAHRUAE_Description.Substring(0,255);}Set_Value ("VAHRUAE_Description", VAHRUAE_Description);}/** Get Description.
@return Description */
public String GetVAHRUAE_Description() {return (String)Get_Value("VAHRUAE_Description");}/** Set Penalty.
@param VAHRUAE_HR_Penality_ID Penalty */
public void SetVAHRUAE_HR_Penality_ID (int VAHRUAE_HR_Penality_ID){if (VAHRUAE_HR_Penality_ID < 1) throw new ArgumentException ("VAHRUAE_HR_Penality_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_HR_Penality_ID", VAHRUAE_HR_Penality_ID);}/** Get Penalty.
@return Penalty */
public int GetVAHRUAE_HR_Penality_ID() {Object ii = Get_Value("VAHRUAE_HR_Penality_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Ignore Exception Days.
@param VAHRUAE_IgnoreExceptionDays Ignore Exception Days */
public void SetVAHRUAE_IgnoreExceptionDays (Decimal? VAHRUAE_IgnoreExceptionDays){Set_Value ("VAHRUAE_IgnoreExceptionDays", (Decimal?)VAHRUAE_IgnoreExceptionDays);}/** Get Ignore Exception Days.
@return Ignore Exception Days */
public Decimal GetVAHRUAE_IgnoreExceptionDays() {Object bd =Get_Value("VAHRUAE_IgnoreExceptionDays");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Name.
@param VAHRUAE_Name The name of an entity (record) is used as a default search option in addition to the search key. */
public void SetVAHRUAE_Name (String VAHRUAE_Name){if (VAHRUAE_Name != null && VAHRUAE_Name.Length > 60){log.Warning("Length > 60 - truncated");VAHRUAE_Name = VAHRUAE_Name.Substring(0,60);}Set_Value ("VAHRUAE_Name", VAHRUAE_Name);}/** Get Name.
@return The name of an entity (record) is used as a default search option in addition to the search key. */
public String GetVAHRUAE_Name() {return (String)Get_Value("VAHRUAE_Name");}
/** VAHRUAE_PenalityOn AD_Reference_ID=1000313 */
public static int VAHRUAE_PENALITYON_AD_Reference_ID=1000313;/** Basic = B */
public static String VAHRUAE_PENALITYON_Basic = "B";/** All Earnings = E */
public static String VAHRUAE_PENALITYON_AllEarnings = "E";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_PenalityOnValid (String test){return test == null || test.Equals("B") || test.Equals("E");}/** Set Penality On.
@param VAHRUAE_PenalityOn Penality On */
public void SetVAHRUAE_PenalityOn (String VAHRUAE_PenalityOn){if (!IsVAHRUAE_PenalityOnValid(VAHRUAE_PenalityOn))
throw new ArgumentException ("VAHRUAE_PenalityOn Invalid value - " + VAHRUAE_PenalityOn + " - Reference_ID=1000313 - B - E");if (VAHRUAE_PenalityOn != null && VAHRUAE_PenalityOn.Length > 1){log.Warning("Length > 1 - truncated");VAHRUAE_PenalityOn = VAHRUAE_PenalityOn.Substring(0,1);}Set_Value ("VAHRUAE_PenalityOn", VAHRUAE_PenalityOn);}/** Get Penality On.
@return Penality On */
public String GetVAHRUAE_PenalityOn() {return (String)Get_Value("VAHRUAE_PenalityOn");}}
}