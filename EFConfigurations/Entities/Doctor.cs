using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s21340_exam.EFConfigurations.Entities;

public class Doctor
{
    public int IdDoctor { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public virtual ICollection<Prescription> Prescriptions { get; set; } = new HashSet<Prescription>();
}