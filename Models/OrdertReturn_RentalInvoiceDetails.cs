using System;

namespace GTSErpSystem.Models;

public class OrdertReturn_RentalInvoiceDetails
{
    public int ID { get; set; }
    public decimal? AmountDisc { get; set; }
    public int? BranchID { get; set; }
    public decimal? DaysNum { get; set; }
    public int? ItemID { get; set; }
    public string ItemNote { get; set; } = string.Empty;
    public int? ItemUnitID { get; set; }
    public string ItemUnitType { get; set; } = string.Empty;
    public decimal? LastCost { get; set; }
    public decimal? NetTotalPrice { get; set; }
    public decimal? NetUnitPrice { get; set; }
    public int? OriginalSN { get; set; }
    public decimal? PercentDisc { get; set; }
    public decimal? Quantity { get; set; }
    public int? RentalInvoiceID { get; set; }
    public int SN { get; set; }
    public decimal? SmallUnitPrice { get; set; }
    public int? StoreID { get; set; }
    public decimal? SumPrice { get; set; }
    public decimal? SumPriceDisc { get; set; }
    public decimal? Total { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? VAT { get; set; }
    public decimal? VAT_Discount { get; set; }
}