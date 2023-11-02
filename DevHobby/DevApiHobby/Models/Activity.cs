using System;
using System.Collections.Generic;

namespace DevApiHobby.Models;

public partial class Activity
{
    public string Id { get; set; } = null!;

    public string MemberId { get; set; } = null!;

    public int CategoryId { get; set; }

    public int ActivityImageId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime? ActivityDeadline { get; set; }

    public string ActivityLocation { get; set; } = null!;

    public string CategoryCity { get; set; } = null!;

    public string CategoryArea { get; set; } = null!;

    public string ActivityNotes { get; set; } = null!;

    public int? MaxPeople { get; set; }

    public int? CurrentPeople { get; set; }

    public decimal JoinFee { get; set; }

    public string Payment { get; set; } = null!;

    public virtual ActivityImage ActivityImage { get; set; } = null!;

    public virtual ICollection<ActivityUser> ActivityUsers { get; set; } = new List<ActivityUser>();

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Wish> Wishes { get; set; } = new List<Wish>();
}
