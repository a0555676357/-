using System;

namespace GTSErpSystem.Models;

public class LoginLog
{
    public int ID { get; set; }
    public string AppVersion { get; set; } = string.Empty;
    public string DatabaseVersion { get; set; } = string.Empty;
    public string MacAddressLogs { get; set; } = string.Empty;
    public int SN { get; set; }
    public int UserID { get; set; }
    public DateTime UserLogsDate { get; set; }
}