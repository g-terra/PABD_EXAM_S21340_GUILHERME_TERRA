using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using s21340_exam.EFConfigurations.Entities;

namespace s21340_exam.EFConfigurations.Seeds;

public class PrescriptionMedicamentSeed : IEntityTypeConfiguration<PrescriptionMedicament>
{
    public void Configure(EntityTypeBuilder<PrescriptionMedicament> builder)
    {
        builder.HasData(
            new PrescriptionMedicament
            {
                IdPrescription = 1,
                IdMedicament = 1,
                Details = "Once a day",
                Dose = 3
            },
            new PrescriptionMedicament
            {
                IdPrescription = 2,
                IdMedicament = 2,
                Details = "Once a day",
                Dose = 3
            },
            new PrescriptionMedicament
            {
                IdPrescription = 3,
                IdMedicament = 3,
                Details = "Once a day",
                Dose = 3
            }
        );
    }
}