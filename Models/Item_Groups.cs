using System;

namespace GTSErpSystem.Models;

public class Item_Groups
{
    public int? AccountID { get; set; }
    public int ID { get; set; }
    public string Image { get; set; } = string.Empty;
    public bool? IsShow { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? PrinterID { get; set; }
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
}