using System;
using System.Collections.Generic;

namespace OBSC.Entities;

public partial class ArrivalTb
{
    public int Id { get; set; }

    public int BusNo { get; set; }

    public string Unit { get; set; } = null!;

    public string DeparturedTime { get; set; } = null!;

    public string RouteDestination { get; set; } = null!;
}
