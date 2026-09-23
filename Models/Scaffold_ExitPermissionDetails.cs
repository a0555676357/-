using System;

namespace GTSErpSystem.Models;

public class Scaffold_ExitPermissionDetails
{
    public int ID { get; set; }
    public int? BranchID { get; set; }
    public DateTime? ItemDate { get; set; }
    public int? ItemID { get; set; }
    public int? ItemUnitID { get; set; }
    public string ItemUnitType { get; set; } = string.Empty;
    public decimal? LastCost { get; set; }
    public decimal? NetTotalPrice { get; set; }
    public decimal? NetUnitPrice { get; set; }
    public string Note { get; set; } = string.Empty;
    public int? Purchese_ID { get; set; }
    public decimal? Quantity { get; set; }
    public int SN { get; set; }
    public decimal? SmallUnitPrice { get; set; }
    public string State { get; set; } = string.Empty;
    public string Statement { get; set; } = string.Empty;
    public int? StoreId { get; set; }
    public decimal? TotalPrice { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? VAT { get; set; }
    public decimal? VAT_Discount { get; set; }
}