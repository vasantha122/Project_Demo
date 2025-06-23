using System;
using System.Collections.Generic;

namespace WebApplication123.Data.Entities;

public partial class User
{
    public int Userid { get; set; }

    public string? Fullname { get; set; }

    public string Email { get; set; } = null!;

    public string? Passwordhash { get; set; }

    public int Roleid { get; set; }

    public virtual ICollection<Leaverequest> LeaverequestManagers { get; set; } = new List<Leaverequest>();

    public virtual ICollection<Leaverequest> LeaverequestUsers { get; set; } = new List<Leaverequest>();

    public virtual Role Role { get; set; } = null!;
}
