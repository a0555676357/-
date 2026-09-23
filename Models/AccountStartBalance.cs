using System;

namespace GTSErpSystem.Models;

public class AccountStartBalance
{
    public decimal? AccountNo { get; set; }
    public bool? AllowEdit { get; set; }
    public int CompID { get; set; }
    public int? CreatedBy { get; set; }
    public int Id { get; set; }
    public decimal? Priv_Credit { get; set; }
    public decimal? Priv_Debit { get; set; }
    public DateTime? StartDate { get; set; }
}