using System;

namespace GTSErpSystem.Models;

public class Order_StoreTransfer
{
    public int? BranchID { get; set; }
    public DateTime? DateTransfer { get; set; }
    public int? FromStoreID { get; set; }
    public int? ID { get; set; }
    public string Note { get; set; } = string.Empty;
    public int SN { get; set; }
    public int? ToStoreID { get; set; }
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
}