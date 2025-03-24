using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Department
{
    public string departmentCode { get; set; } = null!;

    public string title { get; set; } = null!;

    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

    public virtual ICollection<Warehouse> Warehouses { get; set; } = new List<Warehouse>();
}
