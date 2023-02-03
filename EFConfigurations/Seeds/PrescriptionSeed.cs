using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using s21340_exam.EFConfigurations.Entities;

namespace s21340_exam.EFConfigurations.Seeds;

public class PrescriptionSeed : IEntityTypeConfiguration<Prescription>
{
    public void Configure(EntityTypeBuilder<Prescription> builder)
    {
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