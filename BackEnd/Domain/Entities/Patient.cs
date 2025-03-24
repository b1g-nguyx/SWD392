using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Patient
{
    public string patientCode { get; set; } = null!;

    public int userId { get; set; }

    public string? fullname { get; set; }

    public string? gender { get; set; }

    public string? phone { get; set; }

    public string? address { get; set; }

    public DateOnly? dob { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();

    public virtual User user { get; set; } = null!;
}
