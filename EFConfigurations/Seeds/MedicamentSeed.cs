using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using s21340_exam.EFConfigurations.Entities;

namespace s21340_exam.EFConfigurations.Seeds;

public class MedicamentSeed : IEntityTypeConfiguration<Medicament>
{
    public void Configure(EntityTypeBuilder<Medicament> builder)
    {
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