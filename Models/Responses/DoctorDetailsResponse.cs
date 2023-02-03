using s21340_exam.EFConfigurations.Entities;

namespace s21340_exam.Models.Responses;

public class DoctorDetailsResponse
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public IEnumerable<PrescriptionDetailsResponse> Prescriptions { get; set; } =
        new HashSet<PrescriptionDetailsResponse>();

    public static DoctorDetailsResponse From(Doctor doctor)
    {
        var prescriptions = doctor.Prescriptions
            .Select(PrescriptionDetailsResponse.From)
            .OrderByDescending(p => p.Date);

        return new DoctorDetailsResponse
        {
            FirstName = doctor.FirstName,
            LastName = doctor.LastName,
            Prescriptions = prescriptions
        };
    }
}