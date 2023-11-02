using System;
using System.Collections.Generic;

namespace DevApiHobby.Models;

public partial class Comment
{
    public int Id { get; set; }

    public string MemberId { get; set; } = null!;

    public string ActivityId { get; set; } = null!;

    public string? Comment1 { get; set; }

    public string CommentIdentity { get; set; } = null!;

    public int? Fraction { get; set; }

    public DateTime EvaluationTime { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
