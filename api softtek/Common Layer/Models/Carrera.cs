using api_softtek.DAL;

namespace api_softtek.Common_Layer.Models
{
    public class Carrera : BaseEntity
    {


        public string Nombre { get; set; }

        public List<Materia> Materias { get; set; }

        public List<Estudiante> Estudiantes { get; set; }


    }
}
