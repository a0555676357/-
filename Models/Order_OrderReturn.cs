using System;

namespace GTSErpSystem.Models;

public class Order_OrderReturn
{
    public decimal? AllDis { get; set; }
    public decimal? AllTax { get; set; }
    public decimal? Bank { get; set; }
    public int? BranchID { get; set; }
    public decimal? Cash { get; set; }
    public decimal? CostAverg { get; set; }
    public int? CostCentersID { get; set; }
    public int? CreditNote { get; set; }
    public decimal? DiscountNum { get; set; }
    public decimal? DiscountPerantage { get; set; }
    public bool? ExportInvoice { get; set; }
    public int? FromPurchesID { get; set; }
    public int ID { get; set; }
    public bool? ISPurReturnNum { get; set; }
    public bool? IsWaiting { get; set; }
    public decimal? Net { get; set; }
    public bool? NominalInvoice { get; set; }
    public string NormalOrSimpleInvoice { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    public string NoteNum { get; set; } = string.Empty;
    public string OrderTypeElectronicInvoiceId { get; set; } = string.Empty;
    public int? Order_Paymant_Type { get; set; }
    public int? ProjectId { get; set; }
    public int? PurBranchID { get; set; }
    public DateTime? Purchases_Date { get; set; }
    public string QRCode { get; set; } = string.Empty;
    public decimal? Safy { get; set; }
    public bool? SelfInvoice { get; set; }
    public bool? SummaryInvoice { get; set; }
    public int? SupplierID { get; set; }
    public string SupplierName { get; set; } = string.Empty;
    public string SupplierPhone { get; set; } = string.Empty;
    public string SupplierVatNum { get; set; } = string.Empty;
    public decimal? Tax { get; set; }
    public decimal? Tax_Discount { get; set; }
    public bool? ThirdParty { get; set; }
    public decimal? TobaccoTax { get; set; }
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
    public int? YearId { get; set; }
}