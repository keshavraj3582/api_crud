using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace web_api_crud.Models;


public partial class ApiStudentDatabaseContext : DbContext
{
    public ApiStudentDatabaseContext()
    {
    }

    public ApiStudentDatabaseContext(DbContextOptions<ApiStudentDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            
        }

    }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__student__A2F4E9AC8244BD15");

            entity.ToTable("student");

            entity.Property(e => e.StudentId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Student_ID");
            entity.Property(e => e.Class)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("gender");
            entity.Property(e => e.GradeId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GradeID");
            entity.Property(e => e.NationalIty)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NationalITy");
            entity.Property(e => e.ParentAnsweringSurvey)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ParentschoolSatisfaction)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PlaceofBirth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Raisedhands).HasColumnName("raisedhands");
            entity.Property(e => e.Relation)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SectionId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SectionID");
            entity.Property(e => e.Semester)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StageId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("StageID");
            entity.Property(e => e.StudentAbsenceDays)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StudentMarks).HasColumnName("Student_Marks");
            entity.Property(e => e.Topic)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VisItedResources).HasColumnName("VisITedResources");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
