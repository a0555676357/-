using System;

namespace GTSErpSystem.Models;

public class Virg_Branch
{
    public bool? AdminPermission { get; set; }
    public string Branch { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public int? CompID { get; set; }
    public int? FranchiseID { get; set; }
    public int ID { get; set; }
    public bool? ISActive { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public bool? ShowAllCustomer { get; set; }
    public bool? ShowVirg { get; set; }
    public int? TypeID { get; set; }
    public string VirgLogin { get; set; } = string.Empty;
}