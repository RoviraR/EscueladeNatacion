using System.ComponentModel.DataAnnotations;

namespace SmithSwimmingSchoolApp.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public virtual Course? Course { get; set; }
        public int SwimmerId { get; set; }
        public virtual Swimmer? Swimmer { get; set; }
        public int? GroupId { get; set; }
        public virtual Group? Group { get; set; }
        public ICollection<Report>? Reports { get; set; }
    }
}
