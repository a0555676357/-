using System;

namespace GTSErpSystem.Models;

public class Order_Reservations
{
    public DateTime? BookingDate { get; set; }
    public int? BranchID { get; set; }
    public int? HallsID { get; set; }
    public int ID { get; set; }
    public DateTime? InstallationDate { get; set; }
    public int? OrderID { get; set; }
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
    public DateTime? jawDate { get; set; }
}