namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_Vss_EmpMthSalary
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_Vss_EmpMthSalary : PO{public X_VAHRUAE_Vss_EmpMthSalary (Context ctx, int VAHRUAE_Vss_EmpMthSalary_ID, Trx trxName) : base (ctx, VAHRUAE_Vss_EmpMthSalary_ID, trxName){/** if (VAHRUAE_Vss_EmpMthSalary_ID == 0){SetVAHRUAE_Vss_EmpMthSalary_ID (0);SetVAHRUAE_Vss_MonthlySalary_ID (0);} */
}public X_VAHRUAE_Vss_EmpMthSalary (Ctx ctx, int VAHRUAE_Vss_EmpMthSalary_ID, Trx trxName) : base (ctx, VAHRUAE_Vss_EmpMthSalary_ID, trxName){/** if (VAHRUAE_Vss_EmpMthSalary_ID == 0){SetVAHRUAE_Vss_EmpMthSalary_ID (0);SetVAHRUAE_Vss_MonthlySalary_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_Vss_EmpMthSalary (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_Vss_EmpMthSalary (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_Vss_EmpMthSalary (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_Vss_EmpMthSalary(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27902325132605L;/** Last Updated Timestamp 5/5/2021 9:30:15 AM */
public static long updatedMS = 1620199815816L;/** AD_Table_ID=1000811 */
public static int Table_ID; // =1000811;
/** TableName=VAHRUAE_Vss_EmpMthSalary */
public static String Table_Name="VAHRUAE_Vss_EmpMthSalary";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_Vss_EmpMthSalary[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Business Partner.
@param C_BPartner_ID Identifies a Customer/Prospect */
public void SetC_BPartner_ID (int C_BPartner_ID){if (C_BPartner_ID <= 0) Set_Value ("C_BPartner_ID", null);else
Set_Value ("C_BPartner_ID", C_BPartner_ID);}/** Get Business Partner.
@return Identifies a Customer/Prospect */
public int GetC_BPartner_ID() {Object ii = Get_Value("C_BPartner_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Document No..
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
public Boolean IsProcessed() {Object oo = Get_Value("Processed");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set PaySlip GC.
@param VAHRUAE_CryReport_PaySlipGC PaySlip GC */
public void SetVAHRUAE_CryReport_PaySlipGC (String VAHRUAE_CryReport_PaySlipGC){if (VAHRUAE_CryReport_PaySlipGC != null && VAHRUAE_CryReport_PaySlipGC.Length > 2){log.Warning("Length > 2 - truncated");VAHRUAE_CryReport_PaySlipGC = VAHRUAE_CryReport_PaySlipGC.Substring(0,2);}Set_Value ("VAHRUAE_CryReport_PaySlipGC", VAHRUAE_CryReport_PaySlipGC);}/** Get PaySlip GC.
@return PaySlip GC */
public String GetVAHRUAE_CryReport_PaySlipGC() {return (String)Get_Value("VAHRUAE_CryReport_PaySlipGC");}/** Set Print Payment Slip.
@param VAHRUAE_CrystalReport_PaySlip Print Payment Slip */
public void SetVAHRUAE_CrystalReport_PaySlip (String VAHRUAE_CrystalReport_PaySlip){if (VAHRUAE_CrystalReport_PaySlip != null && VAHRUAE_CrystalReport_PaySlip.Length > 50){log.Warning("Length > 50 - truncated");VAHRUAE_CrystalReport_PaySlip = VAHRUAE_CrystalReport_PaySlip.Substring(0,50);}Set_Value ("VAHRUAE_CrystalReport_PaySlip", VAHRUAE_CrystalReport_PaySlip);}/** Get Print Payment Slip.
@return Print Payment Slip */
public String GetVAHRUAE_CrystalReport_PaySlip() {return (String)Get_Value("VAHRUAE_CrystalReport_PaySlip");}/** Set Expense Invoice Created.
@param VAHRUAE_ExpInvCreated Expense Invoice Created */
public void SetVAHRUAE_ExpInvCreated (Boolean VAHRUAE_ExpInvCreated){Set_Value ("VAHRUAE_ExpInvCreated", VAHRUAE_ExpInvCreated);}/** Get Expense Invoice Created.
@return Expense Invoice Created */
public Boolean IsVAHRUAE_ExpInvCreated() {Object oo = Get_Value("VAHRUAE_ExpInvCreated");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Gross Amount.
@param VAHRUAE_Gross_Amount Gross Amount */
public void SetVAHRUAE_Gross_Amount (Decimal? VAHRUAE_Gross_Amount){Set_Value ("VAHRUAE_Gross_Amount", (Decimal?)VAHRUAE_Gross_Amount);}/** Get Gross Amount.
@return Gross Amount */
public Decimal GetVAHRUAE_Gross_Amount() {Object bd =Get_Value("VAHRUAE_Gross_Amount");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Calculated.
@param VAHRUAE_IsCalculated Calculated */
public void SetVAHRUAE_IsCalculated (Boolean VAHRUAE_IsCalculated){Set_Value ("VAHRUAE_IsCalculated", VAHRUAE_IsCalculated);}/** Get Calculated.
@return Calculated */
public Boolean IsVAHRUAE_IsCalculated() {Object oo = Get_Value("VAHRUAE_IsCalculated");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Line No.
@param VAHRUAE_Line Line No */
public void SetVAHRUAE_Line (int VAHRUAE_Line){Set_Value ("VAHRUAE_Line", VAHRUAE_Line);}/** Get Line No.
@return Line No */
public int GetVAHRUAE_Line() {Object ii = Get_Value("VAHRUAE_Line");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Net Amount.
@param VAHRUAE_Net_Amount Net Amount */
public void SetVAHRUAE_Net_Amount (Decimal? VAHRUAE_Net_Amount){Set_Value ("VAHRUAE_Net_Amount", (Decimal?)VAHRUAE_Net_Amount);}/** Get Net Amount.
@return Net Amount */
public Decimal GetVAHRUAE_Net_Amount() {Object bd =Get_Value("VAHRUAE_Net_Amount");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Net Amount Norou.
@param VAHRUAE_Net_Amount_Norou Net Amount Norou */
public void SetVAHRUAE_Net_Amount_Norou (Decimal? VAHRUAE_Net_Amount_Norou){Set_Value ("VAHRUAE_Net_Amount_Norou", (Decimal?)VAHRUAE_Net_Amount_Norou);}/** Get Net Amount Norou.
@return Net Amount Norou */
public Decimal GetVAHRUAE_Net_Amount_Norou() {Object bd =Get_Value("VAHRUAE_Net_Amount_Norou");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Other Deductions.
@param VAHRUAE_OtherDeductions Other Deductions */
public void SetVAHRUAE_OtherDeductions (Decimal? VAHRUAE_OtherDeductions){Set_Value ("VAHRUAE_OtherDeductions", (Decimal?)VAHRUAE_OtherDeductions);}/** Get Other Deductions.
@return Other Deductions */
public Decimal GetVAHRUAE_OtherDeductions() {Object bd =Get_Value("VAHRUAE_OtherDeductions");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set VAHRUAE_PAYSLIP.
@param VAHRUAE_PAYSLIP VAHRUAE_PAYSLIP */
public void SetVAHRUAE_PAYSLIP (Boolean VAHRUAE_PAYSLIP){Set_Value ("VAHRUAE_PAYSLIP", VAHRUAE_PAYSLIP);}/** Get VAHRUAE_PAYSLIP.
@return VAHRUAE_PAYSLIP */
public Boolean IsVAHRUAE_PAYSLIP() {Object oo = Get_Value("VAHRUAE_PAYSLIP");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Pay Year.
@param VAHRUAE_PayYear Pay Year */
public void SetVAHRUAE_PayYear (String VAHRUAE_PayYear){if (VAHRUAE_PayYear != null && VAHRUAE_PayYear.Length > 12){log.Warning("Length > 12 - truncated");VAHRUAE_PayYear = VAHRUAE_PayYear.Substring(0,12);}Set_Value ("VAHRUAE_PayYear", VAHRUAE_PayYear);}/** Get Pay Year.
@return Pay Year */
public String GetVAHRUAE_PayYear() {return (String)Get_Value("VAHRUAE_PayYear");}/** Set Penalty Amount.
@param VAHRUAE_Penality Penalty Amount */
public void SetVAHRUAE_Penality (Decimal? VAHRUAE_Penality){Set_Value ("VAHRUAE_Penality", (Decimal?)VAHRUAE_Penality);}/** Get Penalty Amount.
@return Penalty Amount */
public Decimal GetVAHRUAE_Penality() {Object bd =Get_Value("VAHRUAE_Penality");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Process Now.
@param VAHRUAE_Processing Process Now */
public void SetVAHRUAE_Processing (Boolean VAHRUAE_Processing){Set_Value ("VAHRUAE_Processing", VAHRUAE_Processing);}/** Get Process Now.
@return Process Now */
public Boolean IsVAHRUAE_Processing() {Object oo = Get_Value("VAHRUAE_Processing");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Reason.
@param VAHRUAE_Reason Reason */
public void SetVAHRUAE_Reason (String VAHRUAE_Reason){if (VAHRUAE_Reason != null && VAHRUAE_Reason.Length > 1000){log.Warning("Length > 1000 - truncated");VAHRUAE_Reason = VAHRUAE_Reason.Substring(0,1000);}Set_Value ("VAHRUAE_Reason", VAHRUAE_Reason);}/** Get Reason.
@return Reason */
public String GetVAHRUAE_Reason() {return (String)Get_Value("VAHRUAE_Reason");}/** Set Salary Process.
@param VAHRUAE_SalaryProcess Salary Process */
public void SetVAHRUAE_SalaryProcess (String VAHRUAE_SalaryProcess){if (VAHRUAE_SalaryProcess != null && VAHRUAE_SalaryProcess.Length > 1){log.Warning("Length > 1 - truncated");VAHRUAE_SalaryProcess = VAHRUAE_SalaryProcess.Substring(0,1);}Set_Value ("VAHRUAE_SalaryProcess", VAHRUAE_SalaryProcess);}/** Get Salary Process.
@return Salary Process */
public String GetVAHRUAE_SalaryProcess() {return (String)Get_Value("VAHRUAE_SalaryProcess");}/** Set Unpaid Leave Amount.
@param VAHRUAE_UnpaidLeave Unpaid Leave Amount */
public void SetVAHRUAE_UnpaidLeave (Decimal? VAHRUAE_UnpaidLeave){Set_Value ("VAHRUAE_UnpaidLeave", (Decimal?)VAHRUAE_UnpaidLeave);}/** Get Unpaid Leave Amount.
@return Unpaid Leave Amount */
public Decimal GetVAHRUAE_UnpaidLeave() {Object bd =Get_Value("VAHRUAE_UnpaidLeave");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Emp Monthly Salary.
@param VAHRUAE_Vss_EmpMthSalary_ID Emp Monthly Salary */
public void SetVAHRUAE_Vss_EmpMthSalary_ID (int VAHRUAE_Vss_EmpMthSalary_ID){if (VAHRUAE_Vss_EmpMthSalary_ID < 1) throw new ArgumentException ("VAHRUAE_Vss_EmpMthSalary_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_Vss_EmpMthSalary_ID", VAHRUAE_Vss_EmpMthSalary_ID);}/** Get Emp Monthly Salary.
@return Emp Monthly Salary */
public int GetVAHRUAE_Vss_EmpMthSalary_ID() {Object ii = Get_Value("VAHRUAE_Vss_EmpMthSalary_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Year.
@param VAHRUAE_Vss_MonthlySalary_ID Year */
public void SetVAHRUAE_Vss_MonthlySalary_ID (int VAHRUAE_Vss_MonthlySalary_ID){if (VAHRUAE_Vss_MonthlySalary_ID < 1) throw new ArgumentException ("VAHRUAE_Vss_MonthlySalary_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_Vss_MonthlySalary_ID", VAHRUAE_Vss_MonthlySalary_ID);}/** Get Year.
@return Year */
public int GetVAHRUAE_Vss_MonthlySalary_ID() {Object ii = Get_Value("VAHRUAE_Vss_MonthlySalary_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}}
}