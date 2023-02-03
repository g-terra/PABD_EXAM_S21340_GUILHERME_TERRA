using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s21340_exam.EFConfigurations.Entities;

public class PrescriptionMedicament
{
    public int Dose { get; set; }
    public string Details { get; set; }

    public int IdPrescription { get; set; }

    public virtual Prescription Prescription { get; set; }

    public int IdMedicament { get; set; }


    public virtual Medicament Medicament { get; set; }
}