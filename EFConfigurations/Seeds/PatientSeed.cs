using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using s21340_exam.EFConfigurations.Entities;

namespace s21340_exam.EFConfigurations.Seeds;

public class PatientSeed : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.HasData(
            new Patient
            {
                IdPatient = 1,
                FirstName = "Pedro",
                LastName = "Paulo",
                BirthDate = new DateTime(1992, 08, 19)
            },
            new Patient
            {
                IdPatient = 2,
                FirstName = "King",
                LastName = "Arthur",
                BirthDate = new DateTime(903, 12, 31)
            }
        );
    }
}