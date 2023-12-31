﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DevApiHobby.Models;

public partial class _94hobbyContext : DbContext
{
    public _94hobbyContext()
    {
    }

    public _94hobbyContext(DbContextOptions<_94hobbyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<ActivityImage> ActivityImages { get; set; }

    public virtual DbSet<ActivityUser> ActivityUsers { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<MsgBoard> MsgBoards { get; set; }

    public virtual DbSet<Wish> Wishes { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-LOUR863;Initial Catalog=94Hobby;Integrated Security=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Activity__3214EC27A137FA30");

            entity.ToTable("Activity");

            entity.Property(e => e.Id)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.ActivityDeadline).HasColumnType("datetime");
            entity.Property(e => e.ActivityImageId).HasColumnName("ActivityImageID");
            entity.Property(e => e.ActivityLocation)
                .HasMaxLength(70)
                .IsFixedLength();
            entity.Property(e => e.ActivityNotes)
                .HasMaxLength(1000)
                .IsFixedLength();
            entity.Property(e => e.CategoryArea)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("categoryArea");
            entity.Property(e => e.CategoryCity)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("categoryCity");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.JoinFee).HasColumnType("money");
            entity.Property(e => e.MemberId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("MemberID");
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.Payment)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.HasOne(d => d.ActivityImage).WithMany(p => p.Activities)
                .HasForeignKey(d => d.ActivityImageId)
                .HasConstraintName("FK_Activity_ActivityImage");

            entity.HasOne(d => d.Category).WithMany(p => p.Activities)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Activity_Category");
        });

        modelBuilder.Entity<ActivityImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Activity__3214EC27C658CCDD");

            entity.ToTable("ActivityImage");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ActivityID");
            entity.Property(e => e.ActivityImage1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ActivityImage");
            entity.Property(e => e.IsCover).HasColumnName("isCover");
            entity.Property(e => e.UploadTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ActivityUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Activity__3214EC271CA12E97");

            entity.ToTable("ActivityUser");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ActivityID");
            entity.Property(e => e.MemberId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("MemberID");
            entity.Property(e => e.ReviewStatus)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Role)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.Activity).WithMany(p => p.ActivityUsers)
                .HasForeignKey(d => d.ActivityId)
                .HasConstraintName("FK_ActivityUser_Activity");

            entity.HasOne(d => d.Member).WithMany(p => p.ActivityUsers)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_ActivityUser_Member");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3214EC27710BE2D4");

            entity.ToTable("Category");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(10);
            entity.Property(e => e.TypeName).HasMaxLength(5);
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comment__3214EC27F8A5A489");

            entity.ToTable("Comment");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ActivityID");
            entity.Property(e => e.Comment1)
                .HasMaxLength(255)
                .HasColumnName("Comment");
            entity.Property(e => e.CommentIdentity)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.EvaluationTime).HasColumnType("datetime");
            entity.Property(e => e.MemberId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("MemberID");

            entity.HasOne(d => d.Activity).WithMany(p => p.Comments)
                .HasForeignKey(d => d.ActivityId)
                .HasConstraintName("FK_Comment_Activity");

            entity.HasOne(d => d.Member).WithMany(p => p.Comments)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_Comment_Member");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Member__3214EC27FC0CDA80");

            entity.ToTable("Member");

            entity.Property(e => e.Id)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Account)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AcitveCity).HasMaxLength(14);
            entity.Property(e => e.ActiveArea).HasMaxLength(20);
            entity.Property(e => e.Address).HasMaxLength(70);
            entity.Property(e => e.Birthdaty).HasColumnType("date");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Gender)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.HeadShot)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.IdentityCard)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastSignIn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(16);
            entity.Property(e => e.NickName).HasMaxLength(16);
            entity.Property(e => e.OnlineStatus)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PassWord).HasMaxLength(8);
            entity.Property(e => e.PersonalProfile).HasMaxLength(300);
            entity.Property(e => e.Phone)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MsgBoard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MsgBoard__3214EC27997DC6D5");

            entity.ToTable("MsgBoard");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ActivityID");
            entity.Property(e => e.MemberId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("MemberID");
            entity.Property(e => e.MessageText).HasMaxLength(500);
            entity.Property(e => e.MessageTime).HasColumnType("datetime");

            entity.HasOne(d => d.Member).WithMany(p => p.MsgBoards)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_MsgBoard_Member");
        });

        modelBuilder.Entity<Wish>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Wish__3214EC279CAA0E2B");

            entity.ToTable("Wish");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ActivityID");
            entity.Property(e => e.AddTime).HasColumnType("datetime");
            entity.Property(e => e.MemberId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("MemberID");

            entity.HasOne(d => d.Activity).WithMany(p => p.Wishes)
                .HasForeignKey(d => d.ActivityId)
                .HasConstraintName("FK_Wish_Activity");

            entity.HasOne(d => d.Member).WithMany(p => p.Wishes)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_Wish_Member");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
