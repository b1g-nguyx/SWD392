using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Receptionist
{
    public string receptionistCode { get; set; } = null!;

    public int userId { get; set; }

    public string? address { get; set; }

    public DateOnly? dob { get; set; }

    public virtual User user { get; set; } = null!;
}
