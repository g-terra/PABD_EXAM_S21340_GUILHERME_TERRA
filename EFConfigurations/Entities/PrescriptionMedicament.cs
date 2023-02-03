using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s21340_exam.EFConfigurations.Entities;

public class PrescriptionMedicament
{


    [Required] public int Dose { get; set; }
    [Required] [MaxLength(100)] public string Details { get; set; } 
    
    public int IdPrescription { get; set; }
    
    [ForeignKey(nameof(IdPrescription))]
    public virtual Prescription Prescription { get; set; }
    
    public int IdMedicament { get; set; }
    
    [ForeignKey(nameof(IdMedicament))]
    public virtual Medicament Medicament { get; set; }
}