using System;
using System.Collections.Generic;

namespace DevApiHobby.Models;

public partial class ActivityUser
{
    public int Id { get; set; }

    public string MemberId { get; set; } = null!;

    public string ActivityId { get; set; } = null!;

    public string ReviewStatus { get; set; } = null!;

    public string Role { get; set; } = null!;

    public virtual Activity Activity { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
