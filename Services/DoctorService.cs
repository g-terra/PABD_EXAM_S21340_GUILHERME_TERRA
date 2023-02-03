using s21340_exam.Middlewares.ExceptionHandling.Exceptions;
using s21340_exam.Models.Responses;
using s21340_exam.Repositories;

namespace s21340_exam.Services;

public class DoctorService
{
    private readonly DoctorRepository _doctorRepository;


    public DoctorService(DoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
    }

    public async Task<DoctorDetailsResponse> GetDoctorDetails(int id)
    {
        var doctor = await _doctorRepository.GetDoctorByIdAsync(id);
        
        if (doctor == null)
        {
            throw new NotFoundException($"No doctor found for id {id}");
        }

        return DoctorDetailsResponse.From(doctor);
    }

    public async Task RemoveDoctorById(int id)
    {
        var doctor = await _doctorRepository.GetDoctorByIdAsync(id);

        if (doctor == null)
        {
            throw new NotFoundException($"No doctor found for id {id}");
        }
        
        await _doctorRepository.RemoveDoctorAsync(doctor);
    }
}