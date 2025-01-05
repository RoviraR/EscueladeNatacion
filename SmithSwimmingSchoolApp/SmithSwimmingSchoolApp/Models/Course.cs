using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmithSwimmingSchoolApp.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [DisplayName(displayName: "Titulo")]
        [MaxLength(100)]
        public string? Title { get; set; }
        public int? CoachId { get; set; }
        public virtual Coach? Coach { get; set; }
        [DisplayName(displayName: "Plazas")]
        public int Places { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
