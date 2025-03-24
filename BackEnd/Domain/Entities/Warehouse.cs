using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Warehouse
{
    public string warehouseCode { get; set; } = null!;

    public string? departmentCode { get; set; }

    public virtual Department? departmentCodeNavigation { get; set; }
}
