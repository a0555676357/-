using System;

namespace GTSErpSystem.Models;

public class Account_Stores
{
    public string Address { get; set; } = string.Empty;
    public int? BranchID { get; set; }
    public string Fax { get; set; } = string.Empty;
    public int ID { get; set; }
    public string ItemQuantities { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Store_Name { get; set; } = string.Empty;
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
}