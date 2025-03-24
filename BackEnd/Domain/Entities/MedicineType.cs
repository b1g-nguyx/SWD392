using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MedicineType
{
    public string medicineTypeCode { get; set; } = null!;

    public string name { get; set; } = null!;

    public virtual ICollection<Medicine> Medicines { get; set; } = new List<Medicine>();
}
