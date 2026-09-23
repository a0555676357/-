using System;

namespace GTSErpSystem.Models;

public class Repairs_RepairDetails
{
    public int GroupId { get; set; }
    public int Id { get; set; }
    public int MalfunctionId { get; set; }
    public int RepairId { get; set; }
    public string Repairs_Groups { get; set; } = string.Empty;
    public string Repairs_Malfunctions { get; set; } = string.Empty;
    public string Repairs_Repair { get; set; } = string.Empty;
}