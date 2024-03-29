﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectPowerData;

#nullable disable

namespace ProjectPowerData.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220215231755_UAR")]
    partial class UAR
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjectPowerData.Folder.Models.BasicWorkoutInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("ExerciseCompleted")
                        .HasColumnType("bit");

                    b.Property<int>("ExerciseDay")
                        .HasColumnType("int");

                    b.Property<string>("ExerciseMasterId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExerciseOrder")
                        .HasColumnType("int");

                    b.Property<bool?>("ExerciseTargetCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Template")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Week")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BasicWorkoutInformation", (string)null);

                    b.HasDiscriminator<string>("Template").HasValue("BasicWorkoutInformation");
                });

            modelBuilder.Entity("ProjectPowerData.Folder.Models.UserAccounts", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrentDay")
                        .HasColumnType("int");

                    b.Property<int>("CurrentWeek")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkoutDaysInWeek")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutWeeks")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("ProjectPowerData.Folder.Models.A2SHyperTrophy", b =>
                {
                    b.HasBaseType("ProjectPowerData.Folder.Models.BasicWorkoutInformation");

                    b.Property<int?>("AmrapRepResult")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("AmrapRepTarget")
                        .HasColumnType("int");

                    b.Property<bool>("AuxillaryLift")
                        .HasColumnType("bit");

                    b.Property<string>("Block")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Intensity")
                        .HasPrecision(9, 4)
                        .HasColumnType("decimal(9,4)");

                    b.Property<int>("RepsPerSet")
                        .HasColumnType("int");

                    b.Property<decimal>("RoundingValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Sets")
                        .HasColumnType("int");

                    b.Property<decimal>("TrainingMax")
                        .HasPrecision(9, 4)
                        .HasColumnType("decimal(9,4)");

                    b.Property<decimal?>("WorkingWeight")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("BasicWorkoutInformation", (string)null);

                    b.HasDiscriminator().HasValue("A2SHypertrophy");
                });

            modelBuilder.Entity("ProjectPowerData.Folder.Models.A2SSetsThenReps", b =>
                {
                    b.HasBaseType("ProjectPowerData.Folder.Models.BasicWorkoutInformation");

                    b.Property<int>("CurrentReps")
                        .HasColumnType("int");

                    b.Property<int>("CurrentSets")
                        .HasColumnType("int");

                    b.Property<int>("GoalReps")
                        .HasColumnType("int");

                    b.Property<int>("GoalSets")
                        .HasColumnType("int");

                    b.Property<int>("RepIncreasePerSet")
                        .HasColumnType("int");

                    b.Property<int>("StartingReps")
                        .HasColumnType("int");

                    b.Property<int>("StartingSets")
                        .HasColumnType("int");

                    b.Property<decimal>("StartingWeight")
                        .HasColumnType("decimal(18,2)");

                    b.HasDiscriminator().HasValue("A2SRepsThenSets");
                });
#pragma warning restore 612, 618
        }
    }
}
