using api_softtek.DAL;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_softtek.Common_Layer.Models
{
    public class Materia : BaseEntity
    {

        public string Nombre { get; set; }


        [ForeignKey("Carrera")]
        public int CarreraId { get; set; }
        public Carrera Carrera { get; set; }


        public List<Profesor> Profesores { get; set; }

        

    }
}