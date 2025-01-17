﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScoreBoard.Data;

#nullable disable

namespace ScoreBoard.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240816081439_AddDataSeed")]
    partial class AddDataSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ScoreBoard.Models.ApplicationUser", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("ApplicationUsers");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Birthday = new DateTime(2002, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Lê Đức Tài",
                            PhoneNumber = 1234567890
                        },
                        new
                        {
                            UserId = 2,
                            Birthday = new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = false,
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Trần Văn A",
                            PhoneNumber = 1234567891
                        },
                        new
                        {
                            UserId = 3,
                            Birthday = new DateTime(1999, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Nguyễn Thị C",
                            PhoneNumber = 1234567892
                        });
                });

            modelBuilder.Entity("ScoreBoard.Models.Score", b =>
                {
                    b.Property<int>("ScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScoreId"));

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserScore")
                        .HasColumnType("int");

                    b.HasKey("ScoreId");

                    b.HasIndex("UserId");

                    b.ToTable("Scores");

                    b.HasData(
                        new
                        {
                            ScoreId = 1,
                            Month = 8,
                            UserId = 1,
                            UserScore = 2
                        },
                        new
                        {
                            ScoreId = 2,
                            Month = 9,
                            UserId = 1,
                            UserScore = 3
                        },
                        new
                        {
                            ScoreId = 3,
                            Month = 8,
                            UserId = 2,
                            UserScore = 4
                        },
                        new
                        {
                            ScoreId = 4,
                            Month = 9,
                            UserId = 2,
                            UserScore = 5
                        },
                        new
                        {
                            ScoreId = 5,
                            Month = 8,
                            UserId = 3,
                            UserScore = 0
                        },
                        new
                        {
                            ScoreId = 6,
                            Month = 9,
                            UserId = 3,
                            UserScore = 1
                        });
                });

            modelBuilder.Entity("ScoreBoard.Models.Score", b =>
                {
                    b.HasOne("ScoreBoard.Models.ApplicationUser", "User")
                        .WithMany("Scores")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ScoreBoard.Models.ApplicationUser", b =>
                {
                    b.Navigation("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}
