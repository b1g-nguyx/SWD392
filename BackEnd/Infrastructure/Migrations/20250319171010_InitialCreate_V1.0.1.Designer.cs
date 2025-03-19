﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250319171010_InitialCreate_V1.0.1")]
    partial class InitialCreate_V101
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.MedicalRecord", b =>
                {
                    b.Property<string>("RecordCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("BHYT")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PatientCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecordCode");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("Domain.Entities.MedicalRecordDetail", b =>
                {
                    b.Property<string>("RecordDetailCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DoctorCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorReport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HealthcareResult")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalRecordRecordCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RecordCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TreatmentPlan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecordDetailCode");

                    b.HasIndex("MedicalRecordRecordCode");

                    b.ToTable("MedicalRecordDetails");
                });

            modelBuilder.Entity("Domain.Entities.MedicalRecordDetail", b =>
                {
                    b.HasOne("Domain.Entities.MedicalRecord", null)
                        .WithMany("MedicalRecordDetails")
                        .HasForeignKey("MedicalRecordRecordCode");
                });

            modelBuilder.Entity("Domain.Entities.MedicalRecord", b =>
                {
                    b.Navigation("MedicalRecordDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
