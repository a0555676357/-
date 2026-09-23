using System;

namespace GTSErpSystem.Models;

public class Restaurant_Delivery
{
    public int ID { get; set; }
    public int? BranchID { get; set; }
    public string CustName { get; set; } = string.Empty;
    public string CustPhone { get; set; } = string.Empty;
    public string CustPlace { get; set; } = string.Empty;
    public int? DeliveryID { get; set; }
    public decimal? Money { get; set; }
    public int? OrderID { get; set; }
    public int SN { get; set; }
}