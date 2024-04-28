using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Students.Common.Models;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;

namespace Students.Common.Data;

public class StudentsContext : DbContext
{
    public StudentsContext(DbContextOptions<StudentsContext> options)
        : base(options)
    {
    }
    public DbSet<Lecturer> Lecturer { get; set; }
    public DbSet<LecturerSubject> LecturerSubject { get; set; }


    public DbSet<Subject> Subject { get; set; } = default!;
    public DbSet<Student> Student { get; set; } = default!;
    public DbSet<StudentSubject> StudentSubject { get; set; } = default!;


    public DbSet<LectureHall> LectureHall { get; set; } = default!;
    public DbSet<LectureHallSubject> LectureHallSubject { get; set; } = default!;


    public DbSet<Book> Book { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        #region StudentSubject

        modelBuilder.Entity<StudentSubject>()
            .HasKey(ss => new { ss.StudentId, ss.SubjectId });

        modelBuilder.Entity<StudentSubject>()
            .HasOne(ss => ss.Student)
            .WithMany(s => s.StudentSubjects)
            .HasForeignKey(ss => ss.StudentId);

        modelBuilder.Entity<StudentSubject>()
            .HasOne(ss => ss.Subject)
            .WithMany(s => s.StudentSubjects)
            .HasForeignKey(ss => ss.SubjectId);

        #endregion


        #region LectureHallSubject

        modelBuilder.Entity<LectureHallSubject>()
            .HasKey(ss => new { ss.LectureHallId, ss.SubjectId });

        modelBuilder.Entity<LectureHallSubject>()
           .HasOne(ls => ls.LectureHall)
           .WithMany(s => s.LectureHallSubjects)
           .HasForeignKey(ls => ls.LectureHallId);

        modelBuilder.Entity<LectureHallSubject>()
            .HasOne(ls => ls.Subject)
            .WithMany(s => s.LectureHallSubjects)
            .HasForeignKey(ls => ls.SubjectId);

        #endregion


        #region  LecturerSubject

        modelBuilder.Entity<LecturerSubject>()
           .HasKey(rs => new { rs.LecturerId, rs.SubjectId});

        modelBuilder.Entity<LecturerSubject>()
           .HasOne(rs => rs.Lecturer)
           .WithMany(r => r.LecturerSubjects)
           .HasForeignKey(ls => ls.LecturerId);

        modelBuilder.Entity<LecturerSubject>()
          .HasOne(rs => rs.Subject)
          .WithMany(r => r.LecturerSubjects)
          .HasForeignKey(ls => ls.SubjectId);

        #endregion

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
