using System;
using System.Collections.Generic;

namespace DevApiHobby.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? TypeName { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();
}
