using System;
using System.Collections.Generic;

namespace DevApiHobby.Models;

public partial class MsgBoard
{
    public int Id { get; set; }

    public string MemberId { get; set; } = null!;

    public string ActivityId { get; set; } = null!;

    public string MessageText { get; set; } = null!;

    public DateTime MessageTime { get; set; }

    public virtual Member Member { get; set; } = null!;
}
