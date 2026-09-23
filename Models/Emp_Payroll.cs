using System;

namespace GTSErpSystem.Models;

public class Emp_Payroll
{
    public int? Branch_ID { get; set; }
    public int ID { get; set; }
    public string Note { get; set; } = string.Empty;
    public string NumNote { get; set; } = string.Empty;
    public DateTime? PayrollDate { get; set; }
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
}