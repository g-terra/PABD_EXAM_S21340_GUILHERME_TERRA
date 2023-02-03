using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using s21340_exam.EFConfigurations.Entities;

namespace s21340_exam.EFConfigurations.EntityTypeConfiguration;

public class MedicamentEntityTypeConfiguration : IEntityTypeConfiguration<Medicament>
{
    public void Configure(EntityTypeBuilder<Medicament> builder)
    {
        builder.HasKey(e => e.IdMedicament);
        builder.Property(e=>e.IdMedicament).ValueGeneratedOnAdd();
        builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
        builder.Property(e => e.Description).HasMaxLength(100).IsRequired();
        builder.Property(e => e.Type).HasMaxLength(100).IsRequired();
        builder.HasData(
            new Medicament
            {
                IdMedicament = 1,
                Name = "Paracetamol",
                Description = "pain killer",
                Type = "pills"
            },
            new Medicament
            {
                IdMedicament = 2,
                Name = "Ibuprofen",
                Description = "pain killer",
                Type = "pills"
            },
            new Medicament
            {
                IdMedicament = 3,
                Name = "nasometin",
                Description = "anti-alergic",
                Type = "spray"
            }
        );
    }
}