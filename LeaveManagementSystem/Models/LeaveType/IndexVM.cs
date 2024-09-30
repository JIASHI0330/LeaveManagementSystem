using System;

namespace LeaveManagementSystem.Models.LeaveType;

public class IndexVM
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int NumberOfDays { get; set; }

}
