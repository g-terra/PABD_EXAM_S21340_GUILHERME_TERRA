using s21340_exam.EFConfigurations.Entities;

namespace s21340_exam.Models.Responses;

public class PrescriptionDetailsResponse
{
    public int Id { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime Date { get; set; }
    
    public List<PrescriptionMedicamentDetailsResponse> Items { get; set; }


    public static PrescriptionDetailsResponse From(Prescription prescription)
    {
        return new PrescriptionDetailsResponse
        {
            Id = prescription.IdPrescription,
            Date = prescription.Date,
            DueDate = prescription.DueDate,
            Items = prescription.PrescriptionMedicaments.Select(PrescriptionMedicamentDetailsResponse.From).ToList()

        };
    }

}