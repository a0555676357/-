using System;

namespace GTSErpSystem.Models;

public class Scaffolds_MinutesStartedDetails
{
    public int ID { get; set; }
    public int? BranchID { get; set; }
    public DateTime? ItemDate { get; set; }
    public int? ItemID { get; set; }
    public int? ItemUnitID { get; set; }
    public string ItemUnitType { get; set; } = string.Empty;
    public decimal? LastCost { get; set; }
    public decimal? LastPrice { get; set; }
    public decimal? NetTotalPrice { get; set; }
    public decimal? NetUnitPrice { get; set; }
    public decimal? OriginalQuantity { get; set; }
    public int? Purchese_ID { get; set; }
    public decimal? Quantity { get; set; }
    public int SN { get; set; }
    public decimal? SmallUnitPrice { get; set; }
    public decimal? TotalPrice { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? VAT { get; set; }
    public decimal? VAT_Discount { get; set; }
}