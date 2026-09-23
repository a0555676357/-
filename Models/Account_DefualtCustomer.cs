using System;

namespace GTSErpSystem.Models;

public class Account_DefualtCustomer
{
    public int? AccountID { get; set; }
    public int? BranchID { get; set; }
    public int? ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public int SN { get; set; }
}