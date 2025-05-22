using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmithSwimmingSchoolApp.Models
{
    public class Coach
    {
        [Key]
        public int CoachId { get; set; }
        [MaxLength(50)]
        [DisplayName(displayName: "Nombre")]
        public string? Name { get; set; }
        [DataType(DataType.PhoneNumber)]
        [DisplayName(displayName: "Teléfono")]
        public string? Phone_Number { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public ICollection<Course>? Courses { get; set; }
    }
}
