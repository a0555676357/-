using System;

namespace GTSErpSystem.Models;

public class Tran_TranDetails
{
    public int ID { get; set; }
    public int? AccounIindex { get; set; }
    public int? Account_Sn { get; set; }
    public int? BranchID { get; set; }
    public int? CostCentersID { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Debit { get; set; }
    public int? ProjectId { get; set; }
    public int Sn { get; set; }
    public string TranDesc { get; set; } = string.Empty;
    public int? TranSn { get; set; }
    public int? YearId { get; set; }
}