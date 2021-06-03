namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_LeaveSalaryRule
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_LeaveSalaryRule : PO{public X_VAHRUAE_LeaveSalaryRule (Context ctx, int VAHRUAE_LeaveSalaryRule_ID, Trx trxName) : base (ctx, VAHRUAE_LeaveSalaryRule_ID, trxName){/** if (VAHRUAE_LeaveSalaryRule_ID == 0){SetVAHRUAE_LeaveSalaryRule_ID (0);SetVAHRUAE_Name (null);} */
}public X_VAHRUAE_LeaveSalaryRule (Ctx ctx, int VAHRUAE_LeaveSalaryRule_ID, Trx trxName) : base (ctx, VAHRUAE_LeaveSalaryRule_ID, trxName){/** if (VAHRUAE_LeaveSalaryRule_ID == 0){SetVAHRUAE_LeaveSalaryRule_ID (0);SetVAHRUAE_Name (null);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_LeaveSalaryRule (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_LeaveSalaryRule (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_LeaveSalaryRule (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_LeaveSalaryRule(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27902845986549L;/** Last Updated Timestamp 5/11/2021 10:11:09 AM */
public static long updatedMS = 1620720669760L;/** AD_Table_ID=1000851 */
public static int Table_ID; // =1000851;
/** TableName=VAHRUAE_LeaveSalaryRule */
public static String Table_Name="VAHRUAE_LeaveSalaryRule";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_LeaveSalaryRule[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Description.
@param VAHRUAE_Description Description */
public void SetVAHRUAE_Description (String VAHRUAE_Description){if (VAHRUAE_Description != null && VAHRUAE_Description.Length > 255){log.Warning("Length > 255 - truncated");VAHRUAE_Description = VAHRUAE_Description.Substring(0,255);}Set_Value ("VAHRUAE_Description", VAHRUAE_Description);}/** Get Description.
@return Description */
public String GetVAHRUAE_Description() {return (String)Get_Value("VAHRUAE_Description");}/** Set Leave Salary Rule.
@param VAHRUAE_LeaveSalaryRule_ID Leave Salary Rule */
public void SetVAHRUAE_LeaveSalaryRule_ID (int VAHRUAE_LeaveSalaryRule_ID){if (VAHRUAE_LeaveSalaryRule_ID < 1) throw new ArgumentException ("VAHRUAE_LeaveSalaryRule_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_LeaveSalaryRule_ID", VAHRUAE_LeaveSalaryRule_ID);}/** Get Leave Salary Rule.
@return Leave Salary Rule */
public int GetVAHRUAE_LeaveSalaryRule_ID() {Object ii = Get_Value("VAHRUAE_LeaveSalaryRule_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Name.
@param VAHRUAE_Name The name of an entity (record) is used as a default search option in addition to the search key. */
public void SetVAHRUAE_Name (String VAHRUAE_Name){if (VAHRUAE_Name == null) throw new ArgumentException ("VAHRUAE_Name is mandatory.");if (VAHRUAE_Name.Length > 50){log.Warning("Length > 50 - truncated");VAHRUAE_Name = VAHRUAE_Name.Substring(0,50);}Set_Value ("VAHRUAE_Name", VAHRUAE_Name);}/** Get Name.
@return The name of an entity (record) is used as a default search option in addition to the search key. */
public String GetVAHRUAE_Name() {return (String)Get_Value("VAHRUAE_Name");}/** Set Search Key.
@param Value Search key for the record in the format required - must be unique */
public void SetValue (String Value){if (Value != null && Value.Length > 50){log.Warning("Length > 50 - truncated");Value = Value.Substring(0,50);}Set_Value ("Value", Value);}/** Get Search Key.
@return Search key for the record in the format required - must be unique */
public String GetValue() {return (String)Get_Value("Value");}}
}