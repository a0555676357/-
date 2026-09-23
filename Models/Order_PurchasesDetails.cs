using System;

namespace GTSErpSystem.Models;

public class Order_PurchasesDetails
{
    public int ID { get; set; }
    public decimal? Bounce { get; set; }
    public int? BranchID { get; set; }
    public decimal? DiscNum { get; set; }
    public decimal? DiscPercent { get; set; }
    public int? ItemID { get; set; }
    public int? ItemUnitID { get; set; }
    public string ItemUnitType { get; set; } = string.Empty;
    public string Item_Unit { get; set; } = string.Empty;
    public decimal? NetTotalPrice { get; set; }
    public decimal? NetUnitPrice { get; set; }
    public string NoteItem { get; set; } = string.Empty;
    public int? Purchese_ID { get; set; }
    public decimal? Quantity { get; set; }
    public int SN { get; set; }
    public decimal? SellPrice { get; set; }
    public int? StoreID { get; set; }
    public decimal? TotalPrice { get; set; }
    public decimal? UnitNumber { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? VAT { get; set; }
    public decimal? VAT_Discount { get; set; }
}