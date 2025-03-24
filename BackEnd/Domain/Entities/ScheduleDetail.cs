using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ScheduleDetail
{
    public string scheduleCode { get; set; } = null!;

    public string? doctorCode { get; set; }

    public DateOnly appointmentDate { get; set; }

    public TimeOnly appointmentTime { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual Doctor? doctorCodeNavigation { get; set; }
}
