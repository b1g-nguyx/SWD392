using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Medicine
{
    public string medicineCode { get; set; } = null!;

    public string medicineTypeCode { get; set; } = null!;

    public string name { get; set; } = null!;

    public int? stock { get; set; }

    public virtual MedicineType medicineTypeCodeNavigation { get; set; } = null!;
}
