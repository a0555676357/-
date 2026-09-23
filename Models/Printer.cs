using System;

namespace GTSErpSystem.Models;

public class Printer
{
    public int? BranchID { get; set; }
    public int ID { get; set; }
    public string IPAddress { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string PortNum { get; set; } = string.Empty;
}