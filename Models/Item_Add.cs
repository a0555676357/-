using System;

namespace GTSErpSystem.Models;

public class Item_Add
{
    public decimal? CostPrice { get; set; }
    public int ID { get; set; }
    public bool? Is_Tax { get; set; }
    public string Name { get; set; } = string.Empty;
    public string NameEN { get; set; } = string.Empty;
    public int? PrintID { get; set; }
    public decimal? SellPrice { get; set; }
    public decimal? Tax_Value { get; set; }
    public bool? Type { get; set; }
}