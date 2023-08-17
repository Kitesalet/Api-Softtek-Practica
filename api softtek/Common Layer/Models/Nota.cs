using api_softtek.DAL;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_softtek.Common_Layer.Models
{
    public class Nota : BaseEntity
    {


        [ForeignKey("Estudiante")]
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }

        [ForeignKey("Materia")]
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }

       
        public int Calificacion { get; set; }
    }
}
