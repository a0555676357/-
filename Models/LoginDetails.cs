using System;

namespace GTSErpSystem.Models;

public class LoginDetails
{
    public int ID { get; set; }
    public string AccountSid { get; set; } = string.Empty;
    public int ActivationId { get; set; }
    public bool AlLItemInRow { get; set; }
    public string AuthToken { get; set; } = string.Empty;
    public string Crm { get; set; } = string.Empty;
    public string EmployeeId { get; set; } = string.Empty;
    public string EncHash { get; set; } = string.Empty;
    public string FromPhone { get; set; } = string.Empty;
    public bool SentInvoice { get; set; }
    public bool ShowRoom { get; set; }
    public string Token { get; set; } = string.Empty;
}