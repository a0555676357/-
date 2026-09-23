using System;

namespace GTSErpSystem.Models;

public class Item_ItemComponent
{
    public int ID { get; set; }
    public decimal? Amount { get; set; }
    public int? ItemID_Complant { get; set; }
    public int? ItemID_Master { get; set; }
    public int? ItemUnitID { get; set; }
    public string ItemUnitType { get; set; } = string.Empty;
    public int SN { get; set; }
    public decimal? SmallUnitPrice { get; set; }
    public int? StoreID { get; set; }
    public decimal? TotalPrice { get; set; }
    public int? User_Add { get; set; }
    public string User_MacAddress { get; set; } = string.Empty;
}