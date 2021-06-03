namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_HR_Holidays
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_HR_Holidays : PO{public X_VAHRUAE_HR_Holidays (Context ctx, int VAHRUAE_HR_Holidays_ID, Trx trxName) : base (ctx, VAHRUAE_HR_Holidays_ID, trxName){/** if (VAHRUAE_HR_Holidays_ID == 0){SetVAHRUAE_HR_HolidayMaster_ID (0);SetVAHRUAE_HR_Holidays_ID (0);} */
}public X_VAHRUAE_HR_Holidays (Ctx ctx, int VAHRUAE_HR_Holidays_ID, Trx trxName) : base (ctx, VAHRUAE_HR_Holidays_ID, trxName){/** if (VAHRUAE_HR_Holidays_ID == 0){SetVAHRUAE_HR_HolidayMaster_ID (0);SetVAHRUAE_HR_Holidays_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_Holidays (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_Holidays (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_Holidays (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_HR_Holidays(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27901037542043L;/** Last Updated Timestamp 4/20/2021 11:50:25 AM */
public static long updatedMS = 1618912225254L;/** AD_Table_ID=1000833 */
public static int Table_ID; // =1000833;
/** TableName=VAHRUAE_HR_Holidays */
public static String Table_Name="VAHRUAE_HR_Holidays";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_HR_Holidays[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set IsDelayed.
@param IsDelayed Is the holiday moved to Thursday.  */
public void SetIsDelayed (Boolean IsDelayed){Set_Value ("IsDelayed", IsDelayed);}/** Get IsDelayed.
@return Is the holiday moved to Thursday.  */
public Boolean IsDelayed() {Object oo = Get_Value("IsDelayed");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set ONTHURSDAY.
@param ONTHURSDAY Is the holiday moved to Thursday.  */
public void SetONTHURSDAY (Boolean ONTHURSDAY){Set_Value ("ONTHURSDAY", ONTHURSDAY);}/** Get ONTHURSDAY.
@return Is the holiday moved to Thursday.  */
public Boolean IsONTHURSDAY() {Object oo = Get_Value("ONTHURSDAY");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Processed.
@param Processed The document has been processed */
public void SetProcessed (Boolean Processed){Set_Value ("Processed", Processed);}/** Get Processed.
@return The document has been processed */
public Boolean IsProcessed() {Object oo = Get_Value("Processed");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Date.
@param VAHRUAE_Date1 Date */
public void SetVAHRUAE_Date1 (DateTime? VAHRUAE_Date1){Set_Value ("VAHRUAE_Date1", (DateTime?)VAHRUAE_Date1);}/** Get Date.
@return Date */
public DateTime? GetVAHRUAE_Date1() {return (DateTime?)Get_Value("VAHRUAE_Date1");}/** Set Year.
@param VAHRUAE_HR_HolidayMaster_ID Year */
public void SetVAHRUAE_HR_HolidayMaster_ID (int VAHRUAE_HR_HolidayMaster_ID){if (VAHRUAE_HR_HolidayMaster_ID < 1) throw new ArgumentException ("VAHRUAE_HR_HolidayMaster_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_HR_HolidayMaster_ID", VAHRUAE_HR_HolidayMaster_ID);}/** Get Year.
@return Year */
public int GetVAHRUAE_HR_HolidayMaster_ID() {Object ii = Get_Value("VAHRUAE_HR_HolidayMaster_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set HR Holidays.
@param VAHRUAE_HR_Holidays_ID HR Holidays */
public void SetVAHRUAE_HR_Holidays_ID (int VAHRUAE_HR_Holidays_ID){if (VAHRUAE_HR_Holidays_ID < 1) throw new ArgumentException ("VAHRUAE_HR_Holidays_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_HR_Holidays_ID", VAHRUAE_HR_Holidays_ID);}/** Get HR Holidays.
@return HR Holidays */
public int GetVAHRUAE_HR_Holidays_ID() {Object ii = Get_Value("VAHRUAE_HR_Holidays_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Holiday Name.
@param VAHRUAE_HolidayName Holiday Name */
public void SetVAHRUAE_HolidayName (String VAHRUAE_HolidayName){if (VAHRUAE_HolidayName != null && VAHRUAE_HolidayName.Length > 50){log.Warning("Length > 50 - truncated");VAHRUAE_HolidayName = VAHRUAE_HolidayName.Substring(0,50);}Set_Value ("VAHRUAE_HolidayName", VAHRUAE_HolidayName);}/** Get Holiday Name.
@return Holiday Name */
public String GetVAHRUAE_HolidayName() {return (String)Get_Value("VAHRUAE_HolidayName");}/** Set Public Holiday.
@param VAHRUAE_PublicHoliday Public Holiday */
public void SetVAHRUAE_PublicHoliday (Boolean VAHRUAE_PublicHoliday){Set_Value ("VAHRUAE_PublicHoliday", VAHRUAE_PublicHoliday);}/** Get Public Holiday.
@return Public Holiday */
public Boolean IsVAHRUAE_PublicHoliday() {Object oo = Get_Value("VAHRUAE_PublicHoliday");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Weekly.
@param VAHRUAE_Weekly Weekly */
public void SetVAHRUAE_Weekly (Boolean VAHRUAE_Weekly){Set_Value ("VAHRUAE_Weekly", VAHRUAE_Weekly);}/** Get Weekly.
@return Weekly */
public Boolean IsVAHRUAE_Weekly() {Object oo = Get_Value("VAHRUAE_Weekly");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Weekly Half.
@param VAHRUAE_WeeklyHalf Weekly Half */
public void SetVAHRUAE_WeeklyHalf (Boolean VAHRUAE_WeeklyHalf){Set_Value ("VAHRUAE_WeeklyHalf", VAHRUAE_WeeklyHalf);}/** Get Weekly Half.
@return Weekly Half */
public Boolean IsVAHRUAE_WeeklyHalf() {Object oo = Get_Value("VAHRUAE_WeeklyHalf");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}}
}