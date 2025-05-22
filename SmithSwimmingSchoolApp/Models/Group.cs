using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmithSwimmingSchoolApp.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        [MaxLength(50)]
        [DisplayName(displayName: "Nombre")]
        public string? Name { get; set; }
        [Required]
        [DisplayName(displayName: "Nivel")]
        public LevelGroup Level { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName(displayName: "Fecha Inicio")]
        public DateTime? Start_Date { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName(displayName: "Fecha Fin")]
        public DateTime? End_Date { get; set; }
    }

    public enum LevelGroup
    {
        Principiante = 1, Intermedio, Avanzado
    }
}
