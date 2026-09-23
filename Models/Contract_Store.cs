using System;

namespace GTSErpSystem.Models;

public class Contract_Store
{
    public int? CustID { get; set; }
    public int ID { get; set; }
    public DateTime? ItemDate { get; set; }
    public DateTime? ItemDateExpire { get; set; }
    public int? ItemID { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? QuantityExpire { get; set; }
}