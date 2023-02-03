using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s21340_exam.EFConfigurations.Entities;

public class Patient
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdPatient { get; set; }

    [Required] [MaxLength(100)] public string FirstName { get; set; } 
    [Required] [MaxLength(100)] public string LastName { get; set; } 
    [Required] public DateTime BirthDate { get; set; }
    
    public virtual ICollection<Prescription> Prescriptions { get; set; } = new HashSet<Prescription>();

}