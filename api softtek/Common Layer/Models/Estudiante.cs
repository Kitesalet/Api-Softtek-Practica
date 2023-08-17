using System.ComponentModel.DataAnnotations.Schema;

namespace api_softtek.Common_Layer.Models
{
    public class Estudiante : Persona
    {


        [ForeignKey("Carrera")]
        public int CarreraId { get; set; }
        public Carrera Carrera { get; set; }

    }
}
