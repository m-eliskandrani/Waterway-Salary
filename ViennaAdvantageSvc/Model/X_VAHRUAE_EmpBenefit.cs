namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_EmpBenefit
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_EmpBenefit : PO{public X_VAHRUAE_EmpBenefit (Context ctx, int VAHRUAE_EmpBenefit_ID, Trx trxName) : base (ctx, VAHRUAE_EmpBenefit_ID, trxName){/** if (VAHRUAE_EmpBenefit_ID == 0){SetVAHRUAE_EmpBenefit_ID (0);SetValue (null);} */
}public X_VAHRUAE_EmpBenefit (Ctx ctx, int VAHRUAE_EmpBenefit_ID, Trx trxName) : base (ctx, VAHRUAE_EmpBenefit_ID, trxName){/** if (VAHRUAE_EmpBenefit_ID == 0){SetVAHRUAE_EmpBenefit_ID (0);SetValue (null);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_EmpBenefit (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_EmpBenefit (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_EmpBenefit (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_EmpBenefit(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27903556714985L;/** Last Updated Timestamp 5/19/2021 3:36:38 PM */
public static long updatedMS = 1621431398196L;/** AD_Table_ID=1000890 */
public static int Table_ID; // =1000890;
/** TableName=VAHRUAE_EmpBenefit */
public static String Table_Name="VAHRUAE_EmpBenefit";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_EmpBenefit[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Comments.
@param Comments Comments or additional information */
public void SetComments (String Comments){if (Comments != null && Comments.Length > 500){log.Warning("Length > 500 - truncated");Comments = Comments.Substring(0,500);}Set_Value ("Comments", Comments);}/** Get Comments.
@return Comments or additional information */
public String GetComments() {return (String)Get_Value("Comments");}/** Set Description.
@param Description Optional short description of the record */
public void SetDescription (String Description){if (Description != null && Description.Length > 500){log.Warning("Length > 500 - truncated");Description = Description.Substring(0,500);}Set_Value ("Description", Description);}/** Get Description.
@return Optional short description of the record */
public String GetDescription() {return (String)Get_Value("Description");}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Name.
@param Name Alphanumeric identifier of the entity */
public void SetName (String Name){if (Name != null && Name.Length > 100){log.Warning("Length > 100 - truncated");Name = Name.Substring(0,100);}Set_Value ("Name", Name);}/** Get Name.
@return Alphanumeric identifier of the entity */
public String GetName() {return (String)Get_Value("Name");}
/** VAHRUAE_BenefitType AD_Reference_ID=1000296 */
public static int VAHRUAE_BENEFITTYPE_AD_Reference_ID=1000296;/** Medical = 01 */
public static String VAHRUAE_BENEFITTYPE_Medical = "01";/** Retirement = 02 */
public static String VAHRUAE_BENEFITTYPE_Retirement = "02";/** Accommodation = 03 */
public static String VAHRUAE_BENEFITTYPE_Accommodation = "03";/** Air Ticketing = 04 */
public static String VAHRUAE_BENEFITTYPE_AirTicketing = "04";/** Vehicle = 05 */
public static String VAHRUAE_BENEFITTYPE_Vehicle = "05";/** Education = 06 */
public static String VAHRUAE_BENEFITTYPE_Education = "06";/** Vacations = 07 */
public static String VAHRUAE_BENEFITTYPE_Vacations = "07";/** Others = 08 */
public static String VAHRUAE_BENEFITTYPE_Others = "08";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_BenefitTypeValid (String test){return test == null || test.Equals("01") || test.Equals("02") || test.Equals("03") || test.Equals("04") || test.Equals("05") || test.Equals("06") || test.Equals("07") || test.Equals("08");}/** Set Benefit Type.
@param VAHRUAE_BenefitType Benefit Type */
public void SetVAHRUAE_BenefitType (String VAHRUAE_BenefitType){if (!IsVAHRUAE_BenefitTypeValid(VAHRUAE_BenefitType))
throw new ArgumentException ("VAHRUAE_BenefitType Invalid value - " + VAHRUAE_BenefitType + " - Reference_ID=1000296 - 01 - 02 - 03 - 04 - 05 - 06 - 07 - 08");if (VAHRUAE_BenefitType != null && VAHRUAE_BenefitType.Length > 2){log.Warning("Length > 2 - truncated");VAHRUAE_BenefitType = VAHRUAE_BenefitType.Substring(0,2);}Set_Value ("VAHRUAE_BenefitType", VAHRUAE_BenefitType);}/** Get Benefit Type.
@return Benefit Type */
public String GetVAHRUAE_BenefitType() {return (String)Get_Value("VAHRUAE_BenefitType");}/** Set Benefit Master.
@param VAHRUAE_EmpBenefit_ID Benefit Master */
public void SetVAHRUAE_EmpBenefit_ID (int VAHRUAE_EmpBenefit_ID){if (VAHRUAE_EmpBenefit_ID < 1) throw new ArgumentException ("VAHRUAE_EmpBenefit_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_EmpBenefit_ID", VAHRUAE_EmpBenefit_ID);}/** Get Benefit Master.
@return Benefit Master */
public int GetVAHRUAE_EmpBenefit_ID() {Object ii = Get_Value("VAHRUAE_EmpBenefit_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Search Key.
@param Value Search key for the record in the format required - must be unique */
public void SetValue (String Value){if (Value == null) throw new ArgumentException ("Value is mandatory.");if (Value.Length > 100){log.Warning("Length > 100 - truncated");Value = Value.Substring(0,100);}Set_Value ("Value", Value);}/** Get Search Key.
@return Search key for the record in the format required - must be unique */
public String GetValue() {return (String)Get_Value("Value");}}
}