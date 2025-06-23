using System;
using System.Collections.Generic;

namespace WebApplication123.Data.Entities;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string Email { get; set; } = null!;

    public DateOnly HireDate { get; set; }

    public decimal? Salary { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
