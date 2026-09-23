using System;

namespace GTSErpSystem.Models;

public class Account_ReceiptsDetails
{
    public int ID { get; set; }
    public int? AccounIindex { get; set; }
    public string Account_Receipts { get; set; } = string.Empty;
    public int? Account_Sn { get; set; }
    public int? BranchID { get; set; }
    public int? CostCentersID { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Debit { get; set; }
    public bool? IsVat { get; set; }
    public int? ProjectId { get; set; }
    public int Sn { get; set; }
    public decimal? Total { get; set; }
    public string TranDesc { get; set; } = string.Empty;
    public int? TranSn { get; set; }
    public decimal? Vat { get; set; }
    public int? VatNum { get; set; }
    public int? YearId { get; set; }
}