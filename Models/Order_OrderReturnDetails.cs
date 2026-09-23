using System;

namespace GTSErpSystem.Models;

public class Order_OrderReturnDetails
{
    public int ID { get; set; }
    public decimal? AmountDisc { get; set; }
    public int? BranchID { get; set; }
    public decimal? CostAverg { get; set; }
    public int? CreditNote { get; set; }
    public int? FromPurchID { get; set; }
    public bool? IsWaiting { get; set; }
    public int? ItemID { get; set; }
    public string ItemNote { get; set; } = string.Empty;
    public int? ItemUnitID { get; set; }
    public string ItemUnitType { get; set; } = string.Empty;
    public decimal? NetTotalPrice { get; set; }
    public decimal? NetUnitPrice { get; set; }
    public decimal? Originalquantity { get; set; }
    public decimal? PercentDisc { get; set; }
    public int? Purchese_ID { get; set; }
    public decimal? Quantity { get; set; }
    public int SN { get; set; }
    public decimal? SmallUnitPrice { get; set; }
    public int? SnOrderDetails { get; set; }
    public int? StoreID { get; set; }
    public decimal? SumPriceInstall { get; set; }
    public decimal? SumPriceInstallDisc { get; set; }
    public decimal? TotalPrice { get; set; }
    public decimal? UnitNumber { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? VAT { get; set; }
    public decimal? VAT_Discount { get; set; }
}