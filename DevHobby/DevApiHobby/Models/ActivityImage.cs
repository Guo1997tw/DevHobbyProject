﻿using System;
using System.Collections.Generic;

namespace DevApiHobby.Models;

public partial class ActivityImage
{
    public int Id { get; set; }

    public string ActivityId { get; set; } = null!;

    public string ActivityImage1 { get; set; } = null!;

    public bool IsCover { get; set; }

    public DateTime UploadTime { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();
}
