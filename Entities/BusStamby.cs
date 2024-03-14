using System;
using System.Collections.Generic;

namespace OBSC.Entities;

public partial class BusStamby
{
    public int Id { get; set; }

    public int BusNo { get; set; }

    public string RouteDestination { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public int CorNumber { get; set; }

    public string DriversName { get; set; } = null!;

    public string ConductorsName { get; set; } = null!;

    public string DepartureTime { get; set; } = null!;
}
