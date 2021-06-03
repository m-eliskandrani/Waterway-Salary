namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_HR_SHIFT_DAYSOFF
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_HR_SHIFT_DAYSOFF : PO{public X_VAHRUAE_HR_SHIFT_DAYSOFF (Context ctx, int VAHRUAE_HR_SHIFT_DAYSOFF_ID, Trx trxName) : base (ctx, VAHRUAE_HR_SHIFT_DAYSOFF_ID, trxName){/** if (VAHRUAE_HR_SHIFT_DAYSOFF_ID == 0){SetDAY (DateTime.Now);SetVAHRUAE_HR_AttendanceRule_ID (0);SetVAHRUAE_HR_SHIFT_DAYSOFF_ID (0);} */
}public X_VAHRUAE_HR_SHIFT_DAYSOFF (Ctx ctx, int VAHRUAE_HR_SHIFT_DAYSOFF_ID, Trx trxName) : base (ctx, VAHRUAE_HR_SHIFT_DAYSOFF_ID, trxName){/** if (VAHRUAE_HR_SHIFT_DAYSOFF_ID == 0){SetDAY (DateTime.Now);SetVAHRUAE_HR_AttendanceRule_ID (0);SetVAHRUAE_HR_SHIFT_DAYSOFF_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_SHIFT_DAYSOFF (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_SHIFT_DAYSOFF (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_SHIFT_DAYSOFF (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_HR_SHIFT_DAYSOFF(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27899842109545L;/** Last Updated Timestamp 4/6/2021 3:46:32 PM */
public static long updatedMS = 1617716792756L;/** AD_Table_ID=1000902 */
public static int Table_ID; // =1000902;
/** TableName=VAHRUAE_HR_SHIFT_DAYSOFF */
public static String Table_Name="VAHRUAE_HR_SHIFT_DAYSOFF";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_HR_SHIFT_DAYSOFF[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set DAY.
@param DAY DAY */
public void SetDAY (DateTime? DAY){if (DAY == null) throw new ArgumentException ("DAY is mandatory.");Set_Value ("DAY", (DateTime?)DAY);}/** Get DAY.
@return DAY */
public DateTime? GetDAY() {return (DateTime?)Get_Value("DAY");}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set VAHRUAE_HR_AttendanceRule_ID.
@param VAHRUAE_HR_AttendanceRule_ID VAHRUAE_HR_AttendanceRule_ID */
public void SetVAHRUAE_HR_AttendanceRule_ID (int VAHRUAE_HR_AttendanceRule_ID){if (VAHRUAE_HR_AttendanceRule_ID < 1) throw new ArgumentException ("VAHRUAE_HR_AttendanceRule_ID is mandatory.");Set_Value ("VAHRUAE_HR_AttendanceRule_ID", VAHRUAE_HR_AttendanceRule_ID);}/** Get VAHRUAE_HR_AttendanceRule_ID.
@return VAHRUAE_HR_AttendanceRule_ID */
public int GetVAHRUAE_HR_AttendanceRule_ID() {Object ii = Get_Value("VAHRUAE_HR_AttendanceRule_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set VAHRUAE_HR_SHIFT_DAYSOFF_ID.
@param VAHRUAE_HR_SHIFT_DAYSOFF_ID VAHRUAE_HR_SHIFT_DAYSOFF_ID */
public void SetVAHRUAE_HR_SHIFT_DAYSOFF_ID (int VAHRUAE_HR_SHIFT_DAYSOFF_ID){if (VAHRUAE_HR_SHIFT_DAYSOFF_ID < 1) throw new ArgumentException ("VAHRUAE_HR_SHIFT_DAYSOFF_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_HR_SHIFT_DAYSOFF_ID", VAHRUAE_HR_SHIFT_DAYSOFF_ID);}/** Get VAHRUAE_HR_SHIFT_DAYSOFF_ID.
@return VAHRUAE_HR_SHIFT_DAYSOFF_ID */
public int GetVAHRUAE_HR_SHIFT_DAYSOFF_ID() {Object ii = Get_Value("VAHRUAE_HR_SHIFT_DAYSOFF_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}}
}