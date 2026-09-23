using System;

namespace GTSErpSystem.Models;

public class Order_Transfer_MasterDetails
{
    public int ID { get; set; }
    public int? ItemID { get; set; }
    public string ItemNote { get; set; } = string.Empty;
    public int? ItemUnitID { get; set; }
    public string ItemUnitType { get; set; } = string.Empty;
    public decimal? LastCost { get; set; }
    public decimal? NetTotalPrice { get; set; }
    public decimal? NetUnitPrice { get; set; }
    public decimal? QuantityNeed { get; set; }
    public decimal? QuantityNet { get; set; }
    public decimal? QuantityTransfer { get; set; }
    public int SN { get; set; }
    public decimal? SmallUnitPrice { get; set; }
    public int? StoreIDFrom { get; set; }
    public int? StoreIDTo { get; set; }
    public decimal? TotalPrice { get; set; }
    public int? Transfer_ID { get; set; }
    public decimal? UnitPrice { get; set; }
}