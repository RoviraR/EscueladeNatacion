using SmithSwimmingSchoolApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SmithSwimmingSchoolApp.ViewModels
{
    public class CourseDetailsViewModel
    {
        public int CourseId { get; set; }
        public string? Title { get; set; }
        public string? CoachName { get; set; }
        public int Places { get; set; }
        public List<SwimmerDetails>? Swimmers { get; set; }
    }

    public class SwimmerDetails
    {
        public int SwimmerId { get; set; }
        public string? Name { get; set; }
        public GenreSwimmer Genre { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Birth_Date { get; set; }
        public bool IsActive { get; set; }
        public string? GroupName { get; set; } // Nuevo campo para el grupo
    }
}
