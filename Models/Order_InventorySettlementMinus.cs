using System;

namespace GTSErpSystem.Models;

public class Order_InventorySettlementMinus
{
    public int? BranchID { get; set; }
    public int ID { get; set; }
    public string NoteNum { get; set; } = string.Empty;
    public int? PurBranchID { get; set; }
    public DateTime? Purchases_Date { get; set; }
    public decimal? TotalPrices { get; set; }
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
}