using System;

namespace GTSErpSystem.Models;

public class EmployeeAllowance
{
    public int ID { get; set; }
    public int AllowanceID { get; set; }
    public int EmployeeID { get; set; }
    public decimal Money { get; set; }
}