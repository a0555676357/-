using System;

namespace GTSErpSystem.Models;

public class Account_Projects
{
    public int ID { get; set; }
    public int? BranchID { get; set; }
    public DateTime? DateEnd { get; set; }
    public DateTime? DateStart { get; set; }
    public decimal? InsuranceAmount { get; set; }
    public decimal? InsurancePer { get; set; }
    public string Note { get; set; } = string.Empty;
    public int? ProjectID { get; set; }
    public string ProjectName { get; set; } = string.Empty;
    public int? ProjectNo { get; set; }
    public decimal? ProjectPrice { get; set; }
    public decimal? ProjectVat { get; set; }
    public int SN { get; set; }
    public decimal? TotalAmount { get; set; }
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
}