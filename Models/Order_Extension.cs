using System;

namespace GTSErpSystem.Models;

public class Order_Extension
{
    public int ID { get; set; }
    public string LeftAdd { get; set; } = string.Empty;
    public string LeftAxis { get; set; } = string.Empty;
    public string LeftCYL { get; set; } = string.Empty;
    public string LeftSph { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    public int OrderID { get; set; }
    public string RightAdd { get; set; } = string.Empty;
    public string RightAxis { get; set; } = string.Empty;
    public string RightCYL { get; set; } = string.Empty;
    public string RightSph { get; set; } = string.Empty;
}