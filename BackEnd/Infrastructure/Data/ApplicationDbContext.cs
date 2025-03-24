using System;
using System.Collections.Generic;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<MedicalRecord> MedicalRecords { get; set; }

    public virtual DbSet<MedicalRecordDetail> MedicalRecordDetails { get; set; }

    public virtual DbSet<Medicine> Medicines { get; set; }

    public virtual DbSet<MedicineType> MedicineTypes { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Receptionist> Receptionists { get; set; }

    public virtual DbSet<ScheduleDetail> ScheduleDetails { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.adminCode).HasName("PK__Admin__E3C99C7B9EBDE062");

            entity.ToTable("Admin");

            entity.HasIndex(e => e.userId, "UQ__Admin__CB9A1CFE418A8094").IsUnique();

            entity.Property(e => e.adminCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.user).WithOne(p => p.Admin)
                .HasForeignKey<Admin>(d => d.userId)
                .HasConstraintName("FK__Admin__userId__3E52440B");
        });

        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.appointmentCode).HasName("PK__Appointm__6BAB9A5B36EEE961");

            entity.ToTable("Appointment");

            entity.Property(e => e.appointmentCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.doctorCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.patientCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.scheduleCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.status)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.doctorCodeNavigation).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.doctorCode)
                .HasConstraintName("FK__Appointme__docto__571DF1D5");

            entity.HasOne(d => d.patientCodeNavigation).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.patientCode)
                .HasConstraintName("FK__Appointme__patie__5812160E");

            entity.HasOne(d => d.scheduleCodeNavigation).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.scheduleCode)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__Appointme__sched__59063A47");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.departmentCode).HasName("PK__Departme__7BF423ACEE13FA59");

            entity.ToTable("Department");

            entity.Property(e => e.departmentCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.title)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.doctorCode).HasName("PK__Doctor__4B36E45EAAD2D130");

            entity.ToTable("Doctor");

            entity.HasIndex(e => e.userId, "UQ__Doctor__CB9A1CFEA23B467D").IsUnique();

            entity.Property(e => e.doctorCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.departmentCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.symptomSupport)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.departmentCodeNavigation).WithMany(p => p.Doctors)
                .HasForeignKey(d => d.departmentCode)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__Doctor__departme__4316F928");

            entity.HasOne(d => d.user).WithOne(p => p.Doctor)
                .HasForeignKey<Doctor>(d => d.userId)
                .HasConstraintName("FK__Doctor__userId__4222D4EF");
        });

        modelBuilder.Entity<MedicalRecord>(entity =>
        {
            entity.HasKey(e => e.recordCode).HasName("PK__MedicalR__BC1704607C4BE408");

            entity.ToTable("MedicalRecord");

            entity.Property(e => e.recordCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.createdAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.patientCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.patientCodeNavigation).WithMany(p => p.MedicalRecords)
                .HasForeignKey(d => d.patientCode)
                .HasConstraintName("FK__MedicalRe__patie__5165187F");
        });

        modelBuilder.Entity<MedicalRecordDetail>(entity =>
        {
            entity.HasKey(e => e.recordDetailCode).HasName("PK__MedicalR__DBD2F7C28904CB29");

            entity.ToTable("MedicalRecordDetail");

            entity.Property(e => e.recordDetailCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.appointmentCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.doctorCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.recordCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.result)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.appointmentCodeNavigation).WithMany(p => p.MedicalRecordDetails)
                .HasForeignKey(d => d.appointmentCode)
                .HasConstraintName("FK__MedicalRe__appoi__5BE2A6F2");

            entity.HasOne(d => d.doctorCodeNavigation).WithMany(p => p.MedicalRecordDetails)
                .HasForeignKey(d => d.doctorCode)
                .HasConstraintName("FK__MedicalRe__docto__5DCAEF64");

            entity.HasOne(d => d.recordCodeNavigation).WithMany(p => p.MedicalRecordDetails)
                .HasForeignKey(d => d.recordCode)
                .HasConstraintName("FK__MedicalRe__recor__5CD6CB2B");
        });

        modelBuilder.Entity<Medicine>(entity =>
        {
            entity.HasKey(e => e.medicineCode).HasName("PK__Medicine__B9362A224CD72393");

            entity.ToTable("Medicine");

            entity.Property(e => e.medicineCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.medicineTypeCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.stock).HasDefaultValue(0);

            entity.HasOne(d => d.medicineTypeCodeNavigation).WithMany(p => p.Medicines)
                .HasForeignKey(d => d.medicineTypeCode)
                .HasConstraintName("FK__Medicine__medici__656C112C");
        });

        modelBuilder.Entity<MedicineType>(entity =>
        {
            entity.HasKey(e => e.medicineTypeCode).HasName("PK__Medicine__54D89542478DA838");

            entity.ToTable("MedicineType");

            entity.Property(e => e.medicineTypeCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.patientCode).HasName("PK__Patient__A1A7B027FC0DDB1C");

            entity.ToTable("Patient");

            entity.HasIndex(e => e.userId, "UQ__Patient__CB9A1CFE516E6749").IsUnique();

            entity.Property(e => e.patientCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.fullname).HasMaxLength(50);
            entity.Property(e => e.gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.phone)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.user).WithOne(p => p.Patient)
                .HasForeignKey<Patient>(d => d.userId)
                .HasConstraintName("FK__Patient__userId__4AB81AF0");
        });

        modelBuilder.Entity<Receptionist>(entity =>
        {
            entity.HasKey(e => e.receptionistCode).HasName("PK__Receptio__848E0F116AD360E7");

            entity.ToTable("Receptionist");

            entity.HasIndex(e => e.userId, "UQ__Receptio__CB9A1CFE23EAF614").IsUnique();

            entity.Property(e => e.receptionistCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.address)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.user).WithOne(p => p.Receptionist)
                .HasForeignKey<Receptionist>(d => d.userId)
                .HasConstraintName("FK__Reception__userI__46E78A0C");
        });

        modelBuilder.Entity<ScheduleDetail>(entity =>
        {
            entity.HasKey(e => e.scheduleCode).HasName("PK__Schedule__2D9C9A60C95BCCC9");

            entity.ToTable("ScheduleDetail");

            entity.Property(e => e.scheduleCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.doctorCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.doctorCodeNavigation).WithMany(p => p.ScheduleDetails)
                .HasForeignKey(d => d.doctorCode)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__ScheduleD__docto__5441852A");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.serviceCode).HasName("PK__Service__E5ABEC5378E0A846");

            entity.ToTable("Service");

            entity.Property(e => e.serviceCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.cost).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.title)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Users__3213E83F61CA6B34");

            entity.HasIndex(e => e.email, "UQ__Users__AB6E61645BAAFBBF").IsUnique();

            entity.HasIndex(e => e.username, "UQ__Users__F3DBC572D3B79B1A").IsUnique();

            entity.Property(e => e.email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.fullname).HasMaxLength(50);
            entity.Property(e => e.gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.warehouseCode).HasName("PK__Warehous__CFC9B62CABAC0B9F");

            entity.ToTable("Warehouse");

            entity.Property(e => e.warehouseCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.departmentCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.departmentCodeNavigation).WithMany(p => p.Warehouses)
                .HasForeignKey(d => d.departmentCode)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__Warehouse__depar__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
