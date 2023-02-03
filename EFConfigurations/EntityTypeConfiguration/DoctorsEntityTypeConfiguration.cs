using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using s21340_exam.EFConfigurations.Entities;

namespace s21340_exam.EFConfigurations.EntityTypeConfiguration;

public class DoctorsEntityTypeConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.HasKey(e => e.IdDoctor);
        builder.Property(e => e.IdDoctor).ValueGeneratedOnAdd();
        builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
        builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
        builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
        builder.HasMany(e => e.Prescriptions).WithOne(e => e.Doctor).HasForeignKey(e => e.IdDoctor);

        builder.HasData(
            new Doctor
            {
                IdDoctor = 1,
                FirstName = "John",
                LastName = "Travolta",
                Email = "John.Travolta@email.com"
            },
            new Doctor
            {
                IdDoctor = 2,
                FirstName = "Pablo",
                LastName = "Escobar",
                Email = "Pablo.Escobar@email.com"
            }
        );
    }
}