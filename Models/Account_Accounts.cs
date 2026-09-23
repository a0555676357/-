using System;

namespace GTSErpSystem.Models;

public class Account_Accounts
{
    public int? Account_Level { get; set; }
    public string Account_Name { get; set; } = string.Empty;
    public int? Account_Nature { get; set; }
    public int? Account_No { get; set; }
    public int? Account_Type { get; set; }
    public string Account_Type1 { get; set; } = string.Empty;
    public string AddressA { get; set; } = string.Empty;
    public int? BranchID { get; set; }
    public DateTime? Date_OpenCharge { get; set; }
    public string E_Account_Name { get; set; } = string.Empty;
    public string FaxA { get; set; } = string.Empty;
    public int? Final_Account { get; set; }
    public int ID { get; set; }
    public int? Main_Account_No { get; set; }
    public string Note { get; set; } = string.Empty;
    public string PhoneA { get; set; } = string.Empty;
    public decimal? Priv_Credit { get; set; }
    public decimal? Priv_Debit { get; set; }
    public int? Suspended { get; set; }
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
}