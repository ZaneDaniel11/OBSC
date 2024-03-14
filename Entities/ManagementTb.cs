using System;
using System.Collections.Generic;

namespace OBSC.Entities;

public partial class ManagementTb
{
    public int Id { get; set; }

    public int BusNo { get; set; }

    public string TimeDept { get; set; } = null!;

    public string RouteDestination { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public int CorNumber { get; set; }

    public int PassTicket { get; set; }

    public int BaggTicket { get; set; }

    public int Passenger { get; set; }

    public string DriversName { get; set; } = null!;

    public string ConductorsName { get; set; } = null!;
}
