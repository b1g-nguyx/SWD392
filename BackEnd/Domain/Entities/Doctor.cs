using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Doctor
{
    public string doctorCode { get; set; } = null!;

    public int userId { get; set; }

    public string? departmentCode { get; set; }

    public string? symptomSupport { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<MedicalRecordDetail> MedicalRecordDetails { get; set; } = new List<MedicalRecordDetail>();

    public virtual ICollection<ScheduleDetail> ScheduleDetails { get; set; } = new List<ScheduleDetail>();

    public virtual Department? departmentCodeNavigation { get; set; }

    public virtual User user { get; set; } = null!;
}
