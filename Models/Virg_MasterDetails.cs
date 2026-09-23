using System;

namespace GTSErpSystem.Models;

public class Virg_MasterDetails
{
    public int ID { get; set; }
    public string Active { get; set; } = string.Empty;
    public bool? AlertClose { get; set; }
    public bool? AlertMessage { get; set; }
    public int? AppTypeID { get; set; }
    public int? CompID { get; set; }
    public DateTime? Date { get; set; }
    public DateTime? DateCreate { get; set; }
    public DateTime? DateTo { get; set; }
    public string DeviceName { get; set; } = string.Empty;
    public string HDD { get; set; } = string.Empty;
    public string Mac { get; set; } = string.Empty;
    public int? MarkterID { get; set; }
    public int? MasterID { get; set; }
    public int? NPermission { get; set; }
    public string Notes { get; set; } = string.Empty;
    public int? NumCopys { get; set; }
    public int? NumDays { get; set; }
    public int? NumMessage { get; set; }
    public int? OrderFranchiseType { get; set; }
    public bool? OrderVirgin { get; set; }
    public int SN { get; set; }
    public string Serial { get; set; } = string.Empty;
    public string SerialBoard { get; set; } = string.Empty;
    public bool? ShowVirginInLogin { get; set; }
    public int? StatuseID { get; set; }
    public string Trial { get; set; } = string.Empty;
    public int? UserBranch_Add { get; set; }
    public int? UserBranch_Update { get; set; }
    public DateTime? UserDate_Add { get; set; }
    public DateTime? UserDate_Update { get; set; }
    public int? UserID_Add { get; set; }
    public int? UserID_Update { get; set; }
    public string UserMacAddress_Add { get; set; } = string.Empty;
    public string UserMacAddress_Update { get; set; } = string.Empty;
    public string VirgDue { get; set; } = string.Empty;
    public int? VirgID { get; set; }
    public int? VirgTypeID { get; set; }
}