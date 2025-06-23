using System;
using System.Collections.Generic;

namespace WebApplication123.Data.Entities;

public partial class Leavetype
{
    public int Leavetypeid { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Leaverequest> Leaverequests { get; set; } = new List<Leaverequest>();
}
