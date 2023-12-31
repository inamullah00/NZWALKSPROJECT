﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RESTAPI.Data;

#nullable disable

namespace RESTAPI.Migrations.NZWalksDb
{
    [DbContext(typeof(NZWalksDbContext))]
    partial class NZWalksDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RESTAPI.Models.Domain.Difficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2126ddec-1c42-454a-ade8-6a96df39bbba"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("43fcfd58-1b65-4ef0-8379-05131d3f7225"),
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("4932477d-cacf-4023-8109-d55e4a2b55cd"),
                            Name = "Hard"
                        });
                });

            modelBuilder.Entity("RESTAPI.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0986b9f2-dbea-4a16-8419-476f2207c0f5"),
                            Code = "AKL",
                            Name = "IRLAND REGION",
                            RegionImageUrl = "Some_image.jpg"
                        },
                        new
                        {
                            Id = new Guid("d8e9586b-ba4c-42f1-8bd4-9066bf70bae0"),
                            Code = "DBI",
                            Name = "DUBAI REGION",
                            RegionImageUrl = "Some_image.jpg"
                        },
                        new
                        {
                            Id = new Guid("d8770156-0b55-4700-849a-b8713d9b2731"),
                            Code = "IRL",
                            Name = "ILAND STREET REGION",
                            RegionImageUrl = "Some_image.jpg"
                        });
                });

            modelBuilder.Entity("RESTAPI.Models.Domain.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("LengthInKm")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalkImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("RESTAPI.Models.Domain.Walk", b =>
                {
                    b.HasOne("RESTAPI.Models.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RESTAPI.Models.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
