namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_Vss_AdvanceDetails
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_Vss_AdvanceDetails : PO{public X_VAHRUAE_Vss_AdvanceDetails (Context ctx, int VAHRUAE_Vss_AdvanceDetails_ID, Trx trxName) : base (ctx, VAHRUAE_Vss_AdvanceDetails_ID, trxName){/** if (VAHRUAE_Vss_AdvanceDetails_ID == 0){SetC_BPartner_ID (0);SetC_BankAccount_ID (0);SetVAHRUAE_CompensationMaster_ID (0);SetVAHRUAE_Vss_AdvanceDetails_ID (0);} */
}public X_VAHRUAE_Vss_AdvanceDetails (Ctx ctx, int VAHRUAE_Vss_AdvanceDetails_ID, Trx trxName) : base (ctx, VAHRUAE_Vss_AdvanceDetails_ID, trxName){/** if (VAHRUAE_Vss_AdvanceDetails_ID == 0){SetC_BPartner_ID (0);SetC_BankAccount_ID (0);SetVAHRUAE_CompensationMaster_ID (0);SetVAHRUAE_Vss_AdvanceDetails_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_Vss_AdvanceDetails (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_Vss_AdvanceDetails (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_Vss_AdvanceDetails (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_Vss_AdvanceDetails(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27902849011913L;/** Last Updated Timestamp 5/11/2021 11:01:35 AM */
public static long updatedMS = 1620723695124L;/** AD_Table_ID=1000877 */
public static int Table_ID; // =1000877;
/** TableName=VAHRUAE_Vss_AdvanceDetails */
public static String Table_Name="VAHRUAE_Vss_AdvanceDetails";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_Vss_AdvanceDetails[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Business Partner.
@param C_BPartner_ID Identifies a Customer/Prospect */
public void SetC_BPartner_ID (int C_BPartner_ID){if (C_BPartner_ID < 1) throw new ArgumentException ("C_BPartner_ID is mandatory.");Set_Value ("C_BPartner_ID", C_BPartner_ID);}/** Get Business Partner.
@return Identifies a Customer/Prospect */
public int GetC_BPartner_ID() {Object ii = Get_Value("C_BPartner_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Bank Account.
@param C_BankAccount_ID Account at the Bank */
public void SetC_BankAccount_ID (int C_BankAccount_ID){if (C_BankAccount_ID < 1) throw new ArgumentException ("C_BankAccount_ID is mandatory.");Set_Value ("C_BankAccount_ID", C_BankAccount_ID);}/** Get Bank Account.
@return Account at the Bank */
public int GetC_BankAccount_ID() {Object ii = Get_Value("C_BankAccount_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Charge.
@param C_Charge_ID Additional document charges */
public void SetC_Charge_ID (int C_Charge_ID){if (C_Charge_ID <= 0) Set_Value ("C_Charge_ID", null);else
Set_Value ("C_Charge_ID", C_Charge_ID);}/** Get Charge.
@return Additional document charges */
public int GetC_Charge_ID() {Object ii = Get_Value("C_Charge_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Currency.
@param C_Currency_ID The Currency for this record */
public void SetC_Currency_ID (int C_Currency_ID){if (C_Currency_ID <= 0) Set_Value ("C_Currency_ID", null);else
Set_Value ("C_Currency_ID", C_Currency_ID);}/** Get Currency.
@return The Currency for this record */
public int GetC_Currency_ID() {Object ii = Get_Value("C_Currency_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Invoice.
@param C_Invoice_ID Invoice Identifier */
public void SetC_Invoice_ID (int C_Invoice_ID){if (C_Invoice_ID <= 0) Set_Value ("C_Invoice_ID", null);else
Set_Value ("C_Invoice_ID", C_Invoice_ID);}/** Get Invoice.
@return Invoice Identifier */
public int GetC_Invoice_ID() {Object ii = Get_Value("C_Invoice_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Document No..
@param DocumentNo Document sequence number of the document */
public void SetDocumentNo (String DocumentNo){if (DocumentNo != null && DocumentNo.Length > 30){log.Warning("Length > 30 - truncated");DocumentNo = DocumentNo.Substring(0,30);}Set_Value ("DocumentNo", DocumentNo);}/** Get Document No..
@return Document sequence number of the document */
public String GetDocumentNo() {return (String)Get_Value("DocumentNo");}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Processed.
@param Processed The document has been processed */
public void SetProcessed (Boolean Processed){Set_Value ("Processed", Processed);}/** Get Processed.
@return The document has been processed */
public Boolean IsProcessed() {Object oo = Get_Value("Processed");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}
/** VAHRUAE_AdvanceType AD_Reference_ID=1000340 */
public static int VAHRUAE_ADVANCETYPE_AD_Reference_ID=1000340;/** Advance = AD */
public static String VAHRUAE_ADVANCETYPE_Advance = "AD";/** Product Purchase = PP */
public static String VAHRUAE_ADVANCETYPE_ProductPurchase = "PP";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_AdvanceTypeValid (String test){return test == null || test.Equals("AD") || test.Equals("PP");}/** Set Advance Type.
@param VAHRUAE_AdvanceType Advance Type */
public void SetVAHRUAE_AdvanceType (String VAHRUAE_AdvanceType){if (!IsVAHRUAE_AdvanceTypeValid(VAHRUAE_AdvanceType))
throw new ArgumentException ("VAHRUAE_AdvanceType Invalid value - " + VAHRUAE_AdvanceType + " - Reference_ID=1000340 - AD - PP");if (VAHRUAE_AdvanceType != null && VAHRUAE_AdvanceType.Length > 2){log.Warning("Length > 2 - truncated");VAHRUAE_AdvanceType = VAHRUAE_AdvanceType.Substring(0,2);}Set_Value ("VAHRUAE_AdvanceType", VAHRUAE_AdvanceType);}/** Get Advance Type.
@return Advance Type */
public String GetVAHRUAE_AdvanceType() {return (String)Get_Value("VAHRUAE_AdvanceType");}/** Set Amount Given.
@param VAHRUAE_AmountGiven Amount Given */
public void SetVAHRUAE_AmountGiven (Decimal? VAHRUAE_AmountGiven){Set_Value ("VAHRUAE_AmountGiven", (Decimal?)VAHRUAE_AmountGiven);}/** Get Amount Given.
@return Amount Given */
public Decimal GetVAHRUAE_AmountGiven() {Object bd =Get_Value("VAHRUAE_AmountGiven");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Amount Present.
@param VAHRUAE_AmountPresent Amount Present */
public void SetVAHRUAE_AmountPresent (Decimal? VAHRUAE_AmountPresent){Set_Value ("VAHRUAE_AmountPresent", (Decimal?)VAHRUAE_AmountPresent);}/** Get Amount Present.
@return Amount Present */
public Decimal GetVAHRUAE_AmountPresent() {Object bd =Get_Value("VAHRUAE_AmountPresent");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Calculated.
@param VAHRUAE_Calculated Calculated */
public void SetVAHRUAE_Calculated (Boolean VAHRUAE_Calculated){Set_Value ("VAHRUAE_Calculated", VAHRUAE_Calculated);}/** Get Calculated.
@return Calculated */
public Boolean IsVAHRUAE_Calculated() {Object oo = Get_Value("VAHRUAE_Calculated");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Compensation Name.
@param VAHRUAE_CompensationMaster_ID Compensation Name */
public void SetVAHRUAE_CompensationMaster_ID (int VAHRUAE_CompensationMaster_ID){if (VAHRUAE_CompensationMaster_ID < 1) throw new ArgumentException ("VAHRUAE_CompensationMaster_ID is mandatory.");Set_Value ("VAHRUAE_CompensationMaster_ID", VAHRUAE_CompensationMaster_ID);}/** Get Compensation Name.
@return Compensation Name */
public int GetVAHRUAE_CompensationMaster_ID() {Object ii = Get_Value("VAHRUAE_CompensationMaster_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Deduction Break From 1.
@param VAHRUAE_DEDUCTIONBREAKFROM1 Deduction Break From 1 */
public void SetVAHRUAE_DEDUCTIONBREAKFROM1 (DateTime? VAHRUAE_DEDUCTIONBREAKFROM1){Set_Value ("VAHRUAE_DEDUCTIONBREAKFROM1", (DateTime?)VAHRUAE_DEDUCTIONBREAKFROM1);}/** Get Deduction Break From 1.
@return Deduction Break From 1 */
public DateTime? GetVAHRUAE_DEDUCTIONBREAKFROM1() {return (DateTime?)Get_Value("VAHRUAE_DEDUCTIONBREAKFROM1");}/** Set Deduction Break To 1.
@param VAHRUAE_DEDUCTIONBREAKTO1 Deduction Break To 1 */
public void SetVAHRUAE_DEDUCTIONBREAKTO1 (DateTime? VAHRUAE_DEDUCTIONBREAKTO1){Set_Value ("VAHRUAE_DEDUCTIONBREAKTO1", (DateTime?)VAHRUAE_DEDUCTIONBREAKTO1);}/** Get Deduction Break To 1.
@return Deduction Break To 1 */
public DateTime? GetVAHRUAE_DEDUCTIONBREAKTO1() {return (DateTime?)Get_Value("VAHRUAE_DEDUCTIONBREAKTO1");}/** Set Deduction Break From.
@param VAHRUAE_DeductionBreakFrom Deduction Break From */
public void SetVAHRUAE_DeductionBreakFrom (DateTime? VAHRUAE_DeductionBreakFrom){Set_Value ("VAHRUAE_DeductionBreakFrom", (DateTime?)VAHRUAE_DeductionBreakFrom);}/** Get Deduction Break From.
@return Deduction Break From */
public DateTime? GetVAHRUAE_DeductionBreakFrom() {return (DateTime?)Get_Value("VAHRUAE_DeductionBreakFrom");}/** Set Deduction Break To.
@param VAHRUAE_DeductionBreakTo Deduction Break To */
public void SetVAHRUAE_DeductionBreakTo (DateTime? VAHRUAE_DeductionBreakTo){Set_Value ("VAHRUAE_DeductionBreakTo", (DateTime?)VAHRUAE_DeductionBreakTo);}/** Get Deduction Break To.
@return Deduction Break To */
public DateTime? GetVAHRUAE_DeductionBreakTo() {return (DateTime?)Get_Value("VAHRUAE_DeductionBreakTo");}/** Set Deduction Start Month.
@param VAHRUAE_DeductionStartMonth Deduction Start Month */
public void SetVAHRUAE_DeductionStartMonth (DateTime? VAHRUAE_DeductionStartMonth){Set_Value ("VAHRUAE_DeductionStartMonth", (DateTime?)VAHRUAE_DeductionStartMonth);}/** Get Deduction Start Month.
@return Deduction Start Month */
public DateTime? GetVAHRUAE_DeductionStartMonth() {return (DateTime?)Get_Value("VAHRUAE_DeductionStartMonth");}/** Set Generate Payment.
@param VAHRUAE_GeneratePayment Generate Payment */
public void SetVAHRUAE_GeneratePayment (String VAHRUAE_GeneratePayment){if (VAHRUAE_GeneratePayment != null && VAHRUAE_GeneratePayment.Length > 50){log.Warning("Length > 50 - truncated");VAHRUAE_GeneratePayment = VAHRUAE_GeneratePayment.Substring(0,50);}Set_Value ("VAHRUAE_GeneratePayment", VAHRUAE_GeneratePayment);}/** Get Generate Payment.
@return Generate Payment */
public String GetVAHRUAE_GeneratePayment() {return (String)Get_Value("VAHRUAE_GeneratePayment");}/** Set Given Month.
@param VAHRUAE_GivenMonth Given Month */
public void SetVAHRUAE_GivenMonth (DateTime? VAHRUAE_GivenMonth){Set_Value ("VAHRUAE_GivenMonth", (DateTime?)VAHRUAE_GivenMonth);}/** Get Given Month.
@return Given Month */
public DateTime? GetVAHRUAE_GivenMonth() {return (DateTime?)Get_Value("VAHRUAE_GivenMonth");}/** Set Installments.
@param VAHRUAE_Installments Installments */
public void SetVAHRUAE_Installments (int VAHRUAE_Installments){Set_Value ("VAHRUAE_Installments", VAHRUAE_Installments);}/** Get Installments.
@return Installments */
public int GetVAHRUAE_Installments() {Object ii = Get_Value("VAHRUAE_Installments");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Is Payment Generated.
@param VAHRUAE_IsPaymentGenerated Is Payment Generated */
public void SetVAHRUAE_IsPaymentGenerated (Boolean VAHRUAE_IsPaymentGenerated){Set_Value ("VAHRUAE_IsPaymentGenerated", VAHRUAE_IsPaymentGenerated);}/** Get Is Payment Generated.
@return Is Payment Generated */
public Boolean IsVAHRUAE_IsPaymentGenerated() {Object oo = Get_Value("VAHRUAE_IsPaymentGenerated");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Monthly Deduction.
@param VAHRUAE_MonthlyDeduction Monthly Deduction */
public void SetVAHRUAE_MonthlyDeduction (Decimal? VAHRUAE_MonthlyDeduction){Set_Value ("VAHRUAE_MonthlyDeduction", (Decimal?)VAHRUAE_MonthlyDeduction);}/** Get Monthly Deduction.
@return Monthly Deduction */
public Decimal GetVAHRUAE_MonthlyDeduction() {Object bd =Get_Value("VAHRUAE_MonthlyDeduction");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set No. of Installments Remaining.
@param VAHRUAE_No_Installments_Remain No. of Installments Remaining */
public void SetVAHRUAE_No_Installments_Remain (int VAHRUAE_No_Installments_Remain){Set_Value ("VAHRUAE_No_Installments_Remain", VAHRUAE_No_Installments_Remain);}/** Get No. of Installments Remaining.
@return No. of Installments Remaining */
public int GetVAHRUAE_No_Installments_Remain() {Object ii = Get_Value("VAHRUAE_No_Installments_Remain");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Process Now.
@param VAHRUAE_Processing Process Now */
public void SetVAHRUAE_Processing (String VAHRUAE_Processing){if (VAHRUAE_Processing != null && VAHRUAE_Processing.Length > 1){log.Warning("Length > 1 - truncated");VAHRUAE_Processing = VAHRUAE_Processing.Substring(0,1);}Set_Value ("VAHRUAE_Processing", VAHRUAE_Processing);}/** Get Process Now.
@return Process Now */
public String GetVAHRUAE_Processing() {return (String)Get_Value("VAHRUAE_Processing");}/** Set Re Open Advance.
@param VAHRUAE_ReOpenAdvance Re Open Advance */
public void SetVAHRUAE_ReOpenAdvance (String VAHRUAE_ReOpenAdvance){if (VAHRUAE_ReOpenAdvance != null && VAHRUAE_ReOpenAdvance.Length > 1){log.Warning("Length > 1 - truncated");VAHRUAE_ReOpenAdvance = VAHRUAE_ReOpenAdvance.Substring(0,1);}Set_Value ("VAHRUAE_ReOpenAdvance", VAHRUAE_ReOpenAdvance);}/** Get Re Open Advance.
@return Re Open Advance */
public String GetVAHRUAE_ReOpenAdvance() {return (String)Get_Value("VAHRUAE_ReOpenAdvance");}/** Set Advance Details.
@param VAHRUAE_Vss_AdvanceDetails_ID Advance Details */
public void SetVAHRUAE_Vss_AdvanceDetails_ID (int VAHRUAE_Vss_AdvanceDetails_ID){if (VAHRUAE_Vss_AdvanceDetails_ID < 1) throw new ArgumentException ("VAHRUAE_Vss_AdvanceDetails_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_Vss_AdvanceDetails_ID", VAHRUAE_Vss_AdvanceDetails_ID);}/** Get Advance Details.
@return Advance Details */
public int GetVAHRUAE_Vss_AdvanceDetails_ID() {Object ii = Get_Value("VAHRUAE_Vss_AdvanceDetails_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}}
}