using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s21340_exam.EFConfigurations.Entities;

public class Prescription
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdPrescription { get; set; }

    [Required] public DateTime Date { get; set; }
    [Required] public DateTime DueDate { get; set; }

    public int IdDoctor { get; set; }
    [ForeignKey(nameof(IdDoctor))] public virtual Doctor Doctor { get; set; }

    public int IdPatient { get; set; }
    [ForeignKey(nameof(IdPatient))] public virtual Patient Patient { get; set; }

    public virtual ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; } =
        new HashSet<PrescriptionMedicament>();
}