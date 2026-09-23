using System;

namespace GTSErpSystem.Models;

public class AgeingAnalysi
{
    public int ID { get; set; }
    public string Account_Name { get; set; } = string.Empty;
    public decimal? Account_No { get; set; }
    public decimal AgeingAnalysisID { get; set; }
    public int? CompID { get; set; }
    public decimal? Days_180 { get; set; }
    public decimal? Days_30 { get; set; }
    public decimal? Days_31_60 { get; set; }
    public decimal? Days_61_90 { get; set; }
    public decimal? Days_91_180 { get; set; }
    public int? EmpID { get; set; }
    public decimal? SumValues { get; set; }
}