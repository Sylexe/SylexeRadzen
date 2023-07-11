﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SylexeRadzen.SQLManagement.Context;

#nullable disable

namespace SylexeRadzen.Migrations
{
    [DbContext(typeof(SylexeDB))]
    partial class SylexeDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("SylexeRadzen.SQLManagement.Definitions.SylexeReports", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Timestamp")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("sylexeReports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Aquasec",
                            Path = "rat.json",
                            Timestamp = "aquasec-trivy_0.34.0-05-juillet-2023-14_36_55"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
