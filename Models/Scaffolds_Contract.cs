using System;

namespace GTSErpSystem.Models;

public class Scaffolds_Contract
{
    public decimal? AllTax { get; set; }
    public int? BounceID { get; set; }
    public int? BranchID { get; set; }
    public int? ContractType { get; set; }
    public decimal? CostOrder { get; set; }
    public decimal? DayNum { get; set; }
    public decimal? DiscountNum { get; set; }
    public decimal? DiscountPerantage { get; set; }
    public DateTime? From_Date { get; set; }
    public int ID { get; set; }
    public bool? IsClosed { get; set; }
    public string Location { get; set; } = string.Empty;
    public decimal? Net { get; set; }
    public string Note { get; set; } = string.Empty;
    public string NoteNum { get; set; } = string.Empty;
    public int? PurBranchID { get; set; }
    public string Pyment { get; set; } = string.Empty;
    public decimal? Safy { get; set; }
    public int? SupplierID { get; set; }
    public string SupplierName { get; set; } = string.Empty;
    public string SupplierPhone { get; set; } = string.Empty;
    public string SupplierVatNum { get; set; } = string.Empty;
    public decimal? Tax { get; set; }
    public decimal? Tax_Discount { get; set; }
    public DateTime? To_Date { get; set; }
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
}