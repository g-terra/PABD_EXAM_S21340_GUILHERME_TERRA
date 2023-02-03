using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using s21340_exam.EFConfigurations.Entities;

namespace s21340_exam.EFConfigurations.EntityTypeConfiguration;

public class PrescriptionEntityTypeConfiguration : IEntityTypeConfiguration<Prescription>
{
    public void Configure(EntityTypeBuilder<Prescription> builder)
    {
        builder.HasKey(e => e.IdPrescription);
        builder.Property(e => e.IdPrescription).ValueGeneratedOnAdd();
        builder.Property(e => e.Date).IsRequired();
        builder.Property(e => e.DueDate).IsRequired();
        builder.HasOne(e => e.Patient).WithMany(e => e.Prescriptions).HasForeignKey(e => e.IdPatient);
        builder.HasOne(e => e.Doctor).WithMany(e => e.Prescriptions).HasForeignKey(e => e.IdDoctor);

        
        var baseDate = new DateTime(2023, 01, 01);

        builder.HasData(
            new Prescription
            {
                IdPrescription = 1,
                IdDoctor = 1,
                IdPatient = 1,
                Date = baseDate.AddDays(1),
                DueDate = baseDate.AddDays(15),
            },
            new Prescription
            {
                IdPrescription = 2,
                IdDoctor = 1,
                IdPatient = 1,
                Date = baseDate.AddDays(2),
                DueDate = baseDate.AddDays(20),
            }
            , new Prescription
            {
                IdPrescription = 3,
                IdDoctor = 1,
                IdPatient = 1,
                Date = baseDate.AddDays(3),
                DueDate = baseDate.AddDays(25),
            }
        );
    }
}