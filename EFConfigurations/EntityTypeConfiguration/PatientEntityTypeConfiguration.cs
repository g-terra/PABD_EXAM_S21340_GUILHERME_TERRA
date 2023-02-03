using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using s21340_exam.EFConfigurations.Entities;

namespace s21340_exam.EFConfigurations.EntityTypeConfiguration;

public class PatientEntityTypeConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.HasKey(e => e.IdPatient);
        builder.Property(e => e.IdPatient).ValueGeneratedOnAdd();
        builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
        builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
        builder.Property(e => e.BirthDate).IsRequired();
        builder.HasMany(e => e.Prescriptions)
            .WithOne(e => e.Patient)
            .HasForeignKey(e => e.IdPatient);
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