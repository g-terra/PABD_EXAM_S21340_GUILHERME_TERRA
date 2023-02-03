using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s21340_exam.EFConfigurations.Entities;

public class Medicament
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdMedicament { get; set; }

    [Required] [MaxLength(100)] public string Name { get; set; } 
    [Required] [MaxLength(100)] public string Description { get; set; } 
    [Required] [MaxLength(100)] public string Type { get; set; } 

    public virtual ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; } =
        new HashSet<PrescriptionMedicament>();
}