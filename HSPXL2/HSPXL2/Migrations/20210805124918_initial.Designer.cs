﻿// <auto-generated />
using System;
using HSPXL2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HSPXL2.Migrations
{
    [DbContext(typeof(HSContext))]
    [Migration("20210805124918_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HSPXL2.Entities.Cursus", b =>
                {
                    b.Property<long>("CursusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CursusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HandboekID")
                        .HasColumnType("int");

                    b.Property<int>("Studiepunten")
                        .HasColumnType("int");

                    b.HasKey("CursusID");

                    b.HasIndex("HandboekID");

                    b.ToTable("Cursus");
                });

            modelBuilder.Entity("HSPXL2.Entities.Handboek", b =>
                {
                    b.Property<int>("HandboekID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Afbeelding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CursusID")
                        .HasColumnType("bigint");

                    b.Property<decimal>("KostPrijs")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("UitgiftDatum")
                        .HasColumnType("datetime2");

                    b.HasKey("HandboekID");

                    b.HasIndex("CursusID");

                    b.ToTable("Handboeks");
                });

            modelBuilder.Entity("HSPXL2.Entities.Inschrijving", b =>
                {
                    b.Property<int>("InschrijvingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CursusID")
                        .HasColumnType("bigint");

                    b.Property<long>("StudentID")
                        .HasColumnType("bigint");

                    b.HasKey("InschrijvingID");

                    b.HasIndex("CursusID");

                    b.HasIndex("StudentID");

                    b.ToTable("Inschrijvings");
                });

            modelBuilder.Entity("HSPXL2.Entities.Student", b =>
                {
                    b.Property<long>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("HSPXL2.Entities.Cursus", b =>
                {
                    b.HasOne("HSPXL2.Entities.Handboek", "handboek")
                        .WithMany()
                        .HasForeignKey("HandboekID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HSPXL2.Entities.Handboek", b =>
                {
                    b.HasOne("HSPXL2.Entities.Cursus", null)
                        .WithMany("HandBoeken")
                        .HasForeignKey("CursusID");
                });

            modelBuilder.Entity("HSPXL2.Entities.Inschrijving", b =>
                {
                    b.HasOne("HSPXL2.Entities.Cursus", "Cursus")
                        .WithMany()
                        .HasForeignKey("CursusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HSPXL2.Entities.Student", "Student")
                        .WithMany("Inschrijvings")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}