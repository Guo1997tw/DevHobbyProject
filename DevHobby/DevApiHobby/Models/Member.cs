﻿using System;
using System.Collections.Generic;

namespace DevApiHobby.Models;

public partial class Member
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? NickName { get; set; }

    public string? Gender { get; set; }

    public string? Account { get; set; }

    public byte[]? PassWord { get; set; }

    public string? IdentityCard { get; set; }

    public DateTime? Birthdaty { get; set; }

    public string? Address { get; set; }

    public string? AcitveCity { get; set; }

    public string? ActiveArea { get; set; }

    public string? Phone { get; set; }

    public string? HeadShot { get; set; }

    public string? PersonalProfile { get; set; }

    public string? Status { get; set; }

    public string? OnlineStatus { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? LastSignIn { get; set; }

    public virtual ICollection<ActivityUser> ActivityUsers { get; set; } = new List<ActivityUser>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<MsgBoard> MsgBoards { get; set; } = new List<MsgBoard>();

    public virtual ICollection<Wish> Wishes { get; set; } = new List<Wish>();
}
