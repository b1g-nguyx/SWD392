using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MedicalRecordDetail
{
    public string recordDetailCode { get; set; } = null!;

    public string? appointmentCode { get; set; }

    public string recordCode { get; set; } = null!;

    public string? doctorCode { get; set; }

    public string? result { get; set; }

    public virtual Appointment? appointmentCodeNavigation { get; set; }

    public virtual Doctor? doctorCodeNavigation { get; set; }

    public virtual MedicalRecord recordCodeNavigation { get; set; } = null!;
}
