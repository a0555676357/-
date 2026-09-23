using System;

namespace GTSErpSystem.Models;

public class Tran_Tran
{
    public int? BranchID { get; set; }
    public string DocCode { get; set; } = string.Empty;
    public int ID { get; set; }
    public string? LedgerID { get; set; }
    public string Note { get; set; } = string.Empty;
    public int? ProjectId { get; set; }
    public string ReceivedFrom { get; set; } = string.Empty;
    public int? ReferenceCode { get; set; }
    public decimal? TranCode { get; set; }
    public DateTime? TranDate { get; set; }
    public int? TranTypeID { get; set; }
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
    public int? YearId { get; set; }
}