using System;

namespace GTSErpSystem.Models;

public class Emp_PayrollDetails
{
    public int ID { get; set; }
    public int? AccountBankBox { get; set; }
    public int? AccountNum { get; set; }
    public decimal? Bouns { get; set; }
    public int? CostCentersID { get; set; }
    public decimal? DaysOfBsence { get; set; }
    public decimal? DaysOfBsenceValue { get; set; }
    public decimal? Deduct { get; set; }
    public decimal? Delays { get; set; }
    public int? EmpID { get; set; }
    public decimal? HourDelaysValue { get; set; }
    public decimal? HourExtra { get; set; }
    public decimal? HourExtraValue { get; set; }
    public decimal? Merit { get; set; }
    public decimal? NetAllowances { get; set; }
    public decimal? NetSalary { get; set; }
    public int? PayRollID { get; set; }
    public decimal? PaymentOfAdvance { get; set; }
    public int SN { get; set; }
    public decimal? Salary { get; set; }
    public decimal? Vacations { get; set; }
}