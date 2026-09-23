using System;

namespace GTSErpSystem.Models;

public class Order_OrdersDraft
{
    public string AdditionalNum { get; set; } = string.Empty;
    public decimal? AllDiscount { get; set; }
    public decimal? AllTax { get; set; }
    public decimal? AmountPaid { get; set; }
    public int? BankAcc { get; set; }
    public decimal? BankRecipt { get; set; }
    public int? BankReciptAcc { get; set; }
    public int? BounceID { get; set; }
    public decimal? BounsAmount { get; set; }
    public int? BranchID { get; set; }
    public string BuildingNum { get; set; } = string.Empty;
    public string CarColor { get; set; } = string.Empty;
    public string CarModel { get; set; } = string.Empty;
    public string CarName { get; set; } = string.Empty;
    public int? CashAcc { get; set; }
    public decimal? CashBank { get; set; }
    public decimal? CashMoney { get; set; }
    public decimal? CashRecipt { get; set; }
    public int? CashReciptAcc { get; set; }
    public decimal? Charge { get; set; }
    public string ChassisNum { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string CommercialRecord { get; set; } = string.Empty;
    public int? CostCentersID { get; set; }
    public decimal? CostOrder { get; set; }
    public string Counter { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public int? CreditNote { get; set; }
    public DateTime? DateHold { get; set; }
    public DateTime? DateRecipt { get; set; }
    public string DisCode { get; set; } = string.Empty;
    public decimal? DiscountNum { get; set; }
    public decimal? DiscountPerantage { get; set; }
    public string District { get; set; } = string.Empty;
    public decimal? HasmAmount { get; set; }
    public decimal? HasmPer { get; set; }
    public int ID { get; set; }
    public bool? IsWaiting { get; set; }
    public decimal? Motbqy { get; set; }
    public decimal? Net { get; set; }
    public string Note { get; set; } = string.Empty;
    public string NoteNum { get; set; } = string.Empty;
    public bool? OrderCashierType { get; set; }
    public int? OrderNum { get; set; }
    public int? Order_Paymant_Type { get; set; }
    public string PlateNumber { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public int? ProjectId { get; set; }
    public int? PurBranchID { get; set; }
    public DateTime? Purchases_Date { get; set; }
    public int? Res_Delivery_ID { get; set; }
    public decimal? Rest { get; set; }
    public int? RestBraID { get; set; }
    public bool? RestBraISClosed { get; set; }
    public string Restaurant_PayType { get; set; } = string.Empty;
    public int? Restaurant_TypeID { get; set; }
    public int? RoomNum { get; set; }
    public decimal? Safy { get; set; }
    public string SalesMan { get; set; } = string.Empty;
    public int? Sectoral { get; set; }
    public string Street { get; set; } = string.Empty;
    public int? SupplierID { get; set; }
    public string SupplierName { get; set; } = string.Empty;
    public string SupplierPhone { get; set; } = string.Empty;
    public string SupplierVatNum { get; set; } = string.Empty;
    public int? TableNum { get; set; }
    public decimal? Tax { get; set; }
    public decimal? Tax_Discount { get; set; }
    public decimal? TobaccoTax { get; set; }
    public decimal? TotalPrices { get; set; }
    public decimal? TotalPrices_Discount { get; set; }
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
    public int? YearId { get; set; }
}