using System;

namespace GTSErpSystem.Models;

public class ItemQuantity
{
    public int ID { get; set; }
    public string Account_Stores { get; set; } = string.Empty;
    public decimal? BeginningInventory { get; set; }
    public decimal? BeginningInventoryPrice { get; set; }
    public decimal? CurrentBalance { get; set; }
    public int? ItemID { get; set; }
    public int ItemQuantityID { get; set; }
    public decimal? OpeningBalance { get; set; }
    public int? StoreID { get; set; }
    public decimal? UnitNumber { get; set; }
}