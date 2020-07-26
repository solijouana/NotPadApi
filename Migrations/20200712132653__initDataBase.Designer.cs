﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotePad_api.Models;

namespace NotePad_api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200712132653__initDataBase")]
    partial class _initDataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NotePad_api.Models.Note", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("sync")
                        .HasColumnType("bit");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            CreateDate = new DateTime(2020, 7, 12, 17, 56, 53, 219, DateTimeKind.Local).AddTicks(6343),
                            note = "note sample 1",
                            sync = false,
                            title = "note 1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
