﻿// <auto-generated />
using App;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210701155028_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("App.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CourseName")
                        .HasColumnType("TEXT");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("grade")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Cooking With Gas",
                            StudentId = 1,
                            grade = 0.69999999999999996
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Cooking With Gas",
                            StudentId = 2,
                            grade = 0.89000000000000001
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Cooking With Gas",
                            StudentId = 3,
                            grade = 0.75
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Wood Shop",
                            StudentId = 3,
                            grade = 0.75
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "Data Base Design",
                            StudentId = 3,
                            grade = 0.75
                        },
                        new
                        {
                            Id = 6,
                            CourseName = "Introduction to C# ",
                            StudentId = 3,
                            grade = 0.75
                        });
                });

            modelBuilder.Entity("App.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClassOf")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 13,
                            ClassOf = 0,
                            FirstName = "Laurie",
                            LastName = "Logger"
                        },
                        new
                        {
                            Id = 2,
                            Age = 15,
                            ClassOf = 1,
                            FirstName = "Margert",
                            LastName = "Mury"
                        },
                        new
                        {
                            Id = 3,
                            Age = 16,
                            ClassOf = 2,
                            FirstName = "Peter",
                            LastName = "Piemont"
                        },
                        new
                        {
                            Id = 4,
                            Age = 17,
                            ClassOf = 3,
                            FirstName = "Frank",
                            LastName = "Folly"
                        });
                });

            modelBuilder.Entity("App.Grade", b =>
                {
                    b.HasOne("App.Student", null)
                        .WithMany("classGrade")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("App.Student", b =>
                {
                    b.Navigation("classGrade");
                });
#pragma warning restore 612, 618
        }
    }
}