using System;

namespace GTSErpSystem.Models;

public class Repairs_Malfunctions
{
    public int GroupId { get; set; }
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Repairs_Groups { get; set; } = string.Empty;
    public string Repairs_RepairDetails { get; set; } = string.Empty;
}