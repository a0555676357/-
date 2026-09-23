using System;

namespace GTSErpSystem.Models;

public class Account_SalesMan
{
    public int? BranchID { get; set; }
    public int? ID { get; set; }
    public bool? ISProfitOrder { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public int? PlaceID { get; set; }
    public int SN { get; set; }
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
    public decimal? profit { get; set; }
}