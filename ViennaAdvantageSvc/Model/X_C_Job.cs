namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for C_Job
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_C_Job : PO{public X_C_Job (Context ctx, int C_Job_ID, Trx trxName) : base (ctx, C_Job_ID, trxName){/** if (C_Job_ID == 0){SetC_JobCategory_ID (0);SetC_Job_ID (0);SetIsEmployee (true);// Y
SetName (null);} */
}public X_C_Job (Ctx ctx, int C_Job_ID, Trx trxName) : base (ctx, C_Job_ID, trxName){/** if (C_Job_ID == 0){SetC_JobCategory_ID (0);SetC_Job_ID (0);SetIsEmployee (true);// Y
SetName (null);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_Job (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_Job (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_Job (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_C_Job(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27903557015022L;/** Last Updated Timestamp 5/19/2021 3:41:38 PM */
public static long updatedMS = 1621431698233L;/** AD_Table_ID=789 */
public static int Table_ID; // =789;
/** TableName=C_Job */
public static String Table_Name="C_Job";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_C_Job[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Position Category.
@param C_JobCategory_ID Job Position Category */
public void SetC_JobCategory_ID (int C_JobCategory_ID){if (C_JobCategory_ID < 1) throw new ArgumentException ("C_JobCategory_ID is mandatory.");Set_ValueNoCheck ("C_JobCategory_ID", C_JobCategory_ID);}/** Get Position Category.
@return Job Position Category */
public int GetC_JobCategory_ID() {Object ii = Get_Value("C_JobCategory_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Position.
@param C_Job_ID Job Position */
public void SetC_Job_ID (int C_Job_ID){if (C_Job_ID < 1) throw new ArgumentException ("C_Job_ID is mandatory.");Set_ValueNoCheck ("C_Job_ID", C_Job_ID);}/** Get Position.
@return Job Position */
public int GetC_Job_ID() {Object ii = Get_Value("C_Job_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Description.
@param Description Optional short description of the record */
public void SetDescription (String Description){if (Description != null && Description.Length > 255){log.Warning("Length > 255 - truncated");Description = Description.Substring(0,255);}Set_Value ("Description", Description);}/** Get Description.
@return Optional short description of the record */
public String GetDescription() {return (String)Get_Value("Description");}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_ValueNoCheck ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Comment.
@param Help Comment, Help or Hint */
public void SetHelp (String Help){if (Help != null && Help.Length > 2000){log.Warning("Length > 2000 - truncated");Help = Help.Substring(0,2000);}Set_Value ("Help", Help);}/** Get Comment.
@return Comment, Help or Hint */
public String GetHelp() {return (String)Get_Value("Help");}/** Set Employee.
@param IsEmployee Indicates if  this Business Partner is an employee */
public void SetIsEmployee (Boolean IsEmployee){Set_Value ("IsEmployee", IsEmployee);}/** Get Employee.
@return Indicates if  this Business Partner is an employee */
public Boolean IsEmployee() {Object oo = Get_Value("IsEmployee");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Name.
@param Name Alphanumeric identifier of the entity */
public void SetName (String Name){if (Name == null) throw new ArgumentException ("Name is mandatory.");if (Name.Length > 60){log.Warning("Length > 60 - truncated");Name = Name.Substring(0,60);}Set_Value ("Name", Name);}/** Get Name.
@return Alphanumeric identifier of the entity */
public String GetName() {return (String)Get_Value("Name");}/** Get Record ID/ColumnName
@return ID/ColumnName pair */
public KeyNamePair GetKeyNamePair() {return new KeyNamePair(Get_ID(), GetName());}/** Set Department.
@param VAHRUAE_DepartmentMaster_ID Department */
public void SetVAHRUAE_DepartmentMaster_ID (int VAHRUAE_DepartmentMaster_ID){if (VAHRUAE_DepartmentMaster_ID <= 0) Set_Value ("VAHRUAE_DepartmentMaster_ID", null);else
Set_Value ("VAHRUAE_DepartmentMaster_ID", VAHRUAE_DepartmentMaster_ID);}/** Get Department.
@return Department */
public int GetVAHRUAE_DepartmentMaster_ID() {Object ii = Get_Value("VAHRUAE_DepartmentMaster_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Ex-Servicemen.
@param VAHRUAE_ExServiceMan Ex-Servicemen */
public void SetVAHRUAE_ExServiceMan (int VAHRUAE_ExServiceMan){Set_Value ("VAHRUAE_ExServiceMan", VAHRUAE_ExServiceMan);}/** Get Ex-Servicemen.
@return Ex-Servicemen */
public int GetVAHRUAE_ExServiceMan() {Object ii = Get_Value("VAHRUAE_ExServiceMan");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Filled Seats.
@param VAHRUAE_FilledSeats Filled Seats */
public void SetVAHRUAE_FilledSeats (int VAHRUAE_FilledSeats){Set_Value ("VAHRUAE_FilledSeats", VAHRUAE_FilledSeats);}/** Get Filled Seats.
@return Filled Seats */
public int GetVAHRUAE_FilledSeats() {Object ii = Get_Value("VAHRUAE_FilledSeats");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Free Seats.
@param VAHRUAE_FreeSeats Free Seats */
public void SetVAHRUAE_FreeSeats (int VAHRUAE_FreeSeats){Set_Value ("VAHRUAE_FreeSeats", VAHRUAE_FreeSeats);}/** Get Free Seats.
@return Free Seats */
public int GetVAHRUAE_FreeSeats() {Object ii = Get_Value("VAHRUAE_FreeSeats");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Free Seats Approved.
@param VAHRUAE_FreeSeatsApproval Free Seats Approved */
public void SetVAHRUAE_FreeSeatsApproval (int VAHRUAE_FreeSeatsApproval){throw new ArgumentException ("VAHRUAE_FreeSeatsApproval Is virtual column");}/** Get Free Seats Approved.
@return Free Seats Approved */
public int GetVAHRUAE_FreeSeatsApproval() {Object ii = Get_Value("VAHRUAE_FreeSeatsApproval");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Free Seats (In Approval).
@param VAHRUAE_FreeSeatsInApproval Free Seats (In Approval) */
public void SetVAHRUAE_FreeSeatsInApproval (int VAHRUAE_FreeSeatsInApproval){throw new ArgumentException ("VAHRUAE_FreeSeatsInApproval Is virtual column");}/** Get Free Seats (In Approval).
@return Free Seats (In Approval) */
public int GetVAHRUAE_FreeSeatsInApproval() {Object ii = Get_Value("VAHRUAE_FreeSeatsInApproval");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set General.
@param VAHRUAE_General General */
public void SetVAHRUAE_General (int VAHRUAE_General){Set_Value ("VAHRUAE_General", VAHRUAE_General);}/** Get General.
@return General */
public int GetVAHRUAE_General() {Object ii = Get_Value("VAHRUAE_General");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Shift.
@param VAHRUAE_HR_AttendanceRule_ID Shift */
public void SetVAHRUAE_HR_AttendanceRule_ID (int VAHRUAE_HR_AttendanceRule_ID){if (VAHRUAE_HR_AttendanceRule_ID <= 0) Set_Value ("VAHRUAE_HR_AttendanceRule_ID", null);else
Set_Value ("VAHRUAE_HR_AttendanceRule_ID", VAHRUAE_HR_AttendanceRule_ID);}/** Get Shift.
@return Shift */
public int GetVAHRUAE_HR_AttendanceRule_ID() {Object ii = Get_Value("VAHRUAE_HR_AttendanceRule_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Penalty.
@param VAHRUAE_HR_Penality_ID Penalty */
public void SetVAHRUAE_HR_Penality_ID (int VAHRUAE_HR_Penality_ID){if (VAHRUAE_HR_Penality_ID <= 0) Set_Value ("VAHRUAE_HR_Penality_ID", null);else
Set_Value ("VAHRUAE_HR_Penality_ID", VAHRUAE_HR_Penality_ID);}/** Get Penalty.
@return Penalty */
public int GetVAHRUAE_HR_Penality_ID() {Object ii = Get_Value("VAHRUAE_HR_Penality_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Categorised.
@param VAHRUAE_IsCategorised Categorised */
public void SetVAHRUAE_IsCategorised (Boolean VAHRUAE_IsCategorised){Set_Value ("VAHRUAE_IsCategorised", VAHRUAE_IsCategorised);}/** Get Categorised.
@return Categorised */
public Boolean IsVAHRUAE_IsCategorised() {Object oo = Get_Value("VAHRUAE_IsCategorised");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Leave Salary Rule.
@param VAHRUAE_LeaveSalaryRule_ID Leave Salary Rule */
public void SetVAHRUAE_LeaveSalaryRule_ID (int VAHRUAE_LeaveSalaryRule_ID){if (VAHRUAE_LeaveSalaryRule_ID <= 0) Set_Value ("VAHRUAE_LeaveSalaryRule_ID", null);else
Set_Value ("VAHRUAE_LeaveSalaryRule_ID", VAHRUAE_LeaveSalaryRule_ID);}/** Get Leave Salary Rule.
@return Leave Salary Rule */
public int GetVAHRUAE_LeaveSalaryRule_ID() {Object ii = Get_Value("VAHRUAE_LeaveSalaryRule_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Maximum Experience.
@param VAHRUAE_MaxExperience Maximum Experience */
public void SetVAHRUAE_MaxExperience (Decimal? VAHRUAE_MaxExperience){Set_Value ("VAHRUAE_MaxExperience", (Decimal?)VAHRUAE_MaxExperience);}/** Get Maximum Experience.
@return Maximum Experience */
public Decimal GetVAHRUAE_MaxExperience() {Object bd =Get_Value("VAHRUAE_MaxExperience");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Max. Salary / Month.
@param VAHRUAE_MaxSalary Max. Salary / Month */
public void SetVAHRUAE_MaxSalary (Decimal? VAHRUAE_MaxSalary){Set_Value ("VAHRUAE_MaxSalary", (Decimal?)VAHRUAE_MaxSalary);}/** Get Max. Salary / Month.
@return Max. Salary / Month */
public Decimal GetVAHRUAE_MaxSalary() {Object bd =Get_Value("VAHRUAE_MaxSalary");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Minimum Experience.
@param VAHRUAE_MinExperience Minimum Experience */
public void SetVAHRUAE_MinExperience (Decimal? VAHRUAE_MinExperience){Set_Value ("VAHRUAE_MinExperience", (Decimal?)VAHRUAE_MinExperience);}/** Get Minimum Experience.
@return Minimum Experience */
public Decimal GetVAHRUAE_MinExperience() {Object bd =Get_Value("VAHRUAE_MinExperience");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Min. Salary / Month.
@param VAHRUAE_MinSalary Min. Salary / Month */
public void SetVAHRUAE_MinSalary (Decimal? VAHRUAE_MinSalary){Set_Value ("VAHRUAE_MinSalary", (Decimal?)VAHRUAE_MinSalary);}/** Get Min. Salary / Month.
@return Min. Salary / Month */
public Decimal GetVAHRUAE_MinSalary() {Object bd =Get_Value("VAHRUAE_MinSalary");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set No. of Rounds.
@param VAHRUAE_NoofRounds No. of Rounds */
public void SetVAHRUAE_NoofRounds (int VAHRUAE_NoofRounds){Set_Value ("VAHRUAE_NoofRounds", VAHRUAE_NoofRounds);}/** Get No. of Rounds.
@return No. of Rounds */
public int GetVAHRUAE_NoofRounds() {Object ii = Get_Value("VAHRUAE_NoofRounds");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Physically Handicapped.
@param VAHRUAE_PhysicallyHandicapted Physically Handicapped */
public void SetVAHRUAE_PhysicallyHandicapted (int VAHRUAE_PhysicallyHandicapted){Set_Value ("VAHRUAE_PhysicallyHandicapted", VAHRUAE_PhysicallyHandicapted);}/** Get Physically Handicapped.
@return Physically Handicapped */
public int GetVAHRUAE_PhysicallyHandicapted() {Object ii = Get_Value("VAHRUAE_PhysicallyHandicapted");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Roles & Responsibility.
@param VAHRUAE_RolesResponsibility Roles & Responsibility */
public void SetVAHRUAE_RolesResponsibility (String VAHRUAE_RolesResponsibility){if (VAHRUAE_RolesResponsibility != null && VAHRUAE_RolesResponsibility.Length > 500){log.Warning("Length > 500 - truncated");VAHRUAE_RolesResponsibility = VAHRUAE_RolesResponsibility.Substring(0,500);}Set_Value ("VAHRUAE_RolesResponsibility", VAHRUAE_RolesResponsibility);}/** Get Roles & Responsibility.
@return Roles & Responsibility */
public String GetVAHRUAE_RolesResponsibility() {return (String)Get_Value("VAHRUAE_RolesResponsibility");}/** Set SC.
@param VAHRUAE_SC SC */
public void SetVAHRUAE_SC (int VAHRUAE_SC){Set_Value ("VAHRUAE_SC", VAHRUAE_SC);}/** Get SC.
@return SC */
public int GetVAHRUAE_SC() {Object ii = Get_Value("VAHRUAE_SC");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set ST.
@param VAHRUAE_ST ST */
public void SetVAHRUAE_ST (int VAHRUAE_ST){Set_Value ("VAHRUAE_ST", VAHRUAE_ST);}/** Get ST.
@return ST */
public int GetVAHRUAE_ST() {Object ii = Get_Value("VAHRUAE_ST");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Total Seats.
@param VAHRUAE_TotalSeats Total Seats */
public void SetVAHRUAE_TotalSeats (int VAHRUAE_TotalSeats){Set_Value ("VAHRUAE_TotalSeats", VAHRUAE_TotalSeats);}/** Get Total Seats.
@return Total Seats */
public int GetVAHRUAE_TotalSeats() {Object ii = Get_Value("VAHRUAE_TotalSeats");if (ii == null) return 0;return Convert.ToInt32(ii);}}
}