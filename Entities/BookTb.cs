using System;
using System.Collections.Generic;

namespace OBSC.Entities;

public partial class BookTb
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public string RouteDestination { get; set; } = null!;
}
