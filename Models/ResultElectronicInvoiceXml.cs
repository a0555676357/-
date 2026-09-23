using System;

namespace GTSErpSystem.Models;

public class ResultElectronicInvoiceXml
{
    public string AllowanceTotalAmount { get; set; } = string.Empty;
    public int BranchId { get; set; }
    public string ChargeTotalAmount { get; set; } = string.Empty;
    public DateTime? Created { get; set; }
    public string EncodedInvoice { get; set; } = string.Empty;
    public string ErrorMessage { get; set; } = string.Empty;
    public string FatoraType { get; set; } = string.Empty;
    public int Id { get; set; }
    public string InvoiceHash { get; set; } = string.Empty;
    public string InvoiceTypeName { get; set; } = string.Empty;
    public bool IsValid { get; set; }
    public string LineExtensionAmount { get; set; } = string.Empty;
    public string NormalXMLFileNameFullPath { get; set; } = string.Empty;
    public string NormalXMLFileNameShortPath { get; set; } = string.Empty;
    public string Operation { get; set; } = string.Empty;
    public string OrderId { get; set; } = string.Empty;
    public string PIH { get; set; } = string.Empty;
    public string PayableAmount { get; set; } = string.Empty;
    public string PrepaidAmount { get; set; } = string.Empty;
    public string QRCode { get; set; } = string.Empty;
    public string ResultedValue { get; set; } = string.Empty;
    public string SingedXML { get; set; } = string.Empty;
    public string SingedXMLFileName { get; set; } = string.Empty;
    public string SingedXMLFileNameFullPath { get; set; } = string.Empty;
    public string SingedXMLFileNameShortPath { get; set; } = string.Empty;
    public string TaxAmount { get; set; } = string.Empty;
    public string TaxExclusiveAmount { get; set; } = string.Empty;
    public string TaxInclusiveAmount { get; set; } = string.Empty;
    public string UUID { get; set; } = string.Empty;
    public bool? Uploaded { get; set; }
    public DateTime? UploadedDate { get; set; }
}