using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using s21340_exam.EFConfigurations.Entities;

namespace s21340_exam.EFConfigurations.EntityTypeConfiguration;

public class PrescriptionMedicamentEntityTypeConfiguration : IEntityTypeConfiguration<PrescriptionMedicament>
{
    public void Configure(EntityTypeBuilder<PrescriptionMedicament> builder)
    {
        
        builder.HasKey(
            pm => new
            {
                pm.IdPrescription, pm.IdMedicament
            });

        
        builder.Property(e => e.Details)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(d => d.Dose);

        builder.HasOne(d => d.Prescription)
            .WithMany(p => p.PrescriptionMedicaments)
            .HasForeignKey(d => d.IdPrescription);

        builder.HasOne(d => d.Medicament)
            .WithMany(p => p.PrescriptionMedicaments)
            .HasForeignKey(d => d.IdMedicament);
            
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