﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmithSwimmingSchoolApp.Data;

#nullable disable

namespace SmithSwimmingSchoolApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241219185724_AddDateReport")]
    partial class AddDateReport
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SmithSwimmingSchoolApp.Models.Coach", b =>
                {
                    b.Property<int>("CoachId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoachId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone_Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoachId");

                    b.ToTable("Coaches");

                    b.HasData(
                        new
                        {
                            CoachId = 1,
                            Email = "jose.garcia@ejemplo.com",
                            Name = "José García",
                            Phone_Number = "1234567890"
                        },
                        new
                        {
                            CoachId = 2,
                            Email = "maria.perez@ejemplo.com",
                            Name = "María Pérez",
                            Phone_Number = "9876543210"
                        },
                        new
                        {
                            CoachId = 3,
                            Email = "carlos.sanchez@ejemplo.com",
                            Name = "Carlos Sánchez",
                            Phone_Number = "2223334444"
                        },
                        new
                        {
                            CoachId = 4,
                            Email = "laura.martinez@ejemplo.com",
                            Name = "Laura Martínez",
                            Phone_Number = "5556667777"
                        },
                        new
                        {
                            CoachId = 5,
                            Email = "miguel.hernandez@ejemplo.com",
                            Name = "Miguel Hernández",
                            Phone_Number = "8889990000"
                        },
                        new
                        {
                            CoachId = 6,
                            Email = "sofia.lopez@ejemplo.com",
                            Name = "Sofía López",
                            Phone_Number = "1112223333"
                        });
                });

            modelBuilder.Entity("SmithSwimmingSchoolApp.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<int?>("CoachId")
                        .HasColumnType("int");

                    b.Property<int>("Places")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CourseId");

                    b.HasIndex("CoachId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CoachId = 1,
                            Places = 10,
                            Title = "Braza"
                        },
                        new
                        {
                            CourseId = 2,
                            CoachId = 2,
                            Places = 15,
                            Title = "Flotación y Propulsión"
                        },
                        new
                        {
                            CourseId = 3,
                            CoachId = 3,
                            Places = 12,
                            Title = "Mariposa"
                        },
                        new
                        {
                            CourseId = 4,
                            CoachId = 4,
                            Places = 18,
                            Title = "Crol"
                        },
                        new
                        {
                            CourseId = 5,
                            CoachId = 5,
                            Places = 8,
                            Title = "Resistencia en Aguas Abiertas"
                        },
                        new
                        {
                            CourseId = 6,
                            CoachId = 6,
                            Places = 20,
                            Title = "Técnica de Espalda"
                        });
                });

            modelBuilder.Entity("SmithSwimmingSchoolApp.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("SwimmerId")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("GroupId");

                    b.HasIndex("SwimmerId");

                    b.ToTable("Enrollments");

                    b.HasData(
                        new
                        {
                            EnrollmentId = 1,
                            CourseId = 1,
                            GroupId = 1,
                            SwimmerId = 1
                        },
                        new
                        {
                            EnrollmentId = 2,
                            CourseId = 1,
                            GroupId = 2,
                            SwimmerId = 2
                        },
                        new
                        {
                            EnrollmentId = 3,
                            CourseId = 2,
                            GroupId = 3,
                            SwimmerId = 3
                        },
                        new
                        {
                            EnrollmentId = 4,
                            CourseId = 2,
                            GroupId = 4,
                            SwimmerId = 4
                        },
                        new
                        {
                            EnrollmentId = 5,
                            CourseId = 3,
                            GroupId = 5,
                            SwimmerId = 5
                        },
                        new
                        {
                            EnrollmentId = 6,
                            CourseId = 3,
                            GroupId = 6,
                            SwimmerId = 6
                        },
                        new
                        {
                            EnrollmentId = 7,
                            CourseId = 4,
                            GroupId = 7,
                            SwimmerId = 7
                        },
                        new
                        {
                            EnrollmentId = 8,
                            CourseId = 4,
                            GroupId = 8,
                            SwimmerId = 8
                        });
                });

            modelBuilder.Entity("SmithSwimmingSchoolApp.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"));

                    b.Property<DateTime?>("End_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("Start_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            End_Date = new DateTime(2025, 1, 8, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7130),
                            Level = 1,
                            Name = "Braza Mañana",
                            Start_Date = new DateTime(2024, 12, 9, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7082)
                        },
                        new
                        {
                            GroupId = 2,
                            End_Date = new DateTime(2025, 1, 13, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7135),
                            Level = 2,
                            Name = "Braza Tarde",
                            Start_Date = new DateTime(2024, 12, 14, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7133)
                        },
                        new
                        {
                            GroupId = 3,
                            End_Date = new DateTime(2025, 1, 10, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7140),
                            Level = 1,
                            Name = "Flotación y Propulsión Mañana",
                            Start_Date = new DateTime(2024, 12, 11, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7138)
                        },
                        new
                        {
                            GroupId = 4,
                            End_Date = new DateTime(2025, 1, 16, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7143),
                            Level = 3,
                            Name = "Flotación y Propulsión Tarde",
                            Start_Date = new DateTime(2024, 12, 17, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7141)
                        },
                        new
                        {
                            GroupId = 5,
                            End_Date = new DateTime(2025, 1, 18, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7146),
                            Level = 1,
                            Name = "Mariposa Mañana",
                            Start_Date = new DateTime(2024, 12, 19, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7145)
                        },
                        new
                        {
                            GroupId = 6,
                            End_Date = new DateTime(2025, 1, 21, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7150),
                            Level = 2,
                            Name = "Mariposa Tarde",
                            Start_Date = new DateTime(2024, 12, 22, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7148)
                        },
                        new
                        {
                            GroupId = 7,
                            End_Date = new DateTime(2025, 1, 19, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7153),
                            Level = 2,
                            Name = "Crol Mañana",
                            Start_Date = new DateTime(2024, 12, 20, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7152)
                        },
                        new
                        {
                            GroupId = 8,
                            End_Date = new DateTime(2025, 1, 25, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7156),
                            Level = 3,
                            Name = "Crol Tarde",
                            Start_Date = new DateTime(2024, 12, 26, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7155)
                        });
                });

            modelBuilder.Entity("SmithSwimmingSchoolApp.Models.Report", b =>
                {
                    b.Property<int>("ReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportId"));

                    b.Property<string>("Content")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("EnrollmentId")
                        .HasColumnType("int");

                    b.HasKey("ReportId");

                    b.HasIndex("EnrollmentId");

                    b.ToTable("Reports");

                    b.HasData(
                        new
                        {
                            ReportId = 1,
                            Content = "Buen progreso, ¡sigue practicando!",
                            Date = new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentId = 1
                        },
                        new
                        {
                            ReportId = 2,
                            Content = "Necesita mejorar la técnica, se requiere más práctica.",
                            Date = new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentId = 2
                        },
                        new
                        {
                            ReportId = 3,
                            Content = "Excelente avance en el curso, sigue así.",
                            Date = new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentId = 3
                        },
                        new
                        {
                            ReportId = 4,
                            Content = "Algunos problemas con la flotación, se recomienda reforzar.",
                            Date = new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentId = 3
                        },
                        new
                        {
                            ReportId = 5,
                            Content = "Gran desempeño en las clases, buen trabajo.",
                            Date = new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentId = 4
                        },
                        new
                        {
                            ReportId = 6,
                            Content = "Dificultades en la técnica de brazada, trabajar en ello.",
                            Date = new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentId = 5
                        },
                        new
                        {
                            ReportId = 7,
                            Content = "Muestra mejoría constante en las sesiones.",
                            Date = new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentId = 5
                        },
                        new
                        {
                            ReportId = 8,
                            Content = "Progreso notable en el nado mariposa.",
                            Date = new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentId = 6
                        },
                        new
                        {
                            ReportId = 9,
                            Content = "Problemas menores con la técnica, mejorar coordinación.",
                            Date = new DateTime(2024, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentId = 7
                        },
                        new
                        {
                            ReportId = 10,
                            Content = "Desempeño sobresaliente, excelente actitud.",
                            Date = new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentId = 8
                        });
                });

            modelBuilder.Entity("SmithSwimmingSchoolApp.Models.Swimmer", b =>
                {
                    b.Property<int>("SwimmerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SwimmerId"));

                    b.Property<DateTime?>("Birth_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone_Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SwimmerId");

                    b.ToTable("Swimmers");

                    b.HasData(
                        new
                        {
                            SwimmerId = 1,
                            Birth_Date = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "juanperez@ejemplo.com",
                            Genre = 1,
                            Name = "Juan Pérez",
                            Phone_Number = "555123456"
                        },
                        new
                        {
                            SwimmerId = 2,
                            Birth_Date = new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "anagomez@ejemplo.com",
                            Genre = 2,
                            Name = "Ana Gómez",
                            Phone_Number = "555654321"
                        },
                        new
                        {
                            SwimmerId = 3,
                            Birth_Date = new DateTime(1988, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "luis.fernandez@ejemplo.com",
                            Genre = 1,
                            Name = "Luis Fernández",
                            Phone_Number = "444555666"
                        },
                        new
                        {
                            SwimmerId = 4,
                            Birth_Date = new DateTime(2002, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "maria.torres@ejemplo.com",
                            Genre = 2,
                            Name = "María Torres",
                            Phone_Number = "777888999"
                        },
                        new
                        {
                            SwimmerId = 5,
                            Birth_Date = new DateTime(1999, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "carlos.ruiz@ejemplo.com",
                            Genre = 1,
                            Name = "Carlos Ruiz",
                            Phone_Number = "888777666"
                        },
                        new
                        {
                            SwimmerId = 6,
                            Birth_Date = new DateTime(1996, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lucia.ramirez@ejemplo.com",
                            Genre = 2,
                            Name = "Lucía Ramírez",
                            Phone_Number = "333444555"
                        },
                        new
                        {
                            SwimmerId = 7,
                            Birth_Date = new DateTime(1985, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "pedro.gutierrez@ejemplo.com",
                            Genre = 1,
                            Name = "Pedro Gutiérrez",
                            Phone_Number = "111222444"
                        },
                        new
                        {
                            SwimmerId = 8,
                            Birth_Date = new DateTime(1994, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sofia.moreno@ejemplo.com",
                            Genre = 2,
                            Name = "Sofía Moreno",
                            Phone_Number = "555666888"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmithSwimmingSchoolApp.Models.Course", b =>
                {
                    b.HasOne("SmithSwimmingSchoolApp.Models.Coach", "Coach")
                        .WithMany("Courses")
                        .HasForeignKey("CoachId");

                    b.Navigation("Coach");
                });

            modelBuilder.Entity("SmithSwimmingSchoolApp.Models.Enrollment", b =>
                {
                    b.HasOne("SmithSwimmingSchoolApp.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmithSwimmingSchoolApp.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("SmithSwimmingSchoolApp.Models.Swimmer", "Swimmer")
                        .WithMany("Enrollments")
                        .HasForeignKey("SwimmerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Group");

                    b.Navigation("Swimmer");
                });

            modelBuilder.Entity("SmithSwimmingSchoolApp.Models.Report", b =>
                {
                    b.HasOne("SmithSwimmingSchoolApp.Models.Enrollment", "Enrollment")
                        .WithMany("Reports")
                        .HasForeignKey("EnrollmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enrollment");
                });

            modelBuilder.Entity("SmithSwimmingSchoolApp.Models.Coach", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("SmithSwimmingSchoolApp.Models.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("SmithSwimmingSchoolApp.Models.Enrollment", b =>
                {
                    b.Navigation("Reports");
                });

            modelBuilder.Entity("SmithSwimmingSchoolApp.Models.Swimmer", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
