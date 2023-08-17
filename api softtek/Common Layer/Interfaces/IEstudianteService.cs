using api_softtek.Common_Layer.DTOs;

namespace api_softtek.Common_Layer.Interfaces
{
    public interface IEstudianteService
    {

        public List<CarreraDto> GetAllEstudiantes();

        public CarreraDto GetEstudianteById(int id);

        public int CreateEstudiante(CarreraDto estudiante);

        public CarreraDto UpdateEstudiante(CarreraDto estudiante);

        public bool DeleteEstudiante(int id);


    }
}
