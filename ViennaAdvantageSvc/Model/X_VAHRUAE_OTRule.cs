namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_OTRule
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_OTRule : PO{public X_VAHRUAE_OTRule (Context ctx, int VAHRUAE_OTRule_ID, Trx trxName) : base (ctx, VAHRUAE_OTRule_ID, trxName){/** if (VAHRUAE_OTRule_ID == 0){SetVAHRUAE_Name (null);SetVAHRUAE_OTRule_ID (0);} */
}public X_VAHRUAE_OTRule (Ctx ctx, int VAHRUAE_OTRule_ID, Trx trxName) : base (ctx, VAHRUAE_OTRule_ID, trxName){/** if (VAHRUAE_OTRule_ID == 0){SetVAHRUAE_Name (null);SetVAHRUAE_OTRule_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_OTRule (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_OTRule (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_OTRule (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_OTRule(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27901638022281L;/** Last Updated Timestamp 4/27/2021 10:38:25 AM */
public static long updatedMS = 1619512705492L;/** AD_Table_ID=1000844 */
public static int Table_ID; // =1000844;
/** TableName=VAHRUAE_OTRule */
public static String Table_Name="VAHRUAE_OTRule";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_OTRule[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Description.
@param VAHRUAE_Description Description */
public void SetVAHRUAE_Description (String VAHRUAE_Description){if (VAHRUAE_Description != null && VAHRUAE_Description.Length > 255){log.Warning("Length > 255 - truncated");VAHRUAE_Description = VAHRUAE_Description.Substring(0,255);}Set_Value ("VAHRUAE_Description", VAHRUAE_Description);}/** Get Description.
@return Description */
public String GetVAHRUAE_Description() {return (String)Get_Value("VAHRUAE_Description");}/** Set Name.
@param VAHRUAE_Name The name of an entity (record) is used as a default search option in addition to the search key. */
public void SetVAHRUAE_Name (String VAHRUAE_Name){if (VAHRUAE_Name == null) throw new ArgumentException ("VAHRUAE_Name is mandatory.");if (VAHRUAE_Name.Length > 20){log.Warning("Length > 20 - truncated");VAHRUAE_Name = VAHRUAE_Name.Substring(0,20);}Set_Value ("VAHRUAE_Name", VAHRUAE_Name);}/** Get Name.
@return The name of an entity (record) is used as a default search option in addition to the search key. */
public String GetVAHRUAE_Name() {return (String)Get_Value("VAHRUAE_Name");}/** Set OT Type.
@param VAHRUAE_OTRule_ID OT Type */
public void SetVAHRUAE_OTRule_ID (int VAHRUAE_OTRule_ID){if (VAHRUAE_OTRule_ID < 1) throw new ArgumentException ("VAHRUAE_OTRule_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_OTRule_ID", VAHRUAE_OTRule_ID);}/** Get OT Type.
@return OT Type */
public int GetVAHRUAE_OTRule_ID() {Object ii = Get_Value("VAHRUAE_OTRule_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}}
}