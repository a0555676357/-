using System;

namespace GTSErpSystem.Models;

public class User_Login
{
    public int? BranchID { get; set; }
    public string Crs { get; set; } = string.Empty;
    public DateTime? DateClose { get; set; }
    public DateTime? DateOpen { get; set; }
    public int? GroupID { get; set; }
    public int ID { get; set; }
    public string InvoiceHash { get; set; } = string.Empty;
    public bool? IsActive { get; set; }
    public bool? IsOpenDay { get; set; }
    public string ModeInvoice { get; set; } = string.Empty;
    public decimal? MoneyOpenDay { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    public string PassWord { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string PrivateKey { get; set; } = string.Empty;
    public string PublicKey { get; set; } = string.Empty;
    public string SecretKey { get; set; } = string.Empty;
    public bool? SentXmlZakateNow { get; set; }
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
}