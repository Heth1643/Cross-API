using System;
using System.Collections.Generic;

namespace Model;

public partial class Employee1
{
    public int EmpId { get; set; }

    public string? EmpName { get; set; }

    public double? Salary { get; set; }

    public int? DeptId { get; set; }

   public virtual Department1? Dept { get; set; }
}
