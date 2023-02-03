using Microsoft.EntityFrameworkCore;
using s21340_exam.EFConfigurations.Contexts;
using s21340_exam.EFConfigurations.Entities;

namespace s21340_exam.Repositories;

public class DoctorRepository
{
    private readonly DefaultDbContext _dbContext;

    public DoctorRepository(DefaultDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Doctor?> GetDoctorByIdAsync(int id)
    {
        return await _dbContext
            .Doctors
            .Include(doctor => doctor.Prescriptions)
            .ThenInclude( prescription => prescription.PrescriptionMedicaments)
            .ThenInclude( prescriptionMedicament => prescriptionMedicament.Medicament)
            .SingleOrDefaultAsync(doctor => doctor.IdDoctor.Equals(id));
    }

    public async Task RemoveDoctorAsync(Doctor doctor)
    {
        _dbContext.Remove(doctor);

        await _dbContext.SaveChangesAsync();
    }

}