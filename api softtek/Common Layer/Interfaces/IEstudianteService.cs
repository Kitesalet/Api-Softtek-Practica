using api_softtek.Common_Layer.DTOs;
using api_softtek.Top_Layer.Controllers;

namespace api_softtek.Common_Layer.Interfaces
{
    public interface IEstudianteService
    {

        public List<EstudianteDto> GetAllEstudiantes();

        public EstudianteDto GetEstudianteById(int id);

        public int CreateEstudiante(EstudianteDto estudiante);

        public EstudianteDto UpdateEstudiante(EstudianteDto estudiante);

        public bool DeleteEstudiante(int id);


    }
}
