namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_ShiftCompenstion
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_ShiftCompenstion : PO{public X_VAHRUAE_ShiftCompenstion (Context ctx, int VAHRUAE_ShiftCompenstion_ID, Trx trxName) : base (ctx, VAHRUAE_ShiftCompenstion_ID, trxName){/** if (VAHRUAE_ShiftCompenstion_ID == 0){SetVAHRUAE_HR_AttendanceRule_ID (0);SetVAHRUAE_ShiftCompenstion_ID (0);} */
}public X_VAHRUAE_ShiftCompenstion (Ctx ctx, int VAHRUAE_ShiftCompenstion_ID, Trx trxName) : base (ctx, VAHRUAE_ShiftCompenstion_ID, trxName){/** if (VAHRUAE_ShiftCompenstion_ID == 0){SetVAHRUAE_HR_AttendanceRule_ID (0);SetVAHRUAE_ShiftCompenstion_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_ShiftCompenstion (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_ShiftCompenstion (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_ShiftCompenstion (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_ShiftCompenstion(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27899993475915L;/** Last Updated Timestamp 4/8/2021 9:49:19 AM */
public static long updatedMS = 1617868159126L;/** AD_Table_ID=1000828 */
public static int Table_ID; // =1000828;
/** TableName=VAHRUAE_ShiftCompenstion */
public static String Table_Name="VAHRUAE_ShiftCompenstion";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_ShiftCompenstion[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Charge.
@param C_Charge_ID Additional document charges */
public void SetC_Charge_ID (int C_Charge_ID){if (C_Charge_ID <= 0) Set_Value ("C_Charge_ID", null);else
Set_Value ("C_Charge_ID", C_Charge_ID);}/** Get Charge.
@return Additional document charges */
public int GetC_Charge_ID() {Object ii = Get_Value("C_Charge_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Position.
@param C_Job_ID Job Position */
public void SetC_Job_ID (int C_Job_ID){if (C_Job_ID <= 0) Set_Value ("C_Job_ID", null);else
Set_Value ("C_Job_ID", C_Job_ID);}/** Get Position.
@return Job Position */
public int GetC_Job_ID() {Object ii = Get_Value("C_Job_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}
/** C_Period_ID AD_Reference_ID=1000237 */
public static int C_PERIOD_ID_AD_Reference_ID=1000237;/** Set Period.
@param C_Period_ID Period of the Calendar */
public void SetC_Period_ID (int C_Period_ID){if (C_Period_ID <= 0) Set_Value ("C_Period_ID", null);else
Set_Value ("C_Period_ID", C_Period_ID);}/** Get Period.
@return Period of the Calendar */
public int GetC_Period_ID() {Object ii = Get_Value("C_Period_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Year.
@param C_Year_ID Calendar Year */
public void SetC_Year_ID (int C_Year_ID){if (C_Year_ID <= 0) Set_Value ("C_Year_ID", null);else
Set_Value ("C_Year_ID", C_Year_ID);}/** Get Year.
@return Calendar Year */
public int GetC_Year_ID() {Object ii = Get_Value("C_Year_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Compensation Name.
@param VAHRUAE_CompensationMaster_ID Compensation Name */
public void SetVAHRUAE_CompensationMaster_ID (int VAHRUAE_CompensationMaster_ID){if (VAHRUAE_CompensationMaster_ID <= 0) Set_Value ("VAHRUAE_CompensationMaster_ID", null);else
Set_Value ("VAHRUAE_CompensationMaster_ID", VAHRUAE_CompensationMaster_ID);}/** Get Compensation Name.
@return Compensation Name */
public int GetVAHRUAE_CompensationMaster_ID() {Object ii = Get_Value("VAHRUAE_CompensationMaster_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}
/** VAHRUAE_CompensationType AD_Reference_ID=1000293 */
public static int VAHRUAE_COMPENSATIONTYPE_AD_Reference_ID=1000293;/** Deduction = D */
public static String VAHRUAE_COMPENSATIONTYPE_Deduction = "D";/** Earning = E */
public static String VAHRUAE_COMPENSATIONTYPE_Earning = "E";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_CompensationTypeValid (String test){return test == null || test.Equals("D") || test.Equals("E");}/** Set Compensation Type.
@param VAHRUAE_CompensationType Compensation Type */
public void SetVAHRUAE_CompensationType (String VAHRUAE_CompensationType){if (!IsVAHRUAE_CompensationTypeValid(VAHRUAE_CompensationType))
throw new ArgumentException ("VAHRUAE_CompensationType Invalid value - " + VAHRUAE_CompensationType + " - Reference_ID=1000293 - D - E");if (VAHRUAE_CompensationType != null && VAHRUAE_CompensationType.Length > 1){log.Warning("Length > 1 - truncated");VAHRUAE_CompensationType = VAHRUAE_CompensationType.Substring(0,1);}Set_Value ("VAHRUAE_CompensationType", VAHRUAE_CompensationType);}/** Get Compensation Type.
@return Compensation Type */
public String GetVAHRUAE_CompensationType() {return (String)Get_Value("VAHRUAE_CompensationType");}/** Set Description.
@param VAHRUAE_Description Description */
public void SetVAHRUAE_Description (String VAHRUAE_Description){if (VAHRUAE_Description != null && VAHRUAE_Description.Length > 255){log.Warning("Length > 255 - truncated");VAHRUAE_Description = VAHRUAE_Description.Substring(0,255);}Set_Value ("VAHRUAE_Description", VAHRUAE_Description);}/** Get Description.
@return Description */
public String GetVAHRUAE_Description() {return (String)Get_Value("VAHRUAE_Description");}/** Set Fixed Value.
@param VAHRUAE_FixedValue Fixed Value */
public void SetVAHRUAE_FixedValue (Decimal? VAHRUAE_FixedValue){Set_Value ("VAHRUAE_FixedValue", (Decimal?)VAHRUAE_FixedValue);}/** Get Fixed Value.
@return Fixed Value */
public Decimal GetVAHRUAE_FixedValue() {Object bd =Get_Value("VAHRUAE_FixedValue");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Formula.
@param VAHRUAE_Formula Formula */
public void SetVAHRUAE_Formula (String VAHRUAE_Formula){if (VAHRUAE_Formula != null && VAHRUAE_Formula.Length > 100){log.Warning("Length > 100 - truncated");VAHRUAE_Formula = VAHRUAE_Formula.Substring(0,100);}Set_Value ("VAHRUAE_Formula", VAHRUAE_Formula);}/** Get Formula.
@return Formula */
public String GetVAHRUAE_Formula() {return (String)Get_Value("VAHRUAE_Formula");}/** Set Shift.
@param VAHRUAE_HR_AttendanceRule_ID Shift */
public void SetVAHRUAE_HR_AttendanceRule_ID (int VAHRUAE_HR_AttendanceRule_ID){if (VAHRUAE_HR_AttendanceRule_ID < 1) throw new ArgumentException ("VAHRUAE_HR_AttendanceRule_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_HR_AttendanceRule_ID", VAHRUAE_HR_AttendanceRule_ID);}/** Get Shift.
@return Shift */
public int GetVAHRUAE_HR_AttendanceRule_ID() {Object ii = Get_Value("VAHRUAE_HR_AttendanceRule_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Fixed Value.
@param VAHRUAE_IsFixedValue Fixed Value */
public void SetVAHRUAE_IsFixedValue (Boolean VAHRUAE_IsFixedValue){Set_Value ("VAHRUAE_IsFixedValue", VAHRUAE_IsFixedValue);}/** Get Fixed Value.
@return Fixed Value */
public Boolean IsVAHRUAE_IsFixedValue() {Object oo = Get_Value("VAHRUAE_IsFixedValue");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Maximum Value.
@param VAHRUAE_MaxValue Maximum Value */
public void SetVAHRUAE_MaxValue (Decimal? VAHRUAE_MaxValue){Set_Value ("VAHRUAE_MaxValue", (Decimal?)VAHRUAE_MaxValue);}/** Get Maximum Value.
@return Maximum Value */
public Decimal GetVAHRUAE_MaxValue() {Object bd =Get_Value("VAHRUAE_MaxValue");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Minimum Value.
@param VAHRUAE_MinValue Minimum Value */
public void SetVAHRUAE_MinValue (Decimal? VAHRUAE_MinValue){Set_Value ("VAHRUAE_MinValue", (Decimal?)VAHRUAE_MinValue);}/** Get Minimum Value.
@return Minimum Value */
public Decimal GetVAHRUAE_MinValue() {Object bd =Get_Value("VAHRUAE_MinValue");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Months Frequency.
@param VAHRUAE_MonthsFrequency Months Frequency */
public void SetVAHRUAE_MonthsFrequency (int VAHRUAE_MonthsFrequency){Set_Value ("VAHRUAE_MonthsFrequency", VAHRUAE_MonthsFrequency);}/** Get Months Frequency.
@return Months Frequency */
public int GetVAHRUAE_MonthsFrequency() {Object ii = Get_Value("VAHRUAE_MonthsFrequency");if (ii == null) return 0;return Convert.ToInt32(ii);}
/** VAHRUAE_PayCalculation AD_Reference_ID=1000294 */
public static int VAHRUAE_PAYCALCULATION_AD_Reference_ID=1000294;/** Fixed Value Once = A */
public static String VAHRUAE_PAYCALCULATION_FixedValueOnce = "A";/** Fixed Value = B */
public static String VAHRUAE_PAYCALCULATION_FixedValue = "B";/** % Value = C */
public static String VAHRUAE_PAYCALCULATION_Value = "C";/** % Value Once = D */
public static String VAHRUAE_PAYCALCULATION_ValueOnce = "D";/** Formula = E */
public static String VAHRUAE_PAYCALCULATION_Formula = "E";/** Formula Once = F */
public static String VAHRUAE_PAYCALCULATION_FormulaOnce = "F";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_PayCalculationValid (String test){return test == null || test.Equals("A") || test.Equals("B") || test.Equals("C") || test.Equals("D") || test.Equals("E") || test.Equals("F");}/** Set Pay Calculation.
@param VAHRUAE_PayCalculation Pay Calculation */
public void SetVAHRUAE_PayCalculation (String VAHRUAE_PayCalculation){if (!IsVAHRUAE_PayCalculationValid(VAHRUAE_PayCalculation))
throw new ArgumentException ("VAHRUAE_PayCalculation Invalid value - " + VAHRUAE_PayCalculation + " - Reference_ID=1000294 - A - B - C - D - E - F");if (VAHRUAE_PayCalculation != null && VAHRUAE_PayCalculation.Length > 1){log.Warning("Length > 1 - truncated");VAHRUAE_PayCalculation = VAHRUAE_PayCalculation.Substring(0,1);}Set_Value ("VAHRUAE_PayCalculation", VAHRUAE_PayCalculation);}/** Get Pay Calculation.
@return Pay Calculation */
public String GetVAHRUAE_PayCalculation() {return (String)Get_Value("VAHRUAE_PayCalculation");}/** Set Percent Value.
@param VAHRUAE_PercentValue Percent Value */
public void SetVAHRUAE_PercentValue (Decimal? VAHRUAE_PercentValue){Set_Value ("VAHRUAE_PercentValue", (Decimal?)VAHRUAE_PercentValue);}/** Get Percent Value.
@return Percent Value */
public Decimal GetVAHRUAE_PercentValue() {Object bd =Get_Value("VAHRUAE_PercentValue");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}
/** VAHRUAE_ReferenceName AD_Reference_ID=1000295 */
public static int VAHRUAE_REFERENCENAME_AD_Reference_ID=1000295;/** Set Reference Name.
@param VAHRUAE_ReferenceName Reference Name */
public void SetVAHRUAE_ReferenceName (int VAHRUAE_ReferenceName){Set_Value ("VAHRUAE_ReferenceName", VAHRUAE_ReferenceName);}/** Get Reference Name.
@return Reference Name */
public int GetVAHRUAE_ReferenceName() {Object ii = Get_Value("VAHRUAE_ReferenceName");if (ii == null) return 0;return Convert.ToInt32(ii);}
/** VAHRUAE_SalaryType AD_Reference_ID=1000242 */
public static int VAHRUAE_SALARYTYPE_AD_Reference_ID=1000242;/** Daily = DA */
public static String VAHRUAE_SALARYTYPE_Daily = "DA";/** Fort Night = FN */
public static String VAHRUAE_SALARYTYPE_FortNight = "FN";/** Monthly = MO */
public static String VAHRUAE_SALARYTYPE_Monthly = "MO";/** Weekly = WE */
public static String VAHRUAE_SALARYTYPE_Weekly = "WE";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_SalaryTypeValid (String test){return test == null || test.Equals("DA") || test.Equals("FN") || test.Equals("MO") || test.Equals("WE");}/** Set Salary Type.
@param VAHRUAE_SalaryType Salary Type */
public void SetVAHRUAE_SalaryType (String VAHRUAE_SalaryType){if (!IsVAHRUAE_SalaryTypeValid(VAHRUAE_SalaryType))
throw new ArgumentException ("VAHRUAE_SalaryType Invalid value - " + VAHRUAE_SalaryType + " - Reference_ID=1000242 - DA - FN - MO - WE");if (VAHRUAE_SalaryType != null && VAHRUAE_SalaryType.Length > 2){log.Warning("Length > 2 - truncated");VAHRUAE_SalaryType = VAHRUAE_SalaryType.Substring(0,2);}Set_Value ("VAHRUAE_SalaryType", VAHRUAE_SalaryType);}/** Get Salary Type.
@return Salary Type */
public String GetVAHRUAE_SalaryType() {return (String)Get_Value("VAHRUAE_SalaryType");}/** Set Shift Compenstion.
@param VAHRUAE_ShiftCompenstion_ID Shift Compenstion */
public void SetVAHRUAE_ShiftCompenstion_ID (int VAHRUAE_ShiftCompenstion_ID){if (VAHRUAE_ShiftCompenstion_ID < 1) throw new ArgumentException ("VAHRUAE_ShiftCompenstion_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_ShiftCompenstion_ID", VAHRUAE_ShiftCompenstion_ID);}/** Get Shift Compenstion.
@return Shift Compenstion */
public int GetVAHRUAE_ShiftCompenstion_ID() {Object ii = Get_Value("VAHRUAE_ShiftCompenstion_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}}
}