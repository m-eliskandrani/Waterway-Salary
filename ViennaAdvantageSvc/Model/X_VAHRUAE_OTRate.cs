namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_OTRate
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_OTRate : PO{public X_VAHRUAE_OTRate (Context ctx, int VAHRUAE_OTRate_ID, Trx trxName) : base (ctx, VAHRUAE_OTRate_ID, trxName){/** if (VAHRUAE_OTRate_ID == 0){SetVAHRUAE_OTRate_ID (0);SetVAHRUAE_OTRule_ID (0);} */
}public X_VAHRUAE_OTRate (Ctx ctx, int VAHRUAE_OTRate_ID, Trx trxName) : base (ctx, VAHRUAE_OTRate_ID, trxName){/** if (VAHRUAE_OTRate_ID == 0){SetVAHRUAE_OTRate_ID (0);SetVAHRUAE_OTRule_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_OTRate (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_OTRate (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_OTRate (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_OTRate(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27901638014977L;/** Last Updated Timestamp 4/27/2021 10:38:18 AM */
public static long updatedMS = 1619512698188L;/** AD_Table_ID=1000843 */
public static int Table_ID; // =1000843;
/** TableName=VAHRUAE_OTRate */
public static String Table_Name="VAHRUAE_OTRate";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_OTRate[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Line No.
@param Line Unique line for this document */
public void SetLine (int Line){Set_Value ("Line", Line);}/** Get Line No.
@return Unique line for this document */
public int GetLine() {Object ii = Get_Value("Line");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set No. of Hours.
@param VAHRUAE_NoOfHours No. of Hours */
public void SetVAHRUAE_NoOfHours (int VAHRUAE_NoOfHours){Set_Value ("VAHRUAE_NoOfHours", VAHRUAE_NoOfHours);}/** Get No. of Hours.
@return No. of Hours */
public int GetVAHRUAE_NoOfHours() {Object ii = Get_Value("VAHRUAE_NoOfHours");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set OT Rate.
@param VAHRUAE_OTRate OT Rate */
public void SetVAHRUAE_OTRate (Decimal? VAHRUAE_OTRate){Set_Value ("VAHRUAE_OTRate", (Decimal?)VAHRUAE_OTRate);}/** Get OT Rate.
@return OT Rate */
public Decimal GetVAHRUAE_OTRate() {Object bd =Get_Value("VAHRUAE_OTRate");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set OT Rate.
@param VAHRUAE_OTRate_ID OT Rate */
public void SetVAHRUAE_OTRate_ID (int VAHRUAE_OTRate_ID){if (VAHRUAE_OTRate_ID < 1) throw new ArgumentException ("VAHRUAE_OTRate_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_OTRate_ID", VAHRUAE_OTRate_ID);}/** Get OT Rate.
@return OT Rate */
public int GetVAHRUAE_OTRate_ID() {Object ii = Get_Value("VAHRUAE_OTRate_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set OT Type.
@param VAHRUAE_OTRule_ID OT Type */
public void SetVAHRUAE_OTRule_ID (int VAHRUAE_OTRule_ID){if (VAHRUAE_OTRule_ID < 1) throw new ArgumentException ("VAHRUAE_OTRule_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_OTRule_ID", VAHRUAE_OTRule_ID);}/** Get OT Type.
@return OT Type */
public int GetVAHRUAE_OTRule_ID() {Object ii = Get_Value("VAHRUAE_OTRule_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}
/** VAHRUAE_OtType AD_Reference_ID=1000311 */
public static int VAHRUAE_OTTYPE_AD_Reference_ID=1000311;/** Holiday Overtime = HO */
public static String VAHRUAE_OTTYPE_HolidayOvertime = "HO";/** Normal Overtime = NO */
public static String VAHRUAE_OTTYPE_NormalOvertime = "NO";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_OtTypeValid (String test){return test == null || test.Equals("HO") || test.Equals("NO");}/** Set OT Type.
@param VAHRUAE_OtType OT Type */
public void SetVAHRUAE_OtType (String VAHRUAE_OtType){if (!IsVAHRUAE_OtTypeValid(VAHRUAE_OtType))
throw new ArgumentException ("VAHRUAE_OtType Invalid value - " + VAHRUAE_OtType + " - Reference_ID=1000311 - HO - NO");if (VAHRUAE_OtType != null && VAHRUAE_OtType.Length > 2){log.Warning("Length > 2 - truncated");VAHRUAE_OtType = VAHRUAE_OtType.Substring(0,2);}Set_Value ("VAHRUAE_OtType", VAHRUAE_OtType);}/** Get OT Type.
@return OT Type */
public String GetVAHRUAE_OtType() {return (String)Get_Value("VAHRUAE_OtType");}}
}