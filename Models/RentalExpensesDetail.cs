using System;

namespace GTSErpSystem.Models;

public class RentalExpensesDetail
{
    public int ID { get; set; }
    public int? ExpensesId { get; set; }
    public bool? IsVat { get; set; }
    public string ItemCode { get; set; } = string.Empty;
    public int? ItemId { get; set; }
    public string ItemName { get; set; } = string.Empty;
    public decimal? Net { get; set; }
    public string Note { get; set; } = string.Empty;
    public int SN { get; set; }
    public decimal? Total { get; set; }
    public decimal? Vat { get; set; }
}