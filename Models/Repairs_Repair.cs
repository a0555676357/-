using System;

namespace GTSErpSystem.Models;

public class Repairs_Repair
{
    public string CarColor { get; set; } = string.Empty;
    public string CarModel { get; set; } = string.Empty;
    public string CarType { get; set; } = string.Empty;
    public string CustomerName { get; set; } = string.Empty;
    public int Id { get; set; }
    public string Notes { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string PlateNumber { get; set; } = string.Empty;
    public string Repairs_RepairDetails { get; set; } = string.Empty;
}