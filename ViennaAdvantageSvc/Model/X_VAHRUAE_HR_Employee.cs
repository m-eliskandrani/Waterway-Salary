namespace DGM10.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAHRUAE_HR_Employee
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAHRUAE_HR_Employee : PO{public X_VAHRUAE_HR_Employee (Context ctx, int VAHRUAE_HR_Employee_ID, Trx trxName) : base (ctx, VAHRUAE_HR_Employee_ID, trxName){/** if (VAHRUAE_HR_Employee_ID == 0){SetVAHRUAE_HR_Employee_ID (0);SetVAHRUAE_HR_Training_ID (0);} */
}public X_VAHRUAE_HR_Employee (Ctx ctx, int VAHRUAE_HR_Employee_ID, Trx trxName) : base (ctx, VAHRUAE_HR_Employee_ID, trxName){/** if (VAHRUAE_HR_Employee_ID == 0){SetVAHRUAE_HR_Employee_ID (0);SetVAHRUAE_HR_Training_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_Employee (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_Employee (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAHRUAE_HR_Employee (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAHRUAE_HR_Employee(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27900001072514L;/** Last Updated Timestamp 4/8/2021 11:55:55 AM */
public static long updatedMS = 1617875755725L;/** AD_Table_ID=1000804 */
public static int Table_ID; // =1000804;
/** TableName=VAHRUAE_HR_Employee */
public static String Table_Name="VAHRUAE_HR_Employee";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAHRUAE_HR_Employee[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Business Partner.
@param C_BPartner_ID Identifies a Customer/Prospect */
public void SetC_BPartner_ID (int C_BPartner_ID){if (C_BPartner_ID <= 0) Set_Value ("C_BPartner_ID", null);else
Set_Value ("C_BPartner_ID", C_BPartner_ID);}/** Get Business Partner.
@return Identifies a Customer/Prospect */
public int GetC_BPartner_ID() {Object ii = Get_Value("C_BPartner_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Comments.
@param VAHRUAE_Comments Comments */
public void SetVAHRUAE_Comments (String VAHRUAE_Comments){if (VAHRUAE_Comments != null && VAHRUAE_Comments.Length > 500){log.Warning("Length > 500 - truncated");VAHRUAE_Comments = VAHRUAE_Comments.Substring(0,500);}Set_Value ("VAHRUAE_Comments", VAHRUAE_Comments);}/** Get Comments.
@return Comments */
public String GetVAHRUAE_Comments() {return (String)Get_Value("VAHRUAE_Comments");}/** Set From Date.
@param VAHRUAE_FromDate From Date */
public void SetVAHRUAE_FromDate (DateTime? VAHRUAE_FromDate){Set_Value ("VAHRUAE_FromDate", (DateTime?)VAHRUAE_FromDate);}/** Get From Date.
@return From Date */
public DateTime? GetVAHRUAE_FromDate() {return (DateTime?)Get_Value("VAHRUAE_FromDate");}/** Set VAHRUAE_HR_AttendanceRule_ID.
@param VAHRUAE_HR_AttendanceRule_ID VAHRUAE_HR_AttendanceRule_ID */
public void SetVAHRUAE_HR_AttendanceRule_ID (int VAHRUAE_HR_AttendanceRule_ID){if (VAHRUAE_HR_AttendanceRule_ID <= 0) Set_Value ("VAHRUAE_HR_AttendanceRule_ID", null);else
Set_Value ("VAHRUAE_HR_AttendanceRule_ID", VAHRUAE_HR_AttendanceRule_ID);}/** Get VAHRUAE_HR_AttendanceRule_ID.
@return VAHRUAE_HR_AttendanceRule_ID */
public int GetVAHRUAE_HR_AttendanceRule_ID() {Object ii = Get_Value("VAHRUAE_HR_AttendanceRule_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set HR Employee.
@param VAHRUAE_HR_Employee_ID HR Employee */
public void SetVAHRUAE_HR_Employee_ID (int VAHRUAE_HR_Employee_ID){if (VAHRUAE_HR_Employee_ID < 1) throw new ArgumentException ("VAHRUAE_HR_Employee_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_HR_Employee_ID", VAHRUAE_HR_Employee_ID);}/** Get HR Employee.
@return HR Employee */
public int GetVAHRUAE_HR_Employee_ID() {Object ii = Get_Value("VAHRUAE_HR_Employee_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set HR Training .
@param VAHRUAE_HR_Training_ID HR Training  */
public void SetVAHRUAE_HR_Training_ID (int VAHRUAE_HR_Training_ID){if (VAHRUAE_HR_Training_ID < 1) throw new ArgumentException ("VAHRUAE_HR_Training_ID is mandatory.");Set_ValueNoCheck ("VAHRUAE_HR_Training_ID", VAHRUAE_HR_Training_ID);}/** Get HR Training .
@return HR Training  */
public int GetVAHRUAE_HR_Training_ID() {Object ii = Get_Value("VAHRUAE_HR_Training_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Place.
@param VAHRUAE_Place Place */
public void SetVAHRUAE_Place (String VAHRUAE_Place){if (VAHRUAE_Place != null && VAHRUAE_Place.Length > 100){log.Warning("Length > 100 - truncated");VAHRUAE_Place = VAHRUAE_Place.Substring(0,100);}Set_Value ("VAHRUAE_Place", VAHRUAE_Place);}/** Get Place.
@return Place */
public String GetVAHRUAE_Place() {return (String)Get_Value("VAHRUAE_Place");}/** Set Training Start Time.
@param VAHRUAE_StartTime Training Start Time */
public void SetVAHRUAE_StartTime (DateTime? VAHRUAE_StartTime){Set_Value ("VAHRUAE_StartTime", (DateTime?)VAHRUAE_StartTime);}/** Get Training Start Time.
@return Training Start Time */
public DateTime? GetVAHRUAE_StartTime() {return (DateTime?)Get_Value("VAHRUAE_StartTime");}/** Set To Date.
@param VAHRUAE_ToDate To Date */
public void SetVAHRUAE_ToDate (DateTime? VAHRUAE_ToDate){Set_Value ("VAHRUAE_ToDate", (DateTime?)VAHRUAE_ToDate);}/** Get To Date.
@return To Date */
public DateTime? GetVAHRUAE_ToDate() {return (DateTime?)Get_Value("VAHRUAE_ToDate");}/** Set Trainer Name.
@param VAHRUAE_TrainerName Trainer Name */
public void SetVAHRUAE_TrainerName (String VAHRUAE_TrainerName){if (VAHRUAE_TrainerName != null && VAHRUAE_TrainerName.Length > 100){log.Warning("Length > 100 - truncated");VAHRUAE_TrainerName = VAHRUAE_TrainerName.Substring(0,100);}Set_Value ("VAHRUAE_TrainerName", VAHRUAE_TrainerName);}/** Get Trainer Name.
@return Trainer Name */
public String GetVAHRUAE_TrainerName() {return (String)Get_Value("VAHRUAE_TrainerName");}
/** VAHRUAE_TrainingAttend AD_Reference_ID=1000287 */
public static int VAHRUAE_TRAININGATTEND_AD_Reference_ID=1000287;/** Complete = C */
public static String VAHRUAE_TRAININGATTEND_Complete = "C";/** Partial = P */
public static String VAHRUAE_TRAININGATTEND_Partial = "P";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAHRUAE_TrainingAttendValid (String test){return test == null || test.Equals("C") || test.Equals("P");}/** Set Training Attended.
@param VAHRUAE_TrainingAttend Training Attended */
public void SetVAHRUAE_TrainingAttend (String VAHRUAE_TrainingAttend){if (!IsVAHRUAE_TrainingAttendValid(VAHRUAE_TrainingAttend))
throw new ArgumentException ("VAHRUAE_TrainingAttend Invalid value - " + VAHRUAE_TrainingAttend + " - Reference_ID=1000287 - C - P");if (VAHRUAE_TrainingAttend != null && VAHRUAE_TrainingAttend.Length > 1){log.Warning("Length > 1 - truncated");VAHRUAE_TrainingAttend = VAHRUAE_TrainingAttend.Substring(0,1);}Set_Value ("VAHRUAE_TrainingAttend", VAHRUAE_TrainingAttend);}/** Get Training Attended.
@return Training Attended */
public String GetVAHRUAE_TrainingAttend() {return (String)Get_Value("VAHRUAE_TrainingAttend");}}
}