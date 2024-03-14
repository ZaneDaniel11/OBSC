using System;
using System.Collections.Generic;

namespace OBSC.Entities;

public partial class AdminTb
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;
}
