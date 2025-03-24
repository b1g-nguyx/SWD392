using System;
using System.Collections.Generic;

namespace  Domain.Entities;

public partial class Appointment
{
    public string appointmentCode { get; set; } = null!;

    public string? doctorCode { get; set; }

    public string? patientCode { get; set; }

    public string? scheduleCode { get; set; }

    public string status { get; set; } = null!;

    public virtual ICollection<MedicalRecordDetail> MedicalRecordDetails { get; set; } = new List<MedicalRecordDetail>();

    public virtual Doctor? doctorCodeNavigation { get; set; }

    public virtual Patient? patientCodeNavigation { get; set; }

    public virtual ScheduleDetail? scheduleCodeNavigation { get; set; }
}
