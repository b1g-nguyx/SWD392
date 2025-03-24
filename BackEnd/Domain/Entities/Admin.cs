using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Admin
{
    public string adminCode { get; set; } = null!;

    public int userId { get; set; }

    public virtual User user { get; set; } = null!;
}
