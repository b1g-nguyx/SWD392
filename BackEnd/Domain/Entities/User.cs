using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class User
{
    public int id { get; set; }

    public string username { get; set; } = null!;

    public string password { get; set; } = null!;

    public string email { get; set; } = null!;

    public string? fullname { get; set; }

    public string? gender { get; set; }

    public string? phone { get; set; }

    public virtual Admin? Admin { get; set; }

    public virtual Doctor? Doctor { get; set; }

    public virtual Patient? Patient { get; set; }

    public virtual Receptionist? Receptionist { get; set; }
}
