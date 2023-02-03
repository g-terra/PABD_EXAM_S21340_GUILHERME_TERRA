using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using s21340_exam.EFConfigurations.Entities;

namespace s21340_exam.EFConfigurations.Seeds;

public class DoctorsSeed : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
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