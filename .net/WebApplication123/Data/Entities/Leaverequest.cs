using System;
using System.Collections.Generic;

namespace WebApplication123.Data.Entities;

public partial class Leaverequest
{
    public int Leaverequestid { get; set; }

    public int? Userid { get; set; }

    public int? Leavetypeid { get; set; }

    public DateOnly Startdate { get; set; }

    public DateOnly Enddate { get; set; }

    public string? Reason { get; set; }

    public string? Status { get; set; }

    public int? Managerid { get; set; }

    public DateTime? Requestedon { get; set; }

    public virtual Leavetype? Leavetype { get; set; }

    public virtual User? Manager { get; set; }

    public virtual User? User { get; set; }
}
