using System;

namespace GTSErpSystem.Models;

public class Contract_Files
{
    public int ContractID { get; set; }
    public string FilePath { get; set; } = string.Empty;
    public int ID { get; set; }
    public DateTime? UploadDate { get; set; }
}