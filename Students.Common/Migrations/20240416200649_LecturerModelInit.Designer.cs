﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Students.Common.Data;

#nullable disable

namespace Students.Common.Migrations
{
    [DbContext(typeof(StudentsContext))]
    [Migration("20240416200649_LecturerModelInit")]
    partial class LecturerModelInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Students.Common.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Students.Common.Models.LectureHall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("LectureHall");
                });

            modelBuilder.Entity("Students.Common.Models.LectureHallSubject", b =>
                {
                    b.Property<int>("LectureHallId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("LectureHallId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("LectureHallSubject");
                });

            modelBuilder.Entity("Students.Common.Models.Lecturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lecturer");
                });

            modelBuilder.Entity("Students.Common.Models.LecturerSubject", b =>
                {
                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("LecturerId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("LecturerSubject");
                });

            modelBuilder.Entity("Students.Common.Models.ResearchArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ResearchArea");
                });

            modelBuilder.Entity("Students.Common.Models.ResearchAreaStudent", b =>
                {
                    b.Property<int>("ResearchAreaId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("ResearchAreaId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("ResearchAreaStudent");
                });

            modelBuilder.Entity("Students.Common.Models.ResearchWorker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ResearchWorker");
                });

            modelBuilder.Entity("Students.Common.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Students.Common.Models.StudentSubject", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentSubject");
                });

            modelBuilder.Entity("Students.Common.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("Students.Common.Models.LectureHallSubject", b =>
                {
                    b.HasOne("Students.Common.Models.LectureHall", "LectureHall")
                        .WithMany("LectureHallSubjects")
                        .HasForeignKey("LectureHallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Students.Common.Models.Subject", "Subject")
                        .WithMany("LectureHallSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LectureHall");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Students.Common.Models.LecturerSubject", b =>
                {
                    b.HasOne("Students.Common.Models.Lecturer", "Lecturer")
                        .WithMany("LecturerSubjects")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Students.Common.Models.Subject", "Subject")
                        .WithMany("LecturerSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecturer");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Students.Common.Models.ResearchAreaStudent", b =>
                {
                    b.HasOne("Students.Common.Models.ResearchArea", "ResearchArea")
                        .WithMany("ResearchAreaStudents")
                        .HasForeignKey("ResearchAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Students.Common.Models.Student", "Student")
                        .WithMany("ResearchAreaStudents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ResearchArea");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Students.Common.Models.Student", b =>
                {
                    b.HasOne("Students.Common.Models.Subject", null)
                        .WithMany("Students")
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("Students.Common.Models.StudentSubject", b =>
                {
                    b.HasOne("Students.Common.Models.Student", "Student")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Students.Common.Models.Subject", "Subject")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Students.Common.Models.LectureHall", b =>
                {
                    b.Navigation("LectureHallSubjects");
                });

            modelBuilder.Entity("Students.Common.Models.Lecturer", b =>
                {
                    b.Navigation("LecturerSubjects");
                });

            modelBuilder.Entity("Students.Common.Models.ResearchArea", b =>
                {
                    b.Navigation("ResearchAreaStudents");
                });

            modelBuilder.Entity("Students.Common.Models.Student", b =>
                {
                    b.Navigation("ResearchAreaStudents");

                    b.Navigation("StudentSubjects");
                });

            modelBuilder.Entity("Students.Common.Models.Subject", b =>
                {
                    b.Navigation("LectureHallSubjects");

                    b.Navigation("LecturerSubjects");

                    b.Navigation("StudentSubjects");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
