using System;

namespace GTSErpSystem.Models;

public class Order_InventorySettlementMinusDetails
{
    public int ID { get; set; }
    public int? BranchID { get; set; }
    public int? ItemID { get; set; }
    public int? ItemUnitID { get; set; }
    public string ItemUnitType { get; set; } = string.Empty;
    public int? Purchese_ID { get; set; }
    public decimal? Quantity { get; set; }
    public int SN { get; set; }
    public decimal? SmallUnitPrice { get; set; }
    public int? StoreID { get; set; }
    public decimal? TotalPrice { get; set; }
    public decimal? UnitNumber { get; set; }
    public decimal? UnitPrice { get; set; }
}