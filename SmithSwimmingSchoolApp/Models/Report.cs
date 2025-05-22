using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmithSwimmingSchoolApp.Models
{
    public class Report
    {
        [Key]
        public int ReportId { get; set; }
        [MaxLength(200)]
        [DisplayName(displayName: "Contenido")]
        public string? Content { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName(displayName: "Fecha")]
        public DateTime? Date { get; set; }
        public int EnrollmentId { get; set; }
        public virtual Enrollment? Enrollment { get; set; }
    }
}
