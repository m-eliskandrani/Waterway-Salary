namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for C_Tax
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_C_Tax : PO{public X_C_Tax (Context ctx, int C_Tax_ID, Trx trxName) : base (ctx, C_Tax_ID, trxName){/** if (C_Tax_ID == 0){SetC_TaxCategory_ID (0);SetC_Tax_ID (0);SetIsDefault (false);SetIsDocumentLevel (false);SetIsSalesTax (false);// N
SetIsSummary (false);SetIsTaxExempt (false);SetName (null);SetRate (0.0);SetRequiresTaxCertificate (false);SetSOPOType (null);// B
SetValidFrom (DateTime.Now);// SYSDATE
} */
}public X_C_Tax (Ctx ctx, int C_Tax_ID, Trx trxName) : base (ctx, C_Tax_ID, trxName){/** if (C_Tax_ID == 0){SetC_TaxCategory_ID (0);SetC_Tax_ID (0);SetIsDefault (false);SetIsDocumentLevel (false);SetIsSalesTax (false);// N
SetIsSummary (false);SetIsTaxExempt (false);SetName (null);SetRate (0.0);SetRequiresTaxCertificate (false);SetSOPOType (null);// B
SetValidFrom (DateTime.Now);// SYSDATE
} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_Tax (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_Tax (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_Tax (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_C_Tax(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27902765103893L;/** Last Updated Timestamp 5/10/2021 11:43:07 AM */
public static long updatedMS = 1620639787104L;/** AD_Table_ID=261 */
public static int Table_ID; // =261;
/** TableName=C_Tax */
public static String Table_Name="C_Tax";
protected static KeyNamePair model;protected Decimal accessLevel = new Decimal(2);/** AccessLevel
@return 2 - Client 
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_C_Tax[").Append(Get_ID()).Append("]");return sb.ToString();}
/** C_Country_ID AD_Reference_ID=156 */
public static int C_COUNTRY_ID_AD_Reference_ID=156;/** Set Country.
@param C_Country_ID Country  */
public void SetC_Country_ID (int C_Country_ID){if (C_Country_ID <= 0) Set_Value ("C_Country_ID", null);else
Set_Value ("C_Country_ID", C_Country_ID);}/** Get Country.
@return Country  */
public int GetC_Country_ID() {Object ii = Get_Value("C_Country_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}
/** C_Region_ID AD_Reference_ID=157 */
public static int C_REGION_ID_AD_Reference_ID=157;/** Set Region.
@param C_Region_ID Identifies a geographical Region */
public void SetC_Region_ID (int C_Region_ID){if (C_Region_ID <= 0) Set_Value ("C_Region_ID", null);else
Set_Value ("C_Region_ID", C_Region_ID);}/** Get Region.
@return Identifies a geographical Region */
public int GetC_Region_ID() {Object ii = Get_Value("C_Region_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Tax Category.
@param C_TaxCategory_ID Tax Category */
public void SetC_TaxCategory_ID (int C_TaxCategory_ID){if (C_TaxCategory_ID < 1) throw new ArgumentException ("C_TaxCategory_ID is mandatory.");Set_Value ("C_TaxCategory_ID", C_TaxCategory_ID);}/** Get Tax Category.
@return Tax Category */
public int GetC_TaxCategory_ID() {Object ii = Get_Value("C_TaxCategory_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Tax.
@param C_Tax_ID Tax identifier */
public void SetC_Tax_ID (int C_Tax_ID){if (C_Tax_ID < 1) throw new ArgumentException ("C_Tax_ID is mandatory.");Set_ValueNoCheck ("C_Tax_ID", C_Tax_ID);}/** Get Tax.
@return Tax identifier */
public int GetC_Tax_ID() {Object ii = Get_Value("C_Tax_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Description.
@param Description Optional short description of the record */
public void SetDescription (String Description){if (Description != null && Description.Length > 255){log.Warning("Length > 255 - truncated");Description = Description.Substring(0,255);}Set_Value ("Description", Description);}/** Get Description.
@return Optional short description of the record */
public String GetDescription() {return (String)Get_Value("Description");}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_ValueNoCheck ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set FlatDeduction.
@param FlatDeduction Amount in a defined currency */
public void SetFlatDeduction (Decimal? FlatDeduction){Set_Value ("FlatDeduction", (Decimal?)FlatDeduction);}/** Get FlatDeduction.
@return Amount in a defined currency */
public Decimal GetFlatDeduction() {Object bd =Get_Value("FlatDeduction");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Default.
@param IsDefault Default value */
public void SetIsDefault (Boolean IsDefault){Set_Value ("IsDefault", IsDefault);}/** Get Default.
@return Default value */
public Boolean IsDefault() {Object oo = Get_Value("IsDefault");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Document Level.
@param IsDocumentLevel Tax is calculated on document level (rather than line by line) */
public void SetIsDocumentLevel (Boolean IsDocumentLevel){Set_Value ("IsDocumentLevel", IsDocumentLevel);}/** Get Document Level.
@return Tax is calculated on document level (rather than line by line) */
public Boolean IsDocumentLevel() {Object oo = Get_Value("IsDocumentLevel");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Include In Cost.
@param IsIncludeInCost This checkbox indicates whether the credit of tax paid on input goods and services is recoverable. If this checkbox is false than tax amount going to add in product cost */
public void SetIsIncludeInCost (Boolean IsIncludeInCost){Set_Value ("IsIncludeInCost", IsIncludeInCost);}/** Get Include In Cost.
@return This checkbox indicates whether the credit of tax paid on input goods and services is recoverable. If this checkbox is false than tax amount going to add in product cost */
public Boolean IsIncludeInCost() {Object oo = Get_Value("IsIncludeInCost");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Income Tax.
@param IsIncomeTax Income Tax */
public void SetIsIncomeTax (Boolean IsIncomeTax){Set_Value ("IsIncomeTax", IsIncomeTax);}/** Get Income Tax.
@return Income Tax */
public Boolean IsIncomeTax() {Object oo = Get_Value("IsIncomeTax");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Sales Tax.
@param IsSalesTax This is a sales tax (i.e. not a value added tax) */
public void SetIsSalesTax (Boolean IsSalesTax){Set_Value ("IsSalesTax", IsSalesTax);}/** Get Sales Tax.
@return This is a sales tax (i.e. not a value added tax) */
public Boolean IsSalesTax() {Object oo = Get_Value("IsSalesTax");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Summary Level.
@param IsSummary This is a summary entity */
public void SetIsSummary (Boolean IsSummary){Set_Value ("IsSummary", IsSummary);}/** Get Summary Level.
@return This is a summary entity */
public Boolean IsSummary() {Object oo = Get_Value("IsSummary");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Surcharge.
@param IsSurcharge an additional charge or payment. */
public void SetIsSurcharge (Boolean IsSurcharge){Set_Value ("IsSurcharge", IsSurcharge);}/** Get Surcharge.
@return an additional charge or payment. */
public Boolean IsSurcharge() {Object oo = Get_Value("IsSurcharge");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Tax exempt.
@param IsTaxExempt Business partner is exempt from tax */
public void SetIsTaxExempt (Boolean IsTaxExempt){Set_Value ("IsTaxExempt", IsTaxExempt);}/** Get Tax exempt.
@return Business partner is exempt from tax */
public Boolean IsTaxExempt() {Object oo = Get_Value("IsTaxExempt");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Line No.
@param Line Unique line for this document */
public void SetLine (Decimal? Line){Set_Value ("Line", (Decimal?)Line);}/** Get Line No.
@return Unique line for this document */
public Decimal GetLine() {Object bd =Get_Value("Line");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Name.
@param Name Alphanumeric identifier of the entity */
public void SetName (String Name){if (Name == null) throw new ArgumentException ("Name is mandatory.");if (Name.Length > 60){log.Warning("Length > 60 - truncated");Name = Name.Substring(0,60);}Set_Value ("Name", Name);}/** Get Name.
@return Alphanumeric identifier of the entity */
public String GetName() {return (String)Get_Value("Name");}/** Get Record ID/ColumnName
@return ID/ColumnName pair */
public KeyNamePair GetKeyNamePair() {return new KeyNamePair(Get_ID(), GetName());}
/** Parent_Tax_ID AD_Reference_ID=158 */
public static int PARENT_TAX_ID_AD_Reference_ID=158;/** Set Parent Tax.
@param Parent_Tax_ID Parent Tax indicates a tax that is made up of multiple taxes */
public void SetParent_Tax_ID (int Parent_Tax_ID){if (Parent_Tax_ID <= 0) Set_Value ("Parent_Tax_ID", null);else
Set_Value ("Parent_Tax_ID", Parent_Tax_ID);}/** Get Parent Tax.
@return Parent Tax indicates a tax that is made up of multiple taxes */
public int GetParent_Tax_ID() {Object ii = Get_Value("Parent_Tax_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Rate.
@param Rate Rate or Tax or Exchange */
public void SetRate (Decimal? Rate){if (Rate == null) throw new ArgumentException ("Rate is mandatory.");Set_Value ("Rate", (Decimal?)Rate);}/** Get Rate.
@return Rate or Tax or Exchange */
public Decimal GetRate() {Object bd =Get_Value("Rate");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Requires Tax Certificate.
@param RequiresTaxCertificate This tax rate requires the Business Partner to be tax exempt */
public void SetRequiresTaxCertificate (Boolean RequiresTaxCertificate){Set_Value ("RequiresTaxCertificate", RequiresTaxCertificate);}/** Get Requires Tax Certificate.
@return This tax rate requires the Business Partner to be tax exempt */
public Boolean IsRequiresTaxCertificate() {Object oo = Get_Value("RequiresTaxCertificate");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}
/** SOPOType AD_Reference_ID=287 */
public static int SOPOTYPE_AD_Reference_ID=287;/** Both = B */
public static String SOPOTYPE_Both = "B";/** Purchase Tax = P */
public static String SOPOTYPE_PurchaseTax = "P";/** Sales Tax = S */
public static String SOPOTYPE_SalesTax = "S";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsSOPOTypeValid (String test){return test.Equals("B") || test.Equals("P") || test.Equals("S");}/** Set SO/PO Type.
@param SOPOType Sales Tax applies to sales situations, Purchase Tax to purchase situations */
public void SetSOPOType (String SOPOType){if (SOPOType == null) throw new ArgumentException ("SOPOType is mandatory");if (!IsSOPOTypeValid(SOPOType))
throw new ArgumentException ("SOPOType Invalid value - " + SOPOType + " - Reference_ID=287 - B - P - S");if (SOPOType.Length > 1){log.Warning("Length > 1 - truncated");SOPOType = SOPOType.Substring(0,1);}Set_Value ("SOPOType", SOPOType);}/** Get SO/PO Type.
@return Sales Tax applies to sales situations, Purchase Tax to purchase situations */
public String GetSOPOType() {return (String)Get_Value("SOPOType");}
/** SurchargeType AD_Reference_ID=1000276 */
public static int SURCHARGETYPE_AD_Reference_ID=1000276;/** Line Amount = LA */
public static String SURCHARGETYPE_LineAmount = "LA";/** Line Amount + Tax = LT */
public static String SURCHARGETYPE_LineAmountPlusTax = "LT";/** Tax Amount = TA */
public static String SURCHARGETYPE_TaxAmount = "TA";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsSurchargeTypeValid (String test){return test == null || test.Equals("LA") || test.Equals("LT") || test.Equals("TA");}/** Set Surcharge Calculation Type.
@param SurchargeType it identifies the calculation type of Surcharge. */
public void SetSurchargeType (String SurchargeType){if (!IsSurchargeTypeValid(SurchargeType))
throw new ArgumentException ("SurchargeType Invalid value - " + SurchargeType + " - Reference_ID=1000276 - LA - LT - TA");if (SurchargeType != null && SurchargeType.Length > 2){log.Warning("Length > 2 - truncated");SurchargeType = SurchargeType.Substring(0,2);}Set_Value ("SurchargeType", SurchargeType);}/** Get Surcharge Calculation Type.
@return it identifies the calculation type of Surcharge. */
public String GetSurchargeType() {return (String)Get_Value("SurchargeType");}
/** Surcharge_Tax_ID AD_Reference_ID=158 */
public static int SURCHARGE_TAX_ID_AD_Reference_ID=158;/** Set Surcharge Tax.
@param Surcharge_Tax_ID Surcharge Tax Rate */
public void SetSurcharge_Tax_ID (int Surcharge_Tax_ID){if (Surcharge_Tax_ID <= 0) Set_Value ("Surcharge_Tax_ID", null);else
Set_Value ("Surcharge_Tax_ID", Surcharge_Tax_ID);}/** Get Surcharge Tax.
@return Surcharge Tax Rate */
public int GetSurcharge_Tax_ID() {Object ii = Get_Value("Surcharge_Tax_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Tax Indicator.
@param TaxIndicator Short form for Tax to be printed on documents */
public void SetTaxIndicator (String TaxIndicator){if (TaxIndicator != null && TaxIndicator.Length > 10){log.Warning("Length > 10 - truncated");TaxIndicator = TaxIndicator.Substring(0,10);}Set_Value ("TaxIndicator", TaxIndicator);}/** Get Tax Indicator.
@return Short form for Tax to be printed on documents */
public String GetTaxIndicator() {return (String)Get_Value("TaxIndicator");}
/** To_Country_ID AD_Reference_ID=156 */
public static int TO_COUNTRY_ID_AD_Reference_ID=156;/** Set To.
@param To_Country_ID Receiving Country */
public void SetTo_Country_ID (int To_Country_ID){if (To_Country_ID <= 0) Set_Value ("To_Country_ID", null);else
Set_Value ("To_Country_ID", To_Country_ID);}/** Get To.
@return Receiving Country */
public int GetTo_Country_ID() {Object ii = Get_Value("To_Country_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}
/** To_Region_ID AD_Reference_ID=157 */
public static int TO_REGION_ID_AD_Reference_ID=157;/** Set To.
@param To_Region_ID Receiving Region */
public void SetTo_Region_ID (int To_Region_ID){if (To_Region_ID <= 0) Set_Value ("To_Region_ID", null);else
Set_Value ("To_Region_ID", To_Region_ID);}/** Get To.
@return Receiving Region */
public int GetTo_Region_ID() {Object ii = Get_Value("To_Region_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Valid from.
@param ValidFrom Valid from including this date (first day) */
public void SetValidFrom (DateTime? ValidFrom){if (ValidFrom == null) throw new ArgumentException ("ValidFrom is mandatory.");Set_Value ("ValidFrom", (DateTime?)ValidFrom);}/** Get Valid from.
@return Valid from including this date (first day) */
public DateTime? GetValidFrom() {return (DateTime?)Get_Value("ValidFrom");}}
}