using System;

namespace GTSErpSystem.Models;

public class Order_Transfer_Master
{
    public int? BranchID { get; set; }
    public decimal? CashBank { get; set; }
    public decimal? CashMoney { get; set; }
    public int? CostCentersID { get; set; }
    public decimal? CostOrder { get; set; }
    public decimal? DiscountNum { get; set; }
    public decimal? DiscountPerantage { get; set; }
    public int? FromBranchID { get; set; }
    public int ID { get; set; }
    public decimal? Net { get; set; }
    public string Note { get; set; } = string.Empty;
    public string NoteNum { get; set; } = string.Empty;
    public bool? OrderCashierType { get; set; }
    public int? Order_Paymant_Type { get; set; }
    public int? ProjectId { get; set; }
    public DateTime? Purchases_Date { get; set; }
    public int? StatusTypeID { get; set; }
    public int? ToBranchID { get; set; }
    public decimal? TotalPrices { get; set; }
    public decimal? TotalPrices_Discount { get; set; }
    public int? TrackingTypeID { get; set; }
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
    public int? YearId { get; set; }
}