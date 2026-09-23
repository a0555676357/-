using System;

namespace GTSErpSystem.Models;

public class Emp_EntrustedEmployeeDetails
{
    public int ID { get; set; }
    public DateTime? DateEnter { get; set; }
    public int? EmpID { get; set; }
    public int? EnterID { get; set; }
    public decimal? EnterMoney { get; set; }
    public string Note { get; set; } = string.Empty;
    public decimal? Quantity { get; set; }
    public int SN { get; set; }
    public decimal? Total { get; set; }
}