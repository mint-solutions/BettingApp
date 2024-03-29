﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ODDESTODDS.Persistence.Context;

namespace ODDESTODDS.Persistence.Migrations
{
    [DbContext(typeof(ApplicatioDBContext))]
    partial class ApplicatioDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("ODDESTODDS.Domain.Entity.GameInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AwayTeam")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("CreateBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<DateTime?>("GameStartTime")
                        .IsRequired();

                    b.Property<int>("GameStatus");

                    b.Property<string>("HomeTeam")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.HasKey("Id");

                    b.ToTable("GameInfo");

                    b.HasData(
                        new { Id = 1L, AwayTeam = "France U21", GameStartTime = new DateTime(2019, 6, 21, 13, 20, 36, 223, DateTimeKind.Local), GameStatus = 1, HomeTeam = "England U21", IsDeleted = false },
                        new { Id = 2L, AwayTeam = "Germany U21", GameStartTime = new DateTime(2019, 6, 21, 13, 20, 36, 228, DateTimeKind.Local), GameStatus = 1, HomeTeam = "USA U21", IsDeleted = false },
                        new { Id = 3L, AwayTeam = "England  U21", GameStartTime = new DateTime(2019, 6, 21, 13, 20, 36, 228, DateTimeKind.Local), GameStatus = 1, HomeTeam = "Denmark  U21", IsDeleted = false }
                    );
                });

            modelBuilder.Entity("ODDESTODDS.Domain.Entity.GameInfo", b =>
                {
                    b.OwnsOne("ODDESTODDS.Domain.Entity.GameOdd", "GameOdd", b1 =>
                        {
                            b1.Property<long>("Id")
                                .ValueGeneratedOnAdd();

                            b1.Property<double>("AwayOdd");

                            b1.Property<string>("CreateBy");

                            b1.Property<DateTime?>("CreatedDate");

                            b1.Property<double>("DrawOdd");

                            b1.Property<long>("GameInfoId");

                            b1.Property<double>("HomeOdd");

                            b1.Property<bool>("IsDeleted");

                            b1.Property<string>("ModifiedBy");

                            b1.Property<DateTime?>("ModifiedDate");

                            b1.Property<int>("OddStatus");

                            b1.HasIndex("GameInfoId")
                                .IsUnique();

                            b1.ToTable("GameOdd");

                            b1.HasOne("ODDESTODDS.Domain.Entity.GameInfo", "GameInfo")
                                .WithOne("GameOdd")
                                .HasForeignKey("ODDESTODDS.Domain.Entity.GameOdd", "GameInfoId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasData(
                                new { Id = 1L, AwayOdd = 3.0, CreatedDate = new DateTime(2019, 6, 21, 13, 20, 36, 257, DateTimeKind.Local), DrawOdd = 14.7, GameInfoId = 1L, HomeOdd = 5.9, IsDeleted = false, OddStatus = 1 },
                                new { Id = 2L, AwayOdd = 3.0, CreatedDate = new DateTime(2019, 6, 21, 13, 20, 36, 257, DateTimeKind.Local), DrawOdd = 14.7, GameInfoId = 2L, HomeOdd = 5.9, IsDeleted = false, OddStatus = 1 },
                                new { Id = 3L, AwayOdd = 3.0, CreatedDate = new DateTime(2019, 6, 21, 13, 20, 36, 257, DateTimeKind.Local), DrawOdd = 14.7, GameInfoId = 3L, HomeOdd = 5.9, IsDeleted = false, OddStatus = 1 }
                            );
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
