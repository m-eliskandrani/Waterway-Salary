using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAdvantage.DataBase;
using VAdvantage.Logging;
using VAdvantage.Model;
using VAdvantage.ProcessEngine;
using VAdvantage.Utility;
using DGM10.Model;
using System.IO;
using System.Threading;
using VAdvantage.Classes;
using ViennaAdvantage.Model;
using X_C_BPartner = DGM10.Model.X_C_BPartner;
using X_C_Period = VAdvantage.Model.X_C_Period;
using VAdvantage.DBPort;
using X_C_TaxCategory = DGM10.Model.X_C_TaxCategory;
using X_C_Tax = DGM10.Model.X_C_Tax;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
namespace DGM10.Process
{
	public class CalculateSalaries : SvrProcess
	{
		protected override string DoIt()
		{
			DateTime? GivenStart, GivenEnd;
			GivenStart = DateTime.MinValue;
			ProcessInfoParameter[] para = GetParameter();
			int period = -1;
			foreach (ProcessInfoParameter element in para)
			{
				String name = element.GetParameterName();
				if (element.GetParameter() == null)
				{
					;
				}
				if (name.Equals("C_Period_ID"))
					period = element.GetParameterAsInt();
				else
					log.Log(Level.SEVERE, "Unknown Parameter: " + name);
			}
			string[] monthNames = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN",
				"JUL", "AUG", "SEP", "OCT", "NOV", "DEC"
			};
			DateTime MonthStart, MonthEnd;
			DateTime datetemp = DateTime.Now;
			DateTime? currday;
			DateTime initial;
			bool leaveloop = false;
			X_C_BPartner e;
			X_VAHRUAE_HR_AttendanceRule x;
			X_VAHRUAE_MthAttendDetail m;
			X_VAHRUAE_HR_EmpAttendanceLog d;
			X_VAHRUAE_Vss_EmpMthSalary mthsal;
			X_VAHRUAE_EmployeCompensation empcomp;
			X_VAHRUAE_HR_PenalityDetails pd;
			X_VAHRUAE_HR_LeaveDetail leavedet;
			X_C_Period periodValue;
			X_VAHRUAE_PositionBenefit empbenefit;
			int latearrtemp;
			latearrtemp = 0;
			bool ishol = false;
			int round;
			double leeway;
			List<double> hourlist = new List<double> { };
			int[] compmastID;
			int[] IDs;
			int[] mthIDs;
			int[] pIDs;
			int[] lIDs;
			int[] compensations;
			int[] benefits;
			double shiftDec = Double.MaxValue;
			double hours = 0;
			DateTime? start;
			DateTime? end;
			int mns, mne;
			int times = 0;
			int totaltimes = 0;
			int noOfDays = 0;
			int abs = 0;
			int attcounter = 0;
			compmastID = X_VAHRUAE_CompensationMaster.GetAllIDs("VAHRUAE_COMPENSATIONMASTER", "ISACTIVE = 'Y' AND VAHRUAE_NAME = 'Basic Salary'", null);
			if (compmastID != null && compmastID.Length != 0)
			{
				List<X_VAHRUAE_HR_EmpAttendanceLog> eatt = new List<X_VAHRUAE_HR_EmpAttendanceLog>();
				//e = new X_C_BPartner(GetCtx(), id, null);
				int[] atIDs = X_VAHRUAE_HR_AttendanceRule.GetAllIDs("VAHRUAE_HR_AttendanceRule", "ISACTIVE = 'Y'", null);
				periodValue = new X_C_Period(GetCtx(), period, null);
				if (periodValue != null)
				{
					GivenStart = periodValue.GetStartDate();
					GivenEnd = new DateTime(GivenStart.Value.Year, GivenStart.Value.Month, 19);
					GivenStart = new DateTime(GivenStart.Value.AddMonths(-1).Year, GivenStart.Value.AddMonths(-1).Month, 20);
					if (atIDs != null && atIDs.Length != 0)
					{
						for (int i = 0; i < atIDs.Length; i++)
						{
							x = new X_VAHRUAE_HR_AttendanceRule(GetCtx(), atIDs[i], null);
							IDs = X_C_BPartner.GetAllIDs("C_BPartner", "ISACTIVE = 'Y' AND VAHRUAE_HR_AttendanceRule_ID = " + atIDs[i], null);
							if (IDs != null && IDs.Length != 0)
							{
								for (int j = 0; j < IDs.Length; j++)
								{
									e = new X_C_BPartner(GetCtx(), (IDs[j]), null);
									if (!(e.GetVAHRUAE_DATE_JOINING() > GivenEnd.Value || e.GetVAHRUAE_DateRelieved() < GivenStart.Value))
									{
										compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + "  AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
										if (compensations.Length != 0 && compensations != null)
										{
											if (x.IsWORKINGHOURBASED())
											{
												DateTime MonthStarttemp = GivenStart.Value;
												DateTime MonthEndtemp = MonthStarttemp.AddMonths(1);
												for (int h = 0; h < ((GivenEnd.Value.Year - GivenStart.Value.Year) * 12) + GivenEnd.Value.Month - GivenStart.Value.Month; h++)
												{
													m = new X_VAHRUAE_MthAttendDetail(GetCtx(), 0, null);
													m.SetVAHRUAE_Actual_Days_Present(0);
													m.SetVAHRUAE_EarlyOutCount(0);
													m.SetVAHRUAE_OTHour(0);
													m.SetVAHRUAE_Absent_Days(0);
													m.SetAD_Client_ID(GetAD_Client_ID());
													m.SetAD_Org_ID(GetAD_Org_ID());
													m.SetC_BPartner_ID(IDs[j]);
													m.SetVAHRUAE_HolOtHour(0);
													noOfDays = 0;
													latearrtemp = 0;
													MonthEnd = new DateTime(GivenEnd.Value.Year, GivenEnd.Value.Month + 1, 19);
													mns = int.Parse(MonthStarttemp.ToString("dd-MM-yy").Substring(3, 2)) - 1;
													mne = int.Parse(MonthEndtemp.ToString("dd-MM-yy").Substring(3, 2)) - 1;
													// throw new Exception(( "C_BPartner_ID = " + (IDs[j] - 1) + " AND VAHRUAE_TimeOfAttendance >= '" + GivenStart.Value.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mns]) + "' AND VAHRUAE_TimeOfAttendance < '" + GivenEnd.Value.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mne]) + "' ORDER BY VAHRYUAE_ACTUALINTIME"));
													mthIDs = X_VAHRUAE_HR_EmpAttendanceLog.GetAllIDs("vahruae_hr_empattendancelog", "ISACTIVE = 'Y' AND vahruae_enroll_id = " + (IDs[j]) + " AND VAHRUAE_TimeOfAttendance >= '" + MonthStarttemp.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mns]) + "' AND VAHRUAE_TimeOfAttendance <= '" + MonthEndtemp.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mne]) + "' AND VAHRUAE_ATTMARKED = 'N' ORDER BY VAHRUAE_TimeOfAttendance", null);
													totaltimes = 0;
													if (mthIDs != null && mthIDs.Length != 0)
													{
														Decimal leavepen = 0;
														DateTime joinDate = e.GetVAHRUAE_DATE_JOINING().Value;
														d = new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[0], null); d = new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[0], null);
														if (!d.IsVAHRUAE_FirstAttendance())
														{
															int[] temp = new int[mthIDs.Length - 1];
															for (int rq = 1; rq < mthIDs.Length; rq++)
															{
																temp[rq - 1] = mthIDs[rq];
															}
															mthIDs = temp;
														}
														mthsal = new X_VAHRUAE_Vss_EmpMthSalary(GetCtx(), 0, null);
														mthsal.SetAD_Client_ID(GetAD_Client_ID());
														mthsal.SetAD_Org_ID(GetAD_Org_ID());
														mthsal.SetVAHRUAE_Penality(0);
														if (compensations != null && compensations.Length != 0)
														{
															empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
															mthsal.SetVAHRUAE_Gross_Amount(empcomp.GetVAHRUAE_FixedValue());
															if (e.GetVAHRUAE_DATE_JOINING().Value.Date > GivenStart.Value.Date)
															{
																mthsal.SetVAHRUAE_Gross_Amount((Decimal)((double)mthsal.GetVAHRUAE_Gross_Amount() - ((double)empcomp.GetVAHRUAE_FixedValue() * ((e.GetVAHRUAE_DATE_JOINING().Value.Date - GivenStart.Value.Date).TotalDays) / 30)));
															}
															if (e.GetVAHRUAE_DateRelieved() != null)
															{
																if (e.GetVAHRUAE_DateRelieved().Value.Date < GivenEnd.Value.Date)
																{
																	mthsal.SetVAHRUAE_Gross_Amount((Decimal)((double)mthsal.GetVAHRUAE_Gross_Amount() - ((double)empcomp.GetVAHRUAE_FixedValue() * ((GivenEnd.Value.Date - e.GetVAHRUAE_DateRelieved().Value.Date).TotalDays) / 30)));
																}
															}
															eatt.Add(new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[0], null));
															for (totaltimes = 0; totaltimes + 1 < mthIDs.Length;)
															{
																times = 0;
																leaveloop = false;
																d = new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[totaltimes + times + 1], null);
																while (!leaveloop)
																{
																	if (totaltimes + times + 1 < mthIDs.Length)
																		d = new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[totaltimes + times + 1], null);
																	else
																	{
																		leaveloop = true;
																		break;
																	}
																	if (d.GetVAHRUAE_TimeOfAttendance().Value.Date == eatt[0].GetVAHRUAE_TimeOfAttendance().Value.Date)
																	{
																		eatt.Add(d);
																		times++;
																	}
																	else
																	{
																		leaveloop = true;
																	}
																}
																if ((times + 1) % 2 == 0 && times != 0)
																{
																	hours = 0;
																	for (int q = 0; q < times; q += 2)
																	{
																		hours += (eatt[q + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - eatt[q].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalMinutes;
																		if (checkHoliday(eatt[0].GetVAHRUAE_TimeOfAttendance().Value))
																		{
																			m.SetVAHRUAE_HolOtHour(m.GetVAHRUAE_HolOtHour() + (Decimal)hours);
																		}
																		eatt[q].SetVAHRUAE_AttMarked(true);
																		eatt[q].Save();
																		eatt[q + 1].SetVAHRUAE_AttMarked(true);
																		eatt[q + 1].Save();
																	}
																	if (!checkHoliday(eatt[0].GetVAHRUAE_TimeOfAttendance().Value))
																	{
																		hourlist.Add(hours);
																		noOfDays++;
																	}
																}
																if (eatt.Count == 1)
																{
																	int[] tempp = X_VAHRUAE_HR_PenalityDetails.GetAllIDs("VAHRUAE_HR_PENALITYDETAILS", "ISACTIVE = 'Y' AND VAHRUAE_HR_Penality_ID = " + e.GetVAHRUAE_HR_Penality_ID() + " AND VAHRUAE_Missing_Punch= 'Y'", null);
																	int mnt = int.Parse(eatt[0].GetVAHRUAE_TimeOfAttendance().Value.ToString("dd-MM-yy").Substring(3, 2)) - 1;
																	lIDs = X_VAHRUAE_HR_LeaveDetail.GetAllIDs("VAHRUAE_HR_LEAVEDETAIL", "ISACTIVE = 'Y' AND C_BPARTNER_ID = " + (IDs[j]) + " AND VAHRUAE_DATE1= '" + eatt[0].GetVAHRUAE_TimeOfAttendance().Value.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mnt]) + "'", null);
																	if (tempp != null && tempp.Length != 0 && (lIDs == null||lIDs.Length==0))
																	{
																		pd = new X_VAHRUAE_HR_PenalityDetails(GetCtx(), tempp[0], null);
																		X_VAHRUAE_HR_Employee_Penality emppen = new X_VAHRUAE_HR_Employee_Penality(GetCtx(), 0, null);
																		emppen.SetAD_Client_ID(GetAD_Client_ID());
																		emppen.SetAD_Org_ID(GetAD_Org_ID());
																		emppen.SetC_BPartner_ID(e.GetC_BPartner_ID());
																		emppen.SetVAHRUAE_HR_PenalityDetails_ID(tempp[0]);
																		compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + "  AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
																		empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
																		emppen.SetVAHRUAE_DeductionAmount((empcomp.GetVAHRUAE_FixedValue() / 30) * pd.GetVAHRUAE_DeductionPercentage());
																		mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - emppen.GetVAHRUAE_DeductionAmount());
																		mthsal.SetVAHRUAE_Penality(mthsal.GetVAHRUAE_Penality() + emppen.GetVAHRUAE_DeductionAmount());
																		emppen.Save();
																	}
																}
																eatt.Clear();
																totaltimes += times;
																if (totaltimes + 1 < mthIDs.Length)
																{
																	eatt.Add(new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[totaltimes + 1], null));
																	totaltimes++;
																}
																else
																	break;
															}
															hourlist = hourlist.OrderByDescending(g => g).ToList();
															for (int fg = 0; fg < hourlist.Count; fg++)
															{
																if (fg < x.GetDAYSPERMONTH())
																{
																	if (hourlist[fg] < x.GetHOURSPERDAY() * 60)
																	{
																		pIDs = X_VAHRUAE_HR_PenalityDetails.GetAllIDs("VAHRUAE_HR_PenalityDetails", "ISACTIVE = 'Y' AND VAHRUAE_HR_Penality_ID = " + e.GetVAHRUAE_HR_Penality_ID() + " AND VAHRUAE_Line >" + (x.GetHOURSPERDAY() - hourlist[fg]) + "ORDER BY VAHRUAE_Line ASC", null);
																		//pIDs = X_VAHRUAE_HR_Penality.GetAllIDs("VAHRUAE_HR_Penality", "HOURSMISSING > " + (x.GetHOURSPERDAY() - hourlist[fg] / 60) + "ORDER BY HOURSMISSING ASC", null);
																		if (pIDs != null && pIDs.Length != 0)
																		{
																			pd = new X_VAHRUAE_HR_PenalityDetails(GetCtx(), pIDs[0], null);
																			X_VAHRUAE_HR_Employee_Penality emppen = new X_VAHRUAE_HR_Employee_Penality(GetCtx(), 0, null);
																			emppen.SetAD_Client_ID(GetAD_Client_ID());
																			emppen.SetAD_Org_ID(GetAD_Org_ID());
																			emppen.SetC_BPartner_ID(e.GetC_BPartner_ID());
																			emppen.SetVAHRUAE_HR_PenalityDetails_ID(pIDs[0]);
																			compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + "  AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null); empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
																			emppen.SetVAHRUAE_DeductionAmount((empcomp.GetVAHRUAE_FixedValue() / 30) * pd.GetVAHRUAE_DeductionPercentage());
																			mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - emppen.GetVAHRUAE_DeductionAmount());
																			emppen.Save();
																		}
																		m.SetVAHRUAE_EarlyOutCount((int)((double)m.GetVAHRUAE_EarlyOutCount() + (double)x.GetHOURSPERDAY() * 60 - hourlist[fg]));
																	}
																	else if (hourlist[fg] > x.GetHOURSPERDAY() * 60)
																	{
																		double ot = (hourlist[fg] - x.GetHOURSPERDAY() * 60);
																		round = x.GetRoundNumber();
																		if (x.IsRoundFloor())
																		{
																			ot = Floor((int)ot, round);
																		}
																		else if (x.IsRoundCeiling())
																		{
																			ot = Ceiling((int)ot, round);
																		}
																		else
																		{
																			ot = Round((int)ot, round);
																		}
																		//int[] otr = X_VAHRUAE_OTRate.GetAllIDs("VAHRUAE_OTRate", "VAHRUAE_OTRULE = " + x.GetVAHRUAE_OTRule_ID() + "AND NoOfHours <= " + ot + "ORDER BY ASC", null);
																		//X_VAHRUAE_OTRate otra = new X_VAHRUAE_OTRate(GetCtx(), otr[0], null);
																		//int[] complist = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + "  AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
																		//X_VAHRUAE_EmployeCompensation val = new X_VAHRUAE_EmployeCompensation(GetCtx(), complist[0], null);
																		m.SetVAHRUAE_OTHour((Decimal)(ot) + m.GetVAHRUAE_OTHour());
																	}
																}
																else
																{
																	m.SetVAHRUAE_OTHour((Decimal)hourlist[fg] + m.GetVAHRUAE_OTHour());
																}

															}
															leavepen = 0;
															lIDs = X_VAHRUAE_HR_LeaveDetail.GetAllIDs("VAHRUAE_HR_LEAVEDETAIL", "ISACTIVE = 'Y' AND C_BPARTNER_ID = " + (IDs[j]) + " AND VAHRUAE_APPROVE = 'Y' AND VAHRUAE_DATE1 >= '" + MonthStarttemp.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mns]) + "' AND VAHRUAE_DATE1 <= '" + MonthEndtemp.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mne]) + "'", null);
															if (lIDs != null && lIDs.Length != 0)
															{
																for (int kz = 0; kz < lIDs.Length; kz++)
																{
																	leavedet = new X_VAHRUAE_HR_LeaveDetail(GetCtx(), lIDs[kz], null);
																	Decimal salPer = LeaveDaysDeduction(e.GetC_BPartner_ID(), GivenStart.Value.Year, leavedet.GetVAHRUAE_LeaveType());
																	leavepen += (empcomp.GetVAHRUAE_FixedValue() / 30) * (100 - salPer) / 100;
																}
															}
															mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - leavepen - installmentPayment(e.GetC_BPartner_ID()));
															int[] noofhol = X_VAHRUAE_HR_Holidays.GetAllIDs("VAHRUAE_HR_HOLIDAYS", "ISACTIVE = 'Y' AND VAHRUAE_Date1 >= '" + MonthStarttemp.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mns]) + "' AND VAHRUAE_Date1 <= '" + MonthEndtemp.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mne]) + "'", null);
															m.SetVAHRUAE_Actual_Days_Present(noOfDays);
															m.SetC_Period_ID(period);
															m.Save();
															pIDs = X_VAHRUAE_HR_PenalityDetails.GetAllIDs("VAHRUAE_HR_PenalityDetails", "ISACTIVE = 'Y' AND VAHRUAE_HR_Penality_ID = " + e.GetVAHRUAE_HR_Penality_ID() + " AND VAHRUAE_DAYS = 1 ", null);
															//pIDs = X_VAHRUAE_HR_Penality.GetAllIDs("VAHRUAE_HR_Penality", "HOURSMISSING > " + (x.GetHOURSPERDAY() - hourlist[fg] / 60) + "ORDER BY HOURSMISSING ASC", null);
															if (pIDs != null && pIDs.Length != 0)
															{
																for (int gh = 0; gh < Math.Max(0, (x.GetDAYSPERMONTH() - (noOfDays + lIDs.Length + noofhol.Length))); gh++)
																{
																	pd = new X_VAHRUAE_HR_PenalityDetails(GetCtx(), pIDs[0], null);
																	X_VAHRUAE_HR_Employee_Penality emppen = new X_VAHRUAE_HR_Employee_Penality(GetCtx(), 0, null);
																	emppen.SetAD_Client_ID(GetAD_Client_ID());
																	emppen.SetAD_Org_ID(GetAD_Org_ID());
																	emppen.SetC_BPartner_ID(e.GetC_BPartner_ID());
																	emppen.SetVAHRUAE_HR_PenalityDetails_ID(pIDs[0]);
																	compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + "  AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null); empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
																	emppen.SetVAHRUAE_DeductionAmount((empcomp.GetVAHRUAE_FixedValue() / 30) * pd.GetVAHRUAE_DeductionPercentage());
																	mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - emppen.GetVAHRUAE_DeductionAmount());
																	emppen.Save();
																}
															}
															mthsal.SetVAHRUAE_Net_Amount(empcomp.GetVAHRUAE_FixedValue() - (Decimal)calculateTax((double)mthsal.GetVAHRUAE_Gross_Amount()));
															benefits = X_VAHRUAE_PositionBenefit.GetAllIDs("VAHRUAE_PositionBenefit", "ISACTIVE = 'Y' AND C_JOB_ID =  " + e.GetC_Job_ID(), null);
															if (benefits != null && benefits.Length != 0)
																for (int bens = 0; bens < benefits.Length; bens++)
																{
																	empbenefit = new X_VAHRUAE_PositionBenefit(GetCtx(), benefits[bens], null);
																	mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Net_Amount() + empbenefit.GetVAHRUAE_Amount());
																}
															benefits = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EMPLOYECOMPENSATION", "ISACTIVE = 'Y' AND C_BPartner = " + e.GetC_BPartner_ID() + " AND C_PERIOD_ID = " + period + " AND VAHRUAE_COMPENSATIONMASTER_ID != " + compmastID[0], null);
															if (benefits != null && benefits.Length != 0)
																for (int bens = 0; bens < benefits.Length; bens++)
																{
																	empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), benefits[bens], null);
																	mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Net_Amount() + empcomp.GetVAHRUAE_FixedValue());
																}
															mthsal.SetC_BPartner_ID(e.GetC_BPartner_ID()); mthsal.Save();
														}
														MonthStarttemp = MonthStarttemp.AddMonths(1);
														MonthEndtemp = MonthStarttemp.AddMonths(1);
													}
												}
											}
											else if (x.IsVAHRUAE_IsRotationalShift())
											{
												Decimal dayson, daysoff;
												m = new X_VAHRUAE_MthAttendDetail(GetCtx(), 0, null);
												m.SetVAHRUAE_Actual_Days_Present(0);
												m.SetVAHRUAE_EarlyOutCount(0);
												m.SetVAHRUAE_OTHour(0);
												m.SetVAHRUAE_Absent_Days(0);
												m.SetAD_Client_ID(GetAD_Client_ID());
												m.SetAD_Org_ID(GetAD_Org_ID());
												m.SetC_BPartner_ID(IDs[j]);
												m.SetVAHRUAE_HolOtHour(0);
												MonthStart = new DateTime(GivenStart.Value.Year, GivenStart.Value.Month, 20);
												mns = int.Parse(GivenStart.Value.ToString("dd-MM-yy").Substring(3, 2)) - 1;
												mne = int.Parse(GivenEnd.Value.ToString("dd-MM-yy").Substring(3, 2)) - 1;
												dayson = x.GetVAHRUAE_ROTATIONALDAYSONDUTY();
												daysoff = x.GetVAHRUAE_ROTATIONALDAYSOFF();
												latearrtemp = 0;
												leeway = (double)x.GetRotationalLeeway();
												DateTime joinDate = e.GetVAHRUAE_DATE_JOINING().Value;
												currday = joinDate;
												int miss = 0;
												while (currday.Value < GivenStart.Value)
												{
													currday = currday.Value.AddDays((double)(dayson + daysoff));
													miss++;
												}
												currday = new DateTime(currday.Value.Year, currday.Value.Month, currday.Value.Day, 22, 00, 00);
												mthIDs = X_VAHRUAE_HR_EmpAttendanceLog.GetAllIDs("vahruae_hr_empattendancelog", "ISACTIVE = 'Y' AND vahruae_enroll_id = " + (IDs[j]) + " AND VAHRUAE_TimeOfAttendance >= '" + currday.Value.AddHours(-leeway).ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mns]) + "' AND VAHRUAE_TimeOfAttendance < '" + GivenEnd.Value.AddHours(leeway).ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mne]) + "' ORDER BY VAHRUAE_TimeOfAttendance ASC", null); ;
												if (mthIDs != null &&mthIDs.Length!=0)
												{
													e = new X_C_BPartner(GetCtx(), IDs[j], null);
													mthsal = new X_VAHRUAE_Vss_EmpMthSalary(GetCtx(), 0, null);
													mthsal.SetAD_Client_ID(GetAD_Client_ID());
													mthsal.SetAD_Org_ID(GetAD_Org_ID());
													mthsal.SetVAHRUAE_Penality(0);
													compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + " AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
													if (compensations != null && compensations.Length != 0)
													{
														empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
														mthsal.SetVAHRUAE_Gross_Amount(empcomp.GetVAHRUAE_FixedValue() - installmentPayment(e.GetC_BPartner_ID()) - miss * empcomp.GetVAHRUAE_FixedValue() / 30);
														if (joinDate.Date > GivenStart.Value.Date)
														{
															currday = joinDate;
															mthsal.SetVAHRUAE_Gross_Amount((Decimal)((double)mthsal.GetVAHRUAE_Gross_Amount() - ((double)empcomp.GetVAHRUAE_FixedValue() * ((currday.Value.Date - GivenStart.Value.Date).TotalDays) / 30)));
														}
														abs = 0;
														d = new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[0], null);
														if (!d.IsVAHRUAE_FirstAttendance())
														{
															int[] temp = new int[mthIDs.Length - 1];
															for (int rq = 1; rq < mthIDs.Length; rq++)
															{
																temp[rq - 1] = mthIDs[rq];
															}
															mthIDs = temp;
														}
														d = new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[0], null);
														initial = currday.Value;
														for (int y = 0; currday.Value < GivenEnd.Value; y++)
														{
															datetemp = currday.Value;
															for (int u = 0; u < dayson; u++)
															{
																if ((int)(u + (y * dayson))+1 < mthIDs.Length)
																{
																	ishol = checkHoliday(currday);
																	
																			X_VAHRUAE_HR_EmpAttendanceLog next = new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[(int)(u + (y * dayson)) + 1], null);
																				if (ishol && currday.Value.Date == d.GetVAHRUAE_TimeOfAttendance().Value.Date)
																				{
																					while (d.GetVAHRUAE_TimeOfAttendance().Value.Date < initial.AddDays((double)dayson))
																					{
																						if (!next.IsVAHRUAE_FirstAttendance())
																							m.SetVAHRUAE_HolOtHour(m.GetVAHRUAE_HolOtHour() + (Decimal)(next.GetVAHRUAE_TimeOfAttendance().Value - d.GetVAHRUAE_TimeOfAttendance().Value).TotalMinutes);
																					}
																					ishol = false;
																				}
																				else
																				{
																		if ((currday.Value.AddHours(-leeway) > d.GetVAHRUAE_TimeOfAttendance().Value && d.IsVAHRUAE_FirstAttendance()) && (currday.Value.AddHours(leeway) > next.GetVAHRUAE_TimeOfAttendance() && next.IsVAHRUAE_LastAttendance()))
																		{
																			m.SetVAHRUAE_OTHour((Decimal)(m.GetVAHRUAE_OTHour() + (Decimal)(next.GetVAHRUAE_TimeOfAttendance().Value - d.GetVAHRUAE_TimeOfAttendance().Value).TotalMinutes));
																		}
																		else if (d.GetVAHRUAE_TimeOfAttendance().Value.Date > currday.Value.AddDays((double)dayson).AddHours(leeway).Date)
																		{
																			int mnt = int.Parse(currday.Value.ToString("dd-MM-yy").Substring(3, 2)) - 1;
																			lIDs = X_VAHRUAE_HR_LeaveDetail.GetAllIDs("VAHRUAE_HR_LEAVEDETAIL", "ISACTIVE = 'Y' AND C_BPARTNER_ID = " + (IDs[j]) + " AND VAHRUAE_APPROVE = 'Y' AND VAHRUAE_DATE1= '" + currday.Value.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mnt]) + "'", null);
																			if (lIDs == null || lIDs.Length == 0)
																			{
																				int[] tempp = X_VAHRUAE_HR_PenalityDetails.GetAllIDs("VAHRUAE_HR_PENALITYDETAILS", "ISACTIVE = 'Y' AND VAHRUAE_HR_Penality_ID = " + e.GetVAHRUAE_HR_Penality_ID() + "AND VAHRUAE_DAYS = 1", null); //fix
																				if (tempp != null && tempp.Length != 0)
																				{
																					pd = new X_VAHRUAE_HR_PenalityDetails(GetCtx(), tempp[0], null);
																					X_VAHRUAE_HR_Employee_Penality emppen = new X_VAHRUAE_HR_Employee_Penality(GetCtx(), 0, null);
																					emppen.SetAD_Client_ID(GetAD_Client_ID());
																					emppen.SetAD_Org_ID(GetAD_Org_ID());
																					emppen.SetC_BPartner_ID(e.GetC_BPartner_ID());
																					emppen.SetVAHRUAE_HR_PenalityDetails_ID(tempp[0]);
																					compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + " AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
																					empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
																					emppen.SetVAHRUAE_DeductionAmount((empcomp.GetVAHRUAE_FixedValue() / 30) * pd.GetVAHRUAE_DeductionPercentage());
																					mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - emppen.GetVAHRUAE_DeductionAmount());
																					mthsal.SetVAHRUAE_Penality(mthsal.GetVAHRUAE_Penality() + emppen.GetVAHRUAE_DeductionAmount());
																					emppen.Save();
																					abs++;
																				}
																			}
																			else
																			{
																				if (lIDs != null && lIDs.Length != 0)
																				{
																					leavedet = new X_VAHRUAE_HR_LeaveDetail(GetCtx(), lIDs[0], null);
																					Decimal salPer = LeaveDaysDeduction(e.GetC_BPartner_ID(), GivenStart.Value.Year, leavedet.GetVAHRUAE_LeaveType());
																					if (salPer < 100)
																					{
																						compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + "   AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
																					}
																					if (compensations.Length != 0 && compensations != null)
																					{
																						empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
																						mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - ((salPer / 100) * empcomp.GetVAHRUAE_FixedValue() / 30));
																					}
																				}
																			}
																			break;
																		}
																		else if (currday.Value.AddDays(-(double)dayson).AddHours(-leeway) <= d.GetVAHRUAE_TimeOfAttendance())
																		{
																			break;

																		}
																		else 
																		{
																			if ((int)(d.GetVAHRUAE_TimeOfAttendance().Value - currday.Value).TotalMinutes < 0)
																			{
																				latearrtemp = (int)(d.GetVAHRUAE_TimeOfAttendance().Value - currday.Value).TotalMinutes;
																				m.SetVAHRUAE_EarlyOutCount(m.GetVAHRUAE_EarlyOutCount() - latearrtemp);
																			}
																			else
																			{
																				m.SetVAHRUAE_OTHour((int)(d.GetVAHRUAE_TimeOfAttendance().Value - currday.Value).TotalMinutes);
																				latearrtemp = 0;
																			}
																			if ((int)(d.GetVAHRUAE_TimeOfAttendance().Value - currday.Value).TotalMinutes > 0)
																			{
																				m.SetVAHRUAE_OTHour((int)(d.GetVAHRUAE_TimeOfAttendance().Value - currday.Value).TotalMinutes);
																			}
																			if ((int)(u + (y * dayson)) + 2 < mthIDs.Length)
																				d = new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[(int)(u + (y * dayson)) + 2], null);
																			if (d.GetVAHRUAE_TimeOfAttendance().Value.Date < datetemp.AddDays((double)dayson).Date)
																			{
																				int mnt = int.Parse(currday.Value.ToString("dd-MM-yy").Substring(3, 2)) - 1;
																				lIDs = X_VAHRUAE_HR_LeaveDetail.GetAllIDs("VAHRUAE_HR_LEAVEDETAIL", "ISACTIVE = 'Y' AND C_BPARTNER_ID = " + (IDs[j]) + " AND VAHRUAE_APPROVE = 'Y' AND VAHRUAE_DATE1= '" + currday.Value.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mnt]) + "'", null);
																				for (int qw = 0; qw < (datetemp.AddDays((double)dayson).Date - d.GetVAHRUAE_TimeOfAttendance().Value.Date).TotalDays; qw++)
																				{
																					if (lIDs == null || lIDs.Length == 0)
																					{
																						int[] tempp = X_VAHRUAE_HR_PenalityDetails.GetAllIDs("VAHRUAE_HR_PENALITYDETAILS", "ISACTIVE = 'Y' AND VAHRUAE_HR_Penality_ID = " + e.GetVAHRUAE_HR_Penality_ID() + "AND VAHRUAE_LINE > " + (-latearrtemp / 60) + " ORDER BY VAHRUAE_LINE ASC", null);
																						if (tempp != null && tempp.Length != 0)
																						{
																							pd = new X_VAHRUAE_HR_PenalityDetails(GetCtx(), tempp[0], null);
																							X_VAHRUAE_HR_Employee_Penality emppen = new X_VAHRUAE_HR_Employee_Penality(GetCtx(), 0, null);
																							emppen.SetAD_Client_ID(GetAD_Client_ID());
																							emppen.SetAD_Org_ID(GetAD_Org_ID());
																							emppen.SetC_BPartner_ID(e.GetC_BPartner_ID());
																							emppen.SetVAHRUAE_HR_PenalityDetails_ID(tempp[0]);
																							compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + " AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
																							empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
																							emppen.SetVAHRUAE_DeductionAmount((empcomp.GetVAHRUAE_FixedValue() / 30) * pd.GetVAHRUAE_DeductionPercentage());
																							mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - emppen.GetVAHRUAE_DeductionAmount());
																							mthsal.SetVAHRUAE_Penality(mthsal.GetVAHRUAE_Penality() + emppen.GetVAHRUAE_DeductionAmount());
																							emppen.Save();
																							m.SetVAHRUAE_Absent_Days(m.GetVAHRUAE_Absent_Days() + 1);
																							abs++;
																						}
																					}
																					else
																					{
																						if (lIDs != null || lIDs.Length != 0)
																						{
																							leavedet = new X_VAHRUAE_HR_LeaveDetail(GetCtx(), lIDs[0], null);
																							Decimal salPer = LeaveDaysDeduction(e.GetC_BPartner_ID(), GivenStart.Value.Year, leavedet.GetVAHRUAE_LeaveType());
																							int[] pendet = X_VAHRUAE_HR_PenalityDetails.GetAllIDs("VAHRUAE_HR_PENALITYDETAILS", "ISACTIVE = 'Y' AND VAHRUAE_HR_Penality_ID = " + e.GetVAHRUAE_HR_Penality_ID() + " AND VAHRUAE_DAYS = 1", null);
																							if (pendet != null && pendet.Length != 0 && salPer < 100)
																							{
																								pd = new X_VAHRUAE_HR_PenalityDetails(GetCtx(), pendet[0], null);
																								X_VAHRUAE_HR_Employee_Penality emppen = new X_VAHRUAE_HR_Employee_Penality(GetCtx(), 0, null);
																								emppen.SetAD_Client_ID(GetAD_Client_ID());
																								emppen.SetAD_Org_ID(GetAD_Org_ID());
																								emppen.SetC_BPartner_ID(e.GetC_BPartner_ID());
																								emppen.SetVAHRUAE_HR_PenalityDetails_ID(pendet[0]);
																								compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + "   AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
																								empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
																								emppen.SetVAHRUAE_DeductionAmount((empcomp.GetVAHRUAE_FixedValue() / 30) * ((salPer)) / 100);
																								mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - emppen.GetVAHRUAE_DeductionAmount());
																								mthsal.SetVAHRUAE_Penality(mthsal.GetVAHRUAE_Penality() + emppen.GetVAHRUAE_DeductionAmount());
																								emppen.Save();
																								abs++;
																							}
																						}
																					}
																				}
																			}
																		}
																		
																				}
																			}
																		}

															if (e.GetVAHRUAE_DateRelieved() != null)
															{
																if (currday.Value.Date >= e.GetVAHRUAE_DateRelieved().Value.Date)
																{
																	mthsal.SetVAHRUAE_Gross_Amount((Decimal)((double)mthsal.GetVAHRUAE_Gross_Amount() - ((double)empcomp.GetVAHRUAE_FixedValue() * ((GivenEnd.Value.Date - currday.Value.Date).TotalDays) / 30)));
																	m.SetVAHRUAE_Absent_Days(abs);
																	m.SetC_Period_ID(period);
																	m.Save();
																	mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Gross_Amount() - (Decimal)calculateTax((double)mthsal.GetVAHRUAE_Gross_Amount()));
																	benefits = X_VAHRUAE_PositionBenefit.GetAllIDs("VAHRUAE_PositionBenefit", "ISACTIVE = 'Y' AND C_JOB_ID =  " + e.GetC_Job_ID(), null);
																	if (benefits != null && benefits.Length != 0)
																		for (int bens = 0; bens < benefits.Length; bens++)
																		{
																			empbenefit = new X_VAHRUAE_PositionBenefit(GetCtx(), benefits[bens], null);
																			mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Net_Amount() + empbenefit.GetVAHRUAE_Amount());
																		}
																	benefits = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EMPLOYECOMPENSATION", "ISACTIVE = 'Y' AND C_BPartner = " + e.GetC_BPartner_ID() + " AND C_PERIOD_ID = " + period + " AND VAHRUAE_COMPENSATIONMASTER_ID != " + compmastID[0], null);
																	if (benefits != null && benefits.Length != 0)
																		for (int bens = 0; bens < benefits.Length; bens++)
																		{
																			empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), benefits[bens], null);
																			mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Net_Amount() + empcomp.GetVAHRUAE_FixedValue());
																		}
																	mthsal.SetC_BPartner_ID(e.GetC_BPartner_ID()); mthsal.Save();
																	break;

																}
															
															}
														m.Save();
															currday = initial.Date.AddDays((double)(dayson + daysoff));
															initial = initial.Date.AddDays((double)(dayson + daysoff)); 
														if (e.GetVAHRUAE_DateRelieved() != null)
														{
															if (currday.Value.Date >= e.GetVAHRUAE_DateRelieved().Value.Date)
															{
																mthsal.SetVAHRUAE_Gross_Amount((Decimal)((double)mthsal.GetVAHRUAE_Gross_Amount() - ((double)empcomp.GetVAHRUAE_FixedValue() * ((GivenEnd.Value.Date - currday.Value.Date).TotalDays) / 30)));
																m.SetVAHRUAE_Absent_Days(abs);
																m.SetC_Period_ID(period);
																m.Save();
																mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Gross_Amount() - (Decimal)calculateTax((double)mthsal.GetVAHRUAE_Gross_Amount()));
																benefits = X_VAHRUAE_PositionBenefit.GetAllIDs("VAHRUAE_PositionBenefit", "ISACTIVE = 'Y' AND C_JOB_ID =  " + e.GetC_Job_ID(), null);
																if (benefits != null && benefits.Length != 0)
																	for (int bens = 0; bens < benefits.Length; bens++)
																	{
																		empbenefit = new X_VAHRUAE_PositionBenefit(GetCtx(), benefits[bens], null);
																		mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Net_Amount() + empbenefit.GetVAHRUAE_Amount());
																	}
																benefits = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EMPLOYECOMPENSATION", "ISACTIVE = 'Y' AND C_BPartner = " + e.GetC_BPartner_ID() + " AND C_PERIOD_ID = " + period + " AND VAHRUAE_COMPENSATIONMASTER_ID != " + compmastID[0], null);
																if (benefits != null && benefits.Length != 0)
																	for (int bens = 0; bens < benefits.Length; bens++)
																	{
																		empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), benefits[bens], null);
																		mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Net_Amount() + empcomp.GetVAHRUAE_FixedValue());
																	}
																mthsal.SetC_BPartner_ID(e.GetC_BPartner_ID()); mthsal.Save();
																break;
															}
														}
														
														}
													}
													else
													{
														joinDate = e.GetVAHRUAE_DATE_JOINING().Value;
														currday = joinDate;
														int mnt = int.Parse(GivenStart.Value.ToString("dd-MM-yy").Substring(3, 2)) - 1;
														while (currday.Value < GivenStart.Value)
														{
															currday = currday.Value.AddDays((double)(dayson + daysoff));
														}
														mthsal = new X_VAHRUAE_Vss_EmpMthSalary(GetCtx(), 0, null);
														mthsal.SetAD_Client_ID(GetAD_Client_ID());
														mthsal.SetAD_Org_ID(GetAD_Org_ID());
														mthsal.SetVAHRUAE_Penality(0);
														compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + "  AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
														if (compensations != null && compensations.Length != 0)
														{
															empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
															mthsal.SetVAHRUAE_Gross_Amount(empcomp.GetVAHRUAE_FixedValue() - installmentPayment(e.GetC_BPartner_ID()));
															for (int qe = 0; currday.Value < GivenEnd.Value; qe++)
															{
																for (int qr = 0; qr < dayson; qr++)
																{
																	lIDs = X_VAHRUAE_HR_LeaveDetail.GetAllIDs("VAHRUAE_HR_LEAVEDETAIL", "ISACTIVE = 'Y' AND C_BPARTNER_ID = " + (IDs[j]) + "AND VAHRUAE_APPROVE = 'Y' AND VAHRUAE_DATE1= '" + currday.Value.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mnt]), null);
																	if (lIDs == null || lIDs.Length==0)
																	{
																		int[] tempp = X_VAHRUAE_HR_PenalityDetails.GetAllIDs("VAHRUAE_HR_PENALITYDETAILS", "ISACTIVE = 'Y' AND VAHRUAE_HR_Penality_ID = " + e.GetVAHRUAE_HR_Penality_ID() + "AND VAHRUAE_DAYS = 1", null);
																		if (tempp != null && tempp.Length != 0)
																		{
																			pd = new X_VAHRUAE_HR_PenalityDetails(GetCtx(), tempp[0], null);
																			X_VAHRUAE_HR_Employee_Penality emppen = new X_VAHRUAE_HR_Employee_Penality(GetCtx(), 0, null);
																			emppen.SetAD_Client_ID(GetAD_Client_ID());
																			emppen.SetAD_Org_ID(GetAD_Org_ID());
																			emppen.SetC_BPartner_ID(e.GetC_BPartner_ID());
																			emppen.SetVAHRUAE_HR_PenalityDetails_ID(tempp[0]);
																			compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + " AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
																			empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
																			emppen.SetVAHRUAE_DeductionAmount((empcomp.GetVAHRUAE_FixedValue() / 30) * pd.GetVAHRUAE_DeductionPercentage());
																			mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - emppen.GetVAHRUAE_DeductionAmount());
																			mthsal.SetVAHRUAE_Penality(mthsal.GetVAHRUAE_Penality() + emppen.GetVAHRUAE_DeductionAmount());
																			emppen.Save();
																			abs++;
																		}
																	}
																	else
																	{
																		leavedet = new X_VAHRUAE_HR_LeaveDetail(GetCtx(), lIDs[0], null);
																		Decimal salPer = LeaveDaysDeduction(e.GetC_BPartner_ID(), GivenStart.Value.Year, leavedet.GetVAHRUAE_LeaveType());
																		int[] pendet = X_VAHRUAE_HR_PenalityDetails.GetAllIDs("VAHRUAE_HR_PENALITYDETAILS", "ISACTIVE = 'Y' AND VAHRUAE_HR_Penality_ID = " + e.GetVAHRUAE_HR_Penality_ID() + " AND VAHRUAE_DAYS = 1", null);
																		if (pendet != null && pendet.Length != 0 && salPer < 100)
																		{
																			pd = new X_VAHRUAE_HR_PenalityDetails(GetCtx(), pendet[0], null);
																			X_VAHRUAE_HR_Employee_Penality emppen = new X_VAHRUAE_HR_Employee_Penality(GetCtx(), 0, null);
																			emppen.SetAD_Client_ID(GetAD_Client_ID());
																			emppen.SetAD_Org_ID(GetAD_Org_ID());
																			emppen.SetC_BPartner_ID(e.GetC_BPartner_ID());
																			emppen.SetVAHRUAE_HR_PenalityDetails_ID(pendet[0]);
																			compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + "   AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
																			empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
																			emppen.SetVAHRUAE_DeductionAmount((empcomp.GetVAHRUAE_FixedValue() / 30) * ((salPer)) / 100);
																			mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - emppen.GetVAHRUAE_DeductionAmount());
																			mthsal.SetVAHRUAE_Penality(mthsal.GetVAHRUAE_Penality() + emppen.GetVAHRUAE_DeductionAmount());
																			emppen.Save();
																			abs++;
																		}
																	}
																	currday = currday.Value.AddDays(1);
																	if (e.GetVAHRUAE_DateRelieved() != null)
																	{
																		if (currday.Value.Date >= e.GetVAHRUAE_DateRelieved())
																		{
																			mthsal.SetVAHRUAE_Gross_Amount((Decimal)((double)mthsal.GetVAHRUAE_Gross_Amount() - ((double)empcomp.GetVAHRUAE_FixedValue() * ((GivenEnd.Value.Date - currday.Value.Date).TotalDays) / 30)));
																			m.SetVAHRUAE_Absent_Days(abs);
																			m.SetC_Period_ID(period);
																			m.Save();
																			mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Gross_Amount() - (Decimal)calculateTax((double)mthsal.GetVAHRUAE_Gross_Amount()));
																			benefits = X_VAHRUAE_PositionBenefit.GetAllIDs("VAHRUAE_PositionBenefit", "ISACTIVE = 'Y' AND C_JOB_ID =  " + e.GetC_Job_ID(), null);
																			if (benefits != null && benefits.Length != 0)
																				for (int bens = 0; bens < benefits.Length; bens++)
																				{
																					empbenefit = new X_VAHRUAE_PositionBenefit(GetCtx(), benefits[bens], null);
																					mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Net_Amount() + empbenefit.GetVAHRUAE_Amount());
																				}
																			benefits = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EMPLOYECOMPENSATION", "ISACTIVE = 'Y' AND C_BPartner = " + e.GetC_BPartner_ID() + " AND C_PERIOD_ID = " + period + " AND VAHRUAE_COMPENSATIONMASTER_ID != " + compmastID[0], null);
																			if (benefits != null && benefits.Length != 0)
																				for (int bens = 0; bens < benefits.Length; bens++)
																				{
																					empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), benefits[bens], null);
																					mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Net_Amount() + empcomp.GetVAHRUAE_FixedValue());
																				}
																			mthsal.SetC_BPartner_ID(e.GetC_BPartner_ID()); mthsal.Save();
																			break;
																		}
																	}
																}
																currday = currday.Value.AddDays((int)(daysoff - 1));
															}
															m.Save();
															mthsal.SetC_BPartner_ID(e.GetC_BPartner_ID()); mthsal.Save();
														}
													}
												}
											}
											else
											{
												MonthStart = new DateTime(GivenStart.Value.Year, GivenStart.Value.Month, 20);
												mns = int.Parse(GivenStart.Value.ToString("dd-MM-yy").Substring(3, 2)) - 1;
												mne = int.Parse(GivenEnd.Value.ToString("dd-MM-yy").Substring(3, 2)) - 1;
												// throw new Exception(( "C_BPartner_ID = " + (IDs[j] - 1) + " AND VAHRUAE_TimeOfAttendance >= '" + GivenStart.Value.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mns]) + "' AND VAHRUAE_TimeOfAttendance < '" + GivenEnd.Value.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mne]) + "' ORDER BY VAHRYUAE_ACTUALINTIME"));
												mthIDs = X_VAHRUAE_HR_EmpAttendanceLog.GetAllIDs("vahruae_hr_empattendancelog", "ISACTIVE = 'Y' AND vahruae_enroll_id = " + (IDs[j]) + " AND VAHRUAE_TimeOfAttendance >= '" + GivenStart.Value.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mns]) + "' AND VAHRUAE_TimeOfAttendance <= '" + GivenEnd.Value.AddDays(1).ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mne]) + "' AND VAHRUAE_ATTMARKED = 'N' ORDER BY VAHRUAE_TimeOfAttendance ASC", null);
												int count = 0;
												if (mthIDs != null && mthIDs.Length != 0)
												{
													DateTime MonthStarttemp = GivenStart.Value;
													d = new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[0], null);
													if (!d.IsVAHRUAE_FirstAttendance())
													{
														int[] temp = new int[mthIDs.Length - 1];
														for (int rq = 1; rq < mthIDs.Length; rq++)
														{
															temp[rq - 1] = mthIDs[rq];
														}
														mthIDs = temp;
													}
													for (int h = 0; h < ((GivenEnd.Value.Year - GivenStart.Value.Year) * 12) + GivenEnd.Value.Month - GivenStart.Value.Month; h++)
													{
														eatt.Clear();
														currday = MonthStarttemp;
														DateTime MonthEndtemp = MonthStarttemp.AddMonths(1);
														mthsal = new X_VAHRUAE_Vss_EmpMthSalary(GetCtx(), 0, null);
														m = new X_VAHRUAE_MthAttendDetail(GetCtx(), 0, null);
														mthsal.SetAD_Client_ID(GetAD_Client_ID());
														mthsal.SetAD_Org_ID(GetAD_Org_ID());
														mthsal.SetVAHRUAE_Penality(0);
														compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + " AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
														empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
														mthsal.SetVAHRUAE_Gross_Amount(empcomp.GetVAHRUAE_FixedValue() - installmentPayment(e.GetC_BPartner_ID()));
														m.SetVAHRUAE_Actual_Days_Present(0);
														m.SetVAHRUAE_EarlyOutCount(0);
														m.SetVAHRUAE_OTHour(0);
														m.SetVAHRUAE_Absent_Days(0);
														m.SetVAHRUAE_HolOtHour(0);
														abs = 0;
														m.SetAD_Client_ID(GetAD_Client_ID());
														m.SetAD_Org_ID(GetAD_Org_ID());
														m.SetC_BPartner_ID(IDs[j]);
														eatt.Add(new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[0], null));
														if (e.GetVAHRUAE_DATE_JOINING().Value.Date >= GivenStart.Value.Date)
														{
															currday = e.GetVAHRUAE_DATE_JOINING().Value;
															mthsal.SetVAHRUAE_Gross_Amount((Decimal)((double)mthsal.GetVAHRUAE_Gross_Amount() - ((double)empcomp.GetVAHRUAE_FixedValue() * ((currday.Value.Date - GivenStart.Value.Date).TotalDays) / 30)));
															m.SetVAHRUAE_Absent_Days(abs);
															m.SetC_Period_ID(period);
														}
														//if (!eatt[0].IsVAHRUAE_FirstAttendance())
														//	{
														//		int[] temp = new int[mthIDs.Length - 1];
														//		for (int rq = 1; rq < mthIDs.Length; rq++)
														//		{
														//			temp[rq - 1] = mthIDs[rq];
														//		}
														//		mthIDs = temp;
														//	eatt.Add((new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[0], null)));
														//	}
														//attcounter = 1;
														//while (currday.Value.Date < MonthStart.AddMonths(1).Date && currday.Value < e.GetVAHRUAE_DATE_JOINING().Value.Date)
														//{
														//	if (mthIDs.Length < attcounter)
														//	{
														//		eatt.Add((new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[attcounter], null)));
																
														//			DateTime dayend, nextday;
														//			dayend = DateTime.MinValue;
														//			nextday = currday.Value.AddDays(1);
														//			double shiftdiff = double.MinValue;
														//			double shiftdifftemp=0;
														//			if (x.IsSHIFT1ACTIVE())
														//			{
														//				shiftdifftemp = (x.GetVAHRUAE_InTime().Value.TimeOfDay - eatt[0].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalSeconds;
														//				if (shiftdifftemp < 0)
														//				{
														//					shiftdifftemp = (eatt[0].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - x.GetVAHRUAE_InTime().Value.TimeOfDay).TotalSeconds;
														//				}
														//				if (shiftdifftemp == 0)
														//				{
														//					shiftdifftemp = double.MaxValue;
														//				}
														//				if (shiftdifftemp > shiftdiff)
														//				{
														//					shiftdiff = shiftdifftemp;
														//					dayend = new DateTime(nextday.Year, nextday.Month, nextday.Day, x.GetVAHRUAE_InTime().Value.Hour, x.GetVAHRUAE_InTime().Value.Minute, x.GetVAHRUAE_InTime().Value.Second);
														//				}
														//			}
														//			if (x.IsSHIFT2ACTIVE())
														//			{
														//				shiftdifftemp = (x.GetVAHRUAE_InTime2().Value.TimeOfDay - eatt[0].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalSeconds;
														//				if (shiftdifftemp < 0)
														//				{
														//					shiftdifftemp = (eatt[0].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - x.GetVAHRUAE_InTime2().Value.TimeOfDay).TotalSeconds;
														//				}
														//				if (shiftdifftemp == 0)
														//				{
														//					shiftdifftemp = double.MaxValue;
														//				}
														//				if (shiftdifftemp > shiftdiff)
														//				{
														//					shiftdiff = shiftdifftemp;
														//					dayend = new DateTime(nextday.Year, nextday.Month, nextday.Day, x.GetVAHRUAE_InTime2().Value.Hour, x.GetVAHRUAE_InTime2().Value.Minute, x.GetVAHRUAE_InTime2().Value.Second);
														//				}
														//			}
														//			if (x.IsSHIFT3ACTIVE())
														//			{
														//				shiftdifftemp = (x.GetVAHRUAE_InTime3().Value.TimeOfDay - eatt[0].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalSeconds;
														//				if (shiftdifftemp < 0)
														//				{
														//					shiftdifftemp = (eatt[0].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - x.GetVAHRUAE_InTime3().Value.TimeOfDay).TotalSeconds;
														//				}
														//				if (shiftdifftemp == 0)
														//				{
														//					shiftdifftemp = double.MaxValue;
														//				}
														//				if (shiftdifftemp > shiftdiff)
														//				{
														//					shiftdiff = shiftdifftemp;
														//					dayend = new DateTime(nextday.Year, nextday.Month, nextday.Day, x.GetVAHRUAE_InTime3().Value.Hour, x.GetVAHRUAE_InTime3().Value.Minute, x.GetVAHRUAE_InTime3().Value.Second);
														//				}
														//			}
														//			if (dayend != DateTime.MinValue)
														//			{
														//				X_VAHRUAE_HR_EmpAttendanceLog temp;
														//				do {
														//				if (attcounter >= mthIDs.Length)
														//					break;
														//					temp = new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[attcounter], null);
														//					if (temp.GetVAHRUAE_TimeOfAttendance().Value < dayend)
														//					{
														//						attcounter++;
														//						eatt.Add(temp);
														//					}
														//				} while (temp.GetVAHRUAE_TimeOfAttendance().Value < dayend);
														//			}
														//		if (eatt[eatt.Count - 1].IsVAHRUAE_FirstAttendance())
														//		{
														//			eatt.RemoveAt(eatt.Count - 1);
														//			attcounter--;
														//		}
														//		DateTime shiftstarttemp, shiftendtemp;
														//		bool missingpunch = false;
														//		double shift1hours, shift2hours, shift3hours, totalhours;
														//		shift1hours = shift2hours = shift3hours = totalhours = 0;
														//			for (int zj = 1; zj < eatt.Count; zj++)
														//			{

														//				totalhours += (eatt[zj].GetVAHRUAE_TimeOfAttendance().Value - eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value).TotalMinutes;
														//			if (eatt[zj].IsVAHRUAE_FirstAttendance() || !eatt[zj - 1].IsVAHRUAE_FirstAttendance())
														//			{
														//				missingpunch = true;
														//				break;
														//			}
														//			else
														//			{
														//				if (x.IsSHIFT1ACTIVE())
														//				{
														//					shiftstarttemp = new DateTime(nextday.Year, nextday.Month, nextday.Day, x.GetVAHRUAE_InTime().Value.Hour, x.GetVAHRUAE_InTime().Value.Minute, x.GetVAHRUAE_InTime().Value.Second);
														//					shiftendtemp = new DateTime(nextday.Year, nextday.Month, nextday.Day, x.GetVAHRUAE_OutTime().Value.Hour, x.GetVAHRUAE_OutTime().Value.Minute, x.GetVAHRUAE_OutTime().Value.Second);
														//					if (shiftstarttemp > dayend)
														//					{
														//						shiftstarttemp.AddDays(-1);
														//					}
														//					if (shiftendtemp > dayend)
														//					{
														//						shiftendtemp.AddDays(-1);
														//					}
														//					if (eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value <= shiftstarttemp && eatt[zj].GetVAHRUAE_TimeOfAttendance().Value <= shiftendtemp)
														//					{
														//						shift1hours += (eatt[zj].GetVAHRUAE_TimeOfAttendance().Value - shiftstarttemp).TotalMinutes;
														//					}
														//					if (eatt[zj].GetVAHRUAE_TimeOfAttendance().Value >= shiftendtemp && eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value <= shiftendtemp && eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value > shiftstarttemp)
														//					{
														//						shift1hours += (shiftendtemp - eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value).TotalMinutes;
														//					}
														//					if (eatt[zj].GetVAHRUAE_TimeOfAttendance() <= shiftendtemp && eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value >= shiftstarttemp)
														//					{
														//						shift1hours += (eatt[zj].GetVAHRUAE_TimeOfAttendance().Value - eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value).TotalMinutes;
														//					}
														//				}
														//				if (x.IsSHIFT2ACTIVE())
														//				{
														//					shiftstarttemp = new DateTime(nextday.Year, nextday.Month, nextday.Day, x.GetVAHRUAE_InTime2().Value.Hour, x.GetVAHRUAE_InTime2().Value.Minute, x.GetVAHRUAE_InTime2().Value.Second);
														//					shiftendtemp = new DateTime(nextday.Year, nextday.Month, nextday.Day, x.GetVAHRUAE_OutTime2().Value.Hour, x.GetVAHRUAE_OutTime2().Value.Minute, x.GetVAHRUAE_OutTime2().Value.Second);
														//					if (shiftstarttemp > dayend)
														//					{
														//						shiftstarttemp.AddDays(-1);
														//					}
														//					if (shiftendtemp > dayend)
														//					{
														//						shiftendtemp.AddDays(-1);
														//					}
														//					if (eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value <= shiftstarttemp && eatt[zj].GetVAHRUAE_TimeOfAttendance().Value <= shiftendtemp)
														//					{
														//						shift2hours += (eatt[zj].GetVAHRUAE_TimeOfAttendance().Value - shiftstarttemp).TotalMinutes;
														//					}
														//					if (eatt[zj].GetVAHRUAE_TimeOfAttendance().Value >= shiftendtemp && eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value <= shiftendtemp && eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value > shiftstarttemp)
														//					{
														//						shift2hours += (shiftendtemp - eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value).TotalMinutes;
														//					}
														//					if (eatt[zj].GetVAHRUAE_TimeOfAttendance() <= shiftendtemp && eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value >= shiftstarttemp)
														//					{
														//						shift2hours += (eatt[zj].GetVAHRUAE_TimeOfAttendance().Value - eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value).TotalMinutes;
														//					}
														//				}
														//				if (x.IsSHIFT3ACTIVE())
														//				{
														//					shiftstarttemp = new DateTime(nextday.Year, nextday.Month, nextday.Day, x.GetVAHRUAE_InTime3().Value.Hour, x.GetVAHRUAE_InTime3().Value.Minute, x.GetVAHRUAE_InTime3().Value.Second);
														//					shiftendtemp = new DateTime(nextday.Year, nextday.Month, nextday.Day, x.GetVAHRUAE_OutTime3().Value.Hour, x.GetVAHRUAE_OutTime3().Value.Minute, x.GetVAHRUAE_OutTime3().Value.Second);
														//					if (shiftstarttemp > dayend)
														//					{
														//						shiftstarttemp.AddDays(-1);
														//					}
														//					if (shiftendtemp > dayend)
														//					{
														//						shiftendtemp.AddDays(-1);
														//					}
														//					if (eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value <= shiftstarttemp && eatt[zj].GetVAHRUAE_TimeOfAttendance().Value <= shiftendtemp)
														//					{
														//						shift3hours += (eatt[zj].GetVAHRUAE_TimeOfAttendance().Value - shiftstarttemp).TotalMinutes;
														//					}
														//					if (eatt[zj].GetVAHRUAE_TimeOfAttendance().Value >= shiftendtemp && eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value <= shiftendtemp && eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value > shiftstarttemp)
														//					{
														//						shift3hours += (shiftendtemp - eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value).TotalMinutes;
														//					}
														//					if (eatt[zj].GetVAHRUAE_TimeOfAttendance() <= shiftendtemp && eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value >= shiftstarttemp)
														//					{
														//						shift3hours += (eatt[zj].GetVAHRUAE_TimeOfAttendance().Value - eatt[zj - 1].GetVAHRUAE_TimeOfAttendance().Value).TotalMinutes;
														//					}
														//				}
														//			}
														//			}
														//		if (missingpunch)//herex
														//		{
														//			int[] tempp = X_VAHRUAE_HR_PenalityDetails.GetAllIDs("VAHRUAE_HR_PENALITYDETAILS", "ISACTIVE = 'Y' AND VAHRUAE_HR_Penality_ID = " + e.GetVAHRUAE_HR_Penality_ID() + " AND VAHRUAE_Missing_Punch= 'Y'", null);
														//			if (tempp != null && tempp.Length != 0 && (lIDs == null || lIDs.Length == 0))
														//			{
														//				pd = new X_VAHRUAE_HR_PenalityDetails(GetCtx(), tempp[0], null);
														//				X_VAHRUAE_HR_Employee_Penality emppen = new X_VAHRUAE_HR_Employee_Penality(GetCtx(), 0, null);
														//				emppen.SetAD_Client_ID(GetAD_Client_ID());
														//				emppen.SetAD_Org_ID(GetAD_Org_ID());
														//				emppen.SetC_BPartner_ID(e.GetC_BPartner_ID());
														//				emppen.SetVAHRUAE_HR_PenalityDetails_ID(tempp[0]);
														//				compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + "  AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
														//				empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
														//				emppen.SetVAHRUAE_DeductionAmount((empcomp.GetVAHRUAE_FixedValue() / 30) * pd.GetVAHRUAE_DeductionPercentage());
														//				mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - emppen.GetVAHRUAE_DeductionAmount());
														//				mthsal.SetVAHRUAE_Penality(mthsal.GetVAHRUAE_Penality() + emppen.GetVAHRUAE_DeductionAmount());
														//				emppen.Save();
														//			}
														//			eatt.Clear();
														//		}
														//		currday = currday.Value.AddDays(1);
														//		}
														//	}
														
														if (!(x.IsFRIDAYOFF() && currday.Value.DayOfWeek == DayOfWeek.Friday) && !(x.IsSATURDAYOFF() && currday.Value.DayOfWeek == DayOfWeek.Saturday) && !(x.IsSUNDAYOFF() && currday.Value.DayOfWeek == DayOfWeek.Sunday) && !(x.IsMONDAYOFF() && currday.Value.DayOfWeek == DayOfWeek.Monday) && !(x.IsTHURSDAYOFF() && currday.Value.DayOfWeek == DayOfWeek.Tuesday) && !(x.IsWEDNESDAYOFF() && currday.Value.DayOfWeek == DayOfWeek.Wednesday) && !(x.IsTHURSDAYOFF() && currday.Value.DayOfWeek == DayOfWeek.Thursday))
														{
															int mnt = int.Parse(currday.Value.ToString("dd-MM-yy").Substring(3, 2)) - 1;
															lIDs = X_VAHRUAE_HR_LeaveDetail.GetAllIDs("VAHRUAE_HR_LEAVEDETAIL", "ISACTIVE = 'Y' AND C_BPARTNER_ID = " + (IDs[j]) + "AND VAHRUAE_APPROVE = 'Y' AND VAHRUAE_DATE1= '" + currday.Value.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mnt]), null);
															if (totaltimes == (mthIDs.Length - 1) && currday.Value.Date > (new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[totaltimes - 1], null).GetVAHRUAE_TimeOfAttendance().Value.Date) && lIDs == null)
															{
																int[] tempp = X_VAHRUAE_HR_PenalityDetails.GetAllIDs("VAHRUAE_HR_PENALITYDETAILS", "ISACTIVE = 'Y' AND VAHRUAE_HR_Penality_ID = " + e.GetVAHRUAE_HR_Penality_ID() + " AND VAHRUAE_DAYS = 1", null);
																if (tempp != null && tempp.Length != 0)
																{
																	pd = new X_VAHRUAE_HR_PenalityDetails(GetCtx(), tempp[0], null);
																	X_VAHRUAE_HR_Employee_Penality emppen = new X_VAHRUAE_HR_Employee_Penality(GetCtx(), 0, null);
																	emppen.SetAD_Client_ID(GetAD_Client_ID());
																	emppen.SetAD_Org_ID(GetAD_Org_ID());
																	emppen.SetC_BPartner_ID(e.GetC_BPartner_ID());
																	emppen.SetVAHRUAE_HR_PenalityDetails_ID(tempp[0]);
																	emppen.SetVAHRUAE_DeductionAmount((empcomp.GetVAHRUAE_FixedValue() / 30) * pd.GetVAHRUAE_DeductionPercentage());
																	mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - emppen.GetVAHRUAE_DeductionAmount());
																	mthsal.SetVAHRUAE_Penality(mthsal.GetVAHRUAE_Penality() + emppen.GetVAHRUAE_DeductionAmount());
																	emppen.Save();
																	abs++;
																}
															}
															for (; totaltimes < mthIDs.Length;)
															{
																if (currday.Value.Date < MonthEndtemp.Date)
																{
																	times = 0;
																	leaveloop = false;
																	while (!leaveloop)
																	{
																		if (totaltimes + times + 1 < mthIDs.Length)
																		{
																			d = new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[totaltimes + times + 1], null);
																		}
																		else
																		{
																			leaveloop = true;
																			break;
																		}
																		if (totaltimes + times + 1 < mthIDs.Length)
																		{
																			if (eatt.Count != 0)
																			{
																				if (d.GetVAHRUAE_TimeOfAttendance().Value.Date > eatt[0].GetVAHRUAE_TimeOfAttendance().Value.Date && d.IsVAHRUAE_FirstAttendance())
																				{
																					leaveloop = true;
																					break;
																				}
																				if (eatt[eatt.Count - 1].IsVAHRUAE_FirstAttendance() != d.IsVAHRUAE_FirstAttendance())
																					eatt.Add(d);


																			}
																			else
																			{
																				eatt.Add(d);
																			}
																			times++;
																		}
																	}
																	ishol = checkHoliday(currday);

																	if (eatt.Count > 0)
																	{
																		if (currday.Value.Date < eatt[0].GetVAHRUAE_TimeOfAttendance().Value.Date)
																		{
																			if (!ishol)
																			{

																				mnt = int.Parse(currday.Value.ToString("dd-MM-yy").Substring(3, 2)) - 1;
																				lIDs = X_VAHRUAE_HR_LeaveDetail.GetAllIDs("VAHRUAE_HR_LEAVEDETAIL", "ISACTIVE = 'Y' AND C_BPARTNER_ID = " + (IDs[j]) + " AND VAHRUAE_DATE1= '" + currday.Value.ToString("dd-MM-yy").Remove(3, 2).Insert(3, monthNames[mnt]) + "'", null);
																				if (lIDs != null && lIDs.Length != 0)
																				{
																					leavedet = new X_VAHRUAE_HR_LeaveDetail(GetCtx(), lIDs[0], null);
																					Decimal salPer = LeaveDaysDeduction(e.GetC_BPartner_ID(), GivenStart.Value.Year, leavedet.GetVAHRUAE_LeaveType());
																					int[] pendet = X_VAHRUAE_HR_PenalityDetails.GetAllIDs("VAHRUAE_HR_PENALITYDETAILS", "ISACTIVE = 'Y' AND VAHRUAE_HR_Penality_ID = " + e.GetVAHRUAE_HR_Penality_ID() + " AND VAHRUAE_DAYS = 1", null);
																					if (pendet != null && pendet.Length != 0 && salPer < 100)
																					{
																						pd = new X_VAHRUAE_HR_PenalityDetails(GetCtx(), pendet[0], null);
																						X_VAHRUAE_HR_Employee_Penality emppen = new X_VAHRUAE_HR_Employee_Penality(GetCtx(), 0, null);
																						emppen.SetAD_Client_ID(GetAD_Client_ID());
																						emppen.SetAD_Org_ID(GetAD_Org_ID());
																						emppen.SetC_BPartner_ID(e.GetC_BPartner_ID());
																						emppen.SetVAHRUAE_HR_PenalityDetails_ID(pendet[0]);
																						compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + "   AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
																						empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
																						emppen.SetVAHRUAE_DeductionAmount((empcomp.GetVAHRUAE_FixedValue() / 30) * ((salPer)) / 100);
																						mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - emppen.GetVAHRUAE_DeductionAmount());
																						mthsal.SetVAHRUAE_Penality(mthsal.GetVAHRUAE_Penality() + emppen.GetVAHRUAE_DeductionAmount());
																						emppen.Save();
																						abs++;
																					}
																				}
																				else
																				{
																					int[] tempp = X_VAHRUAE_HR_PenalityDetails.GetAllIDs("VAHRUAE_HR_PENALITYDETAILS", "ISACTIVE = 'Y' AND VAHRUAE_HR_Penality_ID = " + e.GetVAHRUAE_HR_Penality_ID() + " AND VAHRUAE_DAYS = 1", null);
																					if (tempp != null && tempp.Length != 0)
																					{
																						pd = new X_VAHRUAE_HR_PenalityDetails(GetCtx(), tempp[0], null);
																						X_VAHRUAE_HR_Employee_Penality emppen = new X_VAHRUAE_HR_Employee_Penality(GetCtx(), 0, null);
																						emppen.SetAD_Client_ID(GetAD_Client_ID());
																						emppen.SetAD_Org_ID(GetAD_Org_ID());
																						emppen.SetC_BPartner_ID(e.GetC_BPartner_ID());
																						emppen.SetVAHRUAE_HR_PenalityDetails_ID(tempp[0]);
																						compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + "  AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
																						empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
																						emppen.SetVAHRUAE_DeductionAmount((empcomp.GetVAHRUAE_FixedValue() / 30) * pd.GetVAHRUAE_DeductionPercentage());
																						mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - emppen.GetVAHRUAE_DeductionAmount());
																						mthsal.SetVAHRUAE_Penality(mthsal.GetVAHRUAE_Penality() + emppen.GetVAHRUAE_DeductionAmount());
																						emppen.Save();
																						abs++;
																					}
																				}
																			}
																			currday = currday.Value.AddDays(1);
																			if (e.GetVAHRUAE_DateRelieved() != null)
																			{
																				if (currday.Value.Date >= e.GetVAHRUAE_DateRelieved().Value.Date)
																				{
																					mthsal.SetVAHRUAE_Gross_Amount((Decimal)((double)mthsal.GetVAHRUAE_Gross_Amount() - ((double)empcomp.GetVAHRUAE_FixedValue() * ((GivenEnd.Value.Date - currday.Value.Date).TotalDays) / 30)));
																					m.SetVAHRUAE_Absent_Days(abs);
																					m.SetC_Period_ID(period);
																					m.Save();
																					mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Gross_Amount() - (Decimal)calculateTax((double)mthsal.GetVAHRUAE_Gross_Amount()));
																					benefits = X_VAHRUAE_PositionBenefit.GetAllIDs("VAHRUAE_PositionBenefit", "ISACTIVE = 'Y' AND C_JOB_ID =  " + e.GetC_Job_ID(), null);
																					if (benefits != null && benefits.Length != 0)
																						for (int bens = 0; bens < benefits.Length; bens++)
																						{
																							empbenefit = new X_VAHRUAE_PositionBenefit(GetCtx(), benefits[bens], null);
																							mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Net_Amount() + empbenefit.GetVAHRUAE_Amount());
																						}
																					benefits = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EMPLOYECOMPENSATION", "ISACTIVE = 'Y' AND C_BPartner = " + e.GetC_BPartner_ID() + " AND C_PERIOD_ID = " + period + " AND VAHRUAE_COMPENSATIONMASTER_ID != " + compmastID[0], null);
																					if (benefits != null && benefits.Length != 0)
																						for (int bens = 0; bens < benefits.Length; bens++)
																						{
																							empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), benefits[bens], null);
																							mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Net_Amount() + empcomp.GetVAHRUAE_FixedValue());
																						}
																					mthsal.SetC_BPartner_ID(e.GetC_BPartner_ID()); mthsal.Save();
																					break;
																				}
																			}
																			eatt.RemoveRange(1, eatt.Count - 1);
																			continue;
																		}
																	}
																	if (eatt.Count > 1)
																	{
																		if (eatt.Count % 2 == 1)
																		{
																			if (eatt[eatt.Count - 1].IsVAHRUAE_FirstAttendance())
																				eatt.RemoveAt(eatt.Count - 1);
																			else if (eatt[0].IsVAHRUAE_LastAttendance())
																				eatt.RemoveAt(0);
																		}
																		int shift = 0;
																		start = eatt[0].GetVAHRUAE_TimeOfAttendance();
																		end = eatt[eatt.Count - 1].GetVAHRUAE_TimeOfAttendance();
																		shiftDec = Double.MaxValue;
																		if (x.IsSHIFT1ACTIVE())
																		{
																			if (Math.Abs((start.Value.TimeOfDay - x.GetVAHRUAE_InTime().Value.TimeOfDay).TotalMinutes) < shiftDec)
																			{
																				shift = 1;
																				shiftDec = Math.Abs((start.Value.TimeOfDay - x.GetVAHRUAE_InTime().Value.TimeOfDay).TotalMinutes);
																			}
																		}
																		if (x.IsSHIFT2ACTIVE())
																		{
																			if (Math.Abs((start.Value.TimeOfDay - x.GetVAHRUAE_InTime2().Value.TimeOfDay).TotalMinutes) < shiftDec)
																			{
																				shift = 2;
																				shiftDec = Math.Abs((start.Value.TimeOfDay - x.GetVAHRUAE_InTime2().Value.TimeOfDay).TotalMinutes);
																			}
																		}
																		if (x.IsSHIFT3ACTIVE())
																		{
																			if (Math.Abs((start.Value.TimeOfDay - x.GetVAHRUAE_InTime3().Value.TimeOfDay).TotalMinutes) < shiftDec)
																			{
																				shift = 3;
																				shiftDec = Math.Abs((start.Value - x.GetVAHRUAE_InTime3().Value).TotalMinutes);
																			}
																		}
																		hours = 0;
																		if (!ishol)
																		{
																			if (shift == 1)
																			{
																				for (int ty = 0; ty < eatt.Count; ty += 2)
																				{
																					if (eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay < x.GetVAHRUAE_InTime().Value.TimeOfDay)
																					{
																						if (eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay < x.GetVAHRUAE_InTime().Value.TimeOfDay)
																						{
																							m.SetVAHRUAE_OTHour(m.GetVAHRUAE_OTHour() + (Decimal)(eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalMinutes);
																						}
																						else
																						{
																							m.SetVAHRUAE_OTHour(m.GetVAHRUAE_OTHour() + (Decimal)(x.GetVAHRUAE_InTime().Value.TimeOfDay - eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalMinutes);
																							if (eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay > x.GetVAHRUAE_OutTime().Value.TimeOfDay)
																							{
																								m.SetVAHRUAE_OTHour(m.GetVAHRUAE_OTHour() + (Decimal)(eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - x.GetVAHRUAE_OutTime().Value.TimeOfDay).TotalMinutes);
																							}
																						}
																					}
																					else
																					{
																						if (eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay > x.GetVAHRUAE_InTime().Value.TimeOfDay)
																						{
																							if (eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay < x.GetVAHRUAE_OutTime().Value.TimeOfDay)
																							{
																								if (ty == 0)
																								{
																									m.SetVAHRUAE_EarlyOutCount(m.GetVAHRUAE_EarlyOutCount() + (Decimal)(eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - x.GetVAHRUAE_InTime().Value.TimeOfDay).TotalMinutes);
																								}
																								else
																								{
																									m.SetVAHRUAE_EarlyOutCount(m.GetVAHRUAE_EarlyOutCount() + (Decimal)(eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - eatt[ty - 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalMinutes);
																								}
																							}
																							else
																								m.SetVAHRUAE_OTHour(m.GetVAHRUAE_OTHour() + (Decimal)(eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalMinutes);
																						}
																						if (eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay > x.GetVAHRUAE_OutTime().Value.TimeOfDay)
																							m.SetVAHRUAE_OTHour(m.GetVAHRUAE_OTHour() + (Decimal)(eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - x.GetVAHRUAE_OutTime().Value.TimeOfDay).TotalMinutes);
																					}
																				}
																			}
																			else
																			if (shift == 2)
																			{
																				for (int ty = 0; ty < eatt.Count; ty += 2)
																				{
																					if (eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay < x.GetVAHRUAE_InTime2().Value.TimeOfDay)
																					{
																						if (eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay < x.GetVAHRUAE_InTime2().Value.TimeOfDay)
																						{
																							m.SetVAHRUAE_OTHour(m.GetVAHRUAE_OTHour() + (Decimal)(eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalMinutes);
																						}
																						else
																						{
																							m.SetVAHRUAE_OTHour(m.GetVAHRUAE_OTHour() + (Decimal)(x.GetVAHRUAE_InTime2().Value.TimeOfDay - eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalMinutes);
																							if (eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay > x.GetVAHRUAE_OutTime2().Value.TimeOfDay)
																							{
																								m.SetVAHRUAE_OTHour(m.GetVAHRUAE_OTHour() + (Decimal)(eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - x.GetVAHRUAE_OutTime2().Value.TimeOfDay).TotalMinutes);
																							}
																						}
																					}
																					else
																					{
																						if (eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay > x.GetVAHRUAE_InTime2().Value.TimeOfDay)
																						{
																							if (eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay < x.GetVAHRUAE_OutTime2().Value.TimeOfDay)
																							{
																								if (ty == 0)
																								{
																									m.SetVAHRUAE_EarlyOutCount(m.GetVAHRUAE_EarlyOutCount() + (Decimal)(eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - x.GetVAHRUAE_InTime2().Value.TimeOfDay).TotalMinutes);
																								}
																								else
																								{
																									m.SetVAHRUAE_EarlyOutCount(m.GetVAHRUAE_EarlyOutCount() + (Decimal)(eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - eatt[ty - 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalMinutes);
																								}
																							}
																							else
																								m.SetVAHRUAE_OTHour(m.GetVAHRUAE_OTHour() + (Decimal)(eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalMinutes);
																						}
																						if (eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay > x.GetVAHRUAE_OutTime2().Value.TimeOfDay)
																							m.SetVAHRUAE_OTHour(m.GetVAHRUAE_OTHour() + (Decimal)(eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - x.GetVAHRUAE_OutTime2().Value.TimeOfDay).TotalMinutes);
																					}
																				}
																			}
																			else
																			if (shift == 3)
																			{
																				for (int ty = 0; ty < eatt.Count; ty += 2)
																				{
																					if (eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay < x.GetVAHRUAE_InTime3().Value.TimeOfDay)
																					{
																						if (eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay < x.GetVAHRUAE_InTime3().Value.TimeOfDay)
																						{
																							m.SetVAHRUAE_OTHour(m.GetVAHRUAE_OTHour() + (Decimal)(eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalMinutes);
																						}
																						else
																						{
																							m.SetVAHRUAE_OTHour(m.GetVAHRUAE_OTHour() + (Decimal)(x.GetVAHRUAE_InTime3().Value.TimeOfDay - eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalMinutes);
																							if (eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay > x.GetVAHRUAE_OutTime3().Value.TimeOfDay)
																							{
																								m.SetVAHRUAE_OTHour(m.GetVAHRUAE_OTHour() + (Decimal)(eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - x.GetVAHRUAE_OutTime3().Value.TimeOfDay).TotalMinutes);
																							}
																						}
																					}
																					else
																					{
																						if (eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay > x.GetVAHRUAE_InTime3().Value.TimeOfDay)
																						{
																							if (eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay < x.GetVAHRUAE_OutTime3().Value.TimeOfDay)
																							{
																								if (ty == 0)
																								{
																									m.SetVAHRUAE_EarlyOutCount(m.GetVAHRUAE_EarlyOutCount() + (Decimal)(eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - x.GetVAHRUAE_InTime3().Value.TimeOfDay).TotalMinutes);
																								}
																								else
																								{
																									m.SetVAHRUAE_EarlyOutCount(m.GetVAHRUAE_EarlyOutCount() + (Decimal)(eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - eatt[ty - 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalMinutes);
																								}
																							}
																							else
																								m.SetVAHRUAE_OTHour(m.GetVAHRUAE_OTHour() + (Decimal)(eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - eatt[ty].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay).TotalMinutes);
																						}
																						if (eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay > x.GetVAHRUAE_OutTime3().Value.TimeOfDay)
																							m.SetVAHRUAE_OTHour(m.GetVAHRUAE_OTHour() + (Decimal)(eatt[ty + 1].GetVAHRUAE_TimeOfAttendance().Value.TimeOfDay - x.GetVAHRUAE_OutTime3().Value.TimeOfDay).TotalMinutes);
																					}
																				}
																			}
																			if (m.GetVAHRUAE_EarlyOutCount() > 0)
																			{
																				pIDs = X_VAHRUAE_HR_PenalityDetails.GetAllIDs("VAHRUAE_HR_PenalityDetails", "ISACTIVE = 'Y' AND VAHRUAE_HR_Penality_ID = " + e.GetVAHRUAE_HR_Penality_ID() + " AND VAHRUAE_Line >" + (m.GetVAHRUAE_EarlyOutCount()) / 60 + "ORDER BY VAHRUAE_Line ASC", null);
																				//pIDs = X_VAHRUAE_HR_Penality.GetAllIDs("VAHRUAE_HR_Penality", "HOURSMISSING > " + (x.GetHOURSPERDAY() - hours / 60) + "ORDER BY HOURSMISSING ASC", null);
																				if (pIDs != null && pIDs.Length != 0)
																				{
																					pd = new X_VAHRUAE_HR_PenalityDetails(GetCtx(), pIDs[0], null);
																					X_VAHRUAE_HR_Employee_Penality emppen = new X_VAHRUAE_HR_Employee_Penality(GetCtx(), 0, null);
																					emppen.SetAD_Client_ID(GetAD_Client_ID());
																					emppen.SetAD_Org_ID(GetAD_Org_ID());
																					emppen.SetC_BPartner_ID(e.GetC_BPartner_ID());
																					emppen.SetVAHRUAE_HR_PenalityDetails_ID(pIDs[0]);
																					compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + "  AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
																					empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
																					emppen.SetVAHRUAE_DeductionAmount((empcomp.GetVAHRUAE_FixedValue() / 30) * pd.GetVAHRUAE_DeductionPercentage());
																					mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - emppen.GetVAHRUAE_DeductionAmount());
																					mthsal.SetVAHRUAE_Penality(mthsal.GetVAHRUAE_Penality() + emppen.GetVAHRUAE_DeductionAmount());
																					emppen.Save();
																				}
																			}
																		}
																		else
																		{
																			hours = 0;
																			for (int zx = 0; zx < eatt.Count; zx += 2)
																			{
																				hours += (eatt[zx + 1].GetVAHRUAE_TimeOfAttendance().Value - eatt[zx].GetVAHRUAE_TimeOfAttendance().Value).TotalMinutes;
																			}
																			m.SetVAHRUAE_HolOtHour(m.GetVAHRUAE_HolOtHour() + (Decimal)hours);
																			ishol = false;
																		}
																		m.Save();
																		mthsal.SetC_BPartner_ID(e.GetC_BPartner_ID()); mthsal.Save();
																		count++;
																	}
																	if (eatt.Count == 1)
																	{
																		int[] tempp = X_VAHRUAE_HR_PenalityDetails.GetAllIDs("VAHRUAE_HR_PENALITYDETAILS", "ISACTIVE = 'Y' AND VAHRUAE_HR_Penality_ID = " + e.GetVAHRUAE_HR_Penality_ID() + " AND VAHRUAE_Missing_Punch= 'Y'", null);
																		if (tempp != null && tempp.Length != 0 && (lIDs == null||lIDs.Length==0))
																		{
																			pd = new X_VAHRUAE_HR_PenalityDetails(GetCtx(), tempp[0], null);
																			X_VAHRUAE_HR_Employee_Penality emppen = new X_VAHRUAE_HR_Employee_Penality(GetCtx(), 0, null);
																			emppen.SetAD_Client_ID(GetAD_Client_ID());
																			emppen.SetAD_Org_ID(GetAD_Org_ID());
																			emppen.SetC_BPartner_ID(e.GetC_BPartner_ID());
																			emppen.SetVAHRUAE_HR_PenalityDetails_ID(tempp[0]);
																			compensations = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPARTNER_ID =  " + e.GetC_BPartner_ID() + "  AND VAHRUAE_COMPENSATIONMASTER_ID = " + compmastID[0], null);
																			empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), compensations[0], null);
																			emppen.SetVAHRUAE_DeductionAmount((empcomp.GetVAHRUAE_FixedValue() / 30) * pd.GetVAHRUAE_DeductionPercentage());
																			mthsal.SetVAHRUAE_Gross_Amount(mthsal.GetVAHRUAE_Gross_Amount() - emppen.GetVAHRUAE_DeductionAmount());
																			mthsal.SetVAHRUAE_Penality(mthsal.GetVAHRUAE_Penality() + emppen.GetVAHRUAE_DeductionAmount());
																			emppen.Save();
																		}
																	}
																	eatt.Clear();
																	totaltimes += times;
																	if (e.GetVAHRUAE_DateRelieved() != null)
																	{
																		if (currday.Value.Date >= e.GetVAHRUAE_DateRelieved().Value.Date)
																		{
																			mthsal.SetVAHRUAE_Gross_Amount((Decimal)((double)mthsal.GetVAHRUAE_Gross_Amount() - ((double)empcomp.GetVAHRUAE_FixedValue() * ((GivenEnd.Value.Date - currday.Value.Date).TotalDays) / 30)));
																			m.SetVAHRUAE_Absent_Days(abs);
																			m.SetC_Period_ID(period);
																			m.Save();
																			mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Gross_Amount() - (Decimal)calculateTax((double)mthsal.GetVAHRUAE_Gross_Amount()));
																			benefits = X_VAHRUAE_PositionBenefit.GetAllIDs("VAHRUAE_PositionBenefit", "ISACTIVE = 'Y' AND C_JOB_ID =  " + e.GetC_Job_ID(), null);
																			if (benefits != null && benefits.Length != 0)
																				for (int bens = 0; bens < benefits.Length; bens++)
																				{
																					empbenefit = new X_VAHRUAE_PositionBenefit(GetCtx(), benefits[bens], null);
																					mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Net_Amount() + empbenefit.GetVAHRUAE_Amount());
																				}
																			benefits = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EMPLOYECOMPENSATION", "ISACTIVE = 'Y' AND C_BPartner = " + e.GetC_BPartner_ID() + " AND C_PERIOD_ID = " + period + " AND VAHRUAE_COMPENSATIONMASTER_ID != " + compmastID[0], null);
																			if (benefits != null && benefits.Length != 0)
																				for (int bens = 0; bens < benefits.Length; bens++)
																				{
																					empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), benefits[bens], null);
																					mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Net_Amount() + empcomp.GetVAHRUAE_FixedValue());
																				}
																			mthsal.SetC_BPartner_ID(e.GetC_BPartner_ID()); mthsal.Save();
																			break;
																		}
																	}
																	if (totaltimes + 1 < mthIDs.Length)
																	{
																		eatt.Add(new X_VAHRUAE_HR_EmpAttendanceLog(GetCtx(), mthIDs[totaltimes + 1], null));
																		totaltimes++;
																	}
																	else
																	{
																		if (e.GetVAHRUAE_DateRelieved() != null)
																		{
																			if (currday == MonthEndtemp || currday.Value.Date >= e.GetVAHRUAE_DateRelieved().Value.Date)
																			{
																				m.SetVAHRUAE_Absent_Days(abs);
																				m.SetC_Period_ID(period);
																				mthsal.SetC_BPartner_ID(e.GetC_BPartner_ID()); mthsal.Save();
																				m.Save();
																			}
																		}
																		else
																		{
																			if (currday == MonthEndtemp)
																			{
																				m.SetVAHRUAE_Absent_Days(abs);
																				m.SetC_Period_ID(period);
																				m.Save();
																				mthsal.SetC_BPartner_ID(e.GetC_BPartner_ID()); mthsal.Save();
																			}
																		}
																		break;
																	}
																	mthsal.SetC_BPartner_ID(e.GetC_BPartner_ID()); mthsal.Save();
																	currday = currday.Value.AddDays(1);
																}
																else
																{
																	m.SetVAHRUAE_Absent_Days(abs);
																	m.SetC_Period_ID(period);
																	m.Save();
																	mthsal.SetC_BPartner_ID(e.GetC_BPartner_ID()); mthsal.Save();
																	MonthStarttemp = MonthStarttemp.AddMonths(1);
																	break;
																}
															}
														}
														mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Gross_Amount() - (Decimal)calculateTax((double)mthsal.GetVAHRUAE_Gross_Amount()));
														benefits = X_VAHRUAE_PositionBenefit.GetAllIDs("VAHRUAE_PositionBenefit", "ISACTIVE = 'Y' AND C_JOB_ID =  " + e.GetC_Job_ID(), null);
														if (benefits != null && benefits.Length != 0)
															for (int bens = 0; bens < benefits.Length; bens++)
															{
																empbenefit = new X_VAHRUAE_PositionBenefit(GetCtx(), benefits[bens], null);
																mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Net_Amount() + empbenefit.GetVAHRUAE_Amount());
															}
														benefits = X_VAHRUAE_EmployeCompensation.GetAllIDs("VAHRUAE_EmployeCompensation", "ISACTIVE = 'Y' AND C_BPartner_ID = " + e.GetC_BPartner_ID() + " AND VAHRUAE_COMPENSATIONMASTER_ID != " + compmastID[0], null);
														if (benefits != null && benefits.Length != 0)
															for (int bens = 0; bens < benefits.Length; bens++)
															{
																empcomp = new X_VAHRUAE_EmployeCompensation(GetCtx(), benefits[bens], null);
																mthsal.SetVAHRUAE_Net_Amount(mthsal.GetVAHRUAE_Net_Amount() + empcomp.GetVAHRUAE_FixedValue());
															}
														mthsal.SetC_BPartner_ID(e.GetC_BPartner_ID()); mthsal.Save();
													}
												}
											}
										}

									}
								}
							}
						}
					}
				}
			}
			this.log.Log(Level.FINE, "Process Complete");
			return "";
		}
		protected override void Prepare()
		{
		}
		public int Round(int x, int y)
		{
			if (y != 0)
				if (x % y >= y / 2)
					return x + (y - x % y);
				else
					return x - x % y;
			return x;
		}
		public int Ceiling(int x, int y)
		{
			if (y != 0)
				if (x % y != 0)
				{
					x = ((int)(x / y) + 1) * y;
				}
				else
					return x;
			return x;
		}
		public int Floor(int x, int y)
		{
			if (y != 0)
				return (x / y) * y;
			else return x;
		}
		public double calculateTax(double Gross)
		{
			double result = 0;
			int[] tax;
			int[] taxc;
			X_C_TaxCategory taxcinst;
			X_C_Tax taxinst;
			taxc = X_C_TaxCategory.GetAllIDs("C_TAXCATEGORY", "ISACTIVE = 'Y' AND NAME = 'Income'", null);
			if (taxc != null)
			{
				taxcinst = new X_C_TaxCategory(GetCtx(), taxc[0], null);
				tax = X_C_Tax.GetAllIDs("C_TAX", "ISACTIVE = 'Y' AND Line > " + ((Decimal)(Gross * 12) - taxcinst.GetBaseExemption()) + " AND C_TAXCATEGORY_ID = " + taxcinst.GetC_TaxCategory_ID() + " ORDER BY LINE ASC", null);
				if (tax != null && tax.Length!=0)
				{
					taxinst = new X_C_Tax(GetCtx(), tax[0], null);
					result = (((Gross * 12 - (double)taxcinst.GetBaseExemption()) * (double)taxinst.GetRate() / 100) + (double)taxinst.GetFlatDeduction()) / 12;
				}
			}
			if (result <= 0)
				return 0;
			else
				return result;
		}
		public Decimal LeaveDaysDeduction(int part, int year, string type)
		{
			int[] leaverulelinelist;
			int[] daylist;
			daylist = X_VAHRUAE_HR_LeaveDetail.GetAllIDs("VAHRUAE_HR_LeaveDetail", "ISACTIVE = 'Y' AND C_BPartner_ID = " + part + " AND VAHRUAE_LEAVETYPE = '" + type + "' AND VAHRUAE_Date1 >= '01-JAN-" + year + "' AND VAHRUAE_DATE1 <= '31-DEC-" + year + "'", null);
			if (daylist != null && daylist.Length != 0)
			{
				leaverulelinelist = X_VAHRUAE_LeaveSalaryRuleLine.GetAllIDs("VAHRUAE_LeaveSalaryRuleLine", "ISACTIVE = 'Y' AND VAHRUAE_LEAVETYPE = '" + type + "' AND VAHRUAE_LEAVEDAYS > " + daylist.Length + " ORDER BY VAHRUAE_LEAVEDAYS ASC", null);
				if (leaverulelinelist != null && leaverulelinelist.Length != 0)
				{
					X_VAHRUAE_LeaveSalaryRuleLine rule = new X_VAHRUAE_LeaveSalaryRuleLine(GetCtx(), leaverulelinelist[0], null);
					return rule.GetVAHRUAE_SalaryPercent();
				}
				else
					return 0;
			}
			else
				return 0;
		}
		public Decimal installmentPayment(int part)
		{
			int[] advancelist;
			Decimal totalDeduction = 0;
			X_VAHRUAE_Vss_AdvanceDetails advance;
			advancelist = X_VAHRUAE_Vss_AdvanceDetails.GetAllIDs("VAHRUAE_VSS_ADVANCEDETAILS", "ISACTIVE = 'Y' AND C_BPARTNER_ID = " + part + "AND VAHRUAE_NO_INSTALLMENTS_REMAIN > 0", null);
			if (advancelist != null && advancelist.Length != 0)
			{
				for (int i = 0; i < advancelist.Length; i++)
				{
					advance = new X_VAHRUAE_Vss_AdvanceDetails(GetCtx(), advancelist[i], null);
					totalDeduction += advance.GetVAHRUAE_AmountGiven() / advance.GetVAHRUAE_Installments();
					advance.SetVAHRUAE_No_Installments_Remain(advance.GetVAHRUAE_No_Installments_Remain() - 1);
					advance.SetVAHRUAE_AmountPresent(advance.GetVAHRUAE_AmountPresent() + advance.GetVAHRUAE_AmountGiven() / advance.GetVAHRUAE_Installments());
					advance.Save();
				}
			}
			return totalDeduction;
		}
		public bool checkHoliday(DateTime? currday)
		{
			X_VAHRUAE_HR_Holidays hol;
			bool ishol;
			int[] hollist;
			hollist = X_VAHRUAE_HR_Holidays.GetAllIDs("VAHRUAE_HR_Holidays", "ISACTIVE = 'Y'", null);
			ishol = false;
			if (hollist.Length != 0 && hollist != null)
			{
				for (int dw = 0; dw < hollist.Length; dw++)
				{
					hol = new X_VAHRUAE_HR_Holidays(GetCtx(), hollist[dw], null);

					if (hol.IsONTHURSDAY())
					{
						if (hol.GetVAHRUAE_Date1().Value.DayOfWeek == DayOfWeek.Sunday || hol.GetVAHRUAE_Date1().Value.DayOfWeek == DayOfWeek.Monday || hol.GetVAHRUAE_Date1().Value.DayOfWeek == DayOfWeek.Tuesday || hol.GetVAHRUAE_Date1().Value.DayOfWeek == DayOfWeek.Wednesday || hol.GetVAHRUAE_Date1().Value.DayOfWeek == DayOfWeek.Thursday)
						{
							if (currday.Value.DayOfWeek == DayOfWeek.Thursday)
							{
								if (hol.GetVAHRUAE_Date1().Value.AddDays(4) >= currday.Value && hol.GetVAHRUAE_Date1() <= currday.Value.Date)
								{
									ishol = true;
									break;
								}
							}
						}
					}
					if (hol.GetVAHRUAE_Date1().Value.Date == currday.Value.Date && !hol.IsONTHURSDAY())
					{
						ishol = true;
						break;
					}
					ishol = false;
				}
			}
			return ishol;
		}
	}
}