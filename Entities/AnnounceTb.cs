using System;
using System.Collections.Generic;

namespace OBSC.Entities;

public partial class AnnounceTb
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime Date { get; set; }
}
