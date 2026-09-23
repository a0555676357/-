using System;

namespace GTSErpSystem.Models;

public class Car_Receive
{
    public string Car_ColorID { get; set; } = string.Empty;
    public string Car_Model { get; set; } = string.Empty;
    public string Car_PlateNumber { get; set; } = string.Empty;
    public string Car_TypeID { get; set; } = string.Empty;
    public string Car_bodynumber { get; set; } = string.Empty;
    public decimal? CashAmount { get; set; }
    public int? CustID { get; set; }
    public int? Cust_Fin_Num { get; set; }
    public decimal? DiscountAmount { get; set; }
    public int? DriverID { get; set; }
    public string Driver_PlateNumber { get; set; } = string.Empty;
    public int ID { get; set; }
    public bool? IsDone { get; set; }
    public decimal? LastCashAmount { get; set; }
    public string Note { get; set; } = string.Empty;
    public string Order_Date { get; set; } = string.Empty;
    public string Order_DateReceipt { get; set; } = string.Empty;
    public string Order_DateResend { get; set; } = string.Empty;
    public string Order_Destination { get; set; } = string.Empty;
    public int? Order_TypeID { get; set; }
    public string Order_Uploader { get; set; } = string.Empty;
    public decimal? SafyAmount { get; set; }
    public decimal? ShippingAmount { get; set; }
    public decimal? TotalAmount { get; set; }
    public decimal? VatAmount { get; set; }
}