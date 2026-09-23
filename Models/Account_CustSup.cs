using System;

namespace GTSErpSystem.Models;

public class Account_CustSup
{
    public int? AccountNo { get; set; }
    public string AdditionalNum { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public decimal? AlarmLimit { get; set; }
    public int? BranchID { get; set; }
    public string BuildingNum { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string CommercialRecord { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public decimal? CreditLimit { get; set; }
    public int? CustSuppCode { get; set; }
    public string CustSuppName { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
    public string Fax { get; set; } = string.Empty;
    public int? FranchiseID { get; set; }
    public bool? FrmCust { get; set; }
    public int ID { get; set; }
    public bool? IsCustomers { get; set; }
    public bool? IsSuppliers { get; set; }
    public string Note { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public int? PlaceID { get; set; }
    public string PostalCode { get; set; } = string.Empty;
    public int? SalesManID { get; set; }
    public string Street { get; set; } = string.Empty;
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
    public string VatNum { get; set; } = string.Empty;
}