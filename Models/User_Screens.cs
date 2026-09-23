using System;

namespace GTSErpSystem.Models;

public class User_Screens
{
    public int ID { get; set; }
    public bool? ISShow { get; set; }
    public int? ScreenNum { get; set; }
    public int? ScreenTypeID { get; set; }
    public string ScreenTypeName { get; set; } = string.Empty;
    public string Screen_Name { get; set; } = string.Empty;
}