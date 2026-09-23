using System;

namespace GTSErpSystem.Models;

public class Order_GardDetails
{
    public int ID { get; set; }
    public decimal? AvergPrice { get; set; }
    public int? GardID { get; set; }
    public int? ItemID { get; set; }
    public int? ItemUnitID { get; set; }
    public decimal? LastPrice { get; set; }
    public decimal? QuantitiesDifference { get; set; }
    public decimal? QuantityApp { get; set; }
    public decimal? QuantityGard { get; set; }
    public int SN { get; set; }
    public decimal? SellPrice { get; set; }
    public int? StoreID { get; set; }
}