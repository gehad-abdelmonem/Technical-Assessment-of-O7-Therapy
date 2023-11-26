﻿// <auto-generated />
using System;
using Hhealth_Blatform.DAL.Data.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hhealth_Blatform.DAL.Migrations
{
    [DbContext(typeof(HealthContext))]
    partial class HealthContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hhealth_Blatform.DAL.Data.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ReferanceNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Hhealth_Blatform.DAL.Data.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<DateTime>("SessionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TherapistId")
                        .HasColumnType("int");

                    b.Property<double>("TherapistRatting")
                        .HasColumnType("float");

                    b.Property<DateTime>("submissionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("TherapistId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("Hhealth_Blatform.DAL.Data.Models.Therapist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Therapists");
                });

            modelBuilder.Entity("Hhealth_Blatform.DAL.Data.Models.Session", b =>
                {
                    b.HasOne("Hhealth_Blatform.DAL.Data.Models.Client", "Client")
                        .WithMany("Sessions")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hhealth_Blatform.DAL.Data.Models.Therapist", "Therapist")
                        .WithMany("Sessions")
                        .HasForeignKey("TherapistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Therapist");
                });

            modelBuilder.Entity("Hhealth_Blatform.DAL.Data.Models.Client", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("Hhealth_Blatform.DAL.Data.Models.Therapist", b =>
                {
                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
