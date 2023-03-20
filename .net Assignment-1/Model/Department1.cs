using System;
using System.Collections.Generic;

namespace Model;

public partial class Department1
{
    public int Id { get; set; }

    public string? DeptName { get; set; }

      public virtual ICollection<Employee1> Employee1s { get; } = new List<Employee1>();
}
