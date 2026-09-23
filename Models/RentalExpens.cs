using System;

namespace GTSErpSystem.Models;

public class RentalExpens
{
    public decimal? AllTax { get; set; }
    public DateTime? Date { get; set; }
    public int Id { get; set; }
    public decimal? NetTotalPrice { get; set; }
    public decimal? TotalPrice { get; set; }
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
}