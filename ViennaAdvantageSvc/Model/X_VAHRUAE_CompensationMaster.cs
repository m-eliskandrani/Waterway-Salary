namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_CompensationMaster
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_CompensationMaster : PO{public X_VAHRUAE_CompensationMaster (Context ctx, int VAHRUAE_CompensationMaster_ID, Trx trxName) : base (ctx, VAHRUAE_CompensationMaster_ID, trxName){/** if (VAHRUAE_CompensationMaster_ID == 0){SetC_Charge_ID (0);SetVAHRUAE_CompensationMaster_ID (0);SetVAHRUAE_Name (null);SetVAHRUAE_QtyDelivered (0.0);} */
}public X_VAHRUAE_CompensationMaster (Ctx ctx, int VAHRUAE_CompensationMaster_ID, Trx trxName) : base (ctx, VAHRUAE_CompensationMaster_ID, trxName){/** if (VAHRUAE_CompensationMaster_ID == 0){SetC_Charge_ID (0);SetVAHRUAE_CompensationMaster_ID (0);SetVAHRUAE_Name (null);SetVAHRUAE_QtyDelivered (0.0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_CompensationMaster (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_CompensationMaster (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_CompensationMaster (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_CompensationMaster(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27900260357280L;/** Last Updated Timestamp 4/11/2021 11:57:20 AM */
public static long updatedMS = 1618135040491L;/** AD_Table_ID=1000823 */
public static int Table_ID; // =1000823;
/** TableName=VAHRUAE_CompensationMaster */
public static String Table_Name="VAHRUAE_CompensationMaster";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_CompensationMaster[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Charge.
@param C_Charge_ID Additional document charges */
public void SetC_Charge_ID (int C_Charge_ID){if (C_Charge_ID < 1) throw new ArgumentException ("C_Charge_ID is mandatory.");Set_Value ("C_Charge_ID", C_Charge_ID);}/** Get Charge.
@return Additional document charges */
public int GetC_Charge_ID() {Object ii = Get_Value("C_Charge_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}
/** VAHRUAE_AllowanceType AD_Reference_ID=1000315 */
public static int VAHRUAE_ALLOWANCETYPE_AD_Reference_ID=1000315;/** House Rent Allowance = HRA */
public static String VAHRUAE_ALLOWANCETYPE_HouseRentAllowance = "HRA";/** Other Allowances = OAL */
public static String VAHRUAE_ALLOWANCETYPE_OtherAllowances = "OAL";/** Telephone Allowance = TLA */
public static String VAHRUAE_ALLOWANCETYPE_TelephoneAllowance = "TLA";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_AllowanceTypeValid (String test){return test == null || test.Equals("HRA") || test.Equals("OAL") || test.Equals("TLA");}/** Set Allowance Type.
@param VAHRUAE_AllowanceType Allowance Type */
public void SetVAHRUAE_AllowanceType (String VAHRUAE_AllowanceType){if (!IsVAHRUAE_AllowanceTypeValid(VAHRUAE_AllowanceType))
throw new ArgumentException ("VAHRUAE_AllowanceType Invalid value - " + VAHRUAE_AllowanceType + " - Reference_ID=1000315 - HRA - OAL - TLA");if (VAHRUAE_AllowanceType != null && VAHRUAE_AllowanceType.Length > 3){log.Warning("Length > 3 - truncated");VAHRUAE_AllowanceType = VAHRUAE_AllowanceType.Substring(0,3);}Set_Value ("VAHRUAE_AllowanceType", VAHRUAE_AllowanceType);}/** Get Allowance Type.
@return Allowance Type */
public String GetVAHRUAE_AllowanceType() {return (String)Get_Value("VAHRUAE_AllowanceType");}
/** VAHRUAE_CompensationCategory AD_Reference_ID=1000314 */
public static int VAHRUAE_COMPENSATIONCATEGORY_AD_Reference_ID=1000314;/** Advance = ADV */
public static String VAHRUAE_COMPENSATIONCATEGORY_Advance = "ADV";/** Allowance = ALW */
public static String VAHRUAE_COMPENSATIONCATEGORY_Allowance = "ALW";/** AVL Amount = AVL */
public static String VAHRUAE_COMPENSATIONCATEGORY_AVLAmount = "AVL";/** Bonus = BON */
public static String VAHRUAE_COMPENSATIONCATEGORY_Bonus = "BON";/** Basic Salary = BSL */
public static String VAHRUAE_COMPENSATIONCATEGORY_BasicSalary = "BSL";/** Deduction = DED */
public static String VAHRUAE_COMPENSATIONCATEGORY_Deduction = "DED";/** Overtime = OTA */
public static String VAHRUAE_COMPENSATIONCATEGORY_Overtime = "OTA";/** Variables = VAR */
public static String VAHRUAE_COMPENSATIONCATEGORY_Variables = "VAR";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_CompensationCategoryValid (String test){return test == null || test.Equals("ADV") || test.Equals("ALW") || test.Equals("AVL") || test.Equals("BON") || test.Equals("BSL") || test.Equals("DED") || test.Equals("OTA") || test.Equals("VAR");}/** Set Compensation Category.
@param VAHRUAE_CompensationCategory Compensation Category */
public void SetVAHRUAE_CompensationCategory (String VAHRUAE_CompensationCategory){if (!IsVAHRUAE_CompensationCategoryValid(VAHRUAE_CompensationCategory))
throw new ArgumentException ("VAHRUAE_CompensationCategory Invalid value - " + VAHRUAE_CompensationCategory + " - Reference_ID=1000314 - ADV - ALW - AVL - BON - BSL - DED - OTA - VAR");if (VAHRUAE_CompensationCategory != null && VAHRUAE_CompensationCategory.Length > 3){log.Warning("Length > 3 - truncated");VAHRUAE_CompensationCategory = VAHRUAE_CompensationCategory.Substring(0,3);}Set_Value ("VAHRUAE_CompensationCategory", VAHRUAE_CompensationCategory);}/** Get Compensation Category.
@return Compensation Category */
public String GetVAHRUAE_CompensationCategory() {return (String)Get_Value("VAHRUAE_CompensationCategory");}/** Set Compensation Name.
@param VAHRUAE_CompensationMaster_ID Compensation Name */
public void SetVAHRUAE_CompensationMaster_ID (int VAHRUAE_CompensationMaster_ID){if (VAHRUAE_CompensationMaster_ID < 1) throw new ArgumentException ("VAHRUAE_CompensationMaster_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_CompensationMaster_ID", VAHRUAE_CompensationMaster_ID);}/** Get Compensation Name.
@return Compensation Name */
public int GetVAHRUAE_CompensationMaster_ID() {Object ii = Get_Value("VAHRUAE_CompensationMaster_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}
/** VAHRUAE_DeductionType AD_Reference_ID=1000316 */
public static int VAHRUAE_DEDUCTIONTYPE_AD_Reference_ID=1000316;/** Allowance Deduction = ALD */
public static String VAHRUAE_DEDUCTIONTYPE_AllowanceDeduction = "ALD";/** Gosi = GOS */
public static String VAHRUAE_DEDUCTIONTYPE_Gosi = "GOS";/** Other Deductions = ODE */
public static String VAHRUAE_DEDUCTIONTYPE_OtherDeductions = "ODE";/** Penality = PEN */
public static String VAHRUAE_DEDUCTIONTYPE_Penality = "PEN";/** TDS = TDS */
public static String VAHRUAE_DEDUCTIONTYPE_TDS = "TDS";/** Unpaid Leave = UPL */
public static String VAHRUAE_DEDUCTIONTYPE_UnpaidLeave = "UPL";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_DeductionTypeValid (String test){return test == null || test.Equals("ALD") || test.Equals("GOS") || test.Equals("ODE") || test.Equals("PEN") || test.Equals("TDS") || test.Equals("UPL");}/** Set Deduction Type.
@param VAHRUAE_DeductionType Deduction Type */
public void SetVAHRUAE_DeductionType (String VAHRUAE_DeductionType){if (!IsVAHRUAE_DeductionTypeValid(VAHRUAE_DeductionType))
throw new ArgumentException ("VAHRUAE_DeductionType Invalid value - " + VAHRUAE_DeductionType + " - Reference_ID=1000316 - ALD - GOS - ODE - PEN - TDS - UPL");if (VAHRUAE_DeductionType != null && VAHRUAE_DeductionType.Length > 3){log.Warning("Length > 3 - truncated");VAHRUAE_DeductionType = VAHRUAE_DeductionType.Substring(0,3);}Set_Value ("VAHRUAE_DeductionType", VAHRUAE_DeductionType);}/** Get Deduction Type.
@return Deduction Type */
public String GetVAHRUAE_DeductionType() {return (String)Get_Value("VAHRUAE_DeductionType");}/** Set Description.
@param VAHRUAE_Description Description */
public void SetVAHRUAE_Description (String VAHRUAE_Description){if (VAHRUAE_Description != null && VAHRUAE_Description.Length > 255){log.Warning("Length > 255 - truncated");VAHRUAE_Description = VAHRUAE_Description.Substring(0,255);}Set_Value ("VAHRUAE_Description", VAHRUAE_Description);}/** Get Description.
@return Description */
public String GetVAHRUAE_Description() {return (String)Get_Value("VAHRUAE_Description");}/** Set Formula Code.
@param VAHRUAE_FCode Formula Code */
public void SetVAHRUAE_FCode (String VAHRUAE_FCode){if (VAHRUAE_FCode != null && VAHRUAE_FCode.Length > 50){log.Warning("Length > 50 - truncated");VAHRUAE_FCode = VAHRUAE_FCode.Substring(0,50);}Set_Value ("VAHRUAE_FCode", VAHRUAE_FCode);}/** Get Formula Code.
@return Formula Code */
public String GetVAHRUAE_FCode() {return (String)Get_Value("VAHRUAE_FCode");}/** Set Fixed Value.
@param VAHRUAE_FixedValue Fixed Value */
public void SetVAHRUAE_FixedValue (Boolean VAHRUAE_FixedValue){Set_Value ("VAHRUAE_FixedValue", VAHRUAE_FixedValue);}/** Get Fixed Value.
@return Fixed Value */
public Boolean IsVAHRUAE_FixedValue() {Object oo = Get_Value("VAHRUAE_FixedValue");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Formula.
@param VAHRUAE_Formula Formula */
public void SetVAHRUAE_Formula (String VAHRUAE_Formula){if (VAHRUAE_Formula != null && VAHRUAE_Formula.Length > 100){log.Warning("Length > 100 - truncated");VAHRUAE_Formula = VAHRUAE_Formula.Substring(0,100);}Set_Value ("VAHRUAE_Formula", VAHRUAE_Formula);}/** Get Formula.
@return Formula */
public String GetVAHRUAE_Formula() {return (String)Get_Value("VAHRUAE_Formula");}/** Set Formula Based.
@param VAHRUAE_IsFormulaBased Formula Based */
public void SetVAHRUAE_IsFormulaBased (Boolean VAHRUAE_IsFormulaBased){Set_Value ("VAHRUAE_IsFormulaBased", VAHRUAE_IsFormulaBased);}/** Get Formula Based.
@return Formula Based */
public Boolean IsVAHRUAE_IsFormulaBased() {Object oo = Get_Value("VAHRUAE_IsFormulaBased");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Reference Name.
@param VAHRUAE_IsReferenceName Reference Name */
public void SetVAHRUAE_IsReferenceName (Boolean VAHRUAE_IsReferenceName){Set_Value ("VAHRUAE_IsReferenceName", VAHRUAE_IsReferenceName);}/** Get Reference Name.
@return Reference Name */
public Boolean IsVAHRUAE_IsReferenceName() {Object oo = Get_Value("VAHRUAE_IsReferenceName");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Maximum Value.
@param VAHRUAE_MaxValue Maximum Value */
public void SetVAHRUAE_MaxValue (Decimal? VAHRUAE_MaxValue){Set_Value ("VAHRUAE_MaxValue", (Decimal?)VAHRUAE_MaxValue);}/** Get Maximum Value.
@return Maximum Value */
public Decimal GetVAHRUAE_MaxValue() {Object bd =Get_Value("VAHRUAE_MaxValue");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Minimum Value.
@param VAHRUAE_MinValue Minimum Value */
public void SetVAHRUAE_MinValue (Decimal? VAHRUAE_MinValue){Set_Value ("VAHRUAE_MinValue", (Decimal?)VAHRUAE_MinValue);}/** Get Minimum Value.
@return Minimum Value */
public Decimal GetVAHRUAE_MinValue() {Object bd =Get_Value("VAHRUAE_MinValue");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Name.
@param VAHRUAE_Name The name of an entity (record) is used as a default search option in addition to the search key. */
public void SetVAHRUAE_Name (String VAHRUAE_Name){if (VAHRUAE_Name == null) throw new ArgumentException ("VAHRUAE_Name is mandatory.");if (VAHRUAE_Name.Length > 120){log.Warning("Length > 120 - truncated");VAHRUAE_Name = VAHRUAE_Name.Substring(0,120);}Set_Value ("VAHRUAE_Name", VAHRUAE_Name);}/** Get Name.
@return The name of an entity (record) is used as a default search option in addition to the search key. */
public String GetVAHRUAE_Name() {return (String)Get_Value("VAHRUAE_Name");}
/** VAHRUAE_OvertimeType AD_Reference_ID=1000317 */
public static int VAHRUAE_OVERTIMETYPE_AD_Reference_ID=1000317;/** Other Overtimes = OOT */
public static String VAHRUAE_OVERTIMETYPE_OtherOvertimes = "OOT";/** Overtime Regular = OT1 */
public static String VAHRUAE_OVERTIMETYPE_OvertimeRegular = "OT1";/** Overtime Night = OT2 */
public static String VAHRUAE_OVERTIMETYPE_OvertimeNight = "OT2";/** Holiday Overtime = OTH */
public static String VAHRUAE_OVERTIMETYPE_HolidayOvertime = "OTH";/** Normal Overtime = OTN */
public static String VAHRUAE_OVERTIMETYPE_NormalOvertime = "OTN";/** Overtime Premium = OTP */
public static String VAHRUAE_OVERTIMETYPE_OvertimePremium = "OTP";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_OvertimeTypeValid (String test){return test == null || test.Equals("OOT") || test.Equals("OT1") || test.Equals("OT2") || test.Equals("OTH") || test.Equals("OTN") || test.Equals("OTP");}/** Set Overtime Type.
@param VAHRUAE_OvertimeType Overtime Type */
public void SetVAHRUAE_OvertimeType (String VAHRUAE_OvertimeType){if (!IsVAHRUAE_OvertimeTypeValid(VAHRUAE_OvertimeType))
throw new ArgumentException ("VAHRUAE_OvertimeType Invalid value - " + VAHRUAE_OvertimeType + " - Reference_ID=1000317 - OOT - OT1 - OT2 - OTH - OTN - OTP");if (VAHRUAE_OvertimeType != null && VAHRUAE_OvertimeType.Length > 3){log.Warning("Length > 3 - truncated");VAHRUAE_OvertimeType = VAHRUAE_OvertimeType.Substring(0,3);}Set_Value ("VAHRUAE_OvertimeType", VAHRUAE_OvertimeType);}/** Get Overtime Type.
@return Overtime Type */
public String GetVAHRUAE_OvertimeType() {return (String)Get_Value("VAHRUAE_OvertimeType");}/** Set Print Text.
@param VAHRUAE_PrintText Print Text */
public void SetVAHRUAE_PrintText (String VAHRUAE_PrintText){if (VAHRUAE_PrintText != null && VAHRUAE_PrintText.Length > 50){log.Warning("Length > 50 - truncated");VAHRUAE_PrintText = VAHRUAE_PrintText.Substring(0,50);}Set_Value ("VAHRUAE_PrintText", VAHRUAE_PrintText);}/** Get Print Text.
@return Print Text */
public String GetVAHRUAE_PrintText() {return (String)Get_Value("VAHRUAE_PrintText");}/** Set Quantity Delivered.
@param VAHRUAE_QtyDelivered Quantity Delivered */
public void SetVAHRUAE_QtyDelivered (Decimal? VAHRUAE_QtyDelivered){if (VAHRUAE_QtyDelivered == null) throw new ArgumentException ("VAHRUAE_QtyDelivered is mandatory.");Set_Value ("VAHRUAE_QtyDelivered", (Decimal?)VAHRUAE_QtyDelivered);}/** Get Quantity Delivered.
@return Quantity Delivered */
public Decimal GetVAHRUAE_QtyDelivered() {Object bd =Get_Value("VAHRUAE_QtyDelivered");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Search Key.
@param Value Search key for the record in the format required - must be unique */
public void SetValue (String Value){if (Value != null && Value.Length > 50){log.Warning("Length > 50 - truncated");Value = Value.Substring(0,50);}Set_Value ("Value", Value);}/** Get Search Key.
@return Search key for the record in the format required - must be unique */
public String GetValue() {return (String)Get_Value("Value");}}
}