using s21340_exam.EFConfigurations.Entities;

namespace s21340_exam.Models.Responses;

public class PrescriptionMedicamentDetailsResponse
{
    
    public string MedicamentType { get; set; }

    public string Medicament { get; set; }

    public string Details { get; set; }

    public int Dose { get; set; }
    
    public static PrescriptionMedicamentDetailsResponse From(PrescriptionMedicament prescriptionMedicament)
    {
        return new PrescriptionMedicamentDetailsResponse
        {
            Dose = prescriptionMedicament.Dose,
            Details = prescriptionMedicament.Details,
            Medicament = prescriptionMedicament.Medicament.Name,
            MedicamentType = prescriptionMedicament.Medicament.Type

        };
    }


}