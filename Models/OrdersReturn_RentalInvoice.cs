using System;

namespace GTSErpSystem.Models;

public class OrdersReturn_RentalInvoice
{
    public string Address { get; set; } = string.Empty;
    public decimal? AllDiscount { get; set; }
    public int? BranchID { get; set; }
    public decimal? CashBank { get; set; }
    public decimal? CashMoney { get; set; }
    public int? CostCentersID { get; set; }
    public decimal? DayNums { get; set; }
    public decimal? DiscountNum { get; set; }
    public decimal? DiscountPerantage { get; set; }
    public int ID { get; set; }
    public bool? ISRent { get; set; }
    public decimal? Net { get; set; }
    public string Note { get; set; } = string.Empty;
    public int? Order_Paymant_Type { get; set; }
    public decimal? Paid { get; set; }
    public string ParentName { get; set; } = string.Empty;
    public int? PurBranchID { get; set; }
    public DateTime? RentalDate { get; set; }
    public int? RentalInvoiceID { get; set; }
    public DateTime? ReturnDate { get; set; }
    public int? SupplierID { get; set; }
    public string SupplierIDNum { get; set; } = string.Empty;
    public string SupplierName { get; set; } = string.Empty;
    public string SupplierPhone { get; set; } = string.Empty;
    public decimal? Tax { get; set; }
    public decimal? Tax_Discount { get; set; }
    public decimal? TotalPrices { get; set; }
    public decimal? TotalPrices_Discount { get; set; }
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
    public decimal? deposit { get; set; }
    public decimal? rest { get; set; }
}