using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MedicalRecord
{
    public string recordCode { get; set; } = null!;

    public string patientCode { get; set; } = null!;

    public DateTime? createdAt { get; set; }

    public virtual ICollection<MedicalRecordDetail> MedicalRecordDetails { get; set; } = new List<MedicalRecordDetail>();

    public virtual Patient patientCodeNavigation { get; set; } = null!;
}
