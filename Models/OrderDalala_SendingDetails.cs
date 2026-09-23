using System;

namespace GTSErpSystem.Models;

public class OrderDalala_SendingDetails
{
    public int ID { get; set; }
    public int? BranchID { get; set; }
    public DateTime? DateExpire { get; set; }
    public int? ItemID { get; set; }
    public int? ItemUnitID { get; set; }
    public string ItemUnitType { get; set; } = string.Empty;
    public string NoteItem { get; set; } = string.Empty;
    public int? Purchese_ID { get; set; }
    public decimal? Quantity { get; set; }
    public int SN { get; set; }
    public int? StoreID { get; set; }
}