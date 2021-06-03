namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_PositionBenefit
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_PositionBenefit : PO{public X_VAHRUAE_PositionBenefit (Context ctx, int VAHRUAE_PositionBenefit_ID, Trx trxName) : base (ctx, VAHRUAE_PositionBenefit_ID, trxName){/** if (VAHRUAE_PositionBenefit_ID == 0){SetC_Job_ID (0);SetVAHRUAE_PositionBenefit_ID (0);} */
}public X_VAHRUAE_PositionBenefit (Ctx ctx, int VAHRUAE_PositionBenefit_ID, Trx trxName) : base (ctx, VAHRUAE_PositionBenefit_ID, trxName){/** if (VAHRUAE_PositionBenefit_ID == 0){SetC_Job_ID (0);SetVAHRUAE_PositionBenefit_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_PositionBenefit (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_PositionBenefit (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_PositionBenefit (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_PositionBenefit(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27903556720216L;/** Last Updated Timestamp 5/19/2021 3:36:43 PM */
public static long updatedMS = 1621431403427L;/** AD_Table_ID=1000824 */
public static int Table_ID; // =1000824;
/** TableName=VAHRUAE_PositionBenefit */
public static String Table_Name="VAHRUAE_PositionBenefit";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_PositionBenefit[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Position.
@param C_Job_ID Job Position */
public void SetC_Job_ID (int C_Job_ID){if (C_Job_ID < 1) throw new ArgumentException ("C_Job_ID is mandatory.");Set_ValueNoCheck ("C_Job_ID", C_Job_ID);}/** Get Position.
@return Job Position */
public int GetC_Job_ID() {Object ii = Get_Value("C_Job_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Description.
@param Description Optional short description of the record */
public void SetDescription (String Description){if (Description != null && Description.Length > 500){log.Warning("Length > 500 - truncated");Description = Description.Substring(0,500);}Set_Value ("Description", Description);}/** Get Description.
@return Optional short description of the record */
public String GetDescription() {return (String)Get_Value("Description");}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Line No.
@param Line Unique line for this document */
public void SetLine (int Line){Set_Value ("Line", Line);}/** Get Line No.
@return Unique line for this document */
public int GetLine() {Object ii = Get_Value("Line");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Processed.
@param Processed The document has been processed */
public void SetProcessed (Boolean Processed){Set_Value ("Processed", Processed);}/** Get Processed.
@return The document has been processed */
public Boolean IsProcessed() {Object oo = Get_Value("Processed");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Process Now.
@param Processing Process Now */
public void SetProcessing (Boolean Processing){Set_Value ("Processing", Processing);}/** Get Process Now.
@return Process Now */
public Boolean IsProcessing() {Object oo = Get_Value("Processing");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Amount.
@param VAHRUAE_Amount Amount */
public void SetVAHRUAE_Amount (Decimal? VAHRUAE_Amount){Set_Value ("VAHRUAE_Amount", (Decimal?)VAHRUAE_Amount);}/** Get Amount.
@return Amount */
public Decimal GetVAHRUAE_Amount() {Object bd =Get_Value("VAHRUAE_Amount");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}
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
throw new ArgumentException ("VAHRUAE_BenefitType Invalid value - " + VAHRUAE_BenefitType + " - Reference_ID=1000296 - 01 - 02 - 03 - 04 - 05 - 06 - 07 - 08");if (VAHRUAE_BenefitType != null && VAHRUAE_BenefitType.Length > 2){log.Warning("Length > 2 - truncated");VAHRUAE_BenefitType = VAHRUAE_BenefitType.Substring(0,2);}Set_ValueNoCheck ("VAHRUAE_BenefitType", VAHRUAE_BenefitType);}/** Get Benefit Type.
@return Benefit Type */
public String GetVAHRUAE_BenefitType() {return (String)Get_Value("VAHRUAE_BenefitType");}/** Set Benefit Master.
@param VAHRUAE_EmpBenefit_ID Benefit Master */
public void SetVAHRUAE_EmpBenefit_ID (int VAHRUAE_EmpBenefit_ID){if (VAHRUAE_EmpBenefit_ID <= 0) Set_Value ("VAHRUAE_EmpBenefit_ID", null);else
Set_Value ("VAHRUAE_EmpBenefit_ID", VAHRUAE_EmpBenefit_ID);}/** Get Benefit Master.
@return Benefit Master */
public int GetVAHRUAE_EmpBenefit_ID() {Object ii = Get_Value("VAHRUAE_EmpBenefit_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set VAHRUAE_PositionBenefit_ID.
@param VAHRUAE_PositionBenefit_ID VAHRUAE_PositionBenefit_ID */
public void SetVAHRUAE_PositionBenefit_ID (int VAHRUAE_PositionBenefit_ID){if (VAHRUAE_PositionBenefit_ID < 1) throw new ArgumentException ("VAHRUAE_PositionBenefit_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_PositionBenefit_ID", VAHRUAE_PositionBenefit_ID);}/** Get VAHRUAE_PositionBenefit_ID.
@return VAHRUAE_PositionBenefit_ID */
public int GetVAHRUAE_PositionBenefit_ID() {Object ii = Get_Value("VAHRUAE_PositionBenefit_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}}
}