using System;

namespace GTSErpSystem.Models;

public class TblSetting
{
    public string AccountSid { get; set; } = string.Empty;
    public string AdditionalNum { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public bool? AlItemInRow { get; set; }
    public string AuthToken { get; set; } = string.Empty;
    public string Bank { get; set; } = string.Empty;
    public bool? BarcodeResturant { get; set; }
    public string BasicContractTerms { get; set; } = string.Empty;
    public bool? BondTax { get; set; }
    public string BuildingNum { get; set; } = string.Empty;
    public string Calendar { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public bool? CkShowFatoraElctornc { get; set; }
    public bool? CloseYear { get; set; }
    public string CommercialRegister { get; set; } = string.Empty;
    public string CompanyNameAr { get; set; } = string.Empty;
    public string CompanyNameEn { get; set; } = string.Empty;
    public string CompanyNamePrintFatora { get; set; } = string.Empty;
    public string ConString { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Crs { get; set; } = string.Empty;
    public bool? CsIdForUser { get; set; }
    public int? Currency_Dividing { get; set; }
    public string DatabaseVersion { get; set; } = string.Empty;
    public string DateDemo { get; set; } = string.Empty;
    public string DateDemoStart { get; set; } = string.Empty;
    public bool? DisCode { get; set; }
    public decimal? DisPerCashier { get; set; }
    public bool? DiscountDecimal { get; set; }
    public bool? DiscountDecimalForCustomer { get; set; }
    public decimal? DiscountForRestaurant { get; set; }
    public string District { get; set; } = string.Empty;
    public string Fax { get; set; } = string.Empty;
    public decimal? FontSize { get; set; }
    public string FromPhone { get; set; } = string.Empty;
    public bool? Gabr { get; set; }
    public bool? Glasses { get; set; }
    public decimal? GridWidth { get; set; }
    public string GroupColor { get; set; } = string.Empty;
    public string GroupFontColor { get; set; } = string.Empty;
    public int? GroupSize { get; set; }
    public bool? Hasm { get; set; }
    public int ID { get; set; }
    public bool? ISBouns { get; set; }
    public string ISDemo { get; set; } = string.Empty;
    public bool? ImageShape { get; set; }
    public int? InstallationAll { get; set; }
    public string InvoiceHash { get; set; } = string.Empty;
    public bool? IsBackupwhenClose { get; set; }
    public bool? IsElectronicInvoice { get; set; }
    public bool? IsImage { get; set; }
    public bool? IsItemExpire { get; set; }
    public bool? IsItemNameAR { get; set; }
    public bool? IsItemNameEN { get; set; }
    public bool? IsItemShowPrice { get; set; }
    public bool? IsMizanWeight { get; set; }
    public bool? IsPharmacy { get; set; }
    public bool? IsPrintCashier { get; set; }
    public bool? IsPrintItemCook { get; set; }
    public bool? IsPrintOrder { get; set; }
    public bool? IsPrintReturnOrder { get; set; }
    public bool? IsPrintSecondCasheir { get; set; }
    public bool? IsPrintSecondFatoraCasheir { get; set; }
    public bool? IsRestaurant { get; set; }
    public bool? IsSecureCashier { get; set; }
    public bool? IsShowRoomInFormRestaurant { get; set; }
    public bool? IsTakeDateApp { get; set; }
    public bool? IsTimeInRestaurant { get; set; }
    public bool? IsTobacc { get; set; }
    public bool? IsVat { get; set; }
    public string ItemColor { get; set; } = string.Empty;
    public string ItemFontColor { get; set; } = string.Empty;
    public string ItemNameAR { get; set; } = string.Empty;
    public string ItemNameEN { get; set; } = string.Empty;
    public string ItemShowPrice { get; set; } = string.Empty;
    public int? ItemSize { get; set; }
    public bool? ItemTotalWithVat { get; set; }
    public decimal? MinTobaccoTax { get; set; }
    public string Mobile { get; set; } = string.Empty;
    public string ModeInvoice { get; set; } = string.Empty;
    public bool? NoDiscountDecimal { get; set; }
    public string OrderCaptainIPAddress { get; set; } = string.Empty;
    public int? OrderCaptainPort { get; set; }
    public bool? OrderStore { get; set; }
    public string PassWordSupervisor { get; set; } = string.Empty;
    public string PathBackup { get; set; } = string.Empty;
    public decimal? PerVat { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string PrivateKey { get; set; } = string.Empty;
    public string PublicKey { get; set; } = string.Empty;
    public int? Qty_Dividing { get; set; }
    public string SecondPrintDefualt { get; set; } = string.Empty;
    public string SecretKey { get; set; } = string.Empty;
    public bool? ShowRoom { get; set; }
    public string SplitMizan { get; set; } = string.Empty;
    public int? StoreID { get; set; }
    public int? StoreIDPurches { get; set; }
    public int? StoreIDWaiying { get; set; }
    public string Street { get; set; } = string.Empty;
    public string SupervisorBarcode { get; set; } = string.Empty;
    public string SupplierPartyIdentificationID { get; set; } = string.Empty;
    public string SupplierPartyIdentificationschemeID { get; set; } = string.Empty;
    public int? Tafqit_ID { get; set; }
    public string VatNum { get; set; } = string.Empty;
    public string Web { get; set; } = string.Empty;
}