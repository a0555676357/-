using System;

namespace GTSErpSystem.Models;

public class Item_Items
{
    public int ID { get; set; }
    public decimal? Average_cost { get; set; }
    public string BarcodeCountry { get; set; } = string.Empty;
    public string BigBarCode1 { get; set; } = string.Empty;
    public string BigBarCode2 { get; set; } = string.Empty;
    public string BigBarCode3 { get; set; } = string.Empty;
    public int? Category_ID { get; set; }
    public int? Class_ID { get; set; }
    public string Code_Company { get; set; } = string.Empty;
    public int? CompanyID { get; set; }
    public decimal? ConvertBigUnit { get; set; }
    public decimal? ConvertMediumUnit { get; set; }
    public int? CountryID { get; set; }
    public decimal? DiscItemPer { get; set; }
    public decimal? DoctorPer { get; set; }
    public int? GuaranteeID { get; set; }
    public string Image { get; set; } = string.Empty;
    public bool? IsOffer { get; set; }
    public bool? Is_Item_mizan { get; set; }
    public bool? Is_Tax { get; set; }
    public int ItemId { get; set; }
    public string Item_Unit { get; set; } = string.Empty;
    public string Item_Unit1 { get; set; } = string.Empty;
    public string Item_Unit2 { get; set; } = string.Empty;
    public string Item_code { get; set; } = string.Empty;
    public decimal? LastCost { get; set; }
    public decimal? LastCost2 { get; set; }
    public decimal? LastCost3 { get; set; }
    public string LocationLarge { get; set; } = string.Empty;
    public string LocationMedium { get; set; } = string.Empty;
    public string LocationSmall { get; set; } = string.Empty;
    public string MediumBarCode1 { get; set; } = string.Empty;
    public string MediumBarCode2 { get; set; } = string.Empty;
    public string MediumBarCode3 { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    public decimal? NumOffer { get; set; }
    public decimal? PharmPer { get; set; }
    public decimal? PriceExportunit1 { get; set; }
    public decimal? PriceExportunit2 { get; set; }
    public decimal? PriceExportunit3 { get; set; }
    public decimal? PriceMowazaunit1 { get; set; }
    public decimal? PriceMowazaunit2 { get; set; }
    public decimal? PriceMowazaunit3 { get; set; }
    public decimal? PriceOffer { get; set; }
    public int? PrinterID { get; set; }
    public decimal? SellPriceMedium { get; set; }
    public decimal? SellPriceMedium2 { get; set; }
    public decimal? SellPriceMedium3 { get; set; }
    public decimal? SellPriceSmall { get; set; }
    public decimal? SellPriceSmall2 { get; set; }
    public decimal? SellPriceSmall3 { get; set; }
    public decimal? SellpriceLarge { get; set; }
    public decimal? SellpriceLarge2 { get; set; }
    public decimal? SellpriceLarge3 { get; set; }
    public string SmallBarCode1 { get; set; } = string.Empty;
    public string SmallBarCode2 { get; set; } = string.Empty;
    public string SmallBarCode3 { get; set; } = string.Empty;
    public decimal? SmallUnitQuantity { get; set; }
    public decimal? SmallUnitQuantity2 { get; set; }
    public decimal? SmallUnitQuantity3 { get; set; }
    public string TaxExemptionReason { get; set; } = string.Empty;
    public string TaxExemptionReasonCode { get; set; } = string.Empty;
    public decimal? Tax_Tobacco { get; set; }
    public decimal? Tax_Value { get; set; }
    public int? UnitLarge { get; set; }
    public int? UnitMedium { get; set; }
    public int? UnitSmall { get; set; }
    public int? UnitTafqitID { get; set; }
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
    public string VatCode { get; set; } = string.Empty;
    public string item_Name { get; set; } = string.Empty;
    public string item_Name_English { get; set; } = string.Empty;
    public int? item_Type { get; set; }
}