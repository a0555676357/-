using System;

namespace GTSErpSystem.Models;

public class TblRemember
{
    public DateTime? DateTimeRem { get; set; }
    public int ID { get; set; }
    public string NameRem { get; set; } = string.Empty;
}