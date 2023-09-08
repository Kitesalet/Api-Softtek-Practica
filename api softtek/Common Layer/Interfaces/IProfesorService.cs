using api_softtek.Common_Layer.DTOs;

namespace api_softtek.Common_Layer.Interfaces
{
    public interface IProfesorService
    {

        public List<ProfesorDto> GetAllProfesores();

        public ProfesorDto GetProfesorById(int id);

        public int CreateProfesor(ProfesorDto profesor);

        public ProfesorDto UpdateProfesor(ProfesorDto profesor);

        public bool DeleteProfesor(int id);


    }
}
