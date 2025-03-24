using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Service
{
    public string serviceCode { get; set; } = null!;

    public string title { get; set; } = null!;

    public decimal cost { get; set; }
}
