using System;

namespace GTSErpSystem.Models;

public class Repairs_Groups
{
    public string GroupName { get; set; } = string.Empty;
    public int Id { get; set; }
    public string Repairs_Malfunctions { get; set; } = string.Empty;
    public string Repairs_RepairDetails { get; set; } = string.Empty;
}