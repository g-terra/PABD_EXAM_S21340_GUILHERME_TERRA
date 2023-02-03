using Microsoft.EntityFrameworkCore;
using s21340_exam.EFConfigurations.Entities;
using s21340_exam.EFConfigurations.Seeds;

namespace s21340_exam.EFConfigurations.Contexts;

public class DefaultDbContext : DbContext
{
    public DefaultDbContext(DbContextOptions options) : base(options)
    {
    }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Medicament> Medicaments { get; set; }

    public virtual DbSet<Prescription> Prescriptions { get; set; }

    public virtual DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PrescriptionMedicament>().HasKey(
            pm => new
            {
                pm.IdPrescription, pm.IdMedicament
            });

        modelBuilder.ApplyConfiguration(new DoctorsSeed());
        modelBuilder.ApplyConfiguration(new PatientSeed());
        modelBuilder.ApplyConfiguration(new MedicamentSeed());
        modelBuilder.ApplyConfiguration(new PrescriptionSeed());
        modelBuilder.ApplyConfiguration(new PrescriptionMedicamentSeed());
    }
}