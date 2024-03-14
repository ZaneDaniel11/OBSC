using System;
using System.Collections.Generic;

namespace OBSC.Entities;

public partial class LostTb
{
    public int Id { get; set; }

    public int BusNo { get; set; }

    public string DriversName { get; set; } = null!;

    public string ConductorsName { get; set; } = null!;

    public string Item { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Status { get; set; } = null!;

    public int TicketNo { get; set; }
}
