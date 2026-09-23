using System;

namespace GTSErpSystem.Models;

public class Order_Reservation
{
    public int? CustID { get; set; }
    public DateTime? DateReserv { get; set; }
    public DateTime? Eventdate { get; set; }
    public int ID { get; set; }
    public bool? IsRent { get; set; }
    public decimal? Net { get; set; }
    public string Note { get; set; } = string.Empty;
    public DateTime? Receiveddate { get; set; }
    public DateTime? Rehearsaldate { get; set; }
    public DateTime? Returndate { get; set; }
}