using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmithSwimmingSchoolApp.Models
{
    public class Swimmer
    {
        [Key]
        public int SwimmerId { get; set; }
        [MaxLength(50)]
        [DisplayName(displayName: "Nombre")]
        public string? Name { get; set; }
        [DataType(DataType.PhoneNumber)]
        [DisplayName(displayName: "Teléfono")]
        public string? Phone_Number { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DisplayName(displayName: "Género")]
        public GenreSwimmer Genre { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName(displayName: "Fecha Nacimiento")]
        public DateTime? Birth_Date { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<Enrollment>? Enrollments { get; set; }
    }

    public enum GenreSwimmer
    {
        Masculino = 1, Femenino
    }
}
